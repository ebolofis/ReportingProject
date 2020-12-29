Declare @FromDate date = '2016-06-01', @ToDate date = '2016-06-02'

Select PmsDepartmentId,
       PmsDepartmentDescription,
       RoomDescription,
       Description = tpms.Description,
       tpms.Total,
       tpms.Status,
       tpms.PmsResponseId,
       tpms.RegNo,
       tpms.Profilename,
       SendToPmsTS,
       FODay = IsNull( eod.FODay, cast( GetDate() as Date ) ),
       PosInfoCode = pif.Code,
       PosInfoDescription = pif.Description,
       hi.HotelName,
       hi.MPEHotel,
       PaymentType = a.Description,
       Waiter = st.FirstName + ' ' + st.LastName,
       receiptNo

From TransferToPms tpms
     left outer join EndOfDay eod on eod.Id = tpms.EndOfDayId 
     left outer join PosInfo pif on pif.ID = tpms.PosInfoId
     left outer join HotelInfo hi on hi.HotelId = tpms.HotelId
     left outer join Transactions t on t.Id = tpms.TransactionId
     left outer join Accounts a on t.AccountId = a.Id
     left outer join Staff st on st.Id = t.StaffId

Where IsNull( eod.FODay, CAST( getdate() AS DATE ) ) BETWEEN CAST( @FromDate AS DATE ) AND CAST( @ToDate AS DATE )
