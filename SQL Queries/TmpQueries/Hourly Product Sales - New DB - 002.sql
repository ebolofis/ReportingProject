-- select OBJECT_NAME(object_id),* from sys.columns where name='hotelid'
-- select OBJECT_NAME(object_id),* from sys.columns where name='ItemCode'

--------------------------------
-- Ωριαίες Πωλήσεις ανά Είδος --
--------------------------------

Declare @FromDate date = '2016-05-01', @ToDate date = '2016-05-01'

Select Total = SUM(Total) From (

SELECT ProductId,
       ProductCode,
       ProductDescription,
       ProductCategoryCode,
       ProductCategoryDescrtiption,
       CategoryDescription, 
       StaffCode,
       StafName,
       FODay,
       PosInfoId,
       PosInfoDescription,
       DepartmentDescription,
       DepartmentId,
       Abbreviation,
       InvoiceType,
       --PricelistId ,PricelistDescription ,
       CategoryId,
       HourOfDay,
       InvoiceCount = Count( distinct InvoiceId ),
       Qty = Sum( Qty ),
       Total = Sum( Total ),
       MinPrice = Min( Price ),
       MaxPrice = Max( Price ),
       Net = Sum( Net ),
       VatAmount = Sum( VatAmount ) 
       
FROM (
      SELECT ProductId,
             ProductCode,
             ProductDescription,
             ProductCategoryCode,
             ProductCategoryDescrtiption,
             CategoryDescription,
             PricelistCode,
             InvoiceId,
             InvoiceTotal,
             InvoiceType,
             Abbreviation,
             ReceiptNo,
             Cover,
             qty,
             Total,
             Price,
             Net,
             VatAmount,
             StaffCode,
             StafName,
             FODay,
             IsExtra,
             PosInfoId,
             PosInfoDescription,
             DepartmentDescription,
             DepartmentId,
             CategoryId,
             HourOfDay
             --InvoiceUsed = Count(distinct InvoiceId)
      FROM (
            SELECT HourOfDay = Cast(DatePart( hh, i.Day ) as varchar(2)),
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
                   CategoryId = c.Id,
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
                   
   FROM OrderDetailInvoices odi 
        join Invoices i on odi.InvoicesId = i.id AND ISNULL( i.IsVoided, 0 ) = 0
        left join ProductCategories pc on odi.productCategoryId = pc.Id
        left join Categories c on pc.CategoryId = c.Id
        left join EndOfDay eod on i.EndofDayId = eod.Id
        left join Pricelist pl on odi.pricelistid = pl.id
        left join vat v on odi.vatId = v.Id
        left join SalesType st on st.Id = odi.SalesTypeId
        left join Staff s on i.StaffId = s.id
        left outer join Product p on p.id = odi.productid and isextra = 0
        left outer join Ingredients ing on ing.Id = odi.productid and isextra = 1
        left outer join PosInfo pi on i.PosInfoId = pi.Id
        left outer join Department d on pi.DepartmentId = d.Id
                      and IsNull( eod.FODay, cast( getdate() AS DATE ) ) >= cast( @FromDate AS DATE )
                and IsNull( eod.FODay, cast( getdate() AS DATE ) ) <= cast( @ToDate AS DATE )
              
   WHERE IsNull( i.IsDeleted, 0) = 0 and IsNull( odi.IsDeleted, 0) = 0 and InvoiceType not in ( 2, 3, 8 ) 
         and IsNull( eod.FODay, CAST( getdate() AS DATE ) ) Between @FromDate and @ToDate
         
   GROUP BY i.Id,
            odi.ProductId,
            odi.Description,
            pc.Code,
            pc.Description,
            c.Description,
            pl.Code,
            odi.VatId,
            odi.InvoiceType,
            odi.Abbreviation,
            odi.Counter,
            i.Id,
            i.Cover,
            i.Total,
            i.Rooms,
            odi.SalesTypeId,
            st.Description,
            s.Code,
            s.LastName + ' ' + s.FirstName,
            IsNull( eod.FODay, CAST( getdate() AS DATE ) ),
            IsNull( i.EndOfDayId, 0 ),
            IsExtra,
            i.PosInfoId,
            pi.Description,
            d.Description,
            pi.DepartmentId,
            c.Id,
            DatePart( hh, i.Day )
            
   ) t
   
   ) prime
   
--where ProductId= 1674

GROUP BY ProductId,
         ProductCode,
         ProductDescription,
         ProductCategoryCode,
         ProductCategoryDescrtiption,
         Abbreviation,
         InvoiceType,
         CategoryDescription,
         StaffCode,
         StafName,
         FODay,
         PosInfoId,
         PosInfoDescription ,
         DepartmentDescription,
         DepartmentId,
         CategoryId,
         HourOfDay

-- PricelistCode, PricelistDescription, InvoiceTotal, InvoiceType, Abbreviation, ReceiptNo, Cover

-- order by InvoiceId

) sum_of_totals

