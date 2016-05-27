use BB
go

-- init Unit
set IDENTITY_INSERT Unit on
go

insert into Unit(id, code, name) values(1, 'NOI', 'Nồi')
insert into Unit(id, code, name) values(2, 'DIA', 'Đĩa')
insert into Unit(id, code, name) values(3, 'BAT', 'Bát')
insert into Unit(id, code, name) values(4, 'KG', 'Kg')
insert into Unit(id, code, name) values(5, 'CHAI', 'Chai')
insert into Unit(id, code, name) values(6, 'COC', 'Cốc')
go

set IDENTITY_INSERT Unit off
go


-- init Category
set IDENTITY_INSERT Category on
go

insert into Category(id, code, name) values(1, 'LAU', 'Thế giới lẩu')
insert into Category(id, code, name) values(2, 'MONNHAU', 'Các món trâu tươi/Bò/Dê')
insert into Category(id, code, name) values(3, 'KHAIVI', 'Khai vị')
insert into Category(id, code, name) values(4, 'SALAT', 'Các món sa lát')
insert into Category(id, code, name) values(5, 'RAU', 'Rau xanh bốn mùa')
insert into Category(id, code, name) values(6, 'TUCHON', 'Món nhậu tự chọn')
insert into Category(id, code, name) values(7, 'COM', 'Các món cơm/canh/đồ mặn')
insert into Category(id, code, name) values(8, 'UONG', 'Đồ uống')
go

set IDENTITY_INSERT Category off
go

-- init menu
set IDENTITY_INSERT menu on
go

insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(1,1,'1','Lẩu cua đồng',1,385000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(2,1,'1','Lẩu riêu cua bắp bò sườn sụn',1,300000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(3,1,'1','Lẩu cá quả',1,300000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(4,1,'1','Lẩu cá chép',1,285000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(5,1,'1','Lẩu ếch măng cay',1,250000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(6,1,'1','Lẩu trâu nhúng mẻ',1,300000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(7,1,'1','Lẩu bò nhúng giấm',1,300000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(8,1,'1','Lẩu gà vị nấm',1,300000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(9,1,'1','Lẩu đuôi bò vang cay',1,320000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(10,2,'2','Tiết trâu luộc',3,25000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(11,2,'2','Cuống tim trâu xào cần tỏi',2,115000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(12,2,'2','Trâu tái cuốn',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(13,2,'2','Trâu xào củ tỏi',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(14,2,'2','Trâu xào lá lốt',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(15,2,'2','Trâu xào rau muống',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(16,2,'2','Trâu xào lá nồm',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(17,2,'2','Bắp trâu trần hành giá',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(18,2,'2','Bắp trâu ngâm mắm',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(19,2,'2','Bắp trâu rang muối',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(20,2,'2','Đuôi trâu luộc chấm tương gừng',2,35000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(21,2,'2','Sách trâu xào dứa khế',2,115000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(22,2,'2','Sách trâu xào hành răm',2,115000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(23,2,'2','Trâ nước lá lốt',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(24,2,'2','Trâu nướng mắc khén',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(25,2,'2','Trâu gác bếp than hồng',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(26,2,'2','Gân trâu sốt vang/Bánh mỳ',3,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(27,2,'2','Bò xào cần tỏi',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(28,2,'2','Bê tái chanh',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(29,3,'3','Ngô chiên bơ',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(30,3,'3','Khoai tây chiên',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(31,3,'3','Khoai lang chiên',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(32,3,'3','Dưa chuột chẻ',2,25000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(33,4,'4','Nộm sứa biển',2,65000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(34,4,'4','Salat cà dưa',2,35000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(35,4,'4','Gỏi bò vị quất',2,65000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(36,4,'4','Salat bắp cải trộn',2,65000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(37,5,'5','Ngọn su xào/luộc',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(38,5,'5','Ngọn bí xào/luộc',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(39,5,'5','Rau muống xào/luộc',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(40,5,'5','Rau lang xào tỏi',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(41,5,'5','Củ quả luộc',2,35000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(42,6,'6','Chả chai',2,90000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(43,6,'6','Bò tươi xé tay',2,95000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(44,6,'6','Ếch đồng rang muối',2,135000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(45,6,'6','Gà ta rang muối',2,175000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(46,6,'6','Vịt cỏ rang muối',2,165000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(47,7,'7','Cơm tám thái',3,15000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(48,7,'7','Cơm rang dưa bò',3,60000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(49,7,'7','Cơm rang thập cẩm',3,60000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(50,7,'7','Thịt ba chỉ rang cháy cạnh',2,65000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(51,7,'7','Trứng tráng',2,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(52,7,'7','Canh ngao chua',3,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(53,7,'7','Canh cua mùng tơi',3,40000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(54,7,'7','Đậu rán',2,35000,'','YES','SYSTEM',SYSDATETIME())
insert into menu(id,category_id,code,name,unit_id,price,description,is_active,created_by,created_date) values(55,7,'7','Đậu tẩm hành',2,35000,'','YES','SYSTEM',SYSDATETIME())
go

set IDENTITY_INSERT menu off
go

 