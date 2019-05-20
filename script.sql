USE [master]
GO
/****** Object:  Database [QLPCNhanVien]    Script Date: 10/16/2018 9:01:08 AM ******/
CREATE DATABASE [QLPCNhanVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLPCNhanVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLPCNhanVien.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLPCNhanVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLPCNhanVien_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[CanBo]    Script Date: 10/16/2018 9:01:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBo](
	[CanBoID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nchar](50) NULL,
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
/****** Object:  Table [dbo].[CaTruc]    Script Date: 10/16/2018 9:01:08 AM ******/
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
 CONSTRAINT [PK_CaTruc] PRIMARY KEY CLUSTERED 
(
	[CaTrucID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 10/16/2018 9:01:08 AM ******/
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
/****** Object:  Table [dbo].[PhanCong]    Script Date: 10/16/2018 9:01:08 AM ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 10/16/2018 9:01:08 AM ******/
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
/****** Object:  Table [dbo].[YeuCau]    Script Date: 10/16/2018 9:01:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCau](
	[YeuCauID] [int] IDENTITY(1,1) NOT NULL,
	[NgayTruc] [datetimeoffset](7) NULL,
	[IDAdmin] [int] NULL,
	[SoLuongNguoi] [int] NULL,
	[SoLuongCa] [int] NULL,
 CONSTRAINT [PK_BangYeuCau] PRIMARY KEY CLUSTERED 
(
	[YeuCauID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CanBo] ON 

INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (28, N'Cấn Văn Khang                                     ', CAST(N'1963-04-23 00:00:00.000' AS DateTime), N'TP', 1, N'CB01')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (29, N'Chu Hải Yến                                       ', CAST(N'1990-12-07 00:00:00.000' AS DateTime), N'PP', 1, N'CB02')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (30, N'Chu Văn Khải                                      ', CAST(N'1986-05-09 00:00:00.000' AS DateTime), N'NV', 1, N'CB03')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (31, N'Đào Xuân Hội                                      ', CAST(N'1974-04-05 00:00:00.000' AS DateTime), N'NV', 1, N'CB04')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (32, N'Đỗ Văn Tấn                                        ', CAST(N'1981-03-23 00:00:00.000' AS DateTime), N'NV', 1, N'CB05')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (33, N'Đoàn Mạnh Phát                                    ', CAST(N'1974-06-23 00:00:00.000' AS DateTime), N'TP', 2, N'CB06')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (34, N'Hà Thị Mai                                        ', CAST(N'1977-12-01 00:00:00.000' AS DateTime), N'TT', 2, N'CB07')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (35, N'Hoàng Hải Yến                                     ', CAST(N'1977-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB08')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (36, N'Hợp Thanh Thông                                   ', CAST(N'1975-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB09')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (37, N'Lê Văn Mạnh                                       ', CAST(N'1988-02-01 00:00:00.000' AS DateTime), N'TP', 2, N'CB10')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (38, N'Ngô Tùng Dương                                    ', CAST(N'1983-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB11')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (39, N'Nguyễn Anh Tuấn                                   ', CAST(N'1986-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB12')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (40, N'Nguyễn Duy Khôi                                   ', CAST(N'1982-02-01 00:00:00.000' AS DateTime), N'PP', 3, N'CB13')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (41, N'Nguyễn Hữu Bình                                   ', CAST(N'1963-04-23 00:00:00.000' AS DateTime), N'TT', 1, N'CB14')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (42, N'Nguyễn Nam Thắng                                  ', CAST(N'1981-10-03 00:00:00.000' AS DateTime), N'TT', 3, N'CB15')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (43, N'Nguyễn Thanh Huyền                                ', CAST(N'1975-06-20 00:00:00.000' AS DateTime), N'TP', 2, N'CB16')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (44, N'Nguyễn Thị Tình                                   ', CAST(N'1996-03-02 00:00:00.000' AS DateTime), N'NV', 2, N'CB17')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (45, N'Nguyễn Trường Giang                               ', CAST(N'1994-04-05 00:00:00.000' AS DateTime), N'NV', 1, N'CB18')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (46, N'Nguyễn Tuyết Hạnh                                 ', CAST(N'1993-02-01 00:00:00.000' AS DateTime), N'PP', 2, N'CB19')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (47, N'Phạm Linh Chi                                     ', CAST(N'1993-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB20')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (48, N'Phạm Minh Tú                                      ', CAST(N'1985-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB21')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (49, N'Phạm Thị Lụa                                      ', CAST(N'1979-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB22')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (50, N'Phạm Văn Linh                                     ', CAST(N'1992-02-01 00:00:00.000' AS DateTime), N'NV', 3, N'CB23')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (51, N'Tạ Tường Vi                                       ', CAST(N'1988-02-01 00:00:00.000' AS DateTime), N'NV', 1, N'CB24')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (52, N'Trần Bảo Ngọc                                     ', CAST(N'1989-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB25')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (53, N'Trần Trung Kiên                                   ', CAST(N'1976-02-01 00:00:00.000' AS DateTime), N'TT', 3, N'CB26')
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [NgaySinh], [ChucVu], [DonViID], [MaCanBo]) VALUES (54, N'Vũ Thanh Lan                                      ', CAST(N'1969-02-01 00:00:00.000' AS DateTime), N'NV', 2, N'CB27')
SET IDENTITY_INSERT [dbo].[CanBo] OFF
SET IDENTITY_INSERT [dbo].[CaTruc] ON 

INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (14, 10, N'Ca 1', CAST(N'2018-06-20 07:00:00.000' AS DateTime), CAST(N'2018-06-20 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (15, 10, N'Ca 2', CAST(N'2018-06-20 09:30:00.000' AS DateTime), CAST(N'2018-06-20 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (16, 10, N'Ca 3', CAST(N'2018-06-20 11:30:00.000' AS DateTime), CAST(N'2018-06-20 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (17, 10, N'Ca 4', CAST(N'2018-06-20 15:30:00.000' AS DateTime), CAST(N'2018-06-20 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (18, 10, N'Ca 5', CAST(N'2018-06-20 18:30:00.000' AS DateTime), CAST(N'2018-06-20 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (19, 11, N'Ca 1', CAST(N'2018-06-21 07:00:00.000' AS DateTime), CAST(N'2018-06-21 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (20, 11, N'Ca 2', CAST(N'2018-06-21 09:30:00.000' AS DateTime), CAST(N'2018-06-21 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (21, 11, N'Ca 3', CAST(N'2018-06-21 11:30:00.000' AS DateTime), CAST(N'2018-06-21 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (22, 11, N'Ca 4', CAST(N'2018-06-21 15:30:00.000' AS DateTime), CAST(N'2018-06-21 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (23, 11, N'Ca 5', CAST(N'2018-06-21 18:30:00.000' AS DateTime), CAST(N'2018-06-21 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (24, 12, N'Ca 1', CAST(N'2018-06-22 07:00:00.000' AS DateTime), CAST(N'2018-06-22 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (25, 12, N'Ca 2', CAST(N'2018-06-22 09:30:00.000' AS DateTime), CAST(N'2018-06-22 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (26, 12, N'Ca 3', CAST(N'2018-06-22 11:30:00.000' AS DateTime), CAST(N'2018-06-22 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (27, 12, N'Ca 4', CAST(N'2018-06-22 15:30:00.000' AS DateTime), CAST(N'2018-06-22 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (28, 12, N'Ca 5', CAST(N'2018-06-22 18:30:00.000' AS DateTime), CAST(N'2018-06-22 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (29, 13, N'Ca 1', CAST(N'2018-06-23 07:00:00.000' AS DateTime), CAST(N'2018-06-23 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (30, 13, N'Ca 2', CAST(N'2018-06-23 09:30:00.000' AS DateTime), CAST(N'2018-06-23 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (31, 13, N'Ca 3', CAST(N'2018-06-23 11:30:00.000' AS DateTime), CAST(N'2018-06-23 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (32, 13, N'Ca 4', CAST(N'2018-06-23 15:30:00.000' AS DateTime), CAST(N'2018-06-23 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (33, 13, N'Ca 5', CAST(N'2018-06-23 18:30:00.000' AS DateTime), CAST(N'2018-06-23 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (34, 14, N'Ca 1', CAST(N'2018-06-24 07:00:00.000' AS DateTime), CAST(N'2018-06-24 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (35, 14, N'Ca 2', CAST(N'2018-06-24 09:30:00.000' AS DateTime), CAST(N'2018-06-24 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (36, 14, N'Ca 3', CAST(N'2018-06-24 11:30:00.000' AS DateTime), CAST(N'2018-06-24 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (37, 14, N'Ca 4', CAST(N'2018-06-24 15:30:00.000' AS DateTime), CAST(N'2018-06-24 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (38, 14, N'Ca 5', CAST(N'2018-06-24 18:30:00.000' AS DateTime), CAST(N'2018-06-24 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (39, 15, N'Ca 1', CAST(N'2018-06-25 07:00:00.000' AS DateTime), CAST(N'2018-06-25 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (40, 15, N'Ca 2', CAST(N'2018-06-25 09:30:00.000' AS DateTime), CAST(N'2018-06-25 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (41, 15, N'Ca 3', CAST(N'2018-06-25 11:30:00.000' AS DateTime), CAST(N'2018-06-25 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (42, 15, N'Ca 4', CAST(N'2018-06-25 15:30:00.000' AS DateTime), CAST(N'2018-06-25 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (43, 15, N'Ca 5', CAST(N'2018-06-25 18:30:00.000' AS DateTime), CAST(N'2018-06-25 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (44, 16, N'Ca 1', CAST(N'2018-06-26 07:00:00.000' AS DateTime), CAST(N'2018-06-26 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (45, 16, N'Ca 2', CAST(N'2018-06-26 09:30:00.000' AS DateTime), CAST(N'2018-06-26 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (46, 16, N'Ca 3', CAST(N'2018-06-26 11:30:00.000' AS DateTime), CAST(N'2018-06-26 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (47, 16, N'Ca 4', CAST(N'2018-06-26 15:30:00.000' AS DateTime), CAST(N'2018-06-26 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (48, 16, N'Ca 5', CAST(N'2018-06-26 18:30:00.000' AS DateTime), CAST(N'2018-06-26 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (49, 17, N'Ca 1', CAST(N'2018-06-27 07:00:00.000' AS DateTime), CAST(N'2018-06-27 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (50, 17, N'Ca 2', CAST(N'2018-06-27 09:30:00.000' AS DateTime), CAST(N'2018-06-27 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (51, 17, N'Ca 3', CAST(N'2018-06-27 11:30:00.000' AS DateTime), CAST(N'2018-06-27 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (52, 17, N'Ca 4', CAST(N'2018-06-27 15:30:00.000' AS DateTime), CAST(N'2018-06-27 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (53, 17, N'Ca 5', CAST(N'2018-06-27 18:30:00.000' AS DateTime), CAST(N'2018-06-27 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (54, 18, N'Ca 1', CAST(N'2018-06-28 07:00:00.000' AS DateTime), CAST(N'2018-06-28 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (55, 18, N'Ca 2', CAST(N'2018-06-28 09:30:00.000' AS DateTime), CAST(N'2018-06-28 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (56, 18, N'Ca 3', CAST(N'2018-06-28 11:30:00.000' AS DateTime), CAST(N'2018-06-28 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (57, 18, N'Ca 4', CAST(N'2018-06-28 15:30:00.000' AS DateTime), CAST(N'2018-06-28 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (58, 18, N'Ca 5', CAST(N'2018-06-28 18:30:00.000' AS DateTime), CAST(N'2018-06-28 20:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (59, 19, N'Ca 1', CAST(N'2018-06-29 07:00:00.000' AS DateTime), CAST(N'2018-06-29 09:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (60, 19, N'Ca 2', CAST(N'2018-06-29 09:30:00.000' AS DateTime), CAST(N'2018-06-29 11:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (61, 19, N'Ca 3', CAST(N'2018-06-29 11:30:00.000' AS DateTime), CAST(N'2018-06-29 15:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (62, 19, N'Ca 4', CAST(N'2018-06-29 15:30:00.000' AS DateTime), CAST(N'2018-06-29 18:30:00.000' AS DateTime))
INSERT [dbo].[CaTruc] ([CaTrucID], [YeuCauID], [TenCa], [BatDau], [KetThuc]) VALUES (63, 19, N'Ca 5', CAST(N'2018-06-29 18:30:00.000' AS DateTime), CAST(N'2018-06-29 20:30:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[CaTruc] OFF
SET IDENTITY_INSERT [dbo].[DonVi] ON 

INSERT [dbo].[DonVi] ([DonViID], [TenDonVi]) VALUES (1, N'Hàn nguội')
INSERT [dbo].[DonVi] ([DonViID], [TenDonVi]) VALUES (2, N'Hàn nhiệt')
INSERT [dbo].[DonVi] ([DonViID], [TenDonVi]) VALUES (3, N'Hàn công nghệ cao')
SET IDENTITY_INSERT [dbo].[DonVi] OFF
SET IDENTITY_INSERT [dbo].[PhanCong] ON 

INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (60, 28, NULL, 13, 19)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (61, 29, NULL, 14, 19)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (61, 28, NULL, 15, 19)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (62, 29, NULL, 16, 19)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (54, 28, NULL, 17, 18)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (55, 28, NULL, 18, 18)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (56, 28, NULL, 19, 18)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (57, 29, NULL, 20, 18)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (57, 28, NULL, 21, 18)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (49, 54, NULL, 22, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (49, 53, NULL, 23, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (49, 52, NULL, 24, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (49, 51, NULL, 25, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (49, 50, NULL, 26, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (49, 49, NULL, 27, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (50, 54, NULL, 30, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (51, 54, NULL, 37, 17)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (44, 40, NULL, 38, 16)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (44, 39, NULL, 39, 16)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (45, 40, NULL, 40, 16)
INSERT [dbo].[PhanCong] ([CaTrucID], [CanBoID], [GhiChu], [PhanCongID], [YeuCauID]) VALUES (46, 39, NULL, 41, 16)
SET IDENTITY_INSERT [dbo].[PhanCong] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([IDAdmin], [TaiKhoan], [MatKhau], [HoTen], [NgaySinh]) VALUES (1, N'HoangTruong', N'1', N'HoangDuyTruong', NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[YeuCau] ON 

INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (10, CAST(N'2018-06-20T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 2, 3)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (11, CAST(N'2018-06-21T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 4, 8)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (12, CAST(N'2018-06-22T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 3, 8)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (13, CAST(N'2018-06-23T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 8, 10)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (14, CAST(N'2018-06-24T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 2, 3)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (15, CAST(N'2018-06-25T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 10, 24)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (16, CAST(N'2018-06-26T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 2, 7)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (17, CAST(N'2018-06-27T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 6, 8)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (18, CAST(N'2018-06-28T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 2, 5)
INSERT [dbo].[YeuCau] ([YeuCauID], [NgayTruc], [IDAdmin], [SoLuongNguoi], [SoLuongCa]) VALUES (19, CAST(N'2018-06-29T00:00:00.0000000+07:00' AS DateTimeOffset), NULL, 2, 8)
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
ALTER TABLE [dbo].[YeuCau]  WITH CHECK ADD  CONSTRAINT [FK_YeuCau_User] FOREIGN KEY([IDAdmin])
REFERENCES [dbo].[User] ([IDAdmin])
GO
ALTER TABLE [dbo].[YeuCau] CHECK CONSTRAINT [FK_YeuCau_User]
GO
USE [master]
GO
ALTER DATABASE [QLPCNhanVien] SET  READ_WRITE 
GO
