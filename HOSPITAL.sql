USE [master]
GO
/****** Object:  Database [HOSPITAL]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE DATABASE [HOSPITAL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HOSPITAL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HOSPITAL.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HOSPITAL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HOSPITAL_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HOSPITAL] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HOSPITAL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HOSPITAL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HOSPITAL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HOSPITAL] SET ARITHABORT OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HOSPITAL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HOSPITAL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HOSPITAL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HOSPITAL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HOSPITAL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HOSPITAL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HOSPITAL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HOSPITAL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HOSPITAL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HOSPITAL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HOSPITAL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HOSPITAL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HOSPITAL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HOSPITAL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HOSPITAL] SET RECOVERY FULL 
GO
ALTER DATABASE [HOSPITAL] SET  MULTI_USER 
GO
ALTER DATABASE [HOSPITAL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HOSPITAL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HOSPITAL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HOSPITAL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HOSPITAL] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HOSPITAL] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HOSPITAL', N'ON'
GO
ALTER DATABASE [HOSPITAL] SET QUERY_STORE = OFF
GO
USE [HOSPITAL]
GO
/****** Object:  User [NV0008]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0008] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[NV0008]
GO
/****** Object:  User [NV0007]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0007] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[NV0007]
GO
/****** Object:  User [NV0006]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0006] FOR LOGIN [bs6] WITH DEFAULT_SCHEMA=[NV0006]
GO
/****** Object:  User [NV0005]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0005] FOR LOGIN [bs3] WITH DEFAULT_SCHEMA=[NV0005]
GO
/****** Object:  User [NV0004]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0004] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[NV0004]
GO
/****** Object:  User [NV0003]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0003] FOR LOGIN [YT1] WITH DEFAULT_SCHEMA=[YT1]
GO
/****** Object:  User [NV0002]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0002] FOR LOGIN [BS1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV0001]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0001] FOR LOGIN [YTT1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NV0000]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE USER [NV0000] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [YTATRUONG]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE ROLE [YTATRUONG]
GO
/****** Object:  DatabaseRole [YTA]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE ROLE [YTA]
GO
/****** Object:  DatabaseRole [BACSI]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE ROLE [BACSI]
GO
/****** Object:  DatabaseRole [ADMIN]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE ROLE [ADMIN]
GO
ALTER ROLE [YTATRUONG] ADD MEMBER [NV0008]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [NV0008]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [NV0008]
GO
ALTER ROLE [YTA] ADD MEMBER [NV0007]
GO
ALTER ROLE [BACSI] ADD MEMBER [NV0006]
GO
ALTER ROLE [BACSI] ADD MEMBER [NV0005]
GO
ALTER ROLE [BACSI] ADD MEMBER [NV0004]
GO
ALTER ROLE [YTA] ADD MEMBER [NV0003]
GO
ALTER ROLE [BACSI] ADD MEMBER [NV0002]
GO
ALTER ROLE [YTATRUONG] ADD MEMBER [NV0001]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [NV0001]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [NV0001]
GO
ALTER ROLE [ADMIN] ADD MEMBER [NV0000]
GO
ALTER ROLE [db_owner] ADD MEMBER [NV0000]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [YTATRUONG]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [YTATRUONG]
GO
ALTER ROLE [db_owner] ADD MEMBER [ADMIN]
GO
/****** Object:  Schema [NV0004]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE SCHEMA [NV0004]
GO
/****** Object:  Schema [NV0005]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE SCHEMA [NV0005]
GO
/****** Object:  Schema [NV0006]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE SCHEMA [NV0006]
GO
/****** Object:  Schema [NV0007]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE SCHEMA [NV0007]
GO
/****** Object:  Schema [NV0008]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE SCHEMA [NV0008]
GO
/****** Object:  Schema [YT1]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE SCHEMA [YT1]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDGiuong]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDGiuong]()
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	DECLARE @NextNum INT
	IF (SELECT COUNT(MaGiuong) FROM GIUONGBENH) = 0
			SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaGiuong,6)) FROM GIUONGBENH
	SET @NextNum = CONVERT(INT, @ID)
	SELECT @ID = CASE
		WHEN @NextNum >= 0 and @NextNum < 9 THEN 'G00000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9 and @NextNum < 99 THEN 'G0000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99 and @NextNum < 999 THEN 'G000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999 and @NextNum < 9999 THEN 'G00' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9999 and @NextNum < 99999 THEN 'G0' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99999 and @NextNum < 999999 THEN 'G' + CONVERT(CHAR, CONVERT(INT, @ID) +1)

	END
		RETURN @ID

END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MaBenhNhan]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[AUTO_MaBenhNhan]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	DECLARE @NextNum INT
	IF (SELECT COUNT(MaBenhNhan) FROM BENHNHAN) = 0
			SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaBenhNhan,8)) FROM BENHNHAN
	SET @NextNum = CONVERT(INT, @ID)
	SELECT @ID = CASE
		WHEN @NextNum >= 0 and @NextNum < 9 THEN 'BN0000000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9 and @NextNum < 99 THEN 'BN000000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99 and @NextNum < 999 THEN 'BN00000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999 and @NextNum < 9999 THEN 'BN0000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9999 and @NextNum < 99999 THEN 'BN000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99999 and @NextNum < 999999 THEN 'BN00' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999999 and @NextNum < 9999999 THEN 'BN0' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9999999 and @NextNum < 99999999 THEN 'BN' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
	END
		RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MaNV]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE FUNCTION [dbo].[AUTO_MaNV]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	DECLARE @NextNum INT
	IF (SELECT COUNT(MaNV) FROM NHANVIEN) = 0
			SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNV,4)) FROM NHANVIEN
	SET @NextNum = CONVERT(INT, @ID)
	SELECT @ID = CASE
		WHEN @NextNum >= 0 and @NextNum < 9 THEN 'NV000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9 and @NextNum < 99 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99 and @NextNum < 999 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999 and @NextNum < 9999 THEN 'NV' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
	END
		RETURN @ID

END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MaSuChuaTri]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_MaSuChuaTri]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	DECLARE @NextNum INT
	IF (SELECT COUNT(MaSuChuaTri) FROM SUCHUATRI) = 0
			SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSuChuaTri,7)) FROM SUCHUATRI
	SET @NextNum = CONVERT(INT, @ID)
	SELECT @ID = CASE
		WHEN @NextNum >= 0 and @NextNum < 9 THEN 'SCT000000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9 and @NextNum < 99 THEN 'SCT00000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99 and @NextNum < 999 THEN 'SCT0000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999 and @NextNum < 9999 THEN 'SCT000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9999 and @NextNum < 99999 THEN 'SCT00' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99999 and @NextNum < 999999 THEN 'SCT0' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999999 and @NextNum < 9999999 THEN 'SCT' + CONVERT(CHAR, CONVERT(INT, @ID) +1)	END
		RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MaTuan]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[AUTO_MaTuan]()
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	DECLARE @NextNum INT
	IF (SELECT COUNT(MaTuan) FROM TUAN) = 0
			SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaTuan,6)) FROM TUAN
	SET @NextNum = CONVERT(INT, @ID)
	SELECT @ID = CASE
		WHEN @NextNum >= 0 and @NextNum < 9 THEN 'T00000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9 and @NextNum < 99 THEN 'T0000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99 and @NextNum < 999 THEN 'T000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999 and @NextNum < 9999 THEN 'T00' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9999 and @NextNum < 99999 THEN 'T0' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99999 and @NextNum < 999999 THEN 'T' + CONVERT(CHAR, CONVERT(INT, @ID) +1)

	END
		RETURN @ID

END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MaVT]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[AUTO_MaVT]()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	DECLARE @NextNum INT
	IF (SELECT COUNT(MaVT) FROM VATTU) = 0
			SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaVT,8)) FROM VATTU
	SET @NextNum = CONVERT(INT, @ID)
	SELECT @ID = CASE
		WHEN @NextNum >= 0 and @NextNum < 9 THEN 'VT0000000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9 and @NextNum < 99 THEN 'VT000000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99 and @NextNum < 999 THEN 'VT00000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999 and @NextNum < 9999 THEN 'VT0000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9999 and @NextNum < 99999 THEN 'VT000' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 99999 and @NextNum < 999999 THEN 'VT00' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 999999 and @NextNum < 9999999 THEN 'VT0' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
		WHEN @NextNum >= 9999999 and @NextNum < 99999999 THEN 'VT' + CONVERT(CHAR, CONVERT(INT, @ID) +1)
	END
		RETURN @ID
END
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](6) NOT NULL,
	[Ho] [nvarchar](40) NOT NULL,
	[Ten] [nvarchar](10) NOT NULL,
	[Phai] [bit] NULL,
	[SDT] [varchar](12) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_DS_TaiKhoan]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DS_TaiKhoan]
AS
SELECT t2.loginname, t1.name AS username, t3.RoleName, t4.Ho + ' ' + t4.Ten AS HoTen
FROM     sys.sysusers AS t1 LEFT OUTER JOIN
                  sys.syslogins AS t2 ON t2.sid = t1.sid INNER JOIN
                      (SELECT r.name AS RoleName, u.name
                       FROM      sys.database_role_members AS m INNER JOIN
                                         sys.database_principals AS u ON u.principal_id = m.member_principal_id INNER JOIN
                                         sys.database_principals AS r ON r.principal_id = m.role_principal_id) AS t3 ON t3.name = t1.name INNER JOIN
                  dbo.NHANVIEN AS t4 ON t4.MaNV = t1.name
WHERE  (t1.issqluser = 1) AND (t1.hasdbaccess = 1) AND (t2.loginname IS NOT NULL) AND (t3.RoleName <> 'ADMIN') AND (t3.RoleName <> 'db_owner')
GO
/****** Object:  Table [dbo].[BACSI]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BACSI](
	[MaBacSi] [varchar](6) NOT NULL,
	[TrinhDo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BACSI] PRIMARY KEY CLUSTERED 
(
	[MaBacSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BENHNHAN]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BENHNHAN](
	[MaBenhNhan] [varchar](10) NOT NULL,
	[Ho] [nvarchar](40) NOT NULL,
	[Ten] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[MaLoai] [bit] NOT NULL,
	[MaBacSiTheoDoi] [varchar](6) NULL,
	[MaBacSiTiepNhan] [varchar](6) NULL,
 CONSTRAINT [PK_BENHNHAN] PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_BACSI_CHUATRI_BENHNHAN]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN](
	[MaCTBSCTBN] [int] IDENTITY(1,1) NOT NULL,
	[MaBacSi] [varchar](6) NOT NULL,
	[MaBenhNhan] [varchar](10) NOT NULL,
	[MaSuChuaTri] [varchar](10) NOT NULL,
	[NgayChuaTri] [date] NOT NULL,
	[ThoiGianChuaTri] [int] NULL,
	[KetQua] [nvarchar](100) NULL,
 CONSTRAINT [PK_CT_BACSI_CHUATRI_BENHNHAN] PRIMARY KEY CLUSTERED 
(
	[MaCTBSCTBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_BENHNHAN_GIUONG]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BENHNHAN_GIUONG](
	[MaGiuong] [varchar](7) NOT NULL,
	[MaBenhNhan] [varchar](10) NOT NULL,
	[NgayBD] [date] NOT NULL,
	[NgayKT] [date] NULL,
 CONSTRAINT [PK_CT_BENHNHAN_GIUONG] PRIMARY KEY CLUSTERED 
(
	[MaGiuong] ASC,
	[MaBenhNhan] ASC,
	[NgayBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_HOADON]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HOADON](
	[MaVT] [varchar](10) NOT NULL,
	[MaCTBSCTBN] [int] NOT NULL,
	[ThoiGian] [date] NOT NULL,
	[SoLuong] [float] NOT NULL,
	[DonGia] [money] NOT NULL,
 CONSTRAINT [PK_CT_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC,
	[MaCTBSCTBN] ASC,
	[ThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_NV_KHUCHUATRI]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_NV_KHUCHUATRI](
	[MaNV] [varchar](6) NOT NULL,
	[SoKhu] [varchar](3) NOT NULL,
	[NgayBD] [date] NOT NULL,
	[NgayKT] [date] NULL,
 CONSTRAINT [PK_CT_NV_KHUCHUATRI] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[SoKhu] ASC,
	[NgayBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIUONGBENH]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIUONGBENH](
	[MaGiuong] [varchar](7) NOT NULL,
	[SoGiuong] [int] NOT NULL,
	[SoPhong] [varchar](4) NOT NULL,
	[SoKhu] [varchar](3) NOT NULL,
 CONSTRAINT [PK_GIUONGBENH] PRIMARY KEY CLUSTERED 
(
	[MaGiuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHUCHUATRI]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHUCHUATRI](
	[SoKhu] [varchar](3) NOT NULL,
	[Ten] [nvarchar](40) NOT NULL,
	[MaYTaTruong] [varchar](6) NULL,
 CONSTRAINT [PK_KHUCHUATRI] PRIMARY KEY CLUSTERED 
(
	[SoKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUCHUATRI]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUCHUATRI](
	[MaSuChuaTri] [varchar](10) NOT NULL,
	[TenSuChuaTri] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_SUCHUATRI] PRIMARY KEY CLUSTERED 
(
	[MaSuChuaTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VATTU]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATTU](
	[MaVT] [varchar](10) NOT NULL,
	[MoTa] [nvarchar](100) NULL,
	[DonGia] [money] NOT NULL,
 CONSTRAINT [PK_VATTU] PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YTA]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YTA](
	[MaYT] [varchar](6) NOT NULL,
	[CongViec] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_YTA] PRIMARY KEY CLUSTERED 
(
	[MaYT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0002', N'Bác sĩ đa khoa')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0004', N'Bác sĩ đa khoa')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0005', N'Thạc sĩ')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0006', N'Tiến Sĩ')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0009', N'Bác sĩ đa khoa')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0010', N'Bác sĩ ngoại khoa')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0011', N'Bác sĩ nội khoa')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0012', N'Bác sĩ chấn thương')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0013', N'Bác sĩ nhi đồng')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0014', N'Bác sĩ đa khoa')
INSERT [dbo].[BACSI] ([MaBacSi], [TrinhDo]) VALUES (N'NV0015', N'Bác sĩ tiêu hoá')
GO
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000001', N'văn', N'tèo', CAST(N'1905-06-22' AS Date), 1, N'NV0002', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000002', N'hà', N'Hồ', CAST(N'1994-01-19' AS Date), 1, N'', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000003', N'nguyễn', N'Trung', CAST(N'2000-01-18' AS Date), 1, N'NV0004', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000004', N'Văn', N'Tùng', CAST(N'2000-07-13' AS Date), 1, N'NV0002', N'NV0011')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000005', N'lê', N'vy ', CAST(N'1905-06-18' AS Date), 1, N'NV0009', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000006', N'Lê', N'Lợi ', CAST(N'2000-01-01' AS Date), 0, N'NV0004', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000007', N'Hoàng', N'Bảo', CAST(N'1985-12-14' AS Date), 1, N'NV0011', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000008', N'Phạm', N'Thu', CAST(N'1955-04-19' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000009', N'Lê', N'Tiến', CAST(N'1954-12-03' AS Date), 1, N'NV0012', N'NV0012')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000010', N'Phạm', N'Thu', CAST(N'1972-04-26' AS Date), 1, N'NV0012', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000011', N'Lê', N'Bảo', CAST(N'1967-12-05' AS Date), 1, N'NV0013', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000012', N'Trần', N'Hùng', CAST(N'1962-03-01' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000013', N'Phạm', N'Thu', CAST(N'1995-08-16' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000014', N'Lê', N'Bảo', CAST(N'1972-11-24' AS Date), 1, N'NV0011', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000015', N'Hoàng', N'Minh', CAST(N'1971-10-17' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000016', N'Trần', N'Nhung', CAST(N'1965-04-16' AS Date), 0, N'NV0002', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000017', N'Lê', N'Bảo', CAST(N'1971-04-08' AS Date), 0, N'NV0002', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000018', N'Lê', N'Trang', CAST(N'1951-03-26' AS Date), 0, N'NV0002', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000019', N'Phạm', N'Trang', CAST(N'1998-11-14' AS Date), 0, N'NV0011', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000020', N'Hoàng', N'Bảo', CAST(N'1962-07-25' AS Date), 1, N'NV0011', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000021', N'Phạm', N'Thu', CAST(N'1970-03-01' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000022', N'Hoàng', N'Tiến', CAST(N'1978-04-14' AS Date), 1, N'NV0015', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000023', N'Trần', N'Thu', CAST(N'1989-10-16' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000024', N'Phạm', N'Trang', CAST(N'1981-01-11' AS Date), 0, N'NV0011', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000025', N'Trần', N'Trang', CAST(N'1975-06-28' AS Date), 1, N'NV0010', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000026', N'Nguyễn', N'Thu', CAST(N'1962-11-16' AS Date), 0, N'NV0002', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000027', N'Phạm', N'Nhung', CAST(N'1964-01-11' AS Date), 0, N'NV0002', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000028', N'Trần', N'Bảo', CAST(N'1984-06-07' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000029', N'Hoàng', N'Tiến', CAST(N'1970-03-10' AS Date), 1, N'NV0011', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000030', N'Hoàng', N'Lợi', CAST(N'1952-08-08' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000031', N'Trần', N'Thu', CAST(N'1979-06-05' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000032', N'Trần', N'Bảo', CAST(N'1952-12-08' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000033', N'Hoàng', N'Nhung', CAST(N'1952-02-28' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000034', N'Trần', N'Bảo', CAST(N'1982-09-09' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000035', N'Hoàng', N'Nhung', CAST(N'1966-01-01' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000036', N'Trần', N'Tuấn', CAST(N'1952-05-03' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000037', N'Hoàng', N'Thu', CAST(N'1975-02-12' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000038', N'Hoàng', N'Nhung', CAST(N'1980-06-02' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000039', N'Nguyễn', N'Nhung', CAST(N'1950-11-24' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000040', N'Nguyễn', N'Trang', CAST(N'1988-07-11' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000041', N'Lê', N'Tiến', CAST(N'1962-09-22' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000042', N'Trần', N'Trang', CAST(N'1966-04-23' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000043', N'Lê', N'Thu', CAST(N'1950-10-28' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000044', N'Lê', N'Tuấn', CAST(N'1982-07-24' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000045', N'Phạm', N'Nhung', CAST(N'1969-08-18' AS Date), 0, N'NV0015', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000046', N'Hoàng', N'Tiến', CAST(N'1958-08-21' AS Date), 0, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000047', N'Hoàng', N'Thu', CAST(N'1957-09-17' AS Date), 1, N'NV0015', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000048', N'Hoàng', N'Trang', CAST(N'1955-01-24' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000049', N'Lê', N'Bảo', CAST(N'1978-08-21' AS Date), 1, NULL, N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000050', N'Lê', N'Thu', CAST(N'1978-04-17' AS Date), 0, N'NV0009', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000051', N'Trần', N'Bảo', CAST(N'1961-08-22' AS Date), 1, N'NV0010', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000052', N'Nguyễn', N'Thu', CAST(N'1961-05-25' AS Date), 1, N'NV0010', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000053', N'Lê', N'Bảo', CAST(N'1985-07-01' AS Date), 1, N'NV0009', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000054', N'Nguyễn', N'Tiến', CAST(N'1983-10-03' AS Date), 1, N'NV0009', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000055', N'Nguyễn', N'Bảo', CAST(N'1975-08-24' AS Date), 0, N'NV0010', NULL)
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000056', N'Nguyễn', N'Trang', CAST(N'1961-10-01' AS Date), 0, N'NV0010', N'NV0002')
INSERT [dbo].[BENHNHAN] ([MaBenhNhan], [Ho], [Ten], [NgaySinh], [MaLoai], [MaBacSiTheoDoi], [MaBacSiTiepNhan]) VALUES (N'BN00000057', N'toản', N'toản', CAST(N'2001-02-06' AS Date), 0, N'NV0002', NULL)
GO
SET IDENTITY_INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ON 

INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (5, N'NV0002', N'BN00000003', N'SCT0000001', CAST(N'2023-05-28' AS Date), NULL, NULL)
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (6, N'NV0002', N'BN00000005', N'SCT0000001', CAST(N'2023-05-06' AS Date), NULL, NULL)
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (7, N'NV0002', N'BN00000014', N'SCT0000002', CAST(N'2023-06-27' AS Date), NULL, NULL)
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (8, N'NV0002', N'BN00000030', N'SCT0000004', CAST(N'2023-07-06' AS Date), NULL, NULL)
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (9, N'NV0002', N'BN00000030', N'SCT0000006', CAST(N'2023-06-01' AS Date), 8, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (10, N'NV0002', N'BN00000029', N'SCT0000005', CAST(N'2023-07-06' AS Date), NULL, NULL)
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (11, N'NV0002', N'BN00000001', N'SCT0000004', CAST(N'2023-06-03' AS Date), 1, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (12, N'NV0002', N'BN00000008', N'SCT0000001', CAST(N'2023-07-03' AS Date), 1, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (13, N'NV0002', N'BN00000012', N'SCT0000007', CAST(N'2023-07-03' AS Date), 7, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (14, N'NV0002', N'BN00000023', N'SCT0000008', CAST(N'2023-07-03' AS Date), 1, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (15, N'NV0002', N'BN00000036', N'SCT0000001', CAST(N'2023-06-28' AS Date), 1, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (25, N'NV0002', N'BN00000001', N'SCT0000003', CAST(N'2023-06-17' AS Date), 2, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (28, N'NV0002', N'BN00000001', N'SCT0000004', CAST(N'2023-07-01' AS Date), 3, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (30, N'NV0002', N'BN00000001', N'SCT0000003', CAST(N'2023-07-05' AS Date), 5, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (31, N'NV0002', N'BN00000047', N'SCT0000006', CAST(N'2023-06-28' AS Date), 1, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (32, N'NV0002', N'BN00000025', N'SCT0000002', CAST(N'2023-06-23' AS Date), NULL, N'khỏi bệnh')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (33, N'NV0002', N'BN00000013', N'SCT0000001', CAST(N'2023-06-22' AS Date), 1, N'xong')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (34, N'NV0002', N'BN00000002', N'SCT0000001', CAST(N'2023-07-07' AS Date), 1, N'xong')
INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN], [MaBacSi], [MaBenhNhan], [MaSuChuaTri], [NgayChuaTri], [ThoiGianChuaTri], [KetQua]) VALUES (35, N'NV0002', N'BN00000002', N'SCT0000008', CAST(N'2023-07-09' AS Date), 1, N'hoàn tất')
SET IDENTITY_INSERT [dbo].[CT_BACSI_CHUATRI_BENHNHAN] OFF
GO
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000001', N'BN00000007', CAST(N'2023-06-27' AS Date), NULL)
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000002', N'BN00000004', CAST(N'2023-04-19' AS Date), CAST(N'2023-05-10' AS Date))
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000003', N'BN00000001', CAST(N'2023-05-30' AS Date), CAST(N'2023-06-19' AS Date))
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000003', N'BN00000020', CAST(N'2023-06-01' AS Date), CAST(N'2023-06-14' AS Date))
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000004', N'BN00000003', CAST(N'2023-06-15' AS Date), CAST(N'2023-06-30' AS Date))
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000004', N'BN00000029', CAST(N'2022-03-09' AS Date), CAST(N'2023-05-29' AS Date))
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000004', N'BN00000030', CAST(N'2023-06-15' AS Date), NULL)
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000005', N'BN00000011', CAST(N'2023-03-15' AS Date), CAST(N'2023-06-28' AS Date))
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000011', N'BN00000009', CAST(N'2023-07-01' AS Date), NULL)
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000012', N'BN00000014', CAST(N'2023-06-27' AS Date), NULL)
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000013', N'BN00000022', CAST(N'2023-06-14' AS Date), CAST(N'2023-06-20' AS Date))
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000014', N'BN00000025', CAST(N'2023-06-23' AS Date), NULL)
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000015', N'BN00000047', CAST(N'2023-06-22' AS Date), NULL)
INSERT [dbo].[CT_BENHNHAN_GIUONG] ([MaGiuong], [MaBenhNhan], [NgayBD], [NgayKT]) VALUES (N'G000017', N'BN00000001', CAST(N'2023-07-08' AS Date), NULL)
GO
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000001', 5, CAST(N'2023-08-29' AS Date), 1, 0.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000002', 6, CAST(N'2023-06-27' AS Date), 1, 10000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000002', 30, CAST(N'2023-07-07' AS Date), 1, 10000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000003', 6, CAST(N'2023-06-27' AS Date), 1, 200000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000003', 11, CAST(N'2023-06-03' AS Date), 1, 200000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000003', 28, CAST(N'2023-07-07' AS Date), 1, 200000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000003', 31, CAST(N'2023-07-07' AS Date), 1, 200000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000004', 11, CAST(N'2023-06-03' AS Date), 1, 80000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000004', 25, CAST(N'2023-07-03' AS Date), 1, 80000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000004', 28, CAST(N'2023-07-07' AS Date), 1, 80000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000005', 34, CAST(N'2023-07-07' AS Date), 2, 5000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000006', 12, CAST(N'2023-07-03' AS Date), 1, 10000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000006', 15, CAST(N'2023-07-03' AS Date), 1, 10000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000006', 33, CAST(N'2023-06-22' AS Date), 3, 10000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000006', 35, CAST(N'2023-07-09' AS Date), 1, 10000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000007', 12, CAST(N'2023-07-07' AS Date), 1, 502300.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000007', 30, CAST(N'2023-07-07' AS Date), 1, 502300.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000008', 14, CAST(N'2023-07-03' AS Date), 1, 123000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000008', 35, CAST(N'2023-07-09' AS Date), 2, 123000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000009', 34, CAST(N'2023-07-07' AS Date), 1, 120000.0000)
INSERT [dbo].[CT_HOADON] ([MaVT], [MaCTBSCTBN], [ThoiGian], [SoLuong], [DonGia]) VALUES (N'VT00000011', 13, CAST(N'2023-07-03' AS Date), 1, 900000.0000)
GO
INSERT [dbo].[CT_NV_KHUCHUATRI] ([MaNV], [SoKhu], [NgayBD], [NgayKT]) VALUES (N'NV0001', N'1', CAST(N'2023-07-07' AS Date), CAST(N'2023-07-14' AS Date))
INSERT [dbo].[CT_NV_KHUCHUATRI] ([MaNV], [SoKhu], [NgayBD], [NgayKT]) VALUES (N'NV0002', N'1', CAST(N'2023-06-23' AS Date), CAST(N'2023-06-30' AS Date))
INSERT [dbo].[CT_NV_KHUCHUATRI] ([MaNV], [SoKhu], [NgayBD], [NgayKT]) VALUES (N'NV0003', N'2', CAST(N'2023-07-18' AS Date), CAST(N'2023-07-25' AS Date))
INSERT [dbo].[CT_NV_KHUCHUATRI] ([MaNV], [SoKhu], [NgayBD], [NgayKT]) VALUES (N'NV0005', N'2', CAST(N'2023-07-14' AS Date), CAST(N'2023-07-21' AS Date))
INSERT [dbo].[CT_NV_KHUCHUATRI] ([MaNV], [SoKhu], [NgayBD], [NgayKT]) VALUES (N'NV0006', N'4', CAST(N'2023-07-07' AS Date), CAST(N'2023-07-21' AS Date))
GO
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000001', 1, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000011', 1, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000002', 2, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000012', 2, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000003', 3, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000013', 3, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000004', 4, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000014', 4, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000005', 5, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000015', 5, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000006', 6, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000016', 6, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000007', 7, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000017', 7, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000008', 8, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000018', 8, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000009', 9, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000019', 9, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000010', 10, N'1', N'1')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000020', 10, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000022', 50, N'1', N'2')
INSERT [dbo].[GIUONGBENH] ([MaGiuong], [SoGiuong], [SoPhong], [SoKhu]) VALUES (N'G000021', 53, N'1', N'2')
GO
INSERT [dbo].[KHUCHUATRI] ([SoKhu], [Ten], [MaYTaTruong]) VALUES (N'1', N'Khu Chấn Thương', N'NV0001')
INSERT [dbo].[KHUCHUATRI] ([SoKhu], [Ten], [MaYTaTruong]) VALUES (N'2', N'Khu Thần Kinh', N'NV0003')
INSERT [dbo].[KHUCHUATRI] ([SoKhu], [Ten], [MaYTaTruong]) VALUES (N'3', N'Khu Nội', N'NV0007')
INSERT [dbo].[KHUCHUATRI] ([SoKhu], [Ten], [MaYTaTruong]) VALUES (N'4', N'Khu Da liễu', N'NV0008')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0000', N'admin', N'admin', NULL, N'0000000000')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0001', N'Nguyễn ', N'Ngọc', 0, N'0910291121')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0002', N'Văn', N'Trọng', 1, N'0912345678')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0003', N'Võ', N'Trang', 0, N'0978382362')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0004', N'Lê', N'Tèo', 0, N'0917273732')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0005', N'Nguyễn', N'Toản', 0, N'09121211212')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0006', N'Đặng', N'Trung', 1, N'09478473847')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0007', N'Trần', N'Kiên', 0, N'0912345678')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0008', N'Hoàng', N'Thu', 0, N'0912355678')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0009', N'Hoàng', N'Thành', 1, N'0912365679')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0010', N'Hồ', N'Cường', 0, N'0912375680')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0011', N'Dương', N'Thơm', 0, N'0912385681')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0012', N'Vũ', N'Hải', 0, N'0912395682')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0013', N'Vương', N'Cường', 1, N'0912405683')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0014', N'Hồ', N'Trường', 0, N'0912415684')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0015', N'Phạm', N'Thắng', 1, N'0912425685')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0016', N'Lê', N'Bích', 1, N'0912435686')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0017', N'Ngô', N'Hạnh', 0, N'0912445687')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0018', N'Lê', N'Quang', 1, N'0912455688')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0019', N'Huỳnh', N'Tâm', 0, N'0912465689')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0020', N'Vương', N'Nam', 0, N'0912475690')
INSERT [dbo].[NHANVIEN] ([MaNV], [Ho], [Ten], [Phai], [SDT]) VALUES (N'NV0021', N'Lê', N'Lai', 0, N'09345627152')
GO
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000005', N'Băng bó tay chân')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000006', N'Chữa bệnh ngoài da')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000008', N'Chữa đau bao tử')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000002', N'Chữa đau bụng')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000007', N'Chữa đau đầu')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000001', N'Khám nội soi')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000004', N'Nhổ răng')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000009', N'Phẫu thuật não')
INSERT [dbo].[SUCHUATRI] ([MaSuChuaTri], [TenSuChuaTri]) VALUES (N'SCT0000003', N'Phẫu thuật ruột thừa')
GO
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000001', N'Panadol', 12334.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000002', N'C sủi', 10000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000003', N'bông băng', 200000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000004', N'Thuốc đỏ', 80000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000005', N'Kẹo Ngậm', 5000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000006', N'Thuốc A', 10000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000007', N'Thuốc B', 502300.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000008', N'Thuốc C', 123000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000009', N'Thực phẩm chức năng', 120000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000010', N'Siro ho', 300000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000011', N'hoạt huyết bổ não', 900000.0000)
INSERT [dbo].[VATTU] ([MaVT], [MoTa], [DonGia]) VALUES (N'VT00000012', N'siro A', 111111.0000)
GO
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0001', N'Y tá trưởng')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0003', N'Y tá nhập liệu')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0007', N'Y tá kê thuốc')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0008', N'Y tá trưởng')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0016', N'Y tá')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0017', N'Y tá')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0018', N'Y tá')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0019', N'Y tá')
INSERT [dbo].[YTA] ([MaYT], [CongViec]) VALUES (N'NV0020', N'Y tá')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_BENHNHAN_BSTHEODOI]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE NONCLUSTERED INDEX [IDX_BENHNHAN_BSTHEODOI] ON [dbo].[BENHNHAN]
(
	[MaBacSiTheoDoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_CT_BACSI_CHUATRI_BENHNHAN]    Script Date: 7/10/2023 1:18:18 PM ******/
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ADD  CONSTRAINT [UK_CT_BACSI_CHUATRI_BENHNHAN] UNIQUE NONCLUSTERED 
(
	[MaBacSi] ASC,
	[MaBenhNhan] ASC,
	[MaSuChuaTri] ASC,
	[NgayChuaTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_GIUONGBENH]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_GIUONGBENH] ON [dbo].[GIUONGBENH]
(
	[SoGiuong] ASC,
	[SoPhong] ASC,
	[SoKhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TENSUCHUATRI]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_TENSUCHUATRI] ON [dbo].[SUCHUATRI]
(
	[TenSuChuaTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_VATTU]    Script Date: 7/10/2023 1:18:18 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UK_VATTU] ON [dbo].[VATTU]
(
	[MoTa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BENHNHAN] ADD  DEFAULT ([DBO].[AUTO_MaBenhNhan]()) FOR [MaBenhNhan]
GO
ALTER TABLE [dbo].[BENHNHAN] ADD  DEFAULT ((0)) FOR [MaLoai]
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ADD  DEFAULT (getdate()) FOR [NgayChuaTri]
GO
ALTER TABLE [dbo].[CT_BENHNHAN_GIUONG] ADD  DEFAULT (getdate()) FOR [NgayBD]
GO
ALTER TABLE [dbo].[CT_HOADON] ADD  CONSTRAINT [DF__CT_HOADON__DonGi__5EBF139D]  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[GIUONGBENH] ADD  DEFAULT ([DBO].[AUTO_IDGiuong]()) FOR [MaGiuong]
GO
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [DF__NHANVIEN__MaNV__2E1BDC42]  DEFAULT ([DBO].[AUTO_MaNV]()) FOR [MaNV]
GO
ALTER TABLE [dbo].[SUCHUATRI] ADD  DEFAULT ([DBO].[AUTO_MaSuChuaTri]()) FOR [MaSuChuaTri]
GO
ALTER TABLE [dbo].[VATTU] ADD  DEFAULT ([DBO].[AUTO_MaVT]()) FOR [MaVT]
GO
ALTER TABLE [dbo].[VATTU] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD  CONSTRAINT [FK_BACSI_NHANVIEN] FOREIGN KEY([MaBacSi])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[BACSI] CHECK CONSTRAINT [FK_BACSI_NHANVIEN]
GO
ALTER TABLE [dbo].[BENHNHAN]  WITH NOCHECK ADD  CONSTRAINT [FK_BENHNHAN_BACSI] FOREIGN KEY([MaBacSiTheoDoi])
REFERENCES [dbo].[BACSI] ([MaBacSi])
GO
ALTER TABLE [dbo].[BENHNHAN] CHECK CONSTRAINT [FK_BENHNHAN_BACSI]
GO
ALTER TABLE [dbo].[BENHNHAN]  WITH NOCHECK ADD  CONSTRAINT [FK_BENHNHAN_BACSI1] FOREIGN KEY([MaBacSiTiepNhan])
REFERENCES [dbo].[BACSI] ([MaBacSi])
GO
ALTER TABLE [dbo].[BENHNHAN] CHECK CONSTRAINT [FK_BENHNHAN_BACSI1]
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN]  WITH CHECK ADD  CONSTRAINT [FK_CT_BACSI_CHUATRI_BENHNHAN_BACSI] FOREIGN KEY([MaBacSi])
REFERENCES [dbo].[BACSI] ([MaBacSi])
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN] CHECK CONSTRAINT [FK_CT_BACSI_CHUATRI_BENHNHAN_BACSI]
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN]  WITH CHECK ADD  CONSTRAINT [FK_MaBenhNhan_CT_BACSI_CHUATRI_BENHNHAN] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BENHNHAN] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN] CHECK CONSTRAINT [FK_MaBenhNhan_CT_BACSI_CHUATRI_BENHNHAN]
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN]  WITH CHECK ADD  CONSTRAINT [FK_MaSuChuaTri_CT_BACSI_CHUATRI_BENHNHAN] FOREIGN KEY([MaSuChuaTri])
REFERENCES [dbo].[SUCHUATRI] ([MaSuChuaTri])
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN] CHECK CONSTRAINT [FK_MaSuChuaTri_CT_BACSI_CHUATRI_BENHNHAN]
GO
ALTER TABLE [dbo].[CT_BENHNHAN_GIUONG]  WITH CHECK ADD  CONSTRAINT [FK_MaBenhNhan_CT_BENHNHAN_GIUONG] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BENHNHAN] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[CT_BENHNHAN_GIUONG] CHECK CONSTRAINT [FK_MaBenhNhan_CT_BENHNHAN_GIUONG]
GO
ALTER TABLE [dbo].[CT_BENHNHAN_GIUONG]  WITH CHECK ADD  CONSTRAINT [FK_MaGiuong_CT_BENHNHAN_GIUONG] FOREIGN KEY([MaGiuong])
REFERENCES [dbo].[GIUONGBENH] ([MaGiuong])
GO
ALTER TABLE [dbo].[CT_BENHNHAN_GIUONG] CHECK CONSTRAINT [FK_MaGiuong_CT_BENHNHAN_GIUONG]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_MaCTBSCTBN_CT_HOADON] FOREIGN KEY([MaCTBSCTBN])
REFERENCES [dbo].[CT_BACSI_CHUATRI_BENHNHAN] ([MaCTBSCTBN])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_MaCTBSCTBN_CT_HOADON]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_MaVT_CT_HOADON] FOREIGN KEY([MaVT])
REFERENCES [dbo].[VATTU] ([MaVT])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_MaVT_CT_HOADON]
GO
ALTER TABLE [dbo].[CT_NV_KHUCHUATRI]  WITH CHECK ADD  CONSTRAINT [FK_CT_NV_KHUCHUATRI_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CT_NV_KHUCHUATRI] CHECK CONSTRAINT [FK_CT_NV_KHUCHUATRI_NHANVIEN]
GO
ALTER TABLE [dbo].[CT_NV_KHUCHUATRI]  WITH CHECK ADD  CONSTRAINT [FK_SoKhu_CT_NV_KHUCHUATRI] FOREIGN KEY([SoKhu])
REFERENCES [dbo].[KHUCHUATRI] ([SoKhu])
GO
ALTER TABLE [dbo].[CT_NV_KHUCHUATRI] CHECK CONSTRAINT [FK_SoKhu_CT_NV_KHUCHUATRI]
GO
ALTER TABLE [dbo].[GIUONGBENH]  WITH CHECK ADD  CONSTRAINT [FK_SoKhu_GIUONGBENH] FOREIGN KEY([SoKhu])
REFERENCES [dbo].[KHUCHUATRI] ([SoKhu])
GO
ALTER TABLE [dbo].[GIUONGBENH] CHECK CONSTRAINT [FK_SoKhu_GIUONGBENH]
GO
ALTER TABLE [dbo].[KHUCHUATRI]  WITH CHECK ADD  CONSTRAINT [FK_KHUCHUATRI_YTA] FOREIGN KEY([MaYTaTruong])
REFERENCES [dbo].[YTA] ([MaYT])
GO
ALTER TABLE [dbo].[KHUCHUATRI] CHECK CONSTRAINT [FK_KHUCHUATRI_YTA]
GO
ALTER TABLE [dbo].[YTA]  WITH CHECK ADD  CONSTRAINT [FK_YTA_NHANVIEN] FOREIGN KEY([MaYT])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[YTA] CHECK CONSTRAINT [FK_YTA_NHANVIEN]
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN]  WITH CHECK ADD  CONSTRAINT [CK_ThoiGianChuaTri_CT_BACSI_CHUATRI_BENHNHAN] CHECK  (([ThoiGianChuaTri]>=(0)))
GO
ALTER TABLE [dbo].[CT_BACSI_CHUATRI_BENHNHAN] CHECK CONSTRAINT [CK_ThoiGianChuaTri_CT_BACSI_CHUATRI_BENHNHAN]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [CK_DonGia_CT_HOADON] CHECK  (([DonGia]>=(0)))
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [CK_DonGia_CT_HOADON]
GO
ALTER TABLE [dbo].[GIUONGBENH]  WITH CHECK ADD  CONSTRAINT [CK_SoGiuong_GIUONGBENH] CHECK  (([SoGiuong]>(0)))
GO
ALTER TABLE [dbo].[GIUONGBENH] CHECK CONSTRAINT [CK_SoGiuong_GIUONGBENH]
GO
ALTER TABLE [dbo].[VATTU]  WITH CHECK ADD  CONSTRAINT [CK_DonGia_VATTU] CHECK  (([DonGia]>=(0)))
GO
ALTER TABLE [dbo].[VATTU] CHECK CONSTRAINT [CK_DonGia_VATTU]
GO
/****** Object:  StoredProcedure [dbo].[AUTOBACKUP]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AUTOBACKUP]
@COMMAND NVARCHAR(150), @TIME INT
as
begin 


EXEC msdb.dbo.sp_delete_job
   @job_name = N'Backup HOSPITAL Database';


DECLARE @job_name NVARCHAR(128);
SET @job_name = N'Backup HOSPITAL Database';

DECLARE @job_id UNIQUEIDENTIFIER;
EXEC msdb.dbo.sp_add_job
    @job_name = @job_name,
    @enabled = 1,
    @description = N'Backup HOSPITAL Database',
    @job_id = @job_id OUTPUT;

EXEC msdb.dbo.sp_add_jobstep
    @job_id = @job_id,
    @step_name = N'Backup HOSPITAL Database',
    @subsystem = N'TSQL',
    @command = @COMMAND,
    @retry_attempts = 5,
    @retry_interval = 5;

 DECLARE @schedule_id INT;
    EXEC msdb.dbo.sp_add_schedule
        @schedule_name = N'Daily BACKUP',
        @enabled = 1,
        @freq_type = 4,
        @freq_interval = 1,
        @active_start_time = @TIME,
        @schedule_id = @schedule_id OUTPUT;

    EXEC msdb.dbo.sp_attach_schedule
        @job_name = @job_name,
        @schedule_id = @schedule_id;

    EXEC msdb.dbo.sp_add_jobserver
        @job_name = @job_name,
        @server_name = N'(local)';
end
GO
/****** Object:  StoredProcedure [dbo].[BACKUP_DATABASE]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BACKUP_DATABASE]
@PATH NVARCHAR(150)
AS
BEGIN
	BACKUP DATABASE HOSPITAL
	TO DISK = @PATH 
	WITH NOFORMAT, INIT,
	NAME = N'HOSPITAL-Full Database Backup', NOREWIND, NOUNLOAD;

END
GO
/****** Object:  StoredProcedure [dbo].[RESTORE_DATABASE]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[RESTORE_DATABASE]
@PATH NVARCHAR(150)
AS
BEGIN
	alter database HOSPITAL 
set offline with rollback immediate

	RESTORE DATABASE HOSPITAL 
FROM DISK = @PATH 
with replace

 alter database HOSPITAL 
  set online

END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChonBenhNhanChuaTri]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ChonBenhNhanChuaTri]
@MaBS varchar(6)
AS
BEGIN
SELECT MaBenhNhan, HOTEN = Ho +' ' +Ten, NgaySinh, MaLoai, MaBacSiTheoDoi FROM BENHNHAN 
WHERE MaBacSiTiepNhan = @MaBS
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ChuaTriBenhNhan]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ChuaTriBenhNhan]
@MaBNChuaTri varchar(10)
AS
BEGIN
	SELECT *
		FROM CT_BACSI_CHUATRI_BENHNHAN
		WHERE MaBenhNhan = @MaBNChuaTri


END
GO
/****** Object:  StoredProcedure [dbo].[sp_DangNhap]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_DangNhap]
	@TENLOGIN NVARCHAR( 100)
AS
	DECLARE @UID INT
	DECLARE @MANV NVARCHAR(100)
	SELECT @UID= uid , @MANV= NAME FROM sys.sysusers 
  	WHERE sid = SUSER_SID(@TENLOGIN)

	SELECT  MANV= @MANV, 
       		HOTEN = (SELECT HO+ ' '+TEN FROM dbo.NHANVIEN WHERE MANV=@MANV ), 
       		TENNHOM=NAME
  	FROM sys.sysusers
    	WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)

GO
/****** Object:  StoredProcedure [dbo].[SP_DSBN_DangTheoDoi]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DSBN_DangTheoDoi]
@maBS varchar(6)
AS
BEGIN 
	SELECT * FROM BENHNHAN with(INDEX(IDX_BENHNHAN_BSTHEODOI)) WHERE BENHNHAN.MaBacSiTheoDoi = @maBS
	order by Ten, Ho
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraPhongCoGiuong]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_KiemTraPhongCoGiuong]
@SoGiuong int, @SoPhong int,@SoKhu int
AS
BEGIN

IF( EXISTS( SELECT * FROM GIUONGBENH WHERE SoGiuong = @SoGiuong AND SoPhong=@SoPhong And SoKhu=@SoKhu ) )
		RETURN 1;--TON TAI GIUONG
	RETURN 0;-- KHONG TON TAI
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_LayTenBenhNhan]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LayTenBenhNhan]
AS
BEGIN
SELECT T1.MaCTBSCTBN, T1.MaBenhNhan, HOTEN = T2.Ho + ' ' + T2.Ten 
	FROM CT_BACSI_CHUATRI_BENHNHAN T1
	INNER JOIN BENHNHAN T2 ON T1.MaBenhNhan = T2.MaBenhNhan
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LayThongTinDotChuaTri]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LayThongTinDotChuaTri]
@maCTBSCTBN INT
AS
BEGIN 
	SELECT t1.MaCTBSCTBN, t4.HoTen, t2.HoTen, t3.TenSuChuaTri, t1.NgayChuaTri 
	FROM (SELECT * FROM CT_BACSI_CHUATRI_BENHNHAN WHERE MaCTBSCTBN = @maCTBSCTBN) t1
	INNER JOIN (SELECT MaBenhNhan, HoTen = Ho + ' ' + Ten FROM BENHNHAN) t2 ON t1.MaBenhNhan = t2.MaBenhNhan
	INNER JOIN SUCHUATRI t3 ON t3.MaSuChuaTri = t1.MaSuChuaTri
	INNER JOIN (SELECT MaNV, HoTen = Ho + ' ' + Ten FROM NHANVIEN) t4 ON t4.MaNV = t1.MaBacSi
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_TaoTaiKhoan]
    @LGNAME VARCHAR(50),  @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)     
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'HOSPITAL'
  IF (@RET=1)  -- LOGIN NAME BI TRUNG
  BEGIN
     RAISERROR ('Login name bị trùng',16,1)
	 RETURN
  END 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET=1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RAISERROR ('Nhân viên đã có login name',16,2)
       RETURN
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE = 'YTATRUONG' 
  BEGIN
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  END
GO
/****** Object:  StoredProcedure [dbo].[SP_Them_SuChuaTri]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Them_SuChuaTri] @TenSCT NVARCHAR(100)
AS
BEGIN
	INSERT INTO SUCHUATRI(TenSuChuaTri) VALUES (@TenSCT)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemCTBSCTBN]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ThemCTBSCTBN]
@MaBS VARCHAR(6), @MaBenhNhan VARCHAR(10), @MaSuChuaTri VARCHAR(10), @NgayChuaTri date, @ThoiGianChuaTri int, @KetQua nvarchar(100)
AS
BEGIN
	INSERT INTO CT_BACSI_CHUATRI_BENHNHAN(MaBacSi, MaBenhNhan, MaSuChuaTri, NgayChuaTri, ThoiGianChuaTri, KetQua)
	VALUES(@MaBS, @MaBenhNhan, @MaSuChuaTri, @NgayChuaTri, @ThoiGianChuaTri, @KetQua)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ThongKeVTDaSDChoDotChuaTri]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ThongKeVTDaSDChoDotChuaTri]
@maCTBSCTBN INT
AS
BEGIN
	SELECT T1.MaVT, T2.MoTa, T1.ThoiGian, T1.SoLuong, T1.DonGia, TriGia =T1.SoLuong * T1.DonGia 
	FROM CT_HOADON T1
	INNER JOIN VATTU T2 ON T1.MaVT = T2.MaVT
	WHERE MaCTBSCTBN = @maCTBSCTBN

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Xoa_SuChuaTri]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Xoa_SuChuaTri] @TenSCT VARCHAR(100)
AS
BEGIN
	DELETE FROM SUCHUATRI WHERE TenSuChuaTri = @TenSCT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaCTBSCTBN]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaCTBSCTBN]
@MaCTBSCTBN int
AS
BEGIN
	DELETE FROM CT_BACSI_CHUATRI_BENHNHAN WHERE CT_BACSI_CHUATRI_BENHNHAN.MaCTBSCTBN =@MaCTBSCTBN
END	
GO
/****** Object:  StoredProcedure [dbo].[THONGKEBENHNHANNOITRUTHEONAMTHEOKHU]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[THONGKEBENHNHANNOITRUTHEONAMTHEOKHU]
@NAM INT, @KHU NVARCHAR(3)
AS
BEGIN
select DISTINCT  BN.MaBenhNhan,CONCAT(BN.Ho, ' ', BN.Ten) as HoTen, BN.NgaySinh 
from (select * from CT_BENHNHAN_GIUONG where YEAR(ngayBD) =@NAM) CT 
inner join	(select MaBenhNhan, Ho,Ten,NgaySinh from BENHNHAN ) BN on Ct.MaBenhNhan = BN.MaBenhNhan 
inner join (select MaGiuong,SoKhu from GIUONGBENH )  GB on GB.MaGiuong =CT.MaGiuong
where GB.SoKhu=@KHU

order by BN.MaBenhNhan
END
GO
/****** Object:  StoredProcedure [dbo].[THONGKEBENHNHANNOITRUTHEOTHANGTHEOKHU]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[THONGKEBENHNHANNOITRUTHEOTHANGTHEOKHU]
@THANG INT, @NAM INT, @KHU NVARCHAR(3)
AS
BEGIN
select DISTINCT BN.MaBenhNhan,CONCAT(BN.Ho, ' ', BN.Ten) as HoTen, BN.NgaySinh 
from (select * from CT_BENHNHAN_GIUONG where MONTH(ngayBD) =@THANG and YEAR(ngayBD) =@NAM) CT 
inner join	(select MaBenhNhan, Ho,Ten,NgaySinh from BENHNHAN ) BN on Ct.MaBenhNhan = BN.MaBenhNhan 
inner join (select MaGiuong,SoKhu from GIUONGBENH )  GB on GB.MaGiuong =CT.MaGiuong
where GB.SoKhu=@KHU
order by BN.MaBenhNhan
END
GO
/****** Object:  StoredProcedure [dbo].[THONGKEBENHNHANTHEONAM]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[THONGKEBENHNHANTHEONAM]
@LOAI bit ,@NAM int
as
begin
select DISTINCT MaBenhNhan,CONCAT(Ho, ' ', Ten) as HoTen,NgaySinh from BENHNHAN 
where MaLoai=@LOAI and MaBenhNhan IN (select MaBenhNhan from CT_BACSI_CHUATRI_BENHNHAN where YEAR(NgayChuaTri)=@NAM group by MaBenhNhan)
order by MaBenhNhan
end
GO
/****** Object:  StoredProcedure [dbo].[THONGKEBENHNHANTHEOTHANG]    Script Date: 7/10/2023 1:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[THONGKEBENHNHANTHEOTHANG]
@LOAI bit ,@THANG int,@NAM int
as
begin
select DISTINCT MaBenhNhan,CONCAT(Ho, ' ', Ten) as HoTen,NgaySinh from BENHNHAN 
where MaLoai=@LOAI and MaBenhNhan IN (select MaBenhNhan from CT_BACSI_CHUATRI_BENHNHAN where MONTH(NgayChuaTri)=@THANG and YEAR(NgayChuaTri)=@NAM group by MaBenhNhan)
order by MaBenhNhan
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "t1"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t2"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t4"
            Begin Extent = 
               Top = 462
               Left = 48
               Bottom = 625
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t3"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 126
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DS_TaiKhoan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_DS_TaiKhoan'
GO
USE [master]
GO
ALTER DATABASE [HOSPITAL] SET  READ_WRITE 
GO
