declare @FromFODay date = '2016-06-28', @ToFODay date = GetDate()

select Total = Sum(InvoiceTotal) from (

select FODay = IsNull(eod.FODay, CAST(getdate() AS DATE)),
       Day = i.Day,
       NotAudited = IsNull(i.EndOfDayId, 0),
       PosInfoId = i.PosInfoId,
       PosInfoCode = pinf.Code,
       PosInfoDescription = pinf.Description,
       DepartmentId = d.Id,
       DepartmentDescription = d.Description,
       InvoiceId = i.Id,
       InvoiceDescription = i.Description,
       Abbreviation = it.Abbreviation,
       InvoiceType = it.Type,
       ReceiptNo = i.Counter,
       Cover = i.Cover,
       IsVoided = i.IsVoided,
       IsPaid = i.IsPaid,
       IsPrinted = i.IsPrinted,
       InvoiceTotal = i.Total,
       InvoiceDiscount = i.Discount,
       TableCode = tbl.code,
       StaffId = s.Id,
       StaffCode = s.Code,
       StaffName = s.FirstName + ' ' + s.LastName,
       DiscountRemarks = i.DiscountRemark 
from Invoices i
     join invoicetypes it on it.Id = i.InvoiceTypeId  and it.Type != 3 and it.Type != 8
     left outer join [table] tbl on tbl.id = i.tableid
     left outer join EndofDay eod on i.endOfDayId = eod.id
     join PosInfo pinf on pinf.Id = i.PosInfoId
     left outer join Department d on d.Id = pinf.DepartmentId
     join Staff s on s.Id = i.StaffId
                      and IsNull(eod.FODay, cast(getdate() AS DATE))  >= cast(@FromFODay AS DATE)
                      and IsNull(eod.FODay, cast(getdate() AS DATE))  <= cast(@ToFODay  AS DATE)
where IsNull( i.IsDeleted, 0 ) = 0

) sum_of_totals
