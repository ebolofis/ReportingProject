-- declare @FromDate datetime = '2016-06-15', @ToDate  datetime = '2016-06-15', @SelPlID bigint = 1


SELECT 
  CategoryId,
  Category = CategoryDescription , 
  DepartmentDescription,
  DepartmentId,
  SalesPriceListId,
  SalesPriceList,
   CostPriceList,
  CostPrice,
  SalesPrice, 
  ProductId,
   ProductCode = max(ProductCode),
     ProductDescription = max(ProductDescription), 
  SUM(Qty) Qty, 
  SUM(Total) Total,
  SUM(Cost*ISNULL(Qty,0)) Cost
FROM (

--Common section
select 
    PosInfoId = i.PosInfoId
    ,PosInfoDescription = pi.Description
    ,DepartmentDescription = d.Description
    ,DepartmentId = pi.DepartmentId
    ,ProductId = pr.Id
    ,ProductCode = pr.Code
    ,ProductDescription = pr.SalesDescription
    ,ProductCategoryId = pc.Id
    ,ProductCategoryCode = pc.Code
    ,ProductCategoryDescrtiption = pc.Description
    ,CategoryId = pc.CategoryId
    ,CategoryDescription = c.Description
    ,Qty = IsNull(od.Qty,0)
    ,Price = od.Price
    ,Discount = od.Discount
    ,Total = od.TotalAfterDiscount
    ,Net = odva.Net
    ,VatAmount = odva.VatAmount
    ,VatPercentage = v.Percentage
    ,PricelistDescription = pl.Description
    ,PricelistId = pl.Id
    ,PricelistCode = pl.Code
    ,VatId = odi.VatId
    ,InvoiceTotal = i.Total
    ,InvoiceType = it.Type
    ,Abbreviation = it.Abbreviation
    ,ReceiptNo = i.Counter
    ,InvoiceId = i.Id
    ,Cover = i.Cover
    ,Rooms = ''--i.Rooms
    ,SalesTypeId = od.SalesTypeId
    ,SalesTypeDescription = st.Description
    ,StaffCode = s.Code
    ,StafName = s.LastName + ' ' + s.FirstName
              ,TempFODay = IsNull(eod.FODay, CAST(getdate() AS DATE))
    ,FODay = @FromDate
    ,NotAudited = IsNull(i.EndOfDayId, 0)
    ,IsExtra = 0
    , pl.Id SalesPriceListId
    , pl.[Description] SalesPriceList
    , ISNULL(plc.[Description],'No Price List') CostPriceList
    , ISNULL(pdc.Price,0) CostPrice
    , ISNULL(pdc.Price,0)*ISNULL(odi.Qty,0) cOST
    , pd.Price SalesPrice

from OrderDetailInvoices odi
join Invoices i on i.Id = odi.InvoicesId
join InvoiceTypes it on it.Id = i.InvoiceTypeId
join PosInfo pi on pi.Id = i.PosInfoId
left outer join Department d on d.Id = pi.DepartmentId
join OrderDetail od on od.Id = odi.OrderDetailId
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
LEFT OUTER JOIN PricelistDetail pd ON pd.PricelistId = pl.Id AND 
          (pd.ProductId = odi.ProductId AND pd.IngredientId IS NULL)
          
LEFT OUTER JOIN Pricelist plc ON plc.Id = @SelPlID 
LEFT OUTER JOIN PricelistDetail pdc ON pdc.PricelistId = @SelPlID AND 
          (pdc.ProductId = odi.ProductId AND pdc.IngredientId IS NULL)

where  IsNull(eod.FODay, CAST(getdate() AS DATE)) between @FromDate and @ToDate 
    and IsNull(i.IsDeleted, 0) = 0 and IsNull(od.IsDeleted, 0) = 0 and it.Type not in (2,8)
union all
select 
     PosInfoId = i.PosInfoId
    ,PosInfoDescription = pi.Description
    ,DepartmentDescription = d.Description
    ,DepartmentId = pi.DepartmentId
    ,ProductId = ing.Id
    ,ProductCode = ing.Code
    ,ProductDescription = ing.SalesDescription
    ,ProductCategoryId = pc.Id
    ,ProductCategoryCode = pc.Code
    ,ProductCategoryDescrtiption = pc.Description
    ,CategoryId = pc.CategoryId
    ,CategoryDescription = c.Description
    ,Qty = IsNull(oding.Qty,0)
    ,Price = oding.Price
    ,Discount = oding.Discount
    ,Total = oding.TotalAfterDiscount
    ,Net = odva.Net
    ,VatAmount = odva.VatAmount
    ,VatPercentage = v.Percentage
    ,PricelistDescription = pl.Description
    ,PricelistId = pl.Id
    ,PricelistCode = pl.Code
    ,VatId = odi.VatId
    ,InvoiceTotal = i.Total
    ,InvoiceType = it.Type
    ,Abbreviation = it.Abbreviation
    ,ReceiptNo = i.Counter
    ,InvoiceId = i.Id
    ,Cover = i.Cover
    ,Rooms = ''--i.Rooms
    ,SalesTypeId = od.SalesTypeId
    ,SalesTypeDescription = st.Description
    ,StaffCode = s.Code
    ,StafName = s.LastName + ' ' + s.FirstName
              ,TempFODay = IsNull(eod.FODay, CAST(getdate() AS DATE))
    ,FODay = @FromDate
    ,NotAudited = IsNull(i.EndOfDayId, 0)
    ,IsExtra = 1 
    , pl.Id SalesPriceListId
    , pl.[Description] SalesPriceList
    , ISNULL(plc.[Description],'No Price List') CostPriceList
    , ISNULL(pdc.Price,0) CostPrice
    , ISNULL(pdc.Price,0)*ISNULL(odi.Qty,0) cOST
    , pd.Price SalesPrice

from OrderDetailInvoices odi
join OrderDetailIgredients oding on oding.OrderDetailId = odi.OrderDetailId
join Invoices i on i.Id = odi.InvoicesId
join InvoiceTypes it on it.Id = i.InvoiceTypeId
join PosInfo pi on pi.Id = i.PosInfoId
left outer join Department d on d.Id = pi.DepartmentId
join OrderDetail od on od.Id = odi.OrderDetailId
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
LEFT OUTER JOIN PricelistDetail pd ON pd.PricelistId = pl.Id AND 
          (pd.IngredientId = odi.ProductId AND pd.ProductId IS NULL)

LEFT OUTER JOIN Pricelist plc ON plc.Id = @SelPlID 
LEFT OUTER JOIN PricelistDetail pdc ON pdc.PricelistId = @SelPlID AND 
          (pdc.IngredientId = odi.ProductId AND pdc.ProductId IS NULL) 

where  IsNull(eod.FODay, CAST(getdate() AS DATE)) between @FromDate and @ToDate 
  --and IsNull(i.IsDeleted, 0) = 0 and IsNull(oding.IsDeleted, 0) = 0 and it.Type not in (2,8)
-- Common Section Ends


) prime
--WHERE ISNULL(prime.FODay, CAST(GETDATE() AS DATE)) BETWEEN CAST(@FromDate AS DATE) AND CAST(@ToDate AS DATE)
--where IsExtra = 1
--where productId = 554
group by  CategoryId,
   CategoryDescription, 
   ProductId,
  DepartmentDescription,
  DepartmentId,
  SalesPriceListId,
  SalesPriceList,
  CostPriceList,
  CostPrice,
  SalesPrice
