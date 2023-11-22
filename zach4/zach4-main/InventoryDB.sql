create database InventoryDb

use InventoryDb

--Creates the user account table
CREATE TABLE UserAccount (
userId integer IDENTITY(1,1) primary key,
userfirstname varchar (50) not null,
userlastname varchar(50) not null,
userName varchar (50) not null,
userPass varchar(50) not null,
roleId varchar)

--frameset product details

CREATE TABLE Frameset (
frameId integer IDENTITY(1,1) primary key,
frameName varchar (50) not null,
frameType varchar(50) not null,
framePrice money not null,
frameQuantity int)
