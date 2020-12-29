-- SELECT Code, Description FROM ProductCategories ORDER BY Description

Select Code, Description From ProductCategories Where IsNull( Code, 0 ) != 0 Order By code