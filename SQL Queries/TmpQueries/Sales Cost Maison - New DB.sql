-- select OBJECT_NAME(object_id),* from sys.columns where name='hotelid'
-- select OBJECT_NAME(object_id),* from sys.columns where name='ItemCode'

---------------------------------
-- Κόστος Πωληθέντων ( maison )--
---------------------------------

Declare @FromDate Date = '2016-05-01', @ToDate Date = '2016-05-01', @SelPlID Bigint = 0

Select Total = SUM( Total) From (

SELECT c.Id CategoryId,
       c.[Description] Category, 
       ProductCode = max(Case IsExtra when 0 then p.Code else ing.Code end),
       ProductDescription = max(Case IsExtra when 0 then p.SalesDescription else ing.SalesDescription end),	SUM(odi.Qty) Qty, 
	    SUM(odi.Total) Total,
	    d.[Description] DepartmentDescription,
	    d.Id DepartmentId,
	    pl.Id SalesPriceListId,
	    pl.[Description] SalesPriceList,
	    pd.Price SalesPrice, 
	    ISNULL(plc.[Description],'No Price List') CostPriceList,
	    ISNULL(pdc.Price,0) CostPrice,
	    SUM(ISNULL(pdc.Price,0)*ISNULL(odi.Qty,0)) Cost

FROM OrderDetailInvoices odi
     INNER JOIN Invoices i ON i.Id = odi.InvoicesId and IsNull(i.IsVoided, 0)= 0
     LEFT OUTER JOIN EndOfDay eod on eod.Id = i.EndOfDayId
     INNER JOIN InvoiceTypes it ON it.Id = i.InvoiceTypeId AND it.[Type] NOT IN (2, 3, 8) 
     INNER JOIN PosInfo pif ON pif.Id = i.PosInfoId
     LEFT OUTER JOIN Department d ON d.Id = pif.DepartmentId
     LEFT OUTER JOIN ProductCategories pc ON pc.Id = odi.ProductCategoryId
     LEFT OUTER JOIN Categories c ON c.Id = pc.CategoryId	 
     left outer join Product p on p.id = odi.productid and isextra = 0
     left outer join Ingredients ing on ing.Id = odi.productid and isextra = 1
     
     INNER JOIN Pricelist pl ON pl.Id = odi.PricelistId AND pl.[Type] = 3
     LEFT OUTER JOIN PricelistDetail pd ON pd.PricelistId = pl.Id AND 
     	((pd.ProductId = odi.ProductId AND pd.IngredientId IS NULL) OR 
     	(pd.IngredientId = odi.ProductId AND pd.ProductId IS NULL))
     
     LEFT OUTER JOIN Pricelist plc ON plc.Id = @SelPlID 
     LEFT OUTER JOIN PricelistDetail pdc ON pdc.PricelistId = @SelPlID AND 
     	((pdc.ProductId = odi.ProductId AND pdc.IngredientId IS NULL) OR 
     	 (pdc.IngredientId = odi.ProductId AND pdc.ProductId IS NULL) )

Where ISNULL(eod.FODay, CAST(GETDATE() AS DATE)) BETWEEN CAST(@FromDate  AS DATE) AND CAST(@ToDate AS DATE)
	   and IsNull(i.IsDeleted, 0) = 0
      and IsNull(odi.IsDeleted, 0) = 0
      and InvoiceType not in (2,3,8)

Group By c.Id,
         c.[Description],
         odi.[Description],
         pl.Id,
         pd.Price,
         pdc.Price,
         d.Id,
         d.[Description], 
         pl.[Description],
         plc.[Description]

) sum_of_totals
