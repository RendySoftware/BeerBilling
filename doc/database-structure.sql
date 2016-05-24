
create table Category(
id int Indentity primary key,
code nvarchar(5)  ,
name nvarchar(400)  
)
go

create table Unit(
id int Indentity primary key,
code nvarchar(10)  ,
name nvarchar(100)  
)
go

create table Material
id int Indentity primary key,
unit_id int ,
code nvarchar(5)  ,
name nvarchar(200)  
)
go

create table Store
id bigint Indentity primary key,
material_id int ,
amount numeric(10,2)  ,
stored_status nvarchar(20)  ,
stored_date date ,
stored_by  ,
reason text ,
created_by nvarchar(100)  ,
created_date datetime ,
updated_by nvarchar(100)  ,
updated_date datetime 
)
go

create table Menu
id int Indentity primary key,
category_id int ,
code nvarchar(10)  ,
name nvarchar(200)  ,
unit_id int ,
price numeric(10,2)  ,
description text ,
is_active nvarchar(3)  ,
created_by nvarchar(100)  ,
created_date datetime ,
updated_by nvarchar(100)  ,
updated_date datetime 
)
go

create table Order
id bigint Indentity primary key,
bill_id bigint ,
menu_id int ,
amount numeric((5,1))  ,
created_by nvarchar(100)  ,
created_date datetime ,
updated_by nvarchar(100)  ,
updated_date datetime 
)
go

create table Bill(
id bigint Indentity primary key,
customer_id int ,
table_id int ,
is_printed nvarchar(3)  ,
payment nvarchar(6)  ,
billing_date date ,
billing_number int ,
cancel_reason text ,
created_by nvarchar(100)  ,
created_date datetime ,
updated_by nvarchar(100)  ,
updated_date datetime 
)
go

create table Customer
id int Indentity primary key,
name nvarchar(100)  ,
birthday date ,
email nvarchar(100)  ,
phone nvarchar(30)  ,
created_by nvarchar(100)  ,
created_date datetime ,
updated_by nvarchar(100)  ,
updated_date datetime 
)
go

create table ResTable(
id int Indentity primary key,
code nvarchar(10)  ,
position nvarchar(500)  
)
go

create table BookedTable(
id int Indentity primary key,
customer_id int ,
table_id int ,
status nvarchar(10)  ,
process nvarchar(10)  ,
from date ,
to date ,
created_by nvarchar(100)  ,
created_date datetime ,
updated_by nvarchar(100)  ,
updated_date datetime 
)
go
