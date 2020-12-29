
-------------------------
-- InvoiceTypes Lookup --
-------------------------
SELECT DISTINCT Id, Abbreviation, Type
FROM InvoiceTypes
--WHERE Type NOT IN ( 2, 3, 8, 10, 11, 12 )
ORDER BY Type

---------------------
-- PriceList Lookup --
---------------------
Select Id, Description 
From Pricelist
-- Order By Description
Order By Id

------------------------
-- Department Lookup --
------------------------
Select Id, Description
From Department
Order By Description

-----------------------
-- Categories Lookup --
-----------------------
Select Id, Description
From Categories
-- Order By Description
Order By Id

---------------------
-- Accounts Lookup --
---------------------
Select Id, Type, Description
From Accounts
Order By Description

