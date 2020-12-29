-- select OBJECT_NAME(object_id),* from sys.columns where name='hotelid'
-- select OBJECT_NAME(object_id),* from sys.columns where name='ItemCode'

-----------------------
-- Αποδείξεις με ΦΠΑ --
-----------------------

Declare @FromDate Date = '2016-05-01', @ToDate Date = '2016-05-01'

Select * From (

Select Abbreviation = a.Abbreviation,
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
       Room = a.Room,
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
       IsPaid = a.IsPaid,
       StaffCode = a.StaffCode,
       StafName = a.StafName,
       FODay = a.FODay,
       NotAudited = a.NotAudited

From (
     Select Distinct Id = i.Id,
                     Abbreviation = odi.Abbreviation,
                     i.Counter,
                     Day = i.Day,
                     DepartmentId = cast ( d.Id as bigint ),
                     DepartmentDescription = d.Description,
                     PosInfoId = i.PosInfoId,
                     PosInfoCode = pi.Code,
                     PosInfoDescription = pi.Description,
                     TableCode = odi.TableCode,
                     Room = i.Rooms,
                     InvoiceType = odi.InvoiceType,
                     InvoiceTotal = i.Total,
                     InvoiceDiscount = i.Discount,
                     InvoiceDiscountRemark = i.DiscountRemark,
                     IsVoided = ISNULL( i.IsVoided, 0 ),
                     IsPaid = i.IsPaid,
                     StaffCode = st.Code,
                     StafName = st.LastName + ' ' + st.FirstName,
                     FODay = CAST( IsNull( eod.FODay, getdate() ) AS DATE ),
                     NotAudited = IsNull( i.EndOfDayId, 0 )
     From Invoices i
          join OrderDetailInvoices odi on i.id = odi.InvoicesId and
                                          odi.InvoiceType != 3 and
                                          odi.InvoiceType != 8
          join staff st on st.Id = i.StaffId
          join PosInfo pi on i.PosInfoId = pi.id
          left outer join Department d on pi.DepartmentId = d.Id
          left outer join EndOfDay eod on i.EndOfDayId = eod.Id

     -- Where IsNull(i.IsVoided, 0) = 0

     ) a
       
inner join ( Select InvoicesId,
                    Vat1 = Sum( vat1 ), 
                    Vat2 = Sum( vat2 ), 
                    Vat3 = Sum( vat3 ), 
                    Vat4 = Sum( vat4 ), 
                    Vat5 = Sum( vat5 ),
                    Vat1Pst = max( Vat1Pst ),
                    Vat2Pst = max( Vat2Pst ),
                    Vat3Pst = max( Vat3Pst ),
                    Vat4Pst = max( Vat4Pst ),
                    Vat5Pst = max( Vat5Pst )

             From (
                  Select InvoicesId, 
                         Vat1= case vatCode when 1 then Total else 0 end,
                         Vat2= case vatCode when 2 then Total else 0 end,
                         Vat3= case vatCode when 3 then Total else 0 end,
                         Vat4= case vatCode when 4 then Total else 0 end,
                         Vat5= case vatCode when 5 then Total else 0 end,
                         Vat1Pst= case vatCode when 1 THEN v.Percentage else 0 end,
                         Vat2Pst= case vatCode when 2 then v.Percentage else 0 end,
                         Vat3Pst= case vatCode when 3 then v.Percentage else 0 end,
                         Vat4Pst= case vatCode when 4 then v.Percentage else 0 end,
                         Vat5Pst= case vatCode when 5 then v.Percentage else 0 end

                  From OrderDetailInvoices
                       LEFT OUTER JOIN Vat v ON v.Id = VatCode

                  where IsNull( isDeleted, 0 ) != 1

                  ) a

             Group By InvoicesId ) as odiv on odiv.InvoicesId = a.Id

inner join (
           Select InvoicesId,
                  AccountId,
                  AccountType = a.Type,
                  AccountDescription = a.Description,
                  TransAmount = Sum( Amount )

           From Transactions t
                left outer join Accounts a on t.AccountId = a.Id

           Where IsNull( t.isDeleted, 0 ) != 1

           Group by InvoicesId,
                    AccountId,
                    a.Type,
                    a.Description

           ) as t on t.InvoicesId = a.Id

       )  aa

Where IsNull( aa.FODay, cast( getdate() AS DATE ) ) >= cast( @FromDate AS DATE )
      and IsNull( aa.FODay, cast( getdate() AS DATE ) ) <= cast( @ToDate AS DATE )

