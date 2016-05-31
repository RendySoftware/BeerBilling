
create table Employee(
id numeric(10, 0) IDENTITY(1, 1) primary key,
employee_id varchar(100)  ,
full_name nvarchar(100)  ,
birthday date ,
email nvarchar(100)  ,
phone nvarchar(30)  ,
created_by nvarchar(100)  ,
created_date datetime ,
updated_by nvarchar(100)  ,
updated_date datetime 
)
go

insert into Employee(employee_id, full_name, phone) values ('BUIHAINGUYEN',N'Bùi Hải Nguyên','0982094383')
GO
insert into Employee(employee_id, full_name, phone) values ('NGUYENVIETTHANH',N'Nguyễn Việt Thanh','0983368824')
GO