-- declare @FromDate datetime = '2016-05-30', @ToDate  datetime = '2016-05-30'


select a.IsDeleted,
       Abbreviation = a.Abbreviation,
       a.Counter,
       Day = a.Day,
       AccountId = t.AccountId,
       AccountType = t.AccountType,
       AccountDescription = t.AccountDescription,
       DepartmentId = a.DepartmentId ,
       DepartmentDescription = a.DepartmentDescription,
       PosInfoId = a.PosInfoId,
       PosInfoCode = a.PosInfoCode,
       PosInfoDescription = a.PosInfoDescription,
       TableCode = a.TableCode,
       Room = t.Room,
       InvoiceType = a.InvoiceType,
       vat1 = case InvoiceTotal when 0 then odiv.Vat1 else  odiv.Vat1 * (t.TransAmount / a.InvoiceTotal) end,
       vat2 = case InvoiceTotal when 0 then odiv.Vat2 else  odiv.Vat2 * (t.TransAmount / a.InvoiceTotal) end,
       vat3 = case InvoiceTotal when 0 then odiv.Vat3 else  odiv.Vat3 * (t.TransAmount / a.InvoiceTotal) end,
       vat4 = case InvoiceTotal when 0 then odiv.Vat4 else  odiv.Vat4 * (t.TransAmount / a.InvoiceTotal) end,
       vat5 = case InvoiceTotal when 0 then odiv.Vat5 else  odiv.Vat5 * (t.TransAmount / a.InvoiceTotal) end,
       Vat1Pst = odiv.Vat1Pst,
       Vat2Pst = odiv.Vat2Pst,
       Vat3Pst = odiv.Vat3Pst,
       Vat4Pst = odiv.Vat4Pst,
       Vat5Pst = odiv.Vat5Pst,
       TransAmount = t.TransAmount,
       InvoiceTotal = a.InvoiceTotal,
       InvoiceDiscount = a.InvoiceDiscount,
       InvoiceDiscountRemark = a.InvoiceDiscountRemark,
       IsVoided = a.IsVoided,
       IsPaid = case when t.TransAmount > 0 then 1 else 0 end,
       StaffCode = a.StaffCode,
       StafName = a.StafName,
       FODay = a.FODay,
       NotAudited = a.NotAudited
       
from (

     select distinct Id = i.Id,
                     IsDeleted = i.isDeleted,
                     Abbreviation = it.Abbreviation,
                     i.Counter,
                     Day = i.Day,
                     DepartmentId = cast (d.Id as bigint),
                     DepartmentDescription = d.Description,
                     PosInfoId = i.PosInfoId,
                     PosInfoCode = pi.Code,
                     PosInfoDescription = pi.Description,
                     TableCode = tbl.Code,
                     -- Room = t.Room,
                     InvoiceType = it.Type,
                     InvoiceTotal = i.Total,
                     InvoiceDiscount = i.Discount,
                     InvoiceDiscountRemark = i.DiscountRemark,
                     IsVoided = i.IsVoided,
                     -- IsPaid = i.IsPaid,
                     StaffCode = st.Code,
                     StafName = st.LastName + ' ' + st.FirstName,
                     FODay = CAST(IsNull(eod.FODay, getdate()) AS DATE),
                     NotAudited = IsNull(i.EndOfDayId, 0)
                     
     from Invoices i
          join OrderDetailInvoices odi on i.id = odi.InvoicesId 
          join InvoiceTypes it on i.InvoiceTypeId = it.Id and it.Type != 3 and it.Type != 8
          left outer join [Table] tbl on i.TableId = tbl.Id
          join staff st on st.Id = i.StaffId
          join PosInfo pi on i.PosInfoId = pi.id
          left outer join Department d on pi.DepartmentId = d.Id
          left outer join EndOfDay eod on i.EndOfDayId = eod.Id
      
     where IsNull( i.IsDeleted, 0 ) = 0 and IsNull( eod.FODay, cast( getdate() AS DATE ) ) >= cast( @FromDate AS DATE )
           and IsNull( eod.FODay, cast( getdate() AS DATE ) ) <= cast( @ToDate  AS DATE )

     ) a
     
 inner join (
 
            Select InvoicesId,
                   Vat1 = Sum(vat1), 
                   Vat2 = Sum(vat2), 
                   Vat3 = Sum(vat3), 
                   Vat4 = Sum(vat4), 
                   Vat5 = Sum(vat5),
                   Vat1Pst = max(Vat1Pst),
                   Vat2Pst = max(Vat2Pst),
                   Vat3Pst = max(Vat3Pst),
                   Vat4Pst = max(Vat4Pst),
                   Vat5Pst = max(Vat5Pst)
            from ( 
    select InvoicesId, 
           Vat1= case v.Code when 1 then od.TotalAfterDiscount else 0 end,
           Vat2= case v.Code when 2 then od.TotalAfterDiscount else 0 end,
           Vat3= case v.Code when 3 then od.TotalAfterDiscount else 0 end,
           Vat4= case v.Code when 4 then od.TotalAfterDiscount else 0 end,
           Vat5= case v.Code when 5 then od.TotalAfterDiscount else 0 end,
           Vat1Pst= case v.Code when 1 THEN v.Percentage else 0 end,
           Vat2Pst= case v.Code when 2 then v.Percentage else 0 end,
           Vat3Pst= case v.Code when 3 then v.Percentage else 0 end,
           Vat4Pst= case v.Code when 4 then v.Percentage else 0 end,
           Vat5Pst= case v.Code when 5 then v.Percentage else 0 end
           
    from OrderDetailInvoices odi
         LEFT OUTER Join OrderDetail od ON od.Id = odi.OrderDetailId
         LEFT OUTER JOIN OrderDetailVatAnal odva on od.Id = odva.OrderDetailId
         LEFT OUTER JOIN Vat v ON v.Id = odva.VatId
         
    where IsNull(odi.IsDeleted, 0) != 1
    union
    select  InvoicesId, 
            Vat1= case v.Code when 1 then od.TotalAfterDiscount else 0 end,
            Vat2= case v.Code when 2 then od.TotalAfterDiscount else 0 end,
            Vat3= case v.Code when 3 then od.TotalAfterDiscount else 0 end,
            Vat4= case v.Code when 4 then od.TotalAfterDiscount else 0 end,
            Vat5= case v.Code when 5 then od.TotalAfterDiscount else 0 end,
            Vat1Pst= case v.Code when 1 THEN v.Percentage else 0 end,
            Vat2Pst= case v.Code when 2 then v.Percentage else 0 end,
            Vat3Pst= case v.Code when 3 then v.Percentage else 0 end,
            Vat4Pst= case v.Code when 4 then v.Percentage else 0 end,
            Vat5Pst= case v.Code when 5 then v.Percentage else 0 end
    from OrderDetailInvoices odi
         LEFT OUTER Join OrderDetailIgredients od ON od.Id = odi.OrderDetailId
         LEFT OUTER JOIN OrderDetailIgredientVatAnal odva on od.Id = odva.OrderDetailIgredientsId
         LEFT OUTER JOIN Vat v ON v.Id = odva.VatId
         
    where IsNull(odi.IsDeleted, 0) != 1 
     ) nested group by InvoicesId  

   ) as odiv on odiv.InvoicesId = a.Id
  inner join ( Select InvoicesId,
         AccountId,
         AccountType = a.Type,
         AccountDescription = a.Description,
         Room = g.Room,
         TransAmount = Sum( Amount )
        from Transactions t
        left outer join Accounts a on t.AccountId = a.Id
        left outer join Invoice_Guests_Trans igt on igt.TransactionId = t.Id
        left outer join Guest g on igt.GuestId = g.Id

        where IsNull( t.isDeleted, 0 ) != 1
        group by InvoicesId, AccountId, a.Type, a.Description, g.Room ) as t on t.InvoicesId = a.Id
