Select IsNull( Code, 0 ) Code, Description
From ProductCategories
Where Code != 0
Order By code


SELECT Code, Description
FROM ProductCategories
Where IsNull( Code, 0 ) != 0
Order By Description Asc
