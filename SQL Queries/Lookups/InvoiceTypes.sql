-- Select Id, Type, Abbreviation From InvoiceTypes

Select Distinct Id, Abbreviation, Type
From InvoiceTypes
Where Type NOT IN ( 2, 3, 8, 10, 11, 12 )
Order By Type