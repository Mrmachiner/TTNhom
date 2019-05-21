USE [master]
GO
/****** Object:  Database [QLPCNhanVien]    Script Date: 5/21/2019 1:24:08 PM ******/
CREATE DATABASE [QLPCNhanVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLPCNhanVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.HOANGLE\MSSQL\DATA\QLPCNhanVien.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLPCNhanVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.HOANGLE\MSSQL\DATA\QLPCNhanVien_log.ldf' , SIZE = 2112KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLPCNhanVien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLPCNhanVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLPCNhanVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLPCNhanVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLPCNhanVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLPCNhanVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLPCNhanVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLPCNhanVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLPCNhanVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLPCNhanVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLPCNhanVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLPCNhanVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLPCNhanVien] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLPCNhanVien]
GO
/****** Object:  Table [dbo].[CanBo]    Script Date: 5/21/2019 1:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBo](
	[CanBoID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DonViID] [int] NULL,
	[MaCanBo] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangCanBo] PRIMARY KEY CLUSTERED 
(
	[CanBoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CaTruc]    Script Date: 5/21/2019 1:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CaTruc](
	[CaTrucID] [int] IDENTITY(1,1) NOT NULL,
	[YeuCauID] [int] NULL,
	[TenCa] [varchar](15) NULL,
	[BatDau] [datetime] NULL,
	[KetThuc] [datetime] NULL,
	[NguoiCan] [int] NULL,
 CONSTRAINT [PK_CaTruc] PRIMARY KEY CLUSTERED 
(
	[CaTrucID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 5/21/2019 1:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonVi](
	[DonViID] [int] IDENTITY(1,1) NOT NULL,
	[TenDonVi] [nvarchar](200) NULL,
 CONSTRAINT [PK_DonVi] PRIMARY KEY CLUSTERED 
(
	[DonViID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DotCongViec]    Script Date: 5/21/2019 1:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DotCongViec](
	[DotCongViecID] [int] IDENTITY(1,1) NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[LuongNguoiCan] [int] NULL,
 CONSTRAINT [PK_DotCongViec] PRIMARY KEY CLUSTERED 
(
	[DotCongViecID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 5/21/2019 1:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[CaTrucID] [int] NULL,
	[CanBoID] [int] NULL,
	[GhiChu] [nchar](50) NULL,
	[PhanCongID] [int] IDENTITY(1,1) NOT NULL,
	[YeuCauID] [int] NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY CLUSTERED 
(
	[PhanCongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 5/21/2019 1:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[IDAdmin] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
 CONSTRAINT [PK_BangAdmin] PRIMARY KEY CLUSTERED 
(
	[IDAdmin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[YeuCau]    Script Date: 5/21/2019 1:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCau](
	[YeuCauID] [int] IDENTITY(1,1) NOT NULL,
	[NgayTruc] [datetimeoffset](7) NULL,
	[IDAdmin] [int] NULL,
	[DotCongViecID] [int] NULL,
	[GioHan] [int] NULL,
	[MucGioiHan] [int] NULL,
 CONSTRAINT [PK_BangYeuCau] PRIMARY KEY CLUSTERED 
(
	[YeuCauID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CanBo] ON 

INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (1, N'Cấn Văn Khang       ', CAST(N'1963-04-23 00:00:00.000' AS DateTime), N'TP', 1, N'CB01')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (2, N'Chu Hải Yến            ', CAST(N'1990-12-07 00:00:00.000' AS DateTime), N'PP', 1, N'CB02')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (3, N'Chu Văn Khải                                      ', CAST(N'1986-05-09 00:00:00.000' AS DateTime), N'NV', 1, N'CB03')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (4, N'Đào Xuân Hội                                      ', CAST(N'1974-04-05 00:00:00.000' AS DateTime), N'NV', 1, N'CB04')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (5, N'Đỗ Văn Tấn                                        ', CAST(N'1981-03-23 00:00:00.000' AS DateTime), N'NV', 1, N'CB05')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (6, N'Đoàn Mạnh Phát                                    ', CAST(N'1974-06-23 00:00:00.000' AS DateTime), N'TP', 2, N'CB06')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (7, N'Hà Thị Mai                                        ', CAST(N'1977-12-01 00:00:00.000' AS DateTime), N'TT', 2, N'CB07')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (8, N'Hoàng Hải Yến                                     ', CAST(N'1977-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB08')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (9, N'Hợp Thanh Thông                                   ', CAST(N'1975-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB09')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (10, N'Lê Văn Mạnh                                       ', CAST(N'1988-02-01 00:00:00.000' AS DateTime), N'TP', 2, N'CB10')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (11, N'Ngô Tùng Dương                                    ', CAST(N'1983-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB11')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (12, N'Nguyễn Anh Tuấn                                   ', CAST(N'1986-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB12')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (13, N'Nguyễn Duy Khôi                                   ', CAST(N'1982-02-01 00:00:00.000' AS DateTime), N'PP', 3, N'CB13')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (14, N'Nguyễn Hữu Bình                                   ', CAST(N'1963-04-23 00:00:00.000' AS DateTime), N'TT', 1, N'CB14')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (15, N'Nguyễn Nam Thắng                                  ', CAST(N'1981-10-03 00:00:00.000' AS DateTime), N'TT', 3, N'CB15')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (16, N'Nguyễn Thanh Huyền                                ', CAST(N'1975-06-20 00:00:00.000' AS DateTime), N'TP', 2, N'CB16')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (17, N'Nguyễn Thị Tình                                   ', CAST(N'1996-03-02 00:00:00.000' AS DateTime), N'NV', 2, N'CB17')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (18, N'Nguyễn Trường Giang                               ', CAST(N'1994-04-05 00:00:00.000' AS DateTime), N'NV', 1, N'CB18')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (19, N'Nguyễn Tuyết Hạnh                                 ', CAST(N'1993-02-01 00:00:00.000' AS DateTime), N'PP', 2, N'CB19')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (20, N'Phạm Linh Chi                                     ', CAST(N'1993-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB20')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (21, N'Phạm Minh Tú                                      ', CAST(N'1985-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB21')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (22, N'Phạm Thị Lụa                                      ', CAST(N'1979-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB22')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (23, N'Phạm Văn Linh                                     ', CAST(N'1992-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB23')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (24, N'Tạ Tường Vi                                       ', CAST(N'1988-02-01 00:00:00.000' AS DateTime), N'NV', 1, N'CB24')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (25, N'Trần Bảo Ngọc                                     ', CAST(N'1989-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB25')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (26, N'Trần Trung Kiên                                   ', CAST(N'1976-02-01 00:00:00.000' AS DateTime), N'TT', 3, N'CB26')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (27, N'Vũ Thanh Lan                                      ', CAST(N'1969-02-01 00:00:00.000' AS DateTime), N'NV', 1, N'CB27')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (29, N'HOANG', CAST(N'1998-12-30 00:00:00.000' AS DateTime), N'ac', 1, NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (1030, N'Hoang hoanggg', CAST(N'1998-12-30 00:00:00.000' AS DateTime), N'acdb', 1, NULL)
SET IDENTITY_INSERT [dbo].[CanBo] OFF
SET IDENTITY_INSERT [dbo].[CaTruc] ON 

INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1, 1, N'Ca 1', CAST(N'2018-10-10 07:00:00.000' AS DateTime), CAST(N'2018-10-10 09:30:00.000' AS DateTime), 5)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2, 1, N'Ca 2', CAST(N'2018-10-10 09:30:00.000' AS DateTime), CAST(N'2018-10-10 11:30:00.000' AS DateTime), 2)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (3, 1, N'Ca 5', CAST(N'2018-10-10 15:30:00.000' AS DateTime), CAST(N'2018-10-10 15:30:00.000' AS DateTime), 7)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (4, 2, N'Ca 1 ', CAST(N'2018-10-11 07:00:00.000' AS DateTime), CAST(N'2018-10-11 09:30:00.000' AS DateTime), 8)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (5, 2, N'Ca 3 ', CAST(N'2018-10-11 11:30:00.000' AS DateTime), CAST(N'2018-10-11 15:30:00.000' AS DateTime), 6)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (6, 2, N'Ca 4', CAST(N'2018-10-11 15:30:00.000' AS DateTime), CAST(N'2018-10-11 17:30:00.000' AS DateTime), 5)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1020, 3, N'Ca 1', CAST(N'2018-10-12 07:00:00.000' AS DateTime), CAST(N'2018-10-12 09:30:00.000' AS DateTime), 5)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1021, 3, N'Ca 2', CAST(N'2018-10-12 09:30:00.000' AS DateTime), CAST(N'2018-10-12 11:30:00.000' AS DateTime), 2)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1023, 3, N'Ca 4', CAST(N'2018-10-12 15:30:00.000' AS DateTime), CAST(N'2018-10-12 18:30:00.000' AS DateTime), 7)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1024, 4, N'Ca 1', CAST(N'2018-10-13 07:00:00.000' AS DateTime), CAST(N'2018-10-13 09:30:00.000' AS DateTime), 3)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1025, 4, N'Ca 2', CAST(N'2018-10-13 09:30:00.000' AS DateTime), CAST(N'2018-10-13 11:30:00.000' AS DateTime), 5)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1026, 5, N'Ca 2', CAST(N'2018-10-14 09:30:00.000' AS DateTime), CAST(N'2018-10-14 11:30:00.000' AS DateTime), 3)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (1027, 5, N'Ca 4', CAST(N'2018-10-14 15:30:00.000' AS DateTime), CAST(N'2018-10-14 18:30:00.000' AS DateTime), 6)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2024, 6, N'Ca 4', CAST(N'2018-10-15 15:30:00.000' AS DateTime), CAST(N'2018-10-15 18:30:00.000' AS DateTime), 5)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2027, 10, N'Ca 1', CAST(N'2018-10-19 07:00:00.000' AS DateTime), CAST(N'2018-10-19 09:30:00.000' AS DateTime), 6)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2033, 1022, N'Ca 3', CAST(N'2018-11-06 11:30:00.000' AS DateTime), CAST(N'2018-11-06 15:30:00.000' AS DateTime), 5)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2039, 6, N'Ca 1', CAST(N'2018-10-15 07:00:00.000' AS DateTime), CAST(N'2018-10-15 09:30:00.000' AS DateTime), 8)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2040, 6, N'Ca 3', CAST(N'2018-10-15 11:30:00.000' AS DateTime), CAST(N'2018-10-15 15:30:00.000' AS DateTime), 8)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2041, 8, N'Ca 1', CAST(N'2018-10-17 07:00:00.000' AS DateTime), CAST(N'2018-10-17 09:30:00.000' AS DateTime), 7)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2042, 8, N'Ca 3', CAST(N'2018-10-17 11:30:00.000' AS DateTime), CAST(N'2018-10-17 15:30:00.000' AS DateTime), 2)
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc], [NguoiCan]) VALUES (2057, 1032, N'Ca 1', CAST(N'2018-11-16 07:00:00.000' AS DateTime), CAST(N'2018-11-16 09:30:00.000' AS DateTime), 6)
SET IDENTITY_INSERT [dbo].[CaTruc] OFF
SET IDENTITY_INSERT [dbo].[DonVi] ON 

INSERT [dbo].[DonVi] ([DonViID], [TenDonVi]) VALUES (1, N'Hàn nguội')
INSERT [dbo].[DonVi] ([DonViID], [TenDonVi]) VALUES (2, N'Hàn nhiệt')
INSERT [dbo].[DonVi] ([DonViID], [TenDonVi]) VALUES (3, N'Hàn công nghệ cao')
SET IDENTITY_INSERT [dbo].[DonVi] OFF
SET IDENTITY_INSERT [dbo].[DotCongViec] ON 

INSERT [dbo].[DotCongViec] ([DotCongViecID], [NgayBatDau], [NgayKetThuc], [LuongNguoiCan]) VALUES (1, CAST(N'2018-10-10' AS Date), CAST(N'2018-10-20' AS Date), 100)
INSERT [dbo].[DotCongViec] ([DotCongViecID], [NgayBatDau], [NgayKetThuc], [LuongNguoiCan]) VALUES (2, CAST(N'2018-10-21' AS Date), CAST(N'2018-10-28' AS Date), 50)
INSERT [dbo].[DotCongViec] ([DotCongViecID], [NgayBatDau], [NgayKetThuc], [LuongNguoiCan]) VALUES (3, CAST(N'2018-10-29' AS Date), CAST(N'2018-10-31' AS Date), 9)
INSERT [dbo].[DotCongViec] ([DotCongViecID], [NgayBatDau], [NgayKetThuc], [LuongNguoiCan]) VALUES (1003, CAST(N'2018-11-06' AS Date), CAST(N'2018-11-16' AS Date), 100)
SET IDENTITY_INSERT [dbo].[DotCongViec] OFF
SET IDENTITY_INSERT [dbo].[PhanCong] ON 

INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2, 6, NULL, 6, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2, 7, NULL, 7, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (3, 8, NULL, 8, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (3, 9, NULL, 9, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (3, 10, NULL, 10, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (3, 11, NULL, 11, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (3, 12, NULL, 12, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (3, 13, NULL, 13, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (3, 14, NULL, 14, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (5, 23, NULL, 23, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (5, 24, NULL, 24, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (5, 25, NULL, 25, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (5, 26, NULL, 26, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (5, 27, NULL, 27, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (5, 1, NULL, 28, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (6, 2, NULL, 29, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (6, 3, NULL, 30, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (6, 4, NULL, 31, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (6, 5, NULL, 32, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (6, 6, NULL, 33, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (NULL, NULL, NULL, 34, NULL)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1020, 6, NULL, 1065, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1020, 5, NULL, 1066, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1020, 4, NULL, 1067, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1020, 3, NULL, 1068, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1020, 2, NULL, 1069, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1021, 12, NULL, 1070, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1021, 11, NULL, 1071, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1023, 8, NULL, 1072, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1023, 7, NULL, 1073, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1023, 1, NULL, 1074, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1023, 10, NULL, 1075, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1023, 9, NULL, 1076, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1023, 12, NULL, 1077, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1023, 11, NULL, 1078, 3)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1026, 9, NULL, 1079, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1026, 8, NULL, 1080, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1026, 7, NULL, 1081, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1024, 16, NULL, 1089, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1024, 15, NULL, 1090, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1024, 14, NULL, 1091, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1025, 20, NULL, 1092, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1025, 19, NULL, 1093, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1025, 18, NULL, 1094, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1025, 17, NULL, 1095, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1025, 13, NULL, 1096, 4)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2024, 29, NULL, 1103, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2024, 21, NULL, 1104, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2024, 22, NULL, 1105, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2024, 26, NULL, 1106, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2024, 27, NULL, 1107, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 9, NULL, 1152, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 10, NULL, 1153, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 11, NULL, 1154, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 12, NULL, 1155, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 13, NULL, 1156, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 14, NULL, 1157, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 15, NULL, 1158, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (4, 16, NULL, 1159, 2)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2027, 19, NULL, 1160, 10)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2027, 20, NULL, 1161, 10)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2027, 21, NULL, 1162, 10)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2027, 22, NULL, 1163, 10)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2027, 15, NULL, 1164, 10)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2027, 16, NULL, 1165, 10)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 17, NULL, 1196, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 18, NULL, 1197, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 23, NULL, 1198, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 24, NULL, 1199, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 25, NULL, 1200, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 29, NULL, 1201, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 19, NULL, 1202, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2039, 20, NULL, 1203, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 17, NULL, 1204, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 18, NULL, 1205, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 21, NULL, 1206, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 22, NULL, 1207, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 23, NULL, 1208, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 24, NULL, 1209, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 25, NULL, 1210, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2040, 26, NULL, 1211, 6)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2041, 27, NULL, 1212, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2041, 29, NULL, 1213, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2041, 1, NULL, 1214, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2041, 2, NULL, 1215, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2041, 3, NULL, 1216, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2041, 4, NULL, 1217, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2041, 5, NULL, 1218, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1027, 15, NULL, 1219, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1027, 14, NULL, 1220, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1027, 13, NULL, 1221, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1027, 10, NULL, 1222, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1027, 8, NULL, 1223, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1027, 7, NULL, 1224, 5)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2042, 6, NULL, 1225, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2042, 16, NULL, 1226, 8)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1, 23, NULL, 1227, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1, 22, NULL, 1228, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1, 21, NULL, 1229, 1)
GO
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1, 20, NULL, 1230, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (1, 19, NULL, 1231, 1)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2057, 3, NULL, 1309, 1032)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2057, 2, NULL, 1310, 1032)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2057, 1, NULL, 1311, 1032)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2033, 5, NULL, 2309, 1022)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2033, 4, NULL, 2310, 1022)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2033, 3, NULL, 2311, 1022)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (2033, 2, NULL, 2312, 1022)
SET IDENTITY_INSERT [dbo].[PhanCong] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([IDAdmin], [TaiKhoan], [MatKhau], [HoTen], [NgaySinh]) VALUES (1, N'HoangTruong', N'1', N'HoangDuyTruong', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[YeuCau] ON 

INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1, CAST(N'2018-10-10T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (2, CAST(N'2018-10-11T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (3, CAST(N'2018-10-12T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (4, CAST(N'2018-10-13T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (5, CAST(N'2018-10-14T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (6, CAST(N'2018-10-15T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (7, CAST(N'2018-10-16T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (8, CAST(N'2018-10-17T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (9, CAST(N'2018-10-18T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (10, CAST(N'2018-10-19T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 1, 3, 81)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (12, CAST(N'2018-10-21T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 2, 1, 27)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (15, CAST(N'2018-10-24T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 2, 1, 27)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (16, CAST(N'2018-10-25T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 2, 1, 27)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (17, CAST(N'2018-10-26T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 2, 1, 27)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (21, CAST(N'2018-10-30T00:00:00.0000000+07:00' AS DateTimeOffset), 1, 3, 0, 9)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (22, CAST(N'2018-11-02T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, NULL, NULL)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (23, CAST(N'2018-11-03T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, NULL, NULL)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1022, CAST(N'2018-11-06T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1023, CAST(N'2018-11-07T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1024, CAST(N'2018-11-08T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1025, CAST(N'2018-11-09T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1026, CAST(N'2018-11-10T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1027, CAST(N'2018-11-11T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1028, CAST(N'2018-11-12T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1029, CAST(N'2018-11-13T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1030, CAST(N'2018-11-14T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1031, CAST(N'2018-11-15T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1032, CAST(N'2018-11-16T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 1003, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1033, CAST(N'2018-06-18T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1034, CAST(N'2018-06-19T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1035, CAST(N'2018-06-20T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1036, CAST(N'2018-06-21T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1037, CAST(N'2018-06-22T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1038, CAST(N'2018-06-23T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1039, CAST(N'2018-06-24T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1040, CAST(N'2018-06-25T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1041, CAST(N'2018-06-26T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1042, CAST(N'2018-06-27T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1043, CAST(N'2018-06-28T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1044, CAST(N'2018-06-29T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1045, CAST(N'2018-06-30T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1046, CAST(N'2018-07-01T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1047, CAST(N'2018-07-02T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1048, CAST(N'2018-07-03T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1049, CAST(N'2018-07-04T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1050, CAST(N'2018-07-05T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1051, CAST(N'2018-07-06T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1052, CAST(N'2018-07-07T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1053, CAST(N'2018-07-08T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1054, CAST(N'2018-07-09T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1055, CAST(N'2018-07-10T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1056, CAST(N'2018-07-11T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1057, CAST(N'2018-07-12T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1058, CAST(N'2018-07-13T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1059, CAST(N'2018-07-14T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1060, CAST(N'2018-07-15T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1061, CAST(N'2018-07-16T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1062, CAST(N'2018-07-17T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1063, CAST(N'2018-07-18T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1064, CAST(N'2018-07-19T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1065, CAST(N'2018-07-20T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1066, CAST(N'2018-07-21T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1067, CAST(N'2018-07-22T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1068, CAST(N'2018-07-23T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1069, CAST(N'2018-07-24T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1070, CAST(N'2018-07-25T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1071, CAST(N'2018-07-26T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1072, CAST(N'2018-07-27T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1073, CAST(N'2018-07-28T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1074, CAST(N'2018-07-29T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1075, CAST(N'2018-07-30T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1076, CAST(N'2018-07-31T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1077, CAST(N'2018-08-01T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1078, CAST(N'2018-08-02T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1079, CAST(N'2018-08-03T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1080, CAST(N'2018-08-04T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1081, CAST(N'2018-08-05T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1082, CAST(N'2018-08-06T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1083, CAST(N'2018-08-07T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1084, CAST(N'2018-08-08T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1085, CAST(N'2018-08-09T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1086, CAST(N'2018-08-10T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1087, CAST(N'2018-08-11T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1088, CAST(N'2018-08-12T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1089, CAST(N'2018-08-13T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1090, CAST(N'2018-08-14T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1091, CAST(N'2018-08-15T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1092, CAST(N'2018-08-16T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1093, CAST(N'2018-08-17T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1094, CAST(N'2018-08-18T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1095, CAST(N'2018-08-19T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1096, CAST(N'2018-08-20T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1097, CAST(N'2018-08-21T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1098, CAST(N'2018-08-22T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1099, CAST(N'2018-08-23T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1100, CAST(N'2018-08-24T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1101, CAST(N'2018-08-25T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1102, CAST(N'2018-08-26T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1103, CAST(N'2018-08-27T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
GO
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1104, CAST(N'2018-08-28T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1105, CAST(N'2018-08-29T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1106, CAST(N'2018-08-30T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1107, CAST(N'2018-08-31T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 84)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1108, CAST(N'2018-12-10T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1109, CAST(N'2018-12-11T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1110, CAST(N'2018-12-12T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1111, CAST(N'2018-12-13T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1112, CAST(N'2018-12-14T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1113, CAST(N'2018-12-15T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1114, CAST(N'2018-12-16T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [DotCongViecID], [GioHan], [MucGioiHan]) VALUES (1115, CAST(N'2018-12-17T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, NULL, 3, 87)
SET IDENTITY_INSERT [dbo].[YeuCau] OFF
ALTER TABLE [dbo].[CanBo]  WITH CHECK ADD  CONSTRAINT [FK_CanBo_DonVi] FOREIGN KEY([DonViID])
REFERENCES [dbo].[DonVi] ([DonViID])
GO
ALTER TABLE [dbo].[CanBo] CHECK CONSTRAINT [FK_CanBo_DonVi]
GO
ALTER TABLE [dbo].[CaTruc]  WITH CHECK ADD  CONSTRAINT [FK_CaTruc_YeuCau] FOREIGN KEY([YeuCauID])
REFERENCES [dbo].[YeuCau] ([YeuCauID])
GO
ALTER TABLE [dbo].[CaTruc] CHECK CONSTRAINT [FK_CaTruc_YeuCau]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_BangCanBo] FOREIGN KEY([CanBoID])
REFERENCES [dbo].[CanBo] ([CanBoID])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_BangCanBo]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_CaTruc] FOREIGN KEY([CaTrucID])
REFERENCES [dbo].[CaTruc] ([CaTrucID])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_CaTruc]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_YeuCau1] FOREIGN KEY([YeuCauID])
REFERENCES [dbo].[YeuCau] ([YeuCauID])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_YeuCau1]
GO
ALTER TABLE [dbo].[YeuCau]  WITH CHECK ADD  CONSTRAINT [FK_YeuCau_DotCongViec] FOREIGN KEY([DotCongViecID])
REFERENCES [dbo].[DotCongViec] ([DotCongViecID])
GO
ALTER TABLE [dbo].[YeuCau] CHECK CONSTRAINT [FK_YeuCau_DotCongViec]
GO
ALTER TABLE [dbo].[YeuCau]  WITH CHECK ADD  CONSTRAINT [FK_YeuCau_User] FOREIGN KEY([IDAdmin])
REFERENCES [dbo].[User] ([IDAdmin])
GO
ALTER TABLE [dbo].[YeuCau] CHECK CONSTRAINT [FK_YeuCau_User]
GO
USE [master]
GO
ALTER DATABASE [QLPCNhanVien] SET  READ_WRITE 
GO
