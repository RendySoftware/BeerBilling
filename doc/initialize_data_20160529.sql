-- init roles
truncate table roles
go

set IDENTITY_INSERT roles on
go

insert into roles(role_id, role_code, description) values (1,'ADMIN',N'Quản trị hệ thống')
GO
insert into roles(role_id, role_code, description) values (2,'QLKH',N'Quản lý kho')
GO
insert into roles(role_id, role_code, description) values (3,'QLHD',N'Quản lý hóa đơn')
GO

set IDENTITY_INSERT roles off
go

alter table users add FULL_NAME nvarchar(100) null
GO
insert into users(user_name, full_name, password) values ('ADMIN','Quản trị hệ thống','e10adc3949ba59abbe56e057f20f883e')
GO
insert into users(user_name, full_name, password) values ('USER','Người dùng nhập liệu','e10adc3949ba59abbe56e057f20f883e')
GO

truncate table user_role
go
insert into user_role (user_id, role_id)
select user_id, role_id from users, roles order by user_id, role_id
GO