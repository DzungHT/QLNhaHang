USE [master]
GO
CREATE DATABASE [dbRestaurant]
GO
USE [dbRestaurant]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[NhanVienID] [int] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[BanAnID] [int] IDENTITY(1,1) NOT NULL,
	[TenBan] [nvarchar](50) NULL,
	[KhuVucID] [int] NULL,
	[TrangThaiID] [int] NULL,
 CONSTRAINT [PK_Banan] PRIMARY KEY CLUSTERED 
(
	[BanAnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDatBan]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatBan](
	[DatBanID] [int] NOT NULL,
	[MonAnID] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietDatBan] PRIMARY KEY CLUSTERED 
(
	[DatBanID] ASC,
	[MonAnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[HoaDonID] [int] NOT NULL,
	[MonAnID] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[HoaDonID] ASC,
	[MonAnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DatBan]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatBan](
	[DatBanID] [int] IDENTITY(1,1) NOT NULL,
	[BanAnID] [int] NULL,
	[NgayDatBan] [datetime] NULL,
 CONSTRAINT [PK_DatBan] PRIMARY KEY CLUSTERED 
(
	[DatBanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[HoaDonID] [int] IDENTITY(1,1) NOT NULL,
	[NhanVienID] [int] NOT NULL,
	[KhachHangID] [int] NULL,
	[NgayHoaDon] [datetime] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[HoaDonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[KhachHangID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[KhachHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[KhuVucID] [int] IDENTITY(1,1) NOT NULL,
	[TenKhuVuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khuvuc] PRIMARY KEY CLUSTERED 
(
	[KhuVucID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMonAn](
	[LoaiMonAnID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiMonAn] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loaimonan] PRIMARY KEY CLUSTERED 
(
	[LoaiMonAnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MonanID] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[LoaiMonAnID] [int] NULL,
	[SoLuongTon] [int] NULL,
	[TonToiThieu] [nchar](10) NULL,
 CONSTRAINT [PK_Monan] PRIMARY KEY CLUSTERED 
(
	[MonanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[NhanVienID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nchar](10) NULL,
	[GioiTinh] [bit] NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThaiBanAn]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiBanAn](
	[TrangThaiID] [int] NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrangThaiBanAn] PRIMARY KEY CLUSTERED 
(
	[TrangThaiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([Username], [Password], [NhanVienID]) VALUES (N'admin', N'e10adc3949ba59abbe56e057f20f883e', 1)
SET IDENTITY_INSERT [dbo].[BanAn] ON 

INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (1, N'Ban 1', 1, 0)
INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (2, N'Ban 2', 1, 1)
INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (3, N'Ban 3', 1, 0)
INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (4, N'Ban 4', 1, 0)
INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (5, N'Ban 5', 2, 0)
INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (6, N'Ban 6', 2, 1)
INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (7, N'Ban 7', 3, 0)
INSERT [dbo].[BanAn] ([BanAnID], [TenBan], [KhuVucID], [TrangThaiID]) VALUES (8, N'Ban 8', 4, 1)
SET IDENTITY_INSERT [dbo].[BanAn] OFF
INSERT [dbo].[ChiTietDatBan] ([DatBanID], [MonAnID], [SoLuong], [GhiChu]) VALUES (1, 1, 1, NULL)
INSERT [dbo].[ChiTietDatBan] ([DatBanID], [MonAnID], [SoLuong], [GhiChu]) VALUES (1, 6, 1, NULL)
INSERT [dbo].[ChiTietDatBan] ([DatBanID], [MonAnID], [SoLuong], [GhiChu]) VALUES (2, 4, 2, NULL)
INSERT [dbo].[ChiTietDatBan] ([DatBanID], [MonAnID], [SoLuong], [GhiChu]) VALUES (2, 7, 1, NULL)
INSERT [dbo].[ChiTietDatBan] ([DatBanID], [MonAnID], [SoLuong], [GhiChu]) VALUES (3, 8, 1, NULL)
SET IDENTITY_INSERT [dbo].[DatBan] ON 

INSERT [dbo].[DatBan] ([DatBanID], [BanAnID], [NgayDatBan]) VALUES (1, 2, CAST(N'2016-11-20 20:00:00.000' AS DateTime))
INSERT [dbo].[DatBan] ([DatBanID], [BanAnID], [NgayDatBan]) VALUES (2, 6, CAST(N'2016-11-21 20:00:00.000' AS DateTime))
INSERT [dbo].[DatBan] ([DatBanID], [BanAnID], [NgayDatBan]) VALUES (3, 8, CAST(N'2016-11-22 20:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[DatBan] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([KhachHangID], [HoTen], [SDT], [DiaChi]) VALUES (1, N'Nguyen Quang Huy', N'01234567891', N'Hn')
INSERT [dbo].[KhachHang] ([KhachHangID], [HoTen], [SDT], [DiaChi]) VALUES (2, N'Vuong Dang Doan', N'0987654321', N'Hn')
INSERT [dbo].[KhachHang] ([KhachHangID], [HoTen], [SDT], [DiaChi]) VALUES (3, N'Hoang Tri Dung', N'01667778888', N'Hn')
INSERT [dbo].[KhachHang] ([KhachHangID], [HoTen], [SDT], [DiaChi]) VALUES (4, N'Tran Trung Hieu', N'01643332211', N'Hn')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
SET IDENTITY_INSERT [dbo].[KhuVuc] ON 

INSERT [dbo].[KhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (1, N'Tang 1')
INSERT [dbo].[KhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (2, N'Tang 2')
INSERT [dbo].[KhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (3, N'Tang 3 ')
INSERT [dbo].[KhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (4, N'Tang 4')
SET IDENTITY_INSERT [dbo].[KhuVuc] OFF
SET IDENTITY_INSERT [dbo].[LoaiMonAn] ON 

INSERT [dbo].[LoaiMonAn] ([LoaiMonAnID], [TenLoaiMonAn]) VALUES (1, N'Ga')
INSERT [dbo].[LoaiMonAn] ([LoaiMonAnID], [TenLoaiMonAn]) VALUES (2, N'Bo')
INSERT [dbo].[LoaiMonAn] ([LoaiMonAnID], [TenLoaiMonAn]) VALUES (3, N'Lau')
SET IDENTITY_INSERT [dbo].[LoaiMonAn] OFF
SET IDENTITY_INSERT [dbo].[MonAn] ON 

INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (1, N'Gà rang muối', N'Đĩa', 100, 1, 100, N'10        ')
INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (2, N'Gà luộc ', N'Con', 200, 1, 100, N'10        ')
INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (3, N'Súp gà', N'Bát', 10, 1, 300, N'10        ')
INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (4, N'Sốt vang', N'Bát', 80, 2, 200, N'10        ')
INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (5, N'Bò hấp xả', N'Đĩa', 90, 2, 150, N'10        ')
INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (6, N'Lẩu gà', N'Nồi', 300, 3, 300, N'10        ')
INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (7, N'Lẩu đuôi bò', N'Nồi', 350, 3, 300, N'10        ')
INSERT [dbo].[MonAn] ([MonanID], [TenMonAn], [DonViTinh], [DonGia], [LoaiMonAnID], [SoLuongTon], [TonToiThieu]) VALUES (8, N'Lẩu ếch', N'Nồi', 350, 3, 200, N'20        ')
SET IDENTITY_INSERT [dbo].[MonAn] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([NhanVienID], [HoTen], [SDT], [DiaChi], [Email], [GioiTinh]) VALUES (1, N'Administrator', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
INSERT [dbo].[TrangThaiBanAn] ([TrangThaiID], [TenTrangThai]) VALUES (0, N'Còn trống')
INSERT [dbo].[TrangThaiBanAn] ([TrangThaiID], [TenTrangThai]) VALUES (1, N'Đã đặt')
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Nhanvien] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Nhanvien]
GO
ALTER TABLE [dbo].[BanAn]  WITH CHECK ADD  CONSTRAINT [FK_Banan_Khuvuc] FOREIGN KEY([KhuVucID])
REFERENCES [dbo].[KhuVuc] ([KhuVucID])
GO
ALTER TABLE [dbo].[BanAn] CHECK CONSTRAINT [FK_Banan_Khuvuc]
GO
ALTER TABLE [dbo].[BanAn]  WITH CHECK ADD  CONSTRAINT [FK_BanAn_TrangThaiBanAn] FOREIGN KEY([TrangThaiID])
REFERENCES [dbo].[TrangThaiBanAn] ([TrangThaiID])
GO
ALTER TABLE [dbo].[BanAn] CHECK CONSTRAINT [FK_BanAn_TrangThaiBanAn]
GO
ALTER TABLE [dbo].[ChiTietDatBan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatBan_DatBan] FOREIGN KEY([DatBanID])
REFERENCES [dbo].[DatBan] ([DatBanID])
GO
ALTER TABLE [dbo].[ChiTietDatBan] CHECK CONSTRAINT [FK_ChiTietDatBan_DatBan]
GO
ALTER TABLE [dbo].[ChiTietDatBan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatBan_Monan] FOREIGN KEY([MonAnID])
REFERENCES [dbo].[MonAn] ([MonanID])
GO
ALTER TABLE [dbo].[ChiTietDatBan] CHECK CONSTRAINT [FK_ChiTietDatBan_Monan]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([HoaDonID])
REFERENCES [dbo].[HoaDon] ([HoaDonID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Monan] FOREIGN KEY([MonAnID])
REFERENCES [dbo].[MonAn] ([MonanID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Monan]
GO
ALTER TABLE [dbo].[DatBan]  WITH CHECK ADD  CONSTRAINT [FK_DatBan_Banan] FOREIGN KEY([BanAnID])
REFERENCES [dbo].[BanAn] ([BanAnID])
GO
ALTER TABLE [dbo].[DatBan] CHECK CONSTRAINT [FK_DatBan_Banan]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([KhachHangID])
REFERENCES [dbo].[KhachHang] ([KhachHangID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Nhanvien] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Nhanvien]
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_Monan_Loaimonan] FOREIGN KEY([LoaiMonAnID])
REFERENCES [dbo].[LoaiMonAn] ([LoaiMonAnID])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_Monan_Loaimonan]
GO
/****** Object:  StoredProcedure [dbo].[sp_Account_Login]    Script Date: 11/22/2016 14:49:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Account_Login]
@Username varchar(100),
@Password varchar(32)
AS
BEGIN
	SELECT nv.*, a.Username FROM Account a 
	INNER JOIN NhanVien nv ON a.NhanVienID = nv.NhanVienID
	WHERE a.[Username] = @Username AND a.[Password] = @Password
END

GO
