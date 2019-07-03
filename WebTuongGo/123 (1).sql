USE [master]
GO
/****** Object:  Database [DBTuongGo2]    Script Date: 6/30/2019 10:43:57 PM ******/
CREATE DATABASE [DBTuongGo2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTuongGo2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBTuongGo2.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBTuongGo2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBTuongGo2_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBTuongGo2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBTuongGo2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBTuongGo2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBTuongGo2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBTuongGo2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBTuongGo2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBTuongGo2] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBTuongGo2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBTuongGo2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBTuongGo2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBTuongGo2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBTuongGo2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBTuongGo2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBTuongGo2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBTuongGo2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBTuongGo2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBTuongGo2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBTuongGo2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBTuongGo2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBTuongGo2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBTuongGo2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBTuongGo2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBTuongGo2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBTuongGo2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBTuongGo2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBTuongGo2] SET  MULTI_USER 
GO
ALTER DATABASE [DBTuongGo2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBTuongGo2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBTuongGo2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBTuongGo2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBTuongGo2] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBTuongGo2]
GO
/****** Object:  UserDefinedFunction [dbo].[CheckDataThiSinh]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[CheckDataThiSinh](@hoTen nvarchar(200),@email varchar(100) , @ngaySinh date , @gioiTinh nvarchar(10), @cmt nchar(12), @dienThoai nchar(10),
@nhuCauID int ,@doiTuongID int, @trinhDoID int)
returns bit
as
begin
	declare @existedNhuCau int = 0;
	declare @existedDoiTuong int = 0;
	declare @existedTrinhDo int = 0;

	if  dbo.VailidDataIsNull(@hoTen) = 0 or dbo.VailidEmail(@email) = 0 or dbo.VailidDataIsNull(@cmt) = 0 or dbo.VailidDataIsNull(@dienThoai) = 0 
	or dbo.VailidNgaySinh(@ngaySinh) = 0 or dbo.VailidGioiTinh(@gioiTinh) = 0
		return 0
	
	select @existedNhuCau=NhuCauID from NhuCau where NhuCauID = @nhuCauID
	select @existedDoiTuong=DoiTuongID from DoiTuong where DoiTuongID = @doiTuongID
	select @existedTrinhDo=TrinhDoID from TrinhDo where TrinhDoID = @trinhDoID
	
	if @existedNhuCau = 0 or @existedDoiTuong = 0 or @existedTrinhDo =0
		return 0
	return 1
end





GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataCanBo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataCanBo](@input1 nvarchar(100),@input2 nvarchar(50),@input3 nvarchar(50),@input4 nvarchar(100))
returns bit
as
begin
	if @input1 like '' or @input2 like '' or @input3 like '' or @input4 like ''
		return 0
	return 1
end





GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataDanhSachDangKy]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[VailidDataDanhSachDangKy](@input1 int,@input2 nvarchar(100))
returns bit
as
begin
	if @input1 < 0 or @input2 is null
		return 0
	return 1
end






GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataDotThi](@input1 nvarchar(100))
returns bit
as
begin
	if @input1 is null 
		return 0
	return 1
end






GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataIsNull]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataIsNull](@input varchar(100))
returns bit
as
begin
	if @input like ''
		return 0
	return 1
end





GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataScore]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataScore](@input int)
returns bit
as
begin
	if @input < 0 or @input > 10
		return 0
	return 1
end





GO
/****** Object:  UserDefinedFunction [dbo].[VailidEmail]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[VailidEmail](@Input varchar(200))
RETURNS bit
AS
BEGIN
  RETURN CASE
    WHEN @Input LIKE '%_@__%.__%' THEN 1
    ELSE 0
  END
END





GO
/****** Object:  UserDefinedFunction [dbo].[VailidGioiTinh]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[VailidGioiTinh](@input nvarchar(10))
returns bit
as
begin
	if @input like N'Nữ' or @input like N'nữ' or @input like N'nam' or @input like N'Nam'
		return 1
	return 0
end





GO
/****** Object:  UserDefinedFunction [dbo].[VailidNgaySinh]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[VailidNgaySinh](@input date)
returns bit
as
begin
	if YEAR(@input) is null
		return 0
	if YEAR(@input) > 1900 and YEAR(@input) < 2019
		return 1
	return 0
end





GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[ChiTietDonHangID] [int] IDENTITY(1,1) NOT NULL,
	[DonHangID] [int] NULL,
	[SanPhamID] [int] NULL,
	[Mota] [nvarchar](250) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[LoaiGo] [nchar](10) NULL,
	[Size] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[ChiTietDonHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[DanhMucID] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[DanhMucID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonHang](
	[DonHangID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgayDat] [datetime] NULL,
	[NgayGiao] [datetime] NULL,
	[TinhTrangGH] [nvarchar](50) NULL,
	[DaThanhToan] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[DonHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiGo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiGo](
	[LoaiGoID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiGo] [nvarchar](250) NULL,
	[Mota] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiGo] PRIMARY KEY CLUSTERED 
(
	[LoaiGoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[NhaSanXuatID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaSX] [nvarchar](250) NULL,
	[Mota] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[NhaSanXuatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[SanPhamID] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](250) NULL,
	[GiaSP] [int] NULL,
	[DanhMucID] [int] NULL,
	[LoaiGoID] [int] NULL,
	[MaSanPham] [nvarchar](50) NULL,
	[TinhTrang] [int] NULL,
	[Mota] [nvarchar](max) NULL,
	[NhaSanXuatID] [int] NULL,
	[AnhSanPham] [nvarchar](50) NULL,
	[SizeID] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[SanPhamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Size]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[SizeID] [int] IDENTITY(1,1) NOT NULL,
	[TenSize] [nvarchar](50) NULL,
	[KichThuoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[SizeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserAccout]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccout](
	[UserAccoutID] [int] IDENTITY(1,1) NOT NULL,
	[NameID] [nvarchar](50) NULL,
	[Pass] [nvarchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserAccout] PRIMARY KEY CLUSTERED 
(
	[UserAccoutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] ON 

INSERT [dbo].[ChiTietDonHang] ([ChiTietDonHangID], [DonHangID], [SanPhamID], [Mota], [SoLuong], [DonGia], [LoaiGo], [Size]) VALUES (2, 3, 2, N'Gỗ Sưa loại tốt bạn nên dùng', 3, 2000, N'Gỗ Trường ', N'To')
INSERT [dbo].[ChiTietDonHang] ([ChiTietDonHangID], [DonHangID], [SanPhamID], [Mota], [SoLuong], [DonGia], [LoaiGo], [Size]) VALUES (3, 3, 5, N'Gỗ Sưa loại tốt bạn nên dùng', 1, 2000, N'Gỗ Hiếu   ', N'Nhỏ')
INSERT [dbo].[ChiTietDonHang] ([ChiTietDonHangID], [DonHangID], [SanPhamID], [Mota], [SoLuong], [DonGia], [LoaiGo], [Size]) VALUES (4, 5, 2, N'Gỗ Sưa loại tốt bạn nên dùng', 3, 2000, N'Gỗ Bách   ', N'Vừa')
INSERT [dbo].[ChiTietDonHang] ([ChiTietDonHangID], [DonHangID], [SanPhamID], [Mota], [SoLuong], [DonGia], [LoaiGo], [Size]) VALUES (5, 4, 5, N'Gỗ Sưa loại tốt bạn nên dùng', 5, 2000, N'Gỗ Hiếu   ', N'To')
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] OFF
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([DanhMucID], [TenDanhMuc], [MoTa]) VALUES (1, N'Tượng phật', N'Tượng phật các loại')
INSERT [dbo].[DanhMuc] ([DanhMucID], [TenDanhMuc], [MoTa]) VALUES (2, N'Tượng Thần Tài', N'Tượng phật các loại')
INSERT [dbo].[DanhMuc] ([DanhMucID], [TenDanhMuc], [MoTa]) VALUES (3, N'Tượng Phúc Lộc Thọ', N'Tượng phật các loại')
INSERT [dbo].[DanhMuc] ([DanhMucID], [TenDanhMuc], [MoTa]) VALUES (4, N'Tượng Khác', N'Tượng phật các loại')
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([DonHangID], [TenKH], [Email], [SDT], [DiaChi], [NgayDat], [NgayGiao], [TinhTrangGH], [DaThanhToan], [GhiChu]) VALUES (3, N'Hiếu', N'Hieu@gmail.com', N'984099645 ', N'Xuân Đỉnh', CAST(N'2019-10-10 00:00:00.000' AS DateTime), CAST(N'2019-10-06 00:00:00.000' AS DateTime), N'Đang xử lý', N'Chưa thanh toán', N'Giao Nhanh')
INSERT [dbo].[DonHang] ([DonHangID], [TenKH], [Email], [SDT], [DiaChi], [NgayDat], [NgayGiao], [TinhTrangGH], [DaThanhToan], [GhiChu]) VALUES (4, N'Trường', N'Truong@gmail.com', N'984099685 ', N'Cầu Giấy', CAST(N'2019-10-10 00:00:00.000' AS DateTime), CAST(N'2019-07-04 12:03:17.947' AS DateTime), N'Đang xử lý', N'Chưa thanh toán', N'Giao Nhanh')
INSERT [dbo].[DonHang] ([DonHangID], [TenKH], [Email], [SDT], [DiaChi], [NgayDat], [NgayGiao], [TinhTrangGH], [DaThanhToan], [GhiChu]) VALUES (5, N'hoàngxi', N'abcd@gmail.com', N'0352525252', N'Cổ Nhuế', CAST(N'2019-06-30 12:03:17.947' AS DateTime), CAST(N'2019-07-04 12:03:17.947' AS DateTime), N'Đang xử lý', N'Chưa thanh toán', N'Giao Nhanh')
INSERT [dbo].[DonHang] ([DonHangID], [TenKH], [Email], [SDT], [DiaChi], [NgayDat], [NgayGiao], [TinhTrangGH], [DaThanhToan], [GhiChu]) VALUES (6, N'Nam', N'Nam@gmail.com', N'984099885 ', N'Mỹ Đình', CAST(N'1998-10-10 00:00:00.000' AS DateTime), CAST(N'1998-10-10 00:00:00.000' AS DateTime), N'Đang xử lý', N'Chưa thanh toán', N'Giao Nhanh')
SET IDENTITY_INSERT [dbo].[DonHang] OFF
SET IDENTITY_INSERT [dbo].[LoaiGo] ON 

INSERT [dbo].[LoaiGo] ([LoaiGoID], [TenLoaiGo], [Mota]) VALUES (1, N'Gỗ Hương', N'Gỗ Hương loại tốt')
INSERT [dbo].[LoaiGo] ([LoaiGoID], [TenLoaiGo], [Mota]) VALUES (2, N'Gỗ Mun', N'Gỗ Mun loại tốt')
INSERT [dbo].[LoaiGo] ([LoaiGoID], [TenLoaiGo], [Mota]) VALUES (3, N'Gỗ Trắc', N'Gỗ Trắc loại tốt')
INSERT [dbo].[LoaiGo] ([LoaiGoID], [TenLoaiGo], [Mota]) VALUES (4, N'Gỗ Ngọc Am', N'Gỗ Ngọc Am loại tốt')
INSERT [dbo].[LoaiGo] ([LoaiGoID], [TenLoaiGo], [Mota]) VALUES (5, N'Gỗ Hoàng Đàn', N'Gỗ Hoàng Đàn loại tốt')
INSERT [dbo].[LoaiGo] ([LoaiGoID], [TenLoaiGo], [Mota]) VALUES (6, N'Gỗ Sưa ', N'Gỗ Sưa loại tốt')
SET IDENTITY_INSERT [dbo].[LoaiGo] OFF
SET IDENTITY_INSERT [dbo].[NhaSanXuat] ON 

INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (1, N'Gỗ Bách', N'Gỗ Bách gỗ tốt của mọi nhà', N'Đông Anh')
INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (2, N'Gỗ Trường', N'Gỗ Trường gỗ tốt của mọi nhà', N'Trần Cung')
INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (3, N'Gỗ Hoàng', N'Gỗ Hoàng gỗ tốt của mọi nhà', N'Phố Cổ')
INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (4, N'Gỗ Hiếu', N'Gỗ Hiếu gỗ tốt của mọi nhà', N'Cầu Giấy')
INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (5, N'Gỗ Long', N'Gỗ Long gỗ tốt của mọi nhà', N'Phú Thọ')
INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (6, N'Gỗ Mạnh', N'Gỗ Mạnh gỗ tốt của mọi nhà', N'Hòa Bình')
INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (7, N'Gỗ Đức', N'Gỗ Đức gỗ tốt của mọi nhà', N'Mỹ Tho')
INSERT [dbo].[NhaSanXuat] ([NhaSanXuatID], [TenNhaSX], [Mota], [DiaChi]) VALUES (8, N'Gỗ My 1231231', N'Gỗ My gỗ tốt của mọi nhà 123', N'Mỹ Đình')
SET IDENTITY_INSERT [dbo].[NhaSanXuat] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (1, N'Tượng Phật Như Lai 1', 1000, 1, 1, N'SP_TDL', 1, N'Tượng phong thủy', 1, N'NhuLai1.jpg', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (2, N'Tượng Phật Như Lai 2', 2000, 1, 2, N'SP_TDL2', 1, N'Tượng phong thủy. cho công ty', 1, N'NhuLai2.jpg', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (3, N'Tượng Thần Tài 1', 1000, 2, 3, N'SP_TDL4', 1, N'Tượng phong thủy. cho công ty 1212', 1, N'Tai8.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (4, N'Tượng Thần Tài 2', 2000, 2, 4, N'SP_TDL5', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tai1.JPG', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (5, N'Tượng Thần Tài 3', 3000, 2, 5, N'SP_TDL6', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tai2.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (6, N'Tượng Thần Tài 4', 4000, 2, 6, N'SP_TDL7', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tai3.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (7, N'Tượng Thần Tài 5', 5000, 2, 6, N'SP_TDL8', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tai4.JPG', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (8, N'Tượng Thần Tài 6', 6000, 2, 5, N'SP_TDL9', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tai5.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (9, N'Tượng Thần Tài 7', 7000, 2, 4, N'SP_TDL10', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tai6.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (10, N'Tượng Thần Tài 8', 8000, 2, 3, N'SP_TDL11', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tai7.JPG', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (11, N'Tượng Phúc Lộc Thọ 1', 1000, 3, 2, N'SP_TDL12', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhucLocTho1.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (12, N'Tượng Phúc Lộc Thọ 2', 2000, 3, 1, N'SP_TDL13', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhucLocTho2.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (13, N'Tượng Phúc Lộc Thọ 3', 3000, 3, 1, N'SP_TDL14', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhucLocTho3.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (14, N'Tượng Phúc Lộc Thọ 4', 4000, 3, 2, N'SP_TDL15', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhucLocTho4.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (15, N'Tượng Phúc Lộc Thọ 5', 5000, 3, 3, N'SP_TDL16', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhucLocTho5.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (16, N'Tượng Phúc Lộc Thọ 6', 6000, 3, 4, N'SP_TDL17', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhucLocTho6.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (17, N'Tương Triệu Vân 1', 7000, 4, 5, N'SP_TDL18', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'TrieuVan1.JPG', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (18, N'Tương Triệu Vân', 8000, 4, 6, N'SP_TDL19', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'TrieuVan2.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (19, N'Tượng Phật', 1000, 1, 1, N'SP_TDL20', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhatTo1.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (20, N'Tượng Phật Tổ 1', 2000, 1, 2, N'SP_TDL21', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhatTo2.JPG', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (21, N'Tượng Phật Tổ 2', 4000, 1, 3, N'SP_TDL22', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhatTo3.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (22, N'Tượng Phật Tổ 3', 3000, 1, 4, N'SP_TDL23', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'PhatTo1.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (23, N'Đĩa Gỗ 1', 1000, 4, 5, N'SP_TDL24', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'DiaGo1.jpg', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (24, N'Đĩa Gỗ 2', 2000, 4, 6, N'SP_TDL25', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'DiaGo2.jpg', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (25, N'Đĩa Gỗ 3', 3000, 4, 6, N'SP_TDL26', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'DiaGo3.jpg', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (26, N'Đĩa Gỗ 4', 4000, 1, 5, N'SP_TDL27', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'DiaGo4.jpg', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (27, N'Đĩa Gỗ 5', 5000, 4, 4, N'SP_TDL28', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'DiaGo5.jpg', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (28, N'Tượng Cá Đen 1', 1000, 4, 3, N'SP_TDL29', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'CaDen1.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (29, N'Tượng Cá Đen 2', 2000, 4, 2, N'SP_TDL30', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'CaDen2.JPG', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (30, N'Tượng Cá Đen 3', 3000, 4, 1, N'SP_TDL31', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'CaDen3.JPG', 1)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (31, N'Tranh Gỗ 1', 1000, 4, 1, N'SP_TDL32', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tranh1.JPG', 2)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (32, N'Tranh Gỗ 2', 2000, 4, 2, N'SP_TDL33', 1, N'Tượng phong thủy. cho công ty 1211212', 1, N'Tranh2.JPG', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (33, N'abcd', 123, 4, 1, N'SP_TDL34', 1, NULL, 5, N'51327461_413164882761770_4569293961071427584_n.jpg', 3)
INSERT [dbo].[SanPham] ([SanPhamID], [TenSanPham], [GiaSP], [DanhMucID], [LoaiGoID], [MaSanPham], [TinhTrang], [Mota], [NhaSanXuatID], [AnhSanPham], [SizeID]) VALUES (34, N'Tượng Phật Tổ 6', 222, 1, 3, N'SP_TDL35', 1, NULL, 2, N'Null.JPG', 1)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
SET IDENTITY_INSERT [dbo].[Size] ON 

INSERT [dbo].[Size] ([SizeID], [TenSize], [KichThuoc]) VALUES (1, N'To', N'90x90x90')
INSERT [dbo].[Size] ([SizeID], [TenSize], [KichThuoc]) VALUES (2, N'Vừa', N'60x60x60')
INSERT [dbo].[Size] ([SizeID], [TenSize], [KichThuoc]) VALUES (3, N'Nhỏ', N'30x30x30')
SET IDENTITY_INSERT [dbo].[Size] OFF
SET IDENTITY_INSERT [dbo].[UserAccout] ON 

INSERT [dbo].[UserAccout] ([UserAccoutID], [NameID], [Pass], [Quyen]) VALUES (1, N'Hieu                          ', N'123                           ', NULL)
INSERT [dbo].[UserAccout] ([UserAccoutID], [NameID], [Pass], [Quyen]) VALUES (2, N'Hieu2                         ', N'1234                          ', NULL)
INSERT [dbo].[UserAccout] ([UserAccoutID], [NameID], [Pass], [Quyen]) VALUES (3, N'Truong                        ', N'123456                        ', NULL)
INSERT [dbo].[UserAccout] ([UserAccoutID], [NameID], [Pass], [Quyen]) VALUES (5, N'123', N'123123', N'123')
SET IDENTITY_INSERT [dbo].[UserAccout] OFF
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang] FOREIGN KEY([DonHangID])
REFERENCES [dbo].[DonHang] ([DonHangID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_SanPham] FOREIGN KEY([SanPhamID])
REFERENCES [dbo].[SanPham] ([SanPhamID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_SanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DanhMuc1] FOREIGN KEY([DanhMucID])
REFERENCES [dbo].[DanhMuc] ([DanhMucID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DanhMuc1]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiGo] FOREIGN KEY([LoaiGoID])
REFERENCES [dbo].[LoaiGo] ([LoaiGoID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiGo]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaSanXuat] FOREIGN KEY([NhaSanXuatID])
REFERENCES [dbo].[NhaSanXuat] ([NhaSanXuatID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaSanXuat]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_Size] FOREIGN KEY([SizeID])
REFERENCES [dbo].[Size] ([SizeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_Size]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCanBo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Procedure [dbo].[DeleteCanBo](@canBoID int)
as
	DELETE FROM CanBo
	WHERE CanBoID = @canBoID;





GO
/****** Object:  StoredProcedure [dbo].[DeleteCanBoInHoiDongThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteCanBoInHoiDongThi](@canBoID int , @dotThiID int)
as
begin
	Declare @existed int = 0;
	select @existed = NhiemVuID from HoiDongThi
	where CanBoID = @canBoID and DotThiID = @dotThiID

	if @existed > 0 
	DELETE FROM HoiDongThi
	WHERE CanBoID = @canBoID and DotThiID = @dotThiID
end





GO
/****** Object:  StoredProcedure [dbo].[DeleteChungChi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteChungChi](@chungChiID int)
as
begin 
	Declare @existed int = 0;
	select @existed=ChungChiID from ChungChi
	where ChungChiID = @chungChiID

	if @existed > 0
	delete from ChungChi
	where ChungChiID = @chungChiID
end





GO
/****** Object:  StoredProcedure [dbo].[DeleteDoiTuon]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteDoiTuon](@doiTuongID int)
as
	delete from DoiTuong
	where DoiTuongID = @doiTuongID





GO
/****** Object:  StoredProcedure [dbo].[DeleteDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteDotThi](@dotThiID int)
as
begin
	declare @existed int = 0;
	declare @existedDotThiInDanhSachDangKy int = 0;
	declare @existedDotThiInHoiDongThi int = 0;

	-- check
	select @existed = DotThiID from DotThi
	where DotThiID = @dotThiID

	select @existedDotThiInDanhSachDangKy = MaDanhSach from DanhSachDangKy
	where DotThiID = @dotThiID

	select @existedDotThiInHoiDongThi = CanBoID from HoiDongThi
	where DotThiID = @dotThiID

	-- to do
	if @existed > 0 and @existedDotThiInDanhSachDangKy = 0 and @existedDotThiInHoiDongThi = 0
	delete from DotThi
	where DotThiID = @dotThiID
end





GO
/****** Object:  StoredProcedure [dbo].[DeleteKetQuaThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteKetQuaThi](@SBD varchar(10))
as
begin 
	Declare @existed  int = 0;
	select @existed = KetQuaChiTietID from KetQuaChiTiet
	where SBD= @SBD
	
	if @existed > 0
	Delete from KetQuaChiTiet
	where SBD = @SBD
end





GO
/****** Object:  StoredProcedure [dbo].[DeleteNhuCau]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteNhuCau](@nhuCauID int)
as
	delete from NhuCau
	where NhuCauID = @nhuCauID





GO
/****** Object:  StoredProcedure [dbo].[DeleteThiSinh]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteThiSinh](@thiSinhID int)
as 
begin
	Declare @existed int = 0;
	select @existed = ThiSinhID from ThiSinh
	where ThiSinhID = @thiSinhID

	if @existed > 0
	delete from ThiSinh
	where ThiSinhID = @thiSinhID
end





GO
/****** Object:  StoredProcedure [dbo].[DeleteThiSinhInDanhSachThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteThiSinhInDanhSachThi](@SBD varchar(10))
as
	delete from DanhSachThi
	where DanhSachThi.SBD = @SBD





GO
/****** Object:  StoredProcedure [dbo].[DeleteTrinhDo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteTrinhDo](@trinhDoID int)
as
	delete from TrinhDo
	where TrinhDoID = @trinhDoID





GO
/****** Object:  StoredProcedure [dbo].[GetAllCanBo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllCanBo]
as 
	select CanBoID,Hoten,DonVi,CapBac,GhiChu from CanBo





GO
/****** Object:  StoredProcedure [dbo].[GetAllDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllDotThi]
as
	select DotThiID,TenDotThi, Ngay from DotThi





GO
/****** Object:  StoredProcedure [dbo].[GetAllNhiemVu]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAllNhiemVu]
as
	select NhiemVuID, TenNhiemVu from NhiemVu





GO
/****** Object:  StoredProcedure [dbo].[GetCanBoByDotThiID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetCanBoByDotThiID](@maDotThi int)
as
	select HoiDongThi.CanBoID,Hoten,DonVi,CapBac,NhiemVu.TenNhiemVu,GhiChu from HoiDongThi
	inner join NhiemVu on NhiemVu.NhiemVuID = HoiDongThi.NhiemVuID
	inner join CanBo on CanBo.CanBoID = HoiDongThi.CanBoID	
	where HoiDongThi.DotThiID = @maDotThi





GO
/****** Object:  StoredProcedure [dbo].[GetCanBoByID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetCanBoByID]( @MaCB int)
as
	select Hoten,DonVi,CapBac,GhiChu from CanBo
	where CanBo.CanBoID = @MaCB





GO
/****** Object:  StoredProcedure [dbo].[GetChungChiAll]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetChungChiAll]
as
	select Hoten, NgaySinh, CMT, DoiTuong.TenDoiTuong, ChungChi.SoVanBang, ChungChi.SoVaoSo from ThiSinh
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join ChungChi on ChungChi.ThiSinhID = ThiSinh.ThiSinhID





GO
/****** Object:  StoredProcedure [dbo].[GetChungChiByChungChiID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetChungChiByChungChiID](@chungChiID int)
as
	select Hoten, NgaySinh, CMT, DoiTuong.TenDoiTuong, ChungChi.SoVanBang, ChungChi.SoVaoSo from ThiSinh
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join ChungChi on ChungChi.ThiSinhID = ThiSinh.ThiSinhID
	where ChungChiID = @chungChiID






GO
/****** Object:  StoredProcedure [dbo].[GetChungChiByDotThiID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetChungChiByDotThiID](@dotThiID int)
as 
	select ChungChiID,Hoten, NgaySinh, CMT, DoiTuong.TenDoiTuong, ChungChi.SoVanBang, ChungChi.SoVaoSo from ThiSinh
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join ChungChi on ChungChi.ThiSinhID = ThiSinh.ThiSinhID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	where DanhSachDangKy.DotThiID = @dotThiID





GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachThiByDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDanhSachThiByDotThi](@dotThiID int)
as
	select SBD,HoTen,NgaySinh,CMT from DanhSachThi,ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID





GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachThiByThiSinhID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDanhSachThiByThiSinhID](@thiSinhID int)
as
	select SBD,HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi from DanhSachThi,ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	where DanhSachThi.ThiSinhID = @thiSinhID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID





GO
/****** Object:  StoredProcedure [dbo].[GetDoiTuong]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDoiTuong]
as
	select DoiTuongID,TenDoiTuong from DoiTuong





GO
/****** Object:  StoredProcedure [dbo].[GetDotThiByID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDotThiByID](@dotThiID int)
as
begin
	select TenDotThi, Ngay from DotThi
	where DotThiID = @dotThiID
end





GO
/****** Object:  StoredProcedure [dbo].[GetDotThiIDMax]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDotThiIDMax]
as
begin
	select Max(DotThiID) as DotThiIDMax from DotThi
end





GO
/****** Object:  StoredProcedure [dbo].[GetKetQuaThiByDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetKetQuaThiByDotThi](@dotThiID int)
as
	select DanhSachThi.SBD,HoTen,NgaySinh,CMT,DiemTracNghiem,Word,Excel,PPT from ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	inner join KetQuaChiTiet on KetQuaChiTiet.SBD like DanhSachThi.SBD
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID





GO
/****** Object:  StoredProcedure [dbo].[GetKetQuaThiCapChungChiByDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetKetQuaThiCapChungChiByDotThi](@dotThiID int)
as
	select DanhSachThi.SBD,HoTen,NgaySinh,CMT,DiemTracNghiem,(Word+Excel+PPT)/3 as DiemThucHanh from ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	inner join KetQuaChiTiet on KetQuaChiTiet.SBD like DanhSachThi.SBD
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID






GO
/****** Object:  StoredProcedure [dbo].[GetNhuCau]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetNhuCau]
as
	select NhuCauID,TenNhuCau from NhuCau





GO
/****** Object:  StoredProcedure [dbo].[GetOnlyKetQuaThiBySBD]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetOnlyKetQuaThiBySBD](@SBD varchar(10))
as
	select SBD,DiemTracNghiem,Word,Excel,PPT from KetQuaChiTiet
	where  KetQuaChiTiet.SBD = @SBD





GO
/****** Object:  StoredProcedure [dbo].[GetSBDbyChungChiID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetSBDbyChungChiID](@chungChiID int)
as
begin
	select DanhSachThi.SBD  from ChungChi
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ChungChi.ThiSinhID
	where ChungChiID = @chungChiID
end





GO
/****** Object:  StoredProcedure [dbo].[GetSBDCanGetChungChi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetSBDCanGetChungChi]
as
	select DanhSachThi.SBD from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.SBD = KetQuaChiTiet.SBD
	where DiemTracNghiem > 5
	and Word > 5
	and Excel > 5
	and PPT > 5
	and (select ChungChiID from ChungChi where ChungChi.ThiSinhID = DanhSachThi.ThiSinhID) is null





GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhByDotThiID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetThiSinhByDotThiID](@dotThiID int)
as
	select HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi,DotThi.TenDotThi from ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	inner join DotThi on DotThi.DotThiID = DanhSachDangKy.DotThiID
	where DanhSachDangKy.DotThiID = @dotThiID





GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhByDotThiNull]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetThiSinhByDotThiNull]
as
	select ThiSinhID,HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi from ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	where DanhSachDangKy.MaDanhSach = 1





GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhByID]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetThiSinhByID](@thiSinhID int)
as
	select HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi from ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	where ThiSinh.ThiSinhID = @thiSinhID





GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhNotYetKQ]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetThiSinhNotYetKQ](@dotThiID int)
as
begin 
	select DanhSachThi.SBD from ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID and 
	(
		select KetQuaChiTietID from KetQuaChiTiet
		where KetQuaChiTiet.SBD = DanhSachThi.SBD and DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	) is null
end






GO
/****** Object:  StoredProcedure [dbo].[GetTrinhDo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetTrinhDo]
as
	select TrinhDoID,TenTrinhDo from TrinhDo





GO
/****** Object:  StoredProcedure [dbo].[InsertCanBo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertCanBo]( @hoTen nvarchar(200),@donVi nvarchar(50),@capBac nvarchar(50), @ghiChu nvarchar(100))
as
	insert into CanBo(HoTen,DonVi,CapBac,GhiChu)
	values(@hoTen, @donVi,@capBac,@ghiChu)





GO
/****** Object:  StoredProcedure [dbo].[InsertCanBoToHoiDongThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertCanBoToHoiDongThi](@dotThiID int, @canBoID int, @nhiemVuID int)
as
begin
	Declare @existed int = 0;
	--check
	select @existed = @nhiemVuID from HoiDongThi
	where CanBoID = @canBoID and DotThiID = @dotThiID

	if @existed = 0
	insert into HoiDongThi(DotThiID,CanBoID,NhiemVuID)
	values(@dotThiID,@canBoID,@nhiemVuID)
end





GO
/****** Object:  StoredProcedure [dbo].[InsertChungChi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertChungChi](@soVaoSo int,@thiSinhID int)
as
begin
	-- check ket qua thi, 
	-- diem trac nghiem , diem thuc hanh >= 5
	Declare @diemTracNghiem int  = 0;
	Declare @diemThucHanh int = 0;
	select @diemTracNghiem=DiemTracNghiem,@diemThucHanh= (Word+Excel+PPT)/3 from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.ThiSinhID = @thiSinhID
	where KetQuaChiTiet.SBD like DanhSachThi.SBD

	-- check soVaoSo or thiSinhID existed
	Declare @existed int = 0;
	select @existed=ChungChiID from ChungChi
	where SoVaoSo = @soVaoSo or ThiSinhID = @thiSinhID

	if @diemTracNghiem >=5 and @diemThucHanh >=5 and @existed = 0
	insert into ChungChi(SoVanBang, SoVaoSo, ThiSinhID)
	values('MTA_2018',@soVaoSo,@thiSinhID)

end





GO
/****** Object:  StoredProcedure [dbo].[InsertChungChiBySBD]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertChungChiBySBD](@soVaoSo int,@sbd varchar(10))
as
begin
	-- check ket qua thi, 
	-- diem trac nghiem , diem thuc hanh >= 5
	Declare @diemTracNghiem int  = 0;
	Declare @diemThucHanh int = 0;
	select @diemTracNghiem=DiemTracNghiem,@diemThucHanh= (Word+Excel+PPT)/3 from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where KetQuaChiTiet.SBD like DanhSachThi.SBD

	-- check soVaoSo or thiSinhID existed
	Declare @existed int = 0;
	Declare @thiSinhID int = 0;
	select @existed=ChungChiID from ChungChi
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where SoVaoSo = @soVaoSo or ChungChi.ThiSinhID = DanhSachThi.ThiSinhID

	select @thiSinhID = ThiSinhID from DanhSachThi
	where SBD = @sbd

	if @diemTracNghiem >=5 and @diemThucHanh >=5 and @existed = 0
	insert into ChungChi(SoVanBang, SoVaoSo, ThiSinhID)
	values('MTA_2018',@soVaoSo,@thiSinhID)

end





GO
/****** Object:  StoredProcedure [dbo].[InsertDanhSachDangKy]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertDanhSachDangKy](@dotThiID int, @tenDanhSachDK nvarchar(100))
as
begin
	if dbo.VailidDataDanhSachDangKy(@dotThiID,@tenDanhSachDK) = 1
		insert into DanhSachDangKy(DotThiID,TenDanhSach)
		values(@dotThiID,@tenDanhSachDK)
end






GO
/****** Object:  StoredProcedure [dbo].[InsertDoiTuong]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertDoiTuong](@tenDoiTuong nvarchar(100))
as
	insert into DoiTuong(TenDoiTuong)
	values(@tenDoiTuong)





GO
/****** Object:  StoredProcedure [dbo].[InsertDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertDotThi](@tenDotThi nvarchar(100),@ngay date)
as
begin
	if dbo.VailidDataDotThi(@tenDotThi) = 1
		insert into DotThi(TenDotThi,Ngay)
		values(@tenDotThi, @ngay)
end






GO
/****** Object:  StoredProcedure [dbo].[InsertKetQuaThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertKetQuaThi](@SBD varchar(10),@diemTracNghiem int, @word int, @excel int, @ppt int)
as
begin
	Declare @existedSBD int = 0;
	Declare @existed  int = 0;
	Declare @checkCore bit = 1;
	-- check score insert
	if dbo.VailidDataScore(@diemTracNghiem) = 0 or dbo.VailidDataScore(@word) = 0 or dbo.VailidDataScore(@excel) = 0 or dbo.VailidDataScore(@ppt) = 0
		set @checkCore = 0
	
	-- check existed sbd
	select @existedSBD = ThiSinhID from DanhSachThi
	where SBD = @SBD

	select @existed = KetQuaChiTietID from KetQuaChiTiet
	where SBD= @SBD

	if @existedSBD > 0 and @existed = 0 and @checkCore = 1
	insert into KetQuaChiTiet(SBD,DiemTracNghiem,Word,Excel,PPT)
	values(@SBD,@diemTracNghiem,@word,@excel,@ppt)
end





GO
/****** Object:  StoredProcedure [dbo].[InsertNhuCau]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertNhuCau](@tenNhuCau nvarchar(100))
as
	insert into NhuCau(TenNhuCau)
	values(@tenNhuCau)





GO
/****** Object:  StoredProcedure [dbo].[InsertThiSinh]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertThiSinh](@hoTen nvarchar(200),@email varchar(100) , @ngaySinh date , @gioiTinh nvarchar(10), @cmt nchar(12), @dienThoai nchar(10),
@nhuCauID int ,@doiTuongID int, @trinhDoID int, @maDanhSach int)
as
begin
	DECLARE @existed int = 0;
	DECLARE @validData bit = 0;
	-- check data
	select @validData = dbo.CheckDataThiSinh(@hoTen, @email, @ngaySinh, @gioiTinh, @cmt, @dienThoai,@nhuCauID, @doiTuongID, @trinhDoID)

	--- check existed
	select @existed = ThiSinhID from ThiSinh
	where Email = @email or CMT = @cmt or DienThoai = @dienThoai

	if @existed = 0 and @validData = 1
	insert into ThiSinh(HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCauID,DoiTuongID,TrinhDoID,MaDanhSach)
	values(@hoTen,@email,@ngaySinh,@gioiTinh,@cmt,@dienThoai,@nhuCauID,@doiTuongID,@trinhDoID,@maDanhSach)
end






GO
/****** Object:  StoredProcedure [dbo].[InsertThiSinhToDanhSachThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertThiSinhToDanhSachThi](@SBD varchar(10),@thiSinhID int)
as
begin
	Declare @existed int = 0;

	---- check existed
	select @existed = ThiSinhID from DanhSachThi
	where ThiSinhID = @thiSinhID or SBD = @SBD

	if @existed = 0
	insert into DanhSachThi(SBD,ThiSinhID)
	values(@SBD,@thiSinhID)
end





GO
/****** Object:  StoredProcedure [dbo].[InsertThiSinhToDSThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertThiSinhToDSThi](@thiSinhID int, @dotThiID int, @SBD varchar(10))
as 
begin
	Declare @mads int = 0;
	select @mads=MaDanhSach from DanhSachDangKy
	where DanhSachDangKy.DotThiID = @dotThiID

	if @mads > 1 
	begin
		update ThiSinh
		set MaDanhSach = @mads
		where ThiSinhID = @thiSinhID

		insert DanhSachThi(ThiSinhID,SBD)
		values(@thiSinhID,@SBD)
	end

end





GO
/****** Object:  StoredProcedure [dbo].[InsertTrinhDo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertTrinhDo](@tenTrinhDo nvarchar(100))
as
	insert into TrinhDo(TenTrinhDo)
	values(@tenTrinhDo)





GO
/****** Object:  StoredProcedure [dbo].[UpdateCanBo]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateCanBo]( @canBoID int , @hoTen nvarchar(200),@donVi nvarchar(50),@capBac nvarchar(50), @ghiChu nvarchar(100))
as
	update CanBo
	set HoTen=@hoTen,DonVi=@donVi,CapBac=@capBac, GhiChu=@ghiChu
	where CanBoID = @canBoID





GO
/****** Object:  StoredProcedure [dbo].[UpdateCanBoInHoiDongThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateCanBoInHoiDongThi](@dotThiID int, @canBoID int, @nhiemVuID int)
as
begin
	Declare @existed int = 0;
	--check
	select @existed = @nhiemVuID from HoiDongThi
	where CanBoID = @canBoID and DotThiID = @dotThiID

	if @existed > 0
	 update HoiDongThi
	 set NhiemVuID = @nhiemVuID
	 where DotThiID = @dotThiID and CanBoID = @canBoID
end





GO
/****** Object:  StoredProcedure [dbo].[UpdateChungChi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateChungChi](@chungChiID int, @soVaoSo int , @thiSinhID int)
as
begin 
	Declare @existed int = 0;
	select @existed=ChungChiID from ChungChi
	where SoVaoSo = @soVaoSo or ThiSinhID = @thiSinhID

	if @existed > 0
	update ChungChi
	set SoVaoSo = @soVaoSo , ThiSinhID = @thiSinhID
	where ChungChiID = @chungChiID
end





GO
/****** Object:  StoredProcedure [dbo].[UpdateChungChiBySBD]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateChungChiBySBD](@soVaoSo int,@sbd varchar(10))
as
begin
	-- check ket qua thi, 
	-- diem trac nghiem , diem thuc hanh >= 5
	Declare @diemTracNghiem int  = 0;
	Declare @diemThucHanh int = 0;
	Declare @chungchiID int = 0;
	select @diemTracNghiem=DiemTracNghiem,@diemThucHanh= (Word+Excel+PPT)/3 from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where KetQuaChiTiet.SBD like DanhSachThi.SBD

	select @chungchiID=ChungChiID from ChungChi
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where DanhSachThi.ThiSinhID = ChungChi.ThiSinhID

	if @diemTracNghiem >=5 and @diemThucHanh >=5 and @chungchiID > 0
		update ChungChi
		set SoVaoSo = @soVaoSo
		where ChungChi.ChungChiID = @chungchiID
end





GO
/****** Object:  StoredProcedure [dbo].[UpdateDoiTuong]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateDoiTuong](@doiTuongID int , @tenDoiTuong nvarchar(100))
as
	update DoiTuong
	set TenDoiTuong = @tenDoiTuong
	where DoiTuongID = @doiTuongID





GO
/****** Object:  StoredProcedure [dbo].[UpdateDotThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateDotThi](@dotThiID int,@tenDotThi nvarchar(100),@ngay date)
as
begin
	declare @existed int = 0;
	select @existed = DotThiID from DotThi
	where DotThiID = @dotThiID

	if @existed > 0
	update DotThi
	set TenDotThi = @tenDotThi , Ngay = @ngay
	where DotThiID = @dotThiID
end





GO
/****** Object:  StoredProcedure [dbo].[UpdateKetQuaThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateKetQuaThi](@SBD varchar(10),@diemTracNghiem int, @word int, @excel int, @ppt int)
as
begin
	Declare @existed  int = 0;
	select @existed = KetQuaChiTietID from KetQuaChiTiet
	where SBD= @SBD

	Declare @checkCore bit = 1;
	-- check score insert
	if dbo.VailidDataScore(@diemTracNghiem) = 0 or dbo.VailidDataScore(@word) = 0 or dbo.VailidDataScore(@excel) = 0 or dbo.VailidDataScore(@ppt) = 0
		set @checkCore = 0
	
	if @existed > 0 and @checkCore = 1
	update KetQuaChiTiet
	set SBD = @SBD, DiemTracNghiem = @diemTracNghiem, Word = @word, Excel = @excel, PPT = @ppt
	where SBD = @SBD
end





GO
/****** Object:  StoredProcedure [dbo].[UpdateNhuCau]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateNhuCau](@nhuCauID int , @tenNhuCau nvarchar(100))
as
	update NhuCau
	set TenNhuCau = @tenNhuCau
	where NhuCauID = @nhuCauID





GO
/****** Object:  StoredProcedure [dbo].[UpdateSBDForThiSinh]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateSBDForThiSinh](@SBDold varchar(10),@SBDnew varchar(10))
as
begin
	Declare @existed int = 0;

	---- check existed
	select @existed = ThiSinhID from DanhSachThi
	where SBD = @SBDold

	if @existed > 0
	begin
		delete from DanhSachThi
		where SBD=@SBDold

		insert into DanhSachThi(SBD,ThiSinhID)
		values(@SBDnew,@existed)
	end
end





GO
/****** Object:  StoredProcedure [dbo].[UpdateThiSinh]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateThiSinh](@thiSinhID int, @hoTen nvarchar(200),@email varchar(100) , @ngaySinh date , @gioiTinh nvarchar(10), @cmt nchar(12), @dienThoai nchar(10),
@nhuCauID int ,@doiTuongID int, @trinhDoID int, @maDanhSach int)
as
begin 
	Declare @existed int = 0;
	DECLARE @validData bit = 0;
	-- check data
	select @validData = dbo.CheckDataThiSinh(@hoTen, @email, @ngaySinh, @gioiTinh, @cmt, @dienThoai,@nhuCauID, @doiTuongID, @trinhDoID)

	select @existed = ThiSinhID from ThiSinh
	where ThiSinhID = @thiSinhID

	if @existed > 0 and @validData = 1
	update ThiSinh
	set HoTen=@hoTen,Email=@email,NgaySinh=@ngaySinh, GioiTinh=@gioiTinh,CMT=@cmt,DienThoai=@dienThoai, NhuCauID=@nhuCauID, DoiTuongID=@doiTuongID,TrinhDoID=@trinhDoID,MaDanhSach=@maDanhSach
	where ThiSinhID = @thiSinhID
end





GO
/****** Object:  StoredProcedure [dbo].[UpdateThiSinhInDanhSachThi]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateThiSinhInDanhSachThi](@SBD varchar(10),@thiSinhID int)
as
begin
	Declare @existed int = 0;

	---- check existed
	select @existed = ThiSinhID from DanhSachThi
	where ThiSinhID = @thiSinhID or SBD = @SBD

	if @existed > 0
	update DanhSachThi
	set SBD=@SBD
	where ThiSinhID = @thiSinhID
end






GO
/****** Object:  StoredProcedure [dbo].[UpdateTrinhDO]    Script Date: 6/30/2019 10:43:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateTrinhDO](@trinhDoID int , @tenTrinhDo nvarchar(100))
as
	update TrinhDo
	set TenTrinhDo = @tenTrinhDo
	where TrinhDoID = @trinhDoID





GO
USE [master]
GO
ALTER DATABASE [DBTuongGo2] SET  READ_WRITE 
GO
