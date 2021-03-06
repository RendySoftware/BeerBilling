USE bb
GO

--
-- Definition for table Bill :
--

CREATE TABLE dbo.Bill (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  customer_id int NULL,
  table_id int NULL,
  is_printed nvarchar(3) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  payment nvarchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  billing_date date NULL,
  billing_number int NULL,
  cancel_reason text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_date datetime NULL,
  updated_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  updated_date datetime NULL,
  employee_id varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  employee_name nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

--
-- Definition for table BookedTable :
--

CREATE TABLE dbo.BookedTable (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  customer_id int NULL,
  table_id int NULL,
  status nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  process nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  from_date date NULL,
  to_date date NULL,
  created_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_date datetime NULL,
  updated_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  updated_date datetime NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table Category :
--

CREATE TABLE dbo.Category (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  code nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  name nvarchar(400) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table Customer :
--

CREATE TABLE dbo.Customer (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  name nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  birthday date NULL,
  email nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  phone nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_date datetime NULL,
  updated_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  updated_date datetime NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table Employee :
--

CREATE TABLE dbo.Employee (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  employee_id varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  full_name nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  birthday date NULL,
  email nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  phone nvarchar(30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_date datetime NULL,
  updated_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  updated_date datetime NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table Material :
--

CREATE TABLE dbo.Material (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  unit_id int NULL,
  code nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  name nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table Menu :
--

CREATE TABLE dbo.Menu (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  category_id int NULL,
  code nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  name nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  unit_id int NULL,
  price numeric(10, 2) NULL,
  description text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  is_active nvarchar(3) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_date datetime NULL,
  updated_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  updated_date datetime NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

--
-- Definition for table OBJECTS :
--

CREATE TABLE dbo.OBJECTS (
  OBJECT_ID numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  PARENT_ID numeric(10, 0) NULL,
  OBJECT_CODE varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  DESCRIPTION nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  OBJECT_URL varchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  [ORDER] numeric(5, 0) NULL,
  STATUS numeric(1, 0) DEFAULT 1 NULL,
  PRIMARY KEY CLUSTERED (OBJECT_ID)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table ResOrder :
--

CREATE TABLE dbo.ResOrder (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  bill_id bigint NULL,
  menu_id int NULL,
  amount numeric(5, 1) NULL,
  created_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_date datetime NULL,
  updated_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  updated_date datetime NULL,
  discount numeric(5, 2) NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table ResTable :
--

CREATE TABLE dbo.ResTable (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  code nvarchar(10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  position nvarchar(500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table ROLE_OBJECT :
--

CREATE TABLE dbo.ROLE_OBJECT (
  OBJECT_ID numeric(10, 0) NOT NULL,
  ROLE_ID numeric(10, 0) NOT NULL,
  IS_ACTIVE numeric(1, 0) DEFAULT 1 NOT NULL,
  PRIMARY KEY CLUSTERED (OBJECT_ID, ROLE_ID)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table ROLES :
--

CREATE TABLE dbo.ROLES (
  ROLE_ID numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  ROLE_CODE varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
  DESCRIPTION nvarchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  STATUS numeric(1, 0) DEFAULT 1 NOT NULL,
  PRIMARY KEY CLUSTERED (ROLE_ID)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table Store :
--

CREATE TABLE dbo.Store (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  material_id int NULL,
  amount numeric(10, 2) NULL,
  stored_status nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  stored_date date NULL,
  stored_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  reason text COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  created_date datetime NULL,
  updated_by nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  updated_date datetime NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

--
-- Definition for table Unit :
--

CREATE TABLE dbo.Unit (
  id numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  code nvarchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  name nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PRIMARY KEY CLUSTERED (id)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table USER_ROLE :
--

CREATE TABLE dbo.USER_ROLE (
  ROLE_ID numeric(10, 0) NOT NULL,
  USER_ID numeric(10, 0) NOT NULL,
  IS_ACTIVE numeric(1, 0) DEFAULT 1 NOT NULL,
  PRIMARY KEY CLUSTERED (ROLE_ID, USER_ID)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Definition for table users :
--

CREATE TABLE dbo.users (
  USER_ID numeric(10, 0) IDENTITY(1, 1) NOT NULL,
  USER_NAME varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PASSWORD varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  FULL_NAME nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
  PRIMARY KEY CLUSTERED (USER_ID)
    WITH (
      PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF,
      ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
ON [PRIMARY]
GO

--
-- Data for table dbo.Bill  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.Bill ON
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (3, -1, 1, N'', N'YES', N'2016-05-30', 1, N'', N'ADMIN', '20160530 06:24:54', N'ADMIN', '20160530 06:24:54', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (4, -1, 1, N'', N'CANCEL', N'2016-05-31', 1, N'Test', N'ADMIN', '20160531 04:48:33', N'ADMIN', '20160531 04:48:33', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (5, -1, 1, N'YES', N'YES', N'2016-05-31', 2, N'', N'ADMIN', '20160531 08:10:24', N'ADMIN', '20160531 08:10:24', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (6, -1, 2, N'NO', N'NO', N'2016-06-03', 2, N'', N'ADMIN', '20160603 06:14:25', N'ADMIN', '20160603 06:14:25', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (7, -1, 3, N'YES', N'YES', N'2016-05-31', 4, N'', N'ADMIN', '20160531 08:18:11', N'ADMIN', '20160531 08:18:11', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (8, -1, 4, N'NO', N'NO', N'2016-06-03', 4, N'', N'ADMIN', '20160603 06:04:36', N'ADMIN', '20160603 06:04:36', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (9, -1, 6, N'NO', N'NO', N'2016-06-03', 6, N'', N'ADMIN', '20160603 08:39:26', N'ADMIN', '20160603 08:39:26', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (10, -1, 3, N'NO', N'NO', N'2016-06-03', 3, N'', N'ADMIN', '20160603 06:14:13', N'ADMIN', '20160603 06:14:13', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (11, -1, 23, N'NO', N'NO', N'2016-06-04', 1, N'', N'ADMIN', '20160604 05:45:11', N'ADMIN', '20160604 05:45:11', N'1', N'Bùi Hải Nguyên')
GO

INSERT INTO dbo.Bill (id, customer_id, table_id, is_printed, payment, billing_date, billing_number, cancel_reason, created_by, created_date, updated_by, updated_date, employee_id, employee_name)
VALUES
  (12, -1, 5, N'YES', N'NO', N'2016-06-05', 5, N'', N'ADMIN', '20160605 06:47:58', N'ADMIN', '20160605 06:47:58', N'', N'Nguyễn Thế Anh')
GO

SET IDENTITY_INSERT dbo.Bill OFF
GO

--
-- Data for table dbo.Category  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.Category ON
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (1, N'LAU', N'Thế giới lẩu')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (2, N'MONNHAU', N'Các món trâu tươi/Bò/Dê')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (3, N'KHAIVI', N'Khai vị')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (4, N'SALAT', N'Các món sa lát')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (5, N'RAU', N'Rau xanh bốn mùa')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (6, N'TUCHON', N'Món nhậu tự chọn')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (7, N'COM', N'Các món cơm/canh/đồ mặn')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (8, N'UONG', N'Đồ uống')
GO

INSERT INTO dbo.Category (id, code, name)
VALUES
  (9, N'TEST', N'Demo')
GO

SET IDENTITY_INSERT dbo.Category OFF
GO

--
-- Data for table dbo.Employee  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.Employee ON
GO

INSERT INTO dbo.Employee (id, employee_id, full_name, birthday, email, phone, created_by, created_date, updated_by, updated_date)
VALUES
  (1, N'BUIHAINGUYEN', N'Bùi Hải Nguyên', NULL, NULL, N'0982094383', NULL, NULL, NULL, NULL)
GO

INSERT INTO dbo.Employee (id, employee_id, full_name, birthday, email, phone, created_by, created_date, updated_by, updated_date)
VALUES
  (2, N'NGUYENVIETTHANH', N'Nguyễn Việt Thanh', NULL, NULL, N'0983368824', NULL, NULL, NULL, NULL)
GO

SET IDENTITY_INSERT dbo.Employee OFF
GO

--
-- Data for table dbo.Material  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.Material ON
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (1, 4, N'CACHEP', N'Cá chép')
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (2, 4, N'CAQUA', N'Cá quả')
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (3, 4, N'THITBO', N'Thịt bò')
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (4, 4, N'THITTRAU', N'Thịt trâu')
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (5, 4, N'THITGA', N'Thịt gà')
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (6, 4, N'THITVIT', N'Thịt vịt')
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (7, 4, N'ECH', N'Ếch')
GO

INSERT INTO dbo.Material (id, unit_id, code, name)
VALUES
  (8, 7, N'TRUNGGA', N'Trứng gà')
GO

SET IDENTITY_INSERT dbo.Material OFF
GO

--
-- Data for table dbo.Menu  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.Menu ON
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (1, 1, N'1', N'Lẩu cua đồng', 1, 385000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (2, 1, N'1', N'Lẩu riêu cua bắp bò sườn sụn', 1, 300000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (3, 1, N'1', N'Lẩu cá quả', 1, 300000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (4, 1, N'1', N'Lẩu cá chép', 1, 285000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (5, 1, N'1', N'Lẩu ếch măng cay', 1, 250000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (6, 1, N'1', N'Lẩu trâu nhúng mẻ', 1, 300000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (7, 1, N'1', N'Lẩu bò nhúng giấm', 1, 300000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (8, 1, N'1', N'Lẩu gà vị nấm', 1, 300000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (9, 1, N'1', N'Lẩu đuôi bò vang cay', 1, 320000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (10, 2, N'2', N'Tiết trâu luộc', 3, 25000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (11, 2, N'2', N'Cuống tim trâu xào cần tỏi', 2, 115000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (12, 2, N'2', N'Trâu tái cuốn', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (13, 2, N'2', N'Trâu xào củ tỏi', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (14, 2, N'2', N'Trâu xào lá lốt', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.857', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (15, 2, N'2', N'Trâu xào rau muống', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (16, 2, N'2', N'Trâu xào lá nồm', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (17, 2, N'2', N'Bắp trâu trần hành giá', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (18, 2, N'2', N'Bắp trâu ngâm mắm', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (19, 2, N'2', N'Bắp trâu rang muối', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (20, 2, N'2', N'Đuôi trâu luộc chấm tương gừng', 2, 35000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (21, 2, N'2', N'Sách trâu xào dứa khế', 2, 115000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (22, 2, N'2', N'Sách trâu xào hành răm', 2, 115000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (23, 2, N'2', N'Trâ nước lá lốt', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (24, 2, N'2', N'Trâu nướng mắc khén', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (25, 2, N'2', N'Trâu gác bếp than hồng', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (26, 2, N'2', N'Gân trâu sốt vang/Bánh mỳ', 3, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (27, 2, N'2', N'Bò xào cần tỏi', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (28, 2, N'2', N'Bê tái chanh', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (29, 3, N'3', N'Ngô chiên bơ', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (30, 3, N'3', N'Khoai tây chiên', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (31, 3, N'3', N'Khoai lang chiên', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (32, 3, N'3', N'Dưa chuột chẻ', 2, 25000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (33, 4, N'4', N'Nộm sứa biển', 2, 65000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (34, 4, N'4', N'Salat cà dưa', 2, 35000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.860', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (35, 4, N'4', N'Gỏi bò vị quất', 2, 65000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (36, 4, N'4', N'Salat bắp cải trộn', 2, 65000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (37, 5, N'5', N'Ngọn su xào/luộc', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (38, 5, N'5', N'Ngọn bí xào/luộc', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (39, 5, N'5', N'Rau muống xào/luộc', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (40, 5, N'5', N'Rau lang xào tỏi', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (41, 5, N'5', N'Củ quả luộc', 2, 35000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (42, 6, N'6', N'Chả chai', 2, 90000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (43, 6, N'6', N'Bò tươi xé tay', 2, 95000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (44, 6, N'6', N'Ếch đồng rang muối', 2, 135000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (45, 6, N'6', N'Gà ta rang muối', 2, 175000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (46, 6, N'6', N'Vịt cỏ rang muối', 2, 165000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (47, 7, N'7', N'Cơm tám thái', 3, 15000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (48, 7, N'7', N'Cơm rang dưa bò', 3, 60000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (49, 7, N'7', N'Cơm rang thập cẩm', 3, 60000, N'', N'YES', N'', '20160603 08:15:00', N'', '20160603 08:15:00')
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (50, 7, N'7', N'Thịt ba chỉ rang cháy cạnh', 2, 65000, N'', N'YES', N'', '20160603 08:40:13', N'', '20160603 08:40:13')
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (51, 7, N'7', N'Trứng tráng', 2, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (52, 7, N'7', N'Canh ngao chua', 3, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (53, 7, N'7', N'Canh cua mùng tơi', 3, 40000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (54, 7, N'7', N'Đậu rán', 2, 35000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

INSERT INTO dbo.Menu (id, category_id, code, name, unit_id, price, description, is_active, created_by, created_date, updated_by, updated_date)
VALUES
  (55, 7, N'7', N'Đậu tẩm hành', 2, 35000, N'', N'YES', N'SYSTEM', '20160529 05:08:33.863', NULL, NULL)
GO

SET IDENTITY_INSERT dbo.Menu OFF
GO

--
-- Data for table dbo.ResOrder  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.ResOrder ON
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (1, 3, 3, 1, N'ADMIN', '20160530 08:34:29', N'ADMIN', '20160530 08:34:29', NULL)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (2, 3, 12, 1, N'ADMIN', '20160530 08:47:22', N'ADMIN', '20160530 08:47:22', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (3, 3, 6, 1, N'ADMIN', '20160530 08:52:35', N'ADMIN', '20160530 08:52:35', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (4, 4, 2, 1, N'ADMIN', '20160531 04:50:45', N'ADMIN', '20160531 04:50:45', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (6, 5, 2, 1, N'ADMIN', '20160531 08:15:10', N'ADMIN', '20160531 08:15:10', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (7, 6, 15, 1, N'ADMIN', '20160531 08:18:39', N'ADMIN', '20160531 08:18:39', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (8, 5, 20, 2, N'ADMIN', '20160531 23:12:04', N'ADMIN', '20160531 23:12:04', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (9, 7, 4, 1, N'ADMIN', '20160601 00:43:48', N'ADMIN', '20160601 00:43:48', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (10, 7, 16, 1, N'ADMIN', '20160601 00:43:53', N'ADMIN', '20160601 00:43:53', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (11, 11, 3, 1, N'ADMIN', '20160601 04:34:25', N'ADMIN', '20160601 04:34:25', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (12, 11, 7, 1, N'ADMIN', '20160601 05:06:05', N'ADMIN', '20160601 05:06:05', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (13, 8, 2, 1, N'ADMIN', '20160601 07:38:17', N'ADMIN', '20160601 07:38:17', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (14, 8, 4, 2, N'ADMIN', '20160601 07:38:25', N'ADMIN', '20160601 07:38:25', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (15, 8, 11, 3, N'ADMIN', '20160601 07:38:33', N'ADMIN', '20160601 07:38:33', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (16, 8, 26, 3, N'ADMIN', '20160601 07:38:38', N'ADMIN', '20160601 07:38:38', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (19, 12, 4, 1, N'ADMIN', '20160605 06:48:19', N'ADMIN', '20160605 06:48:19', 0)
GO

INSERT INTO dbo.ResOrder (id, bill_id, menu_id, amount, created_by, created_date, updated_by, updated_date, discount)
VALUES
  (20, 12, 5, 1, N'ADMIN', '20160605 07:36:00', N'ADMIN', '20160605 07:36:00', 0.1)
GO

SET IDENTITY_INSERT dbo.ResOrder OFF
GO

--
-- Data for table dbo.ResTable  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.ResTable ON
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (1, N'T001', N'1')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (2, N'T002', N'2')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (3, N'T003', N'3')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (4, N'T004', N'4')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (5, N'T005', N'5')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (6, N'T006', N'6')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (7, N'T007', N'7')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (8, N'T008', N'8')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (9, N'T009', N'9')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (10, N'T010', N'10')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (11, N'T011', N'11')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (12, N'T012', N'12')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (13, N'T013', N'13')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (14, N'T014', N'14')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (15, N'T015', N'15')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (16, N'T016', N'16')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (17, N'T017', N'17')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (18, N'T018', N'18')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (19, N'T019', N'19')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (20, N'T020', N'20')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (21, N'T021', N'21')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (22, N'T022', N'22')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (23, N'T023', N'23')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (24, N'T024', N'24')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (25, N'T025', N'25')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (26, N'T026', N'26')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (27, N'T027', N'27')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (28, N'T028', N'28')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (29, N'T029', N'29')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (30, N'T030', N'30')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (31, N'T031', N'31')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (32, N'T032', N'32')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (33, N'T033', N'33')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (34, N'T034', N'34')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (35, N'T035', N'35')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (36, N'T036', N'36')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (37, N'T037', N'37')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (38, N'T038', N'38')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (39, N'T039', N'39')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (40, N'T040', N'40')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (41, N'T041', N'41')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (42, N'T042', N'42')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (43, N'T043', N'43')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (44, N'T044', N'44')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (45, N'T045', N'45')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (46, N'T046', N'46')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (47, N'T047', N'47')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (48, N'T048', N'48')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (49, N'T049', N'49')
GO

INSERT INTO dbo.ResTable (id, code, position)
VALUES
  (50, N'T050', N'50')
GO

SET IDENTITY_INSERT dbo.ResTable OFF
GO

--
-- Data for table dbo.ROLES  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.ROLES ON
GO

INSERT INTO dbo.ROLES (ROLE_ID, ROLE_CODE, DESCRIPTION, STATUS)
VALUES
  (1, N'ADMIN', N'Quản trị hệ thống', 1)
GO

INSERT INTO dbo.ROLES (ROLE_ID, ROLE_CODE, DESCRIPTION, STATUS)
VALUES
  (2, N'QLKH', N'Quản lý kho', 1)
GO

INSERT INTO dbo.ROLES (ROLE_ID, ROLE_CODE, DESCRIPTION, STATUS)
VALUES
  (3, N'QLHD', N'Quản lý hóa đơn', 1)
GO

SET IDENTITY_INSERT dbo.ROLES OFF
GO

--
-- Data for table dbo.Store  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.Store ON
GO

INSERT INTO dbo.Store (id, material_id, amount, stored_status, stored_date, stored_by, reason, created_by, created_date, updated_by, updated_date)
VALUES
  (1, 3, 2, N'EXPORT', N'2016-06-04', N'SYSTEM', N'Nhap moi', N'SYSTEM', '20160604 05:11:07', N'SYSTEM', '20160604 05:11:07')
GO

INSERT INTO dbo.Store (id, material_id, amount, stored_status, stored_date, stored_by, reason, created_by, created_date, updated_by, updated_date)
VALUES
  (2, 3, 2, N'IMPORT', N'2016-06-04', N'SYSTEM', N'Nhap moi', N'SYSTEM', '20160604 05:11:34', N'SYSTEM', '20160604 05:11:34')
GO

INSERT INTO dbo.Store (id, material_id, amount, stored_status, stored_date, stored_by, reason, created_by, created_date, updated_by, updated_date)
VALUES
  (3, 5, 2, N'IMPORT', N'2016-06-04', N'SYSTEM', N'Nhap moi', N'SYSTEM', '20160604 05:11:34', N'SYSTEM', '20160604 05:11:34')
GO

INSERT INTO dbo.Store (id, material_id, amount, stored_status, stored_date, stored_by, reason, created_by, created_date, updated_by, updated_date)
VALUES
  (4, 3, 5, N'IMPORT', N'2016-06-05', N'SYSTEM', N'', N'SYSTEM', '20160605 07:09:42', N'SYSTEM', '20160605 07:09:42')
GO

INSERT INTO dbo.Store (id, material_id, amount, stored_status, stored_date, stored_by, reason, created_by, created_date, updated_by, updated_date)
VALUES
  (5, 5, 5, N'IMPORT', N'2016-06-05', N'SYSTEM', N'', N'SYSTEM', '20160605 07:13:51', N'SYSTEM', '20160605 07:13:51')
GO

SET IDENTITY_INSERT dbo.Store OFF
GO

--
-- Data for table dbo.Unit  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.Unit ON
GO

INSERT INTO dbo.Unit (id, code, name)
VALUES
  (1, N'NOI', N'Nồi')
GO

INSERT INTO dbo.Unit (id, code, name)
VALUES
  (2, N'DIA', N'Đĩa')
GO

INSERT INTO dbo.Unit (id, code, name)
VALUES
  (3, N'BAT', N'Bát')
GO

INSERT INTO dbo.Unit (id, code, name)
VALUES
  (4, N'KG', N'Kg')
GO

INSERT INTO dbo.Unit (id, code, name)
VALUES
  (5, N'CHAI', N'Chai')
GO

INSERT INTO dbo.Unit (id, code, name)
VALUES
  (6, N'COC', N'Cốc')
GO

INSERT INTO dbo.Unit (id, code, name)
VALUES
  (7, N'QUA', N'Quả')
GO

SET IDENTITY_INSERT dbo.Unit OFF
GO

--
-- Data for table dbo.USER_ROLE  (LIMIT 0,500)
--

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (1, 1, 1)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (1, 2, 1)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (1, 3, 0)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (2, 1, 1)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (2, 2, 1)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (2, 3, 0)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (3, 1, 1)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (3, 2, 1)
GO

INSERT INTO dbo.USER_ROLE (ROLE_ID, USER_ID, IS_ACTIVE)
VALUES
  (3, 3, 1)
GO

--
-- Data for table dbo.users  (LIMIT 0,500)
--

SET IDENTITY_INSERT dbo.users ON
GO

INSERT INTO dbo.users (USER_ID, USER_NAME, PASSWORD, FULL_NAME)
VALUES
  (1, N'ADMIN', N'e10adc3949ba59abbe56e057f20f883e', N'Quản trị hệ thống')
GO

INSERT INTO dbo.users (USER_ID, USER_NAME, PASSWORD, FULL_NAME)
VALUES
  (2, N'USER', N'e10adc3949ba59abbe56e057f20f883e', N'Người dùng nhập liệu')
GO

INSERT INTO dbo.users (USER_ID, USER_NAME, PASSWORD, FULL_NAME)
VALUES
  (3, N'NGUYENBH', N'E10ADC3949BA59ABBE56E057F20F883E', N'Bùi Hải Nguyên')
GO

SET IDENTITY_INSERT dbo.users OFF
GO

--
-- Definition for indices :
--

ALTER TABLE dbo.OBJECTS
ADD UNIQUE NONCLUSTERED (OBJECT_CODE)
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

ALTER TABLE dbo.ROLES
ADD UNIQUE NONCLUSTERED (ROLE_CODE)
WITH (
  PAD_INDEX = OFF,
  IGNORE_DUP_KEY = OFF,
  STATISTICS_NORECOMPUTE = OFF,
  ALLOW_ROW_LOCKS = ON,
  ALLOW_PAGE_LOCKS = ON)
ON [PRIMARY]
GO

