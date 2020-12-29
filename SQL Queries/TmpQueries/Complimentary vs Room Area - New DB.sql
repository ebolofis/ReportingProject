-- select OBJECT_NAME(object_id),* from sys.columns where name='hotelid'
-- select OBJECT_NAME(object_id),* from sys.columns where name='ItemCode'

-----------------------------------------
-- Πωλήσεις Complimentary vs Room Area --
-----------------------------------------

Declare @FromDate Date = '2016-05-01', @ToDate Date = '2016-05-01'

Select Total = SUM( Total ), Total2 = SUM( TotalNew ) From (

SELECT DISTINCT a.*

FROM (

SELECT DISTINCT c.Id CategoryId
              , c.[Description] Category
              , ProductCode = max( Case IsExtra when 0 then p.Code else ing.Code end )
              , ProductDescription = max( Case IsExtra when 0 then p.SalesDescription else ing.SalesDescription end )
              , SUM( odi.Qty ) Qty
              , TotalNew = ROUND( SUM( odi.Total * ( case i.Total
                                                     when 0 then 0
                                                     when NULL then 0
                                                     else t.Amount / i.Total end ) ), 2 )
              , SUM( odi.Total ) Total
              , d.[Description] DepartmentDescription
              , d.Id DepartmentId
              , pl.Id SalesPriceListId
              , pl.[Description] SalesPriceList
              , t.Id transactionId
              , i.Id invoiceId
              , odi.ProductId	
              , g.Room
              , ISNULL( i.EndOfDayId, 0 ) EndOfDayId

FROM OrderDetailInvoices odi
     INNER JOIN Invoices i ON i.Id = odi.InvoicesId and IsNull(i.IsVoided, 0 ) = 0   
     INNER JOIN InvoiceTypes it ON it.Id = i.InvoiceTypeId AND it.[Type] NOT IN (2,3,8) 
       
     LEFT OUTER JOIN ProductCategories pc ON pc.Id = odi.ProductCategoryId
     LEFT OUTER JOIN Categories c ON c.Id = pc.CategoryId	 
       
     INNER JOIN PosInfo pif ON pif.Id = i.PosInfoId
     LEFT OUTER JOIN Department d ON d.Id = pif.DepartmentId
       
     INNER JOIN Pricelist pl ON pl.Id = odi.PricelistId AND pl.[Type] = 3
       
     INNER JOIN Transactions t ON t.InvoicesId = i.Id
      
     INNER JOIN Invoice_Guests_Trans igt ON igt.TransactionId = t.Id
     INNER JOIN Guest g ON g.Id = igt.GuestId
     left outer join Product p on p.id = odi.productid and isextra = 0
     left outer join Ingredients ing on ing.Id = odi.productid and isextra = 1

Group By i.Id
       , odi.ProductId
       , t.Id
       , c.Id
       , c.[Description]
       , odi.[Description]
       , pl.Id
       , d.Id
       , d.[Description]
       , pl.[Description]
       , g.Room
       , i.EndOfDayId
       , i.Total
       , t.Amount

) a

LEFT OUTER JOIN EndOfDay eod ON ISNULL(eod.FODay, CAST(GETDATE() AS DATE)) BETWEEN CAST(@FromDate  AS DATE) AND CAST(@ToDate AS DATE)

WHERE a.EndOfDayId = CASE WHEN CAST(@FromDate AS DATE) = CAST(GETDATE() AS DATE) THEN 0 ELSE eod.Id END

-- ORDER BY a.invoiceId

) sum_of_totals
