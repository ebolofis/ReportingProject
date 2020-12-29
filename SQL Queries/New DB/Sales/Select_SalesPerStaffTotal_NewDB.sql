select ProductId, ProductCode, ProductDescription, StaffCode,StafName,FODay,PricelistId ,PricelistDescription,
       PosInfoId ,PosInfoDescription ,DepartmentDescription ,DepartmentId,
       InvoiceCount = Count(distinct InvoiceId), Qty = Sum(Qty), Total = Sum(Total),
       MinPrice = Min(Price), MaxPrice = Max(Price), Net = Sum(Net), VatAmount = Sum(VatAmount) 
from (
  select ProductId, ProductCode , ProductDescription, ProductCategoryCode,
         ProductCategoryDescrtiption, CategoryDescription,
   PricelistCode, PricelistDescription, InvoiceId, InvoiceTotal,
   InvoiceType, Abbreviation, ReceiptNo, Cover, qty, Total,
   Price, Net, VatAmount, StaffCode,StafName, FODay,IsExtra, 
   PricelistId ,PosInfoId ,PosInfoDescription ,DepartmentDescription ,DepartmentId
   --InvoiceUsed = Count(distinct InvoiceId)
    from (
   select 
    PosInfoId = i.PosInfoId,
    PosInfoDescription = pi.Description,
    DepartmentDescription = d.Description,
    DepartmentId = pi.DepartmentId,
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
    PricelistDescription = pl.Description,
    PricelistId = pl.Id,
    PricelistCode = pl.Code,
    VatId = odi.VatId,
    InvoiceTotal = i.Total,
    InvoiceType = odi.InvoiceType,
    Abbreviation = odi.Abbreviation,
    ReceiptNo = odi.Counter,
    InvoiceId = i.Id,
    Cover = i.Cover,
    Rooms = i.Rooms,
    SalesTypeId = odi.SalesTypeId,
    SalesTypeDescription = st.Description,
    StaffCode = s.Code,
    StafName = s.LastName + ' ' + s.FirstName,
    -- FODay = IsNull(eod.FODay, CAST(getdate() AS DATE)),
    TempFODay = IsNull(eod.FODay, CAST(getdate() AS DATE)),
    FODay = @FromDate,
    NotAudited = IsNull(i.EndOfDayId, 0),
    IsExtra = odi.IsExtra
   from OrderDetailInvoices odi 
        join Invoices i on odi.InvoicesId = i.id AND ISNULL(i.IsVoided,0) = 0
        left outer join Product p on p.id = odi.productid and isextra = 0
        left join ProductCategories pc on  pc.Id = case odi.IsExtra when 1 then odi.productCategoryId else p.ProductCategoryId end
        left join Categories c on pc.CategoryId = c.Id
        left join EndOfDay eod on i.EndofDayId = eod.Id
        left join Pricelist pl on odi.pricelistid = pl.id
        left join vat v on odi.vatId = v.Id
        left join SalesType st on st.Id = odi.SalesTypeId
        left join Staff s on i.StaffId = s.id
        left outer join PosInfo pi on i.PosInfoId = pi.Id
        left outer join Department d on pi.DepartmentId = d.Id
        left outer join Ingredients ing on ing.Id = odi.productid and isextra = 1
   where IsNull(i.IsDeleted, 0) = 0 and IsNull(odi.IsDeleted, 0) = 0 and InvoiceType not in (2,8) --and i.EndOfDayId is Null-- and ProductId= 1448
	  and IsNull(eod.FODay, CAST(getdate() AS DATE)) BETWEEN @FromDate AND @ToDate
   group by i.Id, odi.ProductId,  odi.Description, pc.Code, pc.Description, c.Description,
      pl.Description,pl.Code, odi.VatId,odi.InvoiceType, odi.Abbreviation,odi.Counter, i.Id, i.Cover, i.Total, i.Rooms,
      odi.SalesTypeId,st.Description,s.Code,s.LastName + ' ' + s.FirstName,IsNull(eod.FODay, CAST(getdate() AS DATE)),IsNull(i.EndOfDayId, 0),
      IsExtra, pl.Id, i.PosInfoId,pi.Description,d.Description,pi.DepartmentId
   ) t
   ) prime
--where ProductId= 1674
group by ProductId, ProductCode, ProductDescription, StaffCode,StafName,FODay, PricelistId ,PricelistDescription,
         PosInfoId ,PosInfoDescription ,DepartmentDescription ,DepartmentId
 --PricelistCode, PricelistDescription, InvoiceTotal, InvoiceType, Abbreviation, ReceiptNo, Cover
-- order by InvoiceId
