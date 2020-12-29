-- declare @FromDate datetime = '2016-06-15', @ToDate  datetime = '2016-06-15'

SELECT ProductId, ProductCode, ProductDescription,
       ProductCategoryCode, ProductCategoryDescrtiption,
       CategoryDescription, CategoryId,
       FODay,
       InvoiceCount = Count(distinct InvoiceId),
       Qty = Sum(Qty),
       Total = Sum(Total),
       MinPrice = Min(Price), 
       MaxPrice = Max(Price),
       Net = Sum(Net),
       VatAmount = Sum(VatAmount),
       InvoiceType = prime.InvoiceType,
       DepartmentId = prime.DepartmentId,
       PosInfoId

FROM (

--Common section
Select PosInfoId = i.PosInfoId
     , PosInfoDescription = pi.Description
     , DepartmentDescription = d.Description
     , DepartmentId = pi.DepartmentId
     , ProductId = pr.Id
     , ProductCode = pr.Code
     , ProductDescription = pr.SalesDescription
     , ProductCategoryCode = pc.Code
     , ProductCategoryDescrtiption = pc.Description
     , CategoryDescription = c.Description
     , CategoryId = c.Id
     , Qty = IsNull(od.Qty,0)
     , Price = od.Price
     , Discount = od.Discount
     , Total = od.TotalAfterDiscount
     , Net = odva.Net
     , VatAmount = odva.VatAmount
     , VatPercentage = v.Percentage
     , PricelistDescription = pl.Description
     , PricelistId = pl.Id
     , PricelistCode = pl.Code
     , VatId = odva.VatId
     , InvoiceTotal = i.Total
     , InvoiceType = it.Type
     , Abbreviation = it.Abbreviation
     , ReceiptNo = i.Counter
     , InvoiceId = i.Id
     , Cover = i.Cover
     , Rooms = ''--i.Rooms
     , SalesTypeId = od.SalesTypeId
     , SalesTypeDescription = st.Description
     , StaffCode = s.Code
     , StafName = s.LastName + ' ' + s.FirstName
     , TempFODay = IsNull(eod.FODay, CAST(getdate() AS DATE))
     , FODay = @FromDate
     , NotAudited = IsNull(i.EndOfDayId, 0)
     , IsExtra = 0 

From OrderDetailInvoices odi
     join Invoices i on i.Id = odi.InvoicesId
     join InvoiceTypes it on it.Id = i.InvoiceTypeId
     join PosInfo pi on pi.Id = i.PosInfoId
     left outer join Department d on d.Id = pi.DepartmentId
     join OrderDetail od on od.Id = odi.OrderDetailId and status != 5
     join Product pr on pr.Id = od.ProductId
     join OrderDetailVatAnal odva on odi.OrderDetailId = odva.OrderDetailId
     join Vat v on v.Id = odva.VatId
     left outer join EndOfDay eod on eod.Id = i.EndOfDayId
     left outer join PricelistDetail pld on pld.Id = od.PriceListDetailId
     left outer join Pricelist pl on pld.PricelistId = pl.Id
     join Staff s on s.Id = i.StaffId
     left outer join SalesType st on st.Id = od.SalesTypeId
     left outer join ProductCategories pc on pc.Id = pr.ProductCategoryId
     left outer join Categories c on pc.Categoryid = c.Id

Where IsNull(eod.FODay, CAST(getdate() AS DATE)) between @FromDate and @ToDate 
      and IsNull(i.IsDeleted, 0) = 0 and IsNull(od.IsDeleted, 0) = 0 and it.Type not in (2,8)

Union all

Select PosInfoId = i.PosInfoId
     , PosInfoDescription = pi.Description
     , DepartmentDescription = d.Description
     , DepartmentId = pi.DepartmentId
     , ProductId = ing.Id
     , ProductCode = ing.Code
     , ProductDescription = ing.SalesDescription
     , ProductCategoryCode = pc.Code
     , ProductCategoryDescrtiption = pc.Description
     , CategoryDescription = c.Description
     , Categoryid = c.Id
     , Qty = IsNull(oding.Qty,0)
     , Price = oding.Price
     , Discount = oding.Discount
     , Total = oding.TotalAfterDiscount
     , Net = odva.Net
     , VatAmount = odva.VatAmount
     , VatPercentage = v.Percentage
     , PricelistDescription = pl.Description
     , PricelistId = pl.Id
     , PricelistCode = pl.Code
     , VatId = odva.VatId
     , InvoiceTotal = i.Total
     , InvoiceType = it.Type
     , Abbreviation = it.Abbreviation
     , ReceiptNo = i.Counter
     , InvoiceId = i.Id
     , Cover = i.Cover
     , Rooms = ''--i.Rooms
     , SalesTypeId = od.SalesTypeId
     , SalesTypeDescription = st.Description
     , StaffCode = s.Code
     , StafName = s.LastName + ' ' + s.FirstName
     , TempFODay = IsNull(eod.FODay, CAST(getdate() AS DATE))
     , FODay = @FromDate
     , NotAudited = IsNull(i.EndOfDayId, 0)
     , IsExtra = 1 

From OrderDetailInvoices odi
     join OrderDetailIgredients oding on oding.OrderDetailId = odi.OrderDetailId
     join Invoices i on i.Id = odi.InvoicesId
     join InvoiceTypes it on it.Id = i.InvoiceTypeId
     join PosInfo pi on pi.Id = i.PosInfoId
     left outer join Department d on d.Id = pi.DepartmentId
     join OrderDetail od on od.Id = odi.OrderDetailId and status != 5
     join Product pr on pr.Id = od.ProductId
     join Ingredients ing on ing.Id = oding.IngredientId
     join OrderDetailIgredientVatAnal odva on oding.Id = odva.OrderDetailIgredientsId
     join Vat v on v.Id = odva.VatId
     left outer join EndOfDay eod on eod.Id = i.EndOfDayId
     left outer join PricelistDetail pld on pld.Id = oding.PriceListDetailId
     left outer join Pricelist pl on pld.PricelistId = pl.Id
     join Staff s on s.Id = i.StaffId
     left outer join SalesType st on st.Id = od.SalesTypeId
     left outer join ProductCategories pc on pc.Id = pr.ProductCategoryId
     left outer join Categories c on pc.Categoryid = c.Id

where IsNull(eod.FODay, CAST(getdate() AS DATE)) between @FromDate and @ToDate 
      -- and IsNull(i.IsDeleted, 0) = 0 and IsNull(oding.IsDeleted, 0) = 0 and it.Type not in (2,8)

-- Common Section Ends

) prime

--WHERE ISNULL(prime.FODay, CAST(GETDATE() AS DATE)) BETWEEN CAST(@FromDate AS DATE) AND CAST(@ToDate AS DATE)
--where IsExtra = 1
GROUP BY ProductId, ProductCode, ProductDescription, ProductCategoryCode, ProductCategoryDescrtiption, 
         CategoryDescription, CategoryId,
         FODay, InvoiceType, DepartmentId, PosInfoId

Order by Qty desc
