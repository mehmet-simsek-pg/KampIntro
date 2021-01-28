--Select
--ANSII
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City ='Berlin'

--case insensitive = Büyük küçük harf duyarsız bir syntax i var
Select * from Products where CategoryID =1 or CategoryID=3

Select * from Products where CategoryID =1 and UnitPrice>=10

select * from Products where CategoryID =1  order by UnitPrice desc -- asc ascending == Artan --- descending == azalan/düşen 

select COUNT(*) from Products   -- Products kolonunda kaç adet girdi var// kaç satır var 

select categoryID, count (*) from Products group by CategoryID -- hangi kategoride kaç ürün var

select categoryID, count (*) from Products group by CategoryID having count(*)<10  -- içerisinde 10 dan az ürün olan kategorileri ver 

select categoryID, count (*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 --birim fiyatı 20 den fazla olam ürünleri CategoryId e göre filtrele ve içinde sayısı ondan az olanları ver



select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName  -- Join // birleştirme
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10 -- Fiyatı 10 dan büyük olan ürünleri kategori ismi ile sorgular


--DTO Data Transformation object 


select * from products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o  
on o.OrderID=od.OrderID



select * from customers c left join orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null