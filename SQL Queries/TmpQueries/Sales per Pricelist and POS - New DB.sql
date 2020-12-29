-- select OBJECT_NAME(object_id),* from sys.columns where name='hotelid'
-- select OBJECT_NAME(object_id),* from sys.columns where name='ItemCode'

---------------------------------------------
-- Πωλήσεις Ειδών ανά Τιμοκατάλογο και POS --
---------------------------------------------

Declare @FromDate datetime = '2016-05-01', @ToDate datetime = '2016-05-01'

-- Select Total = SUM(Total) From (

Select ProductId
     , ProductCode
     , ProductDescription
     , FODay
     , PricelistId
     , PricelistDescription
     , PosInfoId
     , PosInfoDescription
     , InvoiceCount = Count( distinct InvoiceId )
     , Qty = Sum( Qty )
     , Total = Sum( Total )
     , MinPrice = Min( Price )
     , MaxPrice = Max( Price )
     , Net = Sum( Net )
     , VatAmount = Sum( VatAmount )
     , Rooms

From (

Select ProductId
     , ProductCode
     , ProductDescription
     , ProductCategoryCode
     , ProductCategoryDescrtiption
     , CategoryDescription
     , PricelistCode
     , PricelistDescription
     , InvoiceId
     , InvoiceTotal
     , Abbreviation
     , ReceiptNo
     , Cover
     , qty
     , Total
     , Price
     , Net
     , VatAmount
     , FODay
     , IsExtra
     , PricelistId
     , PosInfoId
     , PosInfoDescription 
	 , Rooms
     -- , InvoiceUsed = Count( distinct InvoiceId )

From (

Select PosInfoId = i.PosInfoId
     , PosInfoDescription = pi.Description
     -- , DepartmentDescription = d.Description
     -- , DepartmentId = pi.DepartmentId
     , ProductId = odi.ProductId
     , ProductCode = max( Case IsExtra when 0 then p.Code else ing.Code end )
     , ProductDescription = max(Case IsExtra when 0 then p.SalesDescription else ing.SalesDescription end)
     , ProductCategoryCode = pc.Code
     , ProductCategoryDescrtiption = pc.Description
     , CategoryDescription = c.Description
     , Qty = Sum(odi.Qty)
     , Price = Sum(odi.Price)
     , Discount = Sum(odi.Discount)
     , Total = sum(odi.Total)
     , Net = Sum(odi.Net)
     , VatAmount = Sum(odi.VatAmount)
     , VatPercentage = Max(v.Percentage)
     , PricelistDescription = pl.Description
     , PricelistId = pl.Id
     , PricelistCode = pl.Code
     , VatId = odi.VatId
     , InvoiceTotal = i.Total
     -- , InvoiceType = odi.InvoiceType
     , Abbreviation = odi.Abbreviation
     , ReceiptNo = odi.Counter
     , InvoiceId = i.Id
     , Cover = i.Cover
     , Rooms = i.Rooms
     , SalesTypeId = odi.SalesTypeId
     , SalesTypeDescription = st.Description
     -- , StaffCode = s.Code
     -- , StafName = s.LastName + ' ' + s.FirstName
     -- , FODay = IsNull(eod.FODay, CAST(getdate() AS DATE))
     , TempFODay = IsNull(eod.FODay, CAST(getdate() AS DATE))
     , FODay = @FromDate
     , NotAudited = IsNull(i.EndOfDayId, 0)
     , IsExtra = odi.IsExtra

From OrderDetailInvoices odi 
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
          
Where IsNull(i.IsDeleted, 0) = 0 and
      IsNull(odi.IsDeleted, 0) = 0 and
      InvoiceType not in (2,3,8) and
      IsNull(eod.FODay, CAST(getdate() AS DATE)) BETWEEN @FromDate AND @ToDate
          
Group By i.Id
       , odi.ProductId
       , odi.Description
       , pc.Code
       , pc.Description
       , c.Description
       , pl.Description
       , pl.Code
       , odi.VatId
       , odi.Abbreviation
       , odi.Counter
       , i.Id
       , i.Cover
       , i.Total
       , i.Rooms
       , odi.SalesTypeId
       , st.Description
       , IsNull(eod.FODay, CAST(getdate() AS DATE))
       , IsNull(i.EndOfDayId, 0)
       , IsExtra
       , pl.Id
       , i.PosInfoId
       , pi.Description
          
   ) t

   ) prime

-- Where ProductId= 1674

Group By ProductId
       , ProductCode
       , ProductDescription
       , FODay
       , PricelistId
       , PricelistDescription
       , PosInfoId
       , PosInfoDescription
       , Rooms
       -- , PricelistCode
       -- , PricelistDescription
       -- , InvoiceTotal
       -- , InvoiceType
       -- , Abbreviation
       -- , ReceiptNo
       -- , Cover

-- Order By InvoiceId

-- ) sum_of_totals
