SELECT ProductId, ProductCode, ProductDescription, ProductCategoryCode,
       ProductCategoryDescrtiption, CategoryDescription,
	 FODay,
	 InvoiceCount = Count(distinct InvoiceId), Qty = Sum(Qty), Total = Sum(Total),
       MinPrice = Min(Price), 
	 MaxPrice = Max(Price), Net = Sum(Net), VatAmount = Sum(VatAmount) 
FROM (
	SELECT ProductId, ProductCode , ProductDescription, ProductCategoryCode,
             ProductCategoryDescrtiption, CategoryDescription, PricelistCode,
             InvoiceId, InvoiceTotal, Abbreviation, ReceiptNo, Cover, qty, Total,
             Price, Net, VatAmount, FODay,IsExtra
	FROM (
	SELECT 
		--PosInfoId = i.PosInfoId,
		--PosInfoDescription = pi.Description,
		--DepartmentDescription = d.Description,
		--DepartmentId = pi.DepartmentId,
		ProductId = odi.ProductId,
	 	ProductCode = max(Case IsExtra when 0 then p.Code else ing.Code end),
	      ProductDescription = max(Case IsExtra when 0 then p.SalesDescription else ing.SalesDescription end),
		ProductCategoryCode = pc.Code,
		ProductCategoryDescrtiption = pc.Description,
		CategoryDescription = c.Description,
		Qty = Sum(odi.Qty),
		Price = Sum(odi.Price),
		Discount = Sum(odi.Discount),
		Total = sum(odi.Total),
		Net = Sum(odi.Net),
		VatAmount = Sum(odi.VatAmount),
		VatPercentage = Max(v.Percentage),
		--PricelistDescription = pl.Description,
		--PricelistId = pl.Id,
		PricelistCode = pl.Code,
		VatId = odi.VatId,
		InvoiceTotal = i.Total,
		--InvoiceType = odi.InvoiceType,
		Abbreviation = odi.Abbreviation,
		ReceiptNo = odi.Counter,
		InvoiceId = i.Id,
		Cover = i.Cover,
		Rooms = i.Rooms,
		SalesTypeId = odi.SalesTypeId,
		SalesTypeDescription = st.Description,
		--StaffCode = s.Code,
		--StafName = s.LastName + ' ' + s.FirstName,
            TempFODay = IsNull(eod.FODay, CAST(getdate() AS DATE)),
            FODay = @FromDate,
		NotAudited = IsNull(i.EndOfDayId, 0),
		IsExtra = odi.IsExtra
	FROM OrderDetailInvoices odi 
           INNER JOIN Invoices i on odi.InvoicesId = i.id AND ISNULL(i.IsVoided,0) = 0
           left outer join Product p on p.id = odi.productid and isextra = 0
           left join ProductCategories pc on  pc.Id = case odi.IsExtra when 1 then odi.productCategoryId else p.ProductCategoryId end
           LEFT OUTER JOIN Categories c on pc.CategoryId = c.Id
           LEFT OUTER JOIN EndOfDay eod on i.EndofDayId = eod.Id
           LEFT OUTER JOIN Pricelist pl on odi.pricelistid = pl.id
           LEFT OUTER JOIN vat v on odi.vatId = v.Id
           LEFT OUTER JOIN SalesType st on st.Id = odi.SalesTypeId
           LEFT OUTER JOIN Staff s on i.StaffId = s.id
           LEFT OUTER JOIN PosInfo pi on i.PosInfoId = pi.Id
           LEFT OUTER JOIN Department d on pi.DepartmentId = d.Id
           left outer join Ingredients ing on ing.Id = odi.productid and isextra = 1
	WHERE IsNull(i.IsDeleted, 0) = 0 and IsNull(odi.IsDeleted, 0) = 0 and InvoiceType not in (2,3,8)
		AND IsNull(eod.FODay, CAST(getdate() AS DATE)) BETWEEN CAST(@FromDate AS DATE) AND CAST(@ToDate AS DATE)
	group by i.Id, odi.ProductId,  odi.Description, pc.Code, pc.Description, c.Description,
		pl.Code, odi.VatId, odi.Abbreviation,odi.Counter, i.Id, i.Cover, i.Total, i.Rooms,
		odi.SalesTypeId,st.Description,IsNull(eod.FODay, CAST(getdate() AS DATE)),IsNull(i.EndOfDayId, 0),
		IsExtra
	) t
) prime
GROUP BY ProductId, ProductCode, ProductDescription,
         ProductCategoryCode, ProductCategoryDescrtiption, 
         CategoryDescription, FODay
