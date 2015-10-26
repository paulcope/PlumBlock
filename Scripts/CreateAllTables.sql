create table dbo.Users
(
UserID int identity(1,1),
Title varchar(20),
FirstName varchar(50),
Surname varchar(50),
EmailAddress varchar(50),
PassW  varchar(50)
);

create table dbo.Properties
(
Prop_ID      int identity(1,1),
Valuation    money,
LowestPrice  money,
UserID       int,
Prop_Address_ID int
);

create table dbo.Addresses
(
Address_ID   int identity(1,1),
AddressLine1 varchar(50),
AddressLine2 varchar(50),
AddressLine3 varchar(50),
AddressLine4 varchar(50),
AddressLine5 varchar(50),
PostCode     varchar(10)
);

create table dbo.Offers
(
 Prop_ID int,
 By_User int,
 Offer_Amount money
);

