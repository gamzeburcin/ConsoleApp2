--Select
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers

Select * from Customers where City = 'London'

--case insensitive küçük büyük harf duyarsız.
Select * from Products where CategoryID=1 or CategoryID=3 --bu ya da bu

Select * from Products where CategoryID=1 and UnitPrice>=10 --bu ve bu

select * from Products order by ProductName --alfabetik sıraya göre

select * from Products order by CategoryID, ProductName --hem category ıd ye hem product name'e göre sıraladı

select * from Products order by UnitPrice asc  --ascending artan fiyata göre listeleme

select * from Products order by UnitPrice desc  --descending azalan fiyata göre 

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products --toplam kayıt sayısı

select count(*) from Products where CategoryID=2

select CategoryID,count(*) from Products group by CategoryID

select CategoryID, count(*) from Products group by CategoryID having count(*)<10

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductID, Products.UnitPrice, Categories.CategoryName
from products inner join Categories 
on Products.CategoryID=Categories.CategoryID

select Products.ProductID, Products.ProductID, Products.UnitPrice, Categories.CategoryName
from products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO data transformation object 

select * from Products p inner join [Order Details] od
on p.ProductID= od.ProductID

select * from Products p left join [Order Details] od --solda olup sağda olmayanları da getir demek 
on p.ProductID= od.ProductID
inner join Orders o --birden fazla tabloyu birleştirmek istersek
on o.OrderID=od.OrderID

select * from Customers c left join Orders o 
on c.CustomerId=o.CustomerID

select * from Customers c left join Orders o 
on c.CustomerId=o.CustomerID
where o.CustomerID is null





