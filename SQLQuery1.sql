
create database PearGroup

create table Supplier
(
SupplierID int primary key identity,
SupplierName varchar(max)
)

create table Product
(
ProductID int primary key identity,
ProductName varchar(max),
QauantityPerUnit decimal,
ReorderLevel decimal,
UnitPrice decimal,
UnitsInStock int,
UnitsOnOrder int,
SupplierID int,
constraint c1 foreign key (SupplierID) references supplier(SupplierID)
on delete set null on update cascade
)

