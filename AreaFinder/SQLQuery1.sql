SELECT ProductName , CategoryName
FROM 
((Category RIGHT JOIN PivotTable ON Category.Id=PivotTable.CategoryID)
JOIN Product ON Product.Id=PivotTable.ProductID);
