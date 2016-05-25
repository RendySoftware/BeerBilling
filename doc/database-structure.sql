CREATE TABLE dbo.users (
  USER_ID numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  USER_NAME varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PASSWORD varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PRIMARY KEY CLUSTERED (USER_ID)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

CREATE TABLE dbo.USER_ROLE (
  ROLE_ID numeric(10, 0) NOT NULL,
  USER_ID numeric(10, 0) NOT NULL,
  IS_ACTIVE numeric(1, 0) DEFAULT 1 NOT NULL,
  PRIMARY KEY CLUSTERED (ROLE_ID, USER_ID)
)
GO

CREATE TABLE dbo.ROLES (
  ROLE_ID numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  ROLE_CODE varchar(50) NOT NULL,
  DESCRIPTION nvarchar(200) NULL,
  STATUS numeric(1, 0) DEFAULT 1 NOT NULL,
  PRIMARY KEY CLUSTERED (ROLE_ID),
  UNIQUE (ROLE_CODE)
)
GO

CREATE TABLE dbo.ROLE_OBJECT (
  OBJECT_ID numeric(10, 0) NOT NULL,
  ROLE_ID numeric(10, 0) NOT NULL,
  IS_ACTIVE numeric(1, 0) DEFAULT 1 NOT NULL,
  PRIMARY KEY CLUSTERED (OBJECT_ID, ROLE_ID)
)
GO

CREATE TABLE dbo.OBJECTS (
  OBJECT_ID numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  PARENT_ID numeric(10, 0) NULL,
  OBJECT_CODE varchar(50) NULL,
  DESCRIPTION nvarchar(200) NULL,
  OBJECT_URL varchar(500) NULL,
  [ORDER] numeric(5, 0) NULL,
  STATUS numeric(1, 0) DEFAULT 1 NULL,
  PRIMARY KEY CLUSTERED (OBJECT_ID),
  UNIQUE (OBJECT_CODE)
)
GO

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
