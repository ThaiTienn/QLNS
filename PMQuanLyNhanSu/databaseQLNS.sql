CREATE DATABASE dbQLNS
GO
USE [dbQLNS]
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaChamCong] [varchar](32) NOT NULL,
	[MaNV] [varchar](32) NOT NULL,
	[NgayChamCong] [date] NOT NULL,
	[GioVao] [nvarchar](32) NOT NULL,
	[GioRa] [nvarchar](32) NULL,
	[SoGioLam] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [varchar](32) NOT NULL,
	[TenCV] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhaiBaoPCNV]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhaiBaoPCNV](
	[Id] [varchar](32) NOT NULL,
	[MaNV] [varchar](32) NOT NULL,
	[MaPC] [varchar](32) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhaiBaoTPNV]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhaiBaoTPNV](
	[Id] [varchar](32) NOT NULL,
	[MaNV] [varchar](32) NOT NULL,
	[MaThuongPhat] [nvarchar](128) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[SoTien] [decimal](18, 0) NOT NULL,
	[Lydo] [nvarchar](128) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](32) NOT NULL,
	[HoTen] [nvarchar](60) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[CCCD] [char](20) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[SDT] [char](12) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[MaCV] [varchar](32) NOT NULL,
	[MaPB] [varchar](32) NOT NULL,
	[NgayVaoLam] [datetime] NOT NULL,
	[TrangThai] [nvarchar](32) NOT NULL,
	[LuongCoBan] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [varchar](32) NOT NULL,
	[TenPB] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuCap]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuCap](
	[MaPC] [varchar](32) NOT NULL,
	[TenPC] [nvarchar](50) NOT NULL,
	[TienPC] [float] NOT NULL,
	[NgayHieuLuc] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SoGioLam]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoGioLam](
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[SoGioLam] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [varchar](32) NOT NULL,
	[TenTK] [nvarchar](128) NOT NULL,
	[MatKhau] [varchar](256) NOT NULL,
	[DienThoai] [varchar](16) NULL,
	[DiaChi] [nvarchar](128) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhLuong]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhLuong](
	[MaNV] [varchar](32) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[TienPhuCap] [decimal](18, 0) NULL,
	[TienThuong] [decimal](18, 0) NULL,
	[TienPhat] [decimal](18, 0) NULL,
	[ThieuGioLam] [int] NULL,
	[TienPhatLamThieuGio] [decimal](18, 0) NULL,
	[TienLuong] [decimal](18, 0) NULL,
 CONSTRAINT [FK_TinhLuong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240401080344', N'duongxuanminh', CAST(N'2024-04-01' AS Date), N'8:3:44', N'17:4:34', 9)
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240401083018', N'duongxuanminh', CAST(N'2024-04-01' AS Date), N'8:30:18', N'17:0:56', 9)
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240402080315', N'duongxuanminh', CAST(N'2024-04-02' AS Date), N'8:3:15', N'17:3:35', 9)
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240414113143', N'NGUYENVUMANH', CAST(N'2024-04-14' AS Date), N'08:00:00', N'14:39:58', 6)
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240414113726', N'thaitien', CAST(N'2024-04-14' AS Date), N'08:00:00', N'1:1:15', -7)
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240416023837', N'lethithuy', CAST(N'2024-04-16' AS Date), N'14:38:37', N'20:34:1', 6)
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240420080022', N'thaitien', CAST(N'2024-04-20' AS Date), N'8:0:22', N'17:0:34', 9)
INSERT [dbo].[ChamCong] ([MaChamCong], [MaNV], [NgayChamCong], [GioVao], [GioRa], [SoGioLam]) VALUES (N'MCC_20240421080127', N'thaitien', CAST(N'2024-04-21' AS Date), N'8:1:27', N'17:1:41', 9)
GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'GIAMDOC', N'Giám đốc')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'KETOAN', N'Kế toán')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'KYTHUAT', N'Kỹ thuật')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'NHANSU', N'Nhân sự')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'NHANVIEN', N'Nhân viên')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'PHOGIAMDOC', N'Phó giám đốc')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'TAPVU', N'Tạp vụ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'TONGDAI', N'Tổng đài')
GO
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420013909', N'DINHTHITHANHHA', N'PHUCAPCOMTRUA', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420013922', N'DINHTHITHANHHA', N'PHUCAPHAOMONXE', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420013936', N'DUONGXUANMINH', N'PHUCAPHAOMONXE', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420013953', N'DUONGXUANMINH', N'PHUCAPCOMTRUA', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014007', N'LETHITHUY', N'PHUCAPCOMTRUA', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014016', N'LETHITHUY', N'PHUCAPHAOMONXE', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014025', N'LUONGTHINHUHIEN', N'PHUCAPHAOMONXE', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014032', N'LUONGTHINHUHIEN', N'PHUCAPCOMTRUA', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014109', N'NGUYENHUUHIEP', N'PHUCAPCOMTRUA', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014123', N'NGUYENHUUHIEP', N'PHUCAPCOMTRUA', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014524', N'THAITIEN', N'PHUCAPCOMTRUA', 4, 2024)
INSERT [dbo].[KhaiBaoPCNV] ([Id], [MaNV], [MaPC], [Thang], [Nam]) VALUES (N'PCNV_20240420014533', N'THAITIEN', N'PHUCAPHAOMONXE', 4, 2024)
GO
INSERT [dbo].[KhaiBaoTPNV] ([Id], [MaNV], [MaThuongPhat], [Thang], [Nam], [SoTien], [Lydo]) VALUES (N'TPNV_20240414115748', N'LETHITHUY', N'Thưởng', 4, 2024, CAST(300000 AS Decimal(18, 0)), N'Đạt KPI')
INSERT [dbo].[KhaiBaoTPNV] ([Id], [MaNV], [MaThuongPhat], [Thang], [Nam], [SoTien], [Lydo]) VALUES (N'TPNV_20240420014224', N'DUONGXUANMINH', N'Thưởng', 4, 2024, CAST(500000 AS Decimal(18, 0)), N'Đạt KPI')
INSERT [dbo].[KhaiBaoTPNV] ([Id], [MaNV], [MaThuongPhat], [Thang], [Nam], [SoTien], [Lydo]) VALUES (N'TPNV_20240420014551', N'THAITIEN', N'Phạt', 4, 2024, CAST(300000 AS Decimal(18, 0)), N'Làm hư phụ kiện')
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'DINHTHITHANHHA', N'Đinh Thị Thanh Hà', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nữ', N'123456789           ', N'dttha@gmail.com', N'123456789   ', N'An Giang', N'123', N'KETOAN', N'PHONGKETOAN', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'DUONGXUANMINH', N'Dương Xuân Minh', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nam', N'123456789           ', N'dxminh@gmail.com', N'123456789   ', N'Long Xuyên', N'123', N'GIAMDOC', N'BANGIAMDOC', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(20000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'LETHITHUY', N'Lê Thị Thùy', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nữ', N'123456789           ', N'ltthuy@gmail.com', N'123456899   ', N'Long Xuyên', N'123', N'KETOAN', N'PHONGKETOAN', CAST(N'2001-04-14T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(9000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'LUONGTHINHUHIEN', N'Lương Thị Như Hiền', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nữ', N'123456789           ', N'ltnhien@gmail.com', N'123456789   ', N'Chợ Mới', N'123', N'KETOAN', N'PHONGKETOAN', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(7000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'NGUYENDUONGPHUTHANH', N'Nguyễn Dương Phú Thạnh', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nam', N'123456789           ', N'ndpthanh@gmail.com', N'123456789   ', N'Long Xuyên', N'123', N'NHANSU', N'PHONGNHANSU', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(7000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'NGUYENHUUHIEP', N'Nguyễn Hữu Hiệp', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nam', N'123456789           ', N'nhhiep@gmail.com', N'123456789   ', N'Long Xuyên', N'123', N'PHOGIAMDOC', N'BANGIAMDOC', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(10000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'NGUYENTANDAT', N'Nguyễn Tấn Đạt', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nam', N'123456789           ', N'ntdat@gmail.com', N'123456789   ', N'Châu Đóc', N'123', N'KYTHUAT', N'PHONGKYTHUAT', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(7000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'NGUYENVANSON', N'Nguyễn Văn Sơn', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nam', N'123456789           ', N'nvson@gmail.com', N'123456789   ', N'Long Xuyên', N'123', N'NHANVIEN', N'PHONGNHANVIEN', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'NGUYENVUMANH', N'Nguyễn Vũ Mãnh', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nam', N'123456789           ', N'nvmanh@gmail.com', N'123456      ', N'Long Xuyên', N'123', N'NHANVIEN', N'PHONGNHANVIEN', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'THAITIEN', N'Thái Tiến', CAST(N'2002-12-11T00:00:00.000' AS DateTime), N'Nam', N'123456789           ', N'ttien@gmail.com', N'123456789   ', N'An Giang', N'123', N'NHANVIEN', N'PHONGNHANVIEN', CAST(N'2024-04-14T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(7000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'TRANDANGTHIYEUNHI', N'Trần Đặng Thị Yến Nhi', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nữ', N'123456              ', N'tdtynhi@gmail.com', N'123456789   ', N'Long Xuyên', N'123', N'TONGDAI', N'BP.TONGDAI', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CCCD], [Email], [SDT], [DiaChi], [Password], [MaCV], [MaPB], [NgayVaoLam], [TrangThai], [LuongCoBan]) VALUES (N'TRINHTHIBICHDAO', N'Trịnh Thị Bích Đào', CAST(N'1993-02-08T00:00:00.000' AS DateTime), N'Nữ', N'123456789           ', N'ttbdao@gmail.com', N'123456789   ', N'Long Xuyên', N'123', N'TAPVU', N'PHONGNHANVIEN', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'Đang làm việc', CAST(2000000 AS Decimal(18, 0)))
GO
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'BANGIAMDOC', N'Ban giám đốc')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'BP.TONGDAI', N'BP.Tổng đài')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'PHONGKETOAN', N'Phòng kế toán')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'PHONGKYTHUAT', N'Phòng kỹ thuật')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'PHONGNHANSU', N'Phòng nhân sự')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB]) VALUES (N'PHONGNHANVIEN', N'Phòng nhân viên')
GO
INSERT [dbo].[PhuCap] ([MaPC], [TenPC], [TienPC], [NgayHieuLuc]) VALUES (N'PHUCAPCOMTRUA', N'Phụ cấp cơm trưa', 750000, CAST(N'2024-01-03T00:00:00.000' AS DateTime))
INSERT [dbo].[PhuCap] ([MaPC], [TenPC], [TienPC], [NgayHieuLuc]) VALUES (N'PHUCAPHAOMONXE', N'Phụ cấp hao mồn xe', 260000, CAST(N'2024-01-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[SoGioLam] ([Thang], [Nam], [SoGioLam]) VALUES (4, 2024, 30)
GO
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [DienThoai], [DiaChi]) VALUES (N'ADMIN', N'Admin', N'123', N'123456789', N'Long xuyeen')
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [DienThoai], [DiaChi]) VALUES (N'QL', N'quản lý', N'123', N'', N'')
GO
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'DINHTHITHANHHA', 4, 2024, CAST(1010000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(6010000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'DUONGXUANMINH', 4, 2024, CAST(1010000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3, CAST(60000 AS Decimal(18, 0)), CAST(21450000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'LETHITHUY', 4, 2024, CAST(1010000 AS Decimal(18, 0)), CAST(300000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 24, CAST(480000 AS Decimal(18, 0)), CAST(9830000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'LUONGTHINHUHIEN', 4, 2024, CAST(1010000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(8010000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'NGUYENDUONGPHUTHANH', 4, 2024, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(7000000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'NGUYENHUUHIEP', 4, 2024, CAST(1500000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(11500000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'NGUYENTANDAT', 4, 2024, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(7000000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'NGUYENVANSON', 4, 2024, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'NGUYENVUMANH', 4, 2024, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 24, CAST(480000 AS Decimal(18, 0)), CAST(4520000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'THAITIEN', 4, 2024, CAST(1010000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(300000 AS Decimal(18, 0)), 19, CAST(380000 AS Decimal(18, 0)), CAST(7330000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'TRANDANGTHIYEUNHI', 4, 2024, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[TinhLuong] ([MaNV], [Thang], [Nam], [TienPhuCap], [TienThuong], [TienPhat], [ThieuGioLam], [TienPhatLamThieuGio], [TienLuong]) VALUES (N'TRINHTHIBICHDAO', 4, 2024, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, CAST(0 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)))
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhaiBaoPCNV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhaiBaoPCNV]  WITH CHECK ADD FOREIGN KEY([MaPC])
REFERENCES [dbo].[PhuCap] ([MaPC])
GO
ALTER TABLE [dbo].[KhaiBaoTPNV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[TinhLuong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
/****** Object:  StoredProcedure [dbo].[pr_BaoCaoLuong]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_BaoCaoLuong]
	 @MaNV VARCHAR(32),
	 @Thang int,
	 @Nam int
AS 
BEGIN
	IF @MaNV = 'ALL' BEGIN
		SELECT a.Thang,a.Nam,c.TenPB,d.TenCV,a.MaNV,b.HoTen,LuongCoBan,TienPhuCap,TienThuong,TienPhat,ThieuGioLam,TienPhatLamThieuGio,TienLuong
		FROM TinhLuong a INNER JOIN NhanVien b ON a.MaNV = b.MaNV
		INNER JOIN PhongBan c ON b.MaPB = c.MaPB
		INNER JOIN ChucVu d ON b.MaCV = d.MaCV
		WHERE Thang = @Thang AND Nam = @Nam
	END
	ELSE
		SELECT a.Thang,a.Nam,c.TenPB,d.TenCV,a.MaNV,b.HoTen,LuongCoBan,TienPhuCap,TienThuong,TienPhat,ThieuGioLam,TienPhatLamThieuGio,TienLuong
			FROM TinhLuong a INNER JOIN NhanVien b ON a.MaNV = b.MaNV
			INNER JOIN PhongBan c ON b.MaPB = c.MaPB
			INNER JOIN ChucVu d ON b.MaCV = d.MaCV
			WHERE a.MaNV = @MaNV and Thang = @Thang AND Nam = @Nam
END
GO
/****** Object:  StoredProcedure [dbo].[pr_TinhLuong]    Script Date: 20/04/2024 2:52:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pr_TinhLuong]
 @MaNV VARCHAR(32),
 @Thang int,
 @Nam int
AS
BEGIN
	DELETE TinhLuong WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @Nam

	DECLARE @TienPhuCap decimal = 0
	DECLARE @TienThuong decimal = 0
	DECLARE @TienPhat decimal = 0
	DECLARE @ThieuGioLam int = 0
	DECLARE @TienPhatLamThieuGio decimal = 0
	DECLARE @TienLuong decimal = 0
	SELECT * INTO #tmp FROM TinhLuong WHERE 1 = 0

	SET @TienPhuCap = (SELECT SUM(TienPC) FROM KhaiBaoPCNV a INNER JOIN PhuCap b ON a.MaPC = b.MaPC
	WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @Nam AND NgayHieuLuc <= GETDATE()
	GROUP BY MaNV,Thang,Nam)

	if @TienPhuCap is null begin set @TienPhuCap = 0 end

	SET @TienThuong = (SELECT SUM(SoTien) FROM KhaiBaoTPNV
	WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @Nam AND MaThuongPhat = N'Thưởng'
	GROUP BY MaNV,Thang,Nam)

	if @TienThuong is null begin set @TienThuong = 0 end

	SET @TienPhat = (SELECT SUM(SoTien) FROM KhaiBaoTPNV
	WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @Nam AND MaThuongPhat = N'Phạt'
	GROUP BY MaNV,Thang,Nam)

	if @TienPhat is null begin set @TienPhat = 0 end

	SET @ThieuGioLam = (SELECT SoGioLam FROM SoGioLam WHERE Thang = @Thang AND Nam = @Nam) 
	- (SELECT SUM(SoGioLAM) FROM ChamCong 
	WHERE MaNV = @MaNV AND MONTH(NgayChamCong) = @Thang AND YEAR(NgayChamCong) = @Nam)
	
	if @ThieuGioLam is null begin set @ThieuGioLam = 0 end
	if @ThieuGioLam < 0 begin set @ThieuGioLam = 0 end

	SET @TienPhatLamThieuGio = @ThieuGioLam * 20000

	SET @TienLuong = (SELECT LuongCoBan FROM NhanVien WHERE MaNV = @MaNV)
	+ @TienPhuCap + @TienThuong - @TienPhat - @TienPhatLamThieuGio

	if @TienLuong is null begin set @TienLuong = 0 end
	INSERT INTO #tmp VALUES (@MaNV,@Thang,@Nam,@TienPhuCap,@TienThuong,@TienPhat,@ThieuGioLam,@TienPhatLamThieuGio,@TienLuong)
	INSERT INTO TinhLuong
	SELECT * FROM #tmp
END
GO
