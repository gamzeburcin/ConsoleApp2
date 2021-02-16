Select Products.ProductName 'Product Name',
SUM([Order Details].UnitPrice*[Order Details].Quantity)'Total'
FROM Products
INNER JOIN[Order Details]
ON Products.ProductID=[Order Details].ProductID
INNER JOIN Orders ON Orders.OrderID=[Order Details].OrderID
GROUP BY Products.ProductName