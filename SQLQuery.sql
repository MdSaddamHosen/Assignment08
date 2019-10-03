use CoffeeShop
drop table Items
create table Items
(
ID int identity(1,1),
Name varchar(50),
Price float

)
select* from Items
CREATE TABLE Customer
(
ID INT IDENTITY(1,1),
Name VARCHAR(50),
[Address] VARCHAR(200),
Contract VARCHAR(50),
)
drop table Customer
select * from  Customer
select * from  Ordercustomer