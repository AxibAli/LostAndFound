create database LostandFound

use LostandFound

create table App_User(
User_ID              bigint primary key Identity,
User_FullName        nvarchar(max) Not null,
User_Email           nvarchar(max) Not null,
User_Gender          nvarchar(max) Not null,
User_Contact         bigint Not null,
User_Password        nvarchar(max) Not null,
User_DOB             Date Not null,
User_Address         nvarchar(max) Not null,
User_Created_ON      Date Not null,
User_Updated_ON      Date Not null,
User_IsActive        Bit Not null,
)

create table Product(

Product_ID          bigint primary key Identity,
Postedby            bigint foreign key references App_User (User_ID),
Product_Name        nvarchar(max) not null,
Product_Category    nvarchar(max) Not null,
Product_Image       nvarchar(max) Not null,
Product_Description nvarchar(max) Not null,
Product_Created_ON  nvarchar(max) Not null,
Product_Location    nvarchar(max) Not null,
Product_IsActive    bit Not null,
)


create table Lost_Product(
 
Lost_Product          bigint primary key Identity,
Product_ID            bigint foreign key references Product(Product_ID),
Lost_Product_Status   nvarchar(max) Not null,

)

create table Found_Product(

Found_Product          bigint primary key Identity,
Product_ID             bigint foreign key references Product(Product_ID),
Found_Product_Status   nvarchar(max) Not null,

)


create table App_Admin(
Admin_ID  bigint primary key Identity,
Admin_FullName        nvarchar(max) Not null,
Admin_Gender          nvarchar(max) Not null,
Admin_Email           nvarchar(max) Not null,
Admin_Password        nvarchar(max) Not null,
Admin_Role            nvarchar(max) Not null,
Admin_Created_ON      Date Not null,
Admin_Created_By     Date Not null,
Admin_Updated_ON      Date Not null,
Admin_Updated_By      Date Not null,
Admin_IsActive        Bit Not null,
Admin_Contact         bigint Not null,

)
