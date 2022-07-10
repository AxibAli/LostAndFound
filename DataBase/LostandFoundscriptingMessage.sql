create table Messages(
Message_ID bigint identity not null primary key,
Product_ID bigint not null foreign key references Product(Product_ID),
Message nvarchar(max) not null,
Meassage_Date datetime not null
)
alter database LostandFound set enable_broker
ALTER DATABASE LostandFound SET ENABLE_BROKER WITH ROLLBACK IMMEDIATE ;

insert into Messages(Product_ID,Message,Meassage_Date)values(2,'abc',GETDATE());
