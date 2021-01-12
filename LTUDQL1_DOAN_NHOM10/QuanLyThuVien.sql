CREATE DATABASE QuanLyThuVien
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[BANGCAP]    Script Date: 10/01/2020 9:27:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGCAP](
	[MaBangCap] [varchar](4) NOT NULL,
	[LoaiBangCap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BANGCAP] PRIMARY KEY CLUSTERED 
(
	[MaBangCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBoPhan] [varchar](4) NOT NULL,
	[TenBoPhan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [varchar](4) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUMUON](
	[MaPM] [varchar](10) NOT NULL,
	[MaSach] [varchar](8) NOT NULL,
 CONSTRAINT [PK_CT_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUTHANHLY]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUTHANHLY](
	[MaPhieuThanhLy] [varchar](10) NOT NULL,
	[MaSach] [varchar](8) NOT NULL,
	[MaLyDoThanhLy] [varchar](10) NOT NULL,
 CONSTRAINT [PK_CT_PHIEUTHANHLY] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThanhLy] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUTRA]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUTRA](
	[MaPT] [varchar](10) NOT NULL,
	[MaSach] [varchar](8) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[SoNgayMuon] [int] NOT NULL,
	[TienPhat] [float] NOT NULL,
 CONSTRAINT [PK_CT_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDocGia] [varchar](6) NOT NULL,
	[HoTenDG] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[TongNo] [float] NULL,
	[NgayLapThe] [date] NULL,
	[NgayHetHan] [date] NULL,
	[NVLapThe] [varchar](6) NULL,
	[MaLoaiDG] [varchar](6) NULL,
	[TTDG] [varchar](6) NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDOCGIA]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDOCGIA](
	[MaLoaiDG] [varchar](6) NOT NULL,
	[TenLoaiDG] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LOAIDOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LYDOTHANHLY]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LYDOTHANHLY](
	[MaLyDoThanhLy] [varchar](10) NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_LYDOTHANHLY] PRIMARY KEY CLUSTERED 
(
	[MaLyDoThanhLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATSACH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATSACH](
	[MaGNMatSach] [varchar](8) NOT NULL,
	[MaSach] [varchar](8) NOT NULL,
	[NgayGhiNhan] [date] NOT NULL,
	[MaDG] [varchar](6) NOT NULL,
	[TienPhat] [float] NOT NULL,
	[MaNV] [varchar](6) NOT NULL,
 CONSTRAINT [PK_MATSACH] PRIMARY KEY CLUSTERED 
(
	[MaGNMatSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [varchar](6) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DienThoai] [varchar](10) NOT NULL,
	[MaBangCap] [varchar](4) NOT NULL,
	[MaChucVu] [varchar](4) NOT NULL,
	[MaBoPhan] [varchar](4) NOT NULL,
	[MaTTNV] [varchar](6) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [varchar](10) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUONSACH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUONSACH](
	[MaPM] [varchar](10) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[MaDG] [varchar](6) NOT NULL,
	[NgayHetHan] [date] NOT NULL,
 CONSTRAINT [PK_PHIEUMUONSACH] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUTIENPHAT]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUTIENPHAT](
	[MaPhieuThu] [varchar](10) NOT NULL,
	[MaNV] [varchar](6) NOT NULL,
	[SoTienThu] [float] NOT NULL,
	[NgayThu] [date] NOT NULL,
	[MaPT] [varchar](10) NULL,
	[ConLai] [float] NULL,
 CONSTRAINT [PK_PHIEUTHUTIENPHAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTRASACH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRASACH](
	[MaPT] [varchar](10) NOT NULL,
	[NgayTra] [date] NOT NULL,
	[MaPM] [varchar](10) NOT NULL,
	[TienPhatKyNay] [float] NOT NULL,
	[TienNo] [float] NOT NULL,
	[SoNgayTraTre] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUTRASACH] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYDINH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYDINH](
	[TuoiToiThieu] [int] NOT NULL,
	[TuoiToiDa] [int] NOT NULL,
	[GiaTriThe] [int] NOT NULL,
	[SoNamXB] [int] NOT NULL,
	[SoSachMuonToiDa] [int] NOT NULL,
	[SoNgayMuonToiDa] [int] NOT NULL,
	[TienPhatTraTre] [int] NOT NULL,
 CONSTRAINT [PK_TuoiToiThieu] PRIMARY KEY CLUSTERED 
(
	[TuoiToiThieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [varchar](8) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[NgayXuatBan] [date] NOT NULL,
	[MaTacGia] [varchar](10) NOT NULL,
	[MaTheLoai] [varchar](10) NOT NULL,
	[MaNXB] [varchar](10) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[MaNVTiepNhan] [varchar](6) NOT NULL,
	[GiaTien] [int] NOT NULL,
	[Ke] [int] NOT NULL,
	[TTS] [varchar](8) NOT NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTacGia] [varchar](10) NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANHLYSACH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANHLYSACH](
	[MaPhieuThanhLy] [varchar](10) NOT NULL,
	[MaNV] [varchar](6) NOT NULL,
	[NgayThanhLy] [date] NOT NULL,
 CONSTRAINT [PK_THANHLYSACH] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThanhLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAISACH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAISACH](
	[MaTheLoai] [varchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_THELOAISACH] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANGDOCGIA]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANGDOCGIA](
	[MaTinhTrangDG] [varchar](6) NOT NULL,
	[LoaiTinhTrangDG] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TINHTRANGDOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrangDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANGNHANVIEN]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANGNHANVIEN](
	[MaTinhTrangNV] [varchar](6) NOT NULL,
	[LoaiTinhTrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TINHTRANGNHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrangNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANGSACH]    Script Date: 10/01/2020 9:27:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANGSACH](
	[MaTTSach] [varchar](8) NOT NULL,
	[TenTinhTrang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TINHTRANGSACH] PRIMARY KEY CLUSTERED 
(
	[MaTTSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BANGCAP] ([MaBangCap], [LoaiBangCap]) VALUES (N'BC01', N'Tú tài')
INSERT [dbo].[BANGCAP] ([MaBangCap], [LoaiBangCap]) VALUES (N'BC02', N'Trung cấp')
INSERT [dbo].[BANGCAP] ([MaBangCap], [LoaiBangCap]) VALUES (N'BC03', N'Cao đẳng')
INSERT [dbo].[BANGCAP] ([MaBangCap], [LoaiBangCap]) VALUES (N'BC04', N'Đại học')
INSERT [dbo].[BANGCAP] ([MaBangCap], [LoaiBangCap]) VALUES (N'BC05', N'Thạc sĩ')
INSERT [dbo].[BANGCAP] ([MaBangCap], [LoaiBangCap]) VALUES (N'BC06', N'Tiến sĩ')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan]) VALUES (N'BP01', N'Ban giám đốc')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan]) VALUES (N'BP02', N'Thủ thư')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan]) VALUES (N'BP03', N'Thủ kho')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan]) VALUES (N'BP04', N'Thủ quỷ')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'CV01', N'Giám đốc')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'CV02', N'Phó giám đốc')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'CV03', N'Trưởng phòng')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'CV04', N'Phó phòng')
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu]) VALUES (N'CV05', N'Nhân viên')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM001', N'S003')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM002', N'S002')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM003', N'S003')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM004', N'S012')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM005', N'S003')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM006', N'S002')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM007', N'S004')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM008', N'S005')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM009', N'S002')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM010', N'S001')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM011', N'S001')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM012', N'S007')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM013', N'S006')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM014', N'S008')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM015', N'S015')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM016', N'S001')
INSERT [dbo].[CT_PHIEUMUON] ([MaPM], [MaSach]) VALUES (N'PM017', N'S019')
INSERT [dbo].[CT_PHIEUTHANHLY] ([MaPhieuThanhLy], [MaSach], [MaLyDoThanhLy]) VALUES (N'PTLS001', N'S002', N'LDTL002')
INSERT [dbo].[CT_PHIEUTHANHLY] ([MaPhieuThanhLy], [MaSach], [MaLyDoThanhLy]) VALUES (N'PTLS002', N'S001', N'LDTL001')
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT001', N'S003', CAST(N'2019-05-22' AS Date), 4, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT002', N'S002', CAST(N'2019-05-04' AS Date), 12, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT003', N'S003', CAST(N'2018-05-05' AS Date), 3, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT004', N'S012', CAST(N'2019-08-07' AS Date), 4, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT005', N'S003', CAST(N'2019-05-04' AS Date), 2, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT006', N'S002', CAST(N'2019-05-26' AS Date), 3, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT007', N'S004', CAST(N'2018-07-03' AS Date), 4, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT008', N'S005', CAST(N'2019-07-06' AS Date), 3, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT009', N'S002', CAST(N'2019-08-04' AS Date), 4, 0)
INSERT [dbo].[CT_PHIEUTRA] ([MaPT], [MaSach], [NgayMuon], [SoNgayMuon], [TienPhat]) VALUES (N'PT010', N'S001', CAST(N'2017-09-09' AS Date), 4, 0)
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0001', N'Đinh Thành An', CAST(N'1997-05-22' AS Date), N'11 Nguyễn Văn Cừ', N'NVWW@gmail.com', 0, CAST(N'2015-05-22' AS Date), CAST(N'2015-11-22' AS Date), N'NV0015', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0002', N'Lê Văn Đại', CAST(N'1997-06-04' AS Date), N'55 Tô Hiến Thành', N'DaiVan@gmail.com', 20000, CAST(N'2017-01-04' AS Date), CAST(N'2017-01-10' AS Date), N'NV0011', N'LDG2', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0003', N'Nguyễn Thuỳ Anh', CAST(N'1992-06-04' AS Date), N'11 Nguyễn Cư Trinh', N'NCT@gmail.com', 0, CAST(N'2018-03-06' AS Date), CAST(N'2018-09-06' AS Date), N'NV0011', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0004', N'Nguyễn Kim Cúc', CAST(N'1997-05-22' AS Date), N'46 Nguyễn Oanh', N'NKC@gmail.com', 0, CAST(N'2015-06-12' AS Date), CAST(N'2015-12-12' AS Date), N'NV0015', N'LDG2', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0005', N'Hồ Văn Hùng', CAST(N'1999-07-12' AS Date), N'146 Huỳnh Tấn Phát', N'VanHung@gmail.com', 50000, CAST(N'2019-01-01' AS Date), CAST(N'2019-07-01' AS Date), N'NV0015', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0006', N'Lê Văn Chúng', CAST(N'1997-06-01' AS Date), N'78 Ngô Gia Tự', N'LeVanChung@gmail.com', 0, CAST(N'2015-06-04' AS Date), CAST(N'2015-12-04' AS Date), N'NV0011', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0007', N'Phùng Hạ Anh', CAST(N'1992-12-06' AS Date), N'88 Xuân Hưng', N'PHA@gmail.com', 0, CAST(N'2018-01-12' AS Date), CAST(N'2019-11-05' AS Date), N'NV0015', N'LDG2', N'TTDG02')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0008', N'Nguyễn Công Hoàng', CAST(N'1998-06-12' AS Date), N'190 CMT8', N'NCH@gmail.com', 0, CAST(N'2017-01-22' AS Date), CAST(N'2017-07-22' AS Date), N'NV0011', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0009', N'Vũ Thị Kim Anh', CAST(N'1997-09-06' AS Date), N'228 Lã Thanh Nhàn', N'VTKA@gmail.com', 0, CAST(N'2019-05-08' AS Date), CAST(N'2019-11-08' AS Date), N'NV0011', N'LDG2', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0010', N'Lê Thị Kim Huệ', CAST(N'1999-05-09' AS Date), N'326 Mai Chí Thọ', N'LTKH@gmail.com', 88000, CAST(N'2015-05-22' AS Date), CAST(N'2015-11-22' AS Date), N'NV0011', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0011', N'Hà Gia Thành', CAST(N'1997-05-22' AS Date), N'18 Lữ Gia', N'HGT@gmail.com', 0, CAST(N'2015-05-22' AS Date), CAST(N'2015-11-22' AS Date), N'NV0015', N'LDG1', N'TTDG02')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0012', N'Lương Thành Danh', CAST(N'1999-04-04' AS Date), N'98 Điện Biên Phủ', N'TTTDAH@gmail.com', 10000, CAST(N'2018-03-04' AS Date), CAST(N'2018-09-04' AS Date), N'NV0015', N'LDG2', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0013', N'Nguyễn Hoàng Anh Tuấn', CAST(N'1991-06-25' AS Date), N'101 Trường Chinh', N'NAnhTuan@gmail.com', 0, CAST(N'2019-05-22' AS Date), CAST(N'2019-11-22' AS Date), N'NV0015', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0014', N'Phạm Kim Yến', CAST(N'1992-07-04' AS Date), N'77 Hoàng Văn Thụ', N'YenKim@gmail.com', 0, CAST(N'2019-11-08' AS Date), CAST(N'2019-04-08' AS Date), N'NV0015', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0015', N'Lê Thanh Bình', CAST(N'1994-01-12' AS Date), N'15 Cộng Hoà', N'icarus@gmail.com', 0, CAST(N'2019-05-06' AS Date), CAST(N'2019-11-06' AS Date), N'NV0015', N'LDG1', N'TTDG01')
INSERT [dbo].[DOCGIA] ([MaDocGia], [HoTenDG], [NgaySinh], [DiaChi], [Email], [TongNo], [NgayLapThe], [NgayHetHan], [NVLapThe], [MaLoaiDG], [TTDG]) VALUES (N'DG0016', N'Ngô Tiến Thiện', CAST(N'2020-01-10' AS Date), N'Bình Thạnh', N'ThienNgo@gmail.com', 0, CAST(N'2020-01-10' AS Date), CAST(N'2020-07-10' AS Date), N'NV0011', N'LDG1', N'TTDG01')
INSERT [dbo].[LOAIDOCGIA] ([MaLoaiDG], [TenLoaiDG]) VALUES (N'LDG1', N'X')
INSERT [dbo].[LOAIDOCGIA] ([MaLoaiDG], [TenLoaiDG]) VALUES (N'LDG2', N'Y')
INSERT [dbo].[LYDOTHANHLY] ([MaLyDoThanhLy], [MoTa]) VALUES (N'LDTL001', N'Mất')
INSERT [dbo].[LYDOTHANHLY] ([MaLyDoThanhLy], [MoTa]) VALUES (N'LDTL002', N'Người dùng làm mất')
INSERT [dbo].[LYDOTHANHLY] ([MaLyDoThanhLy], [MoTa]) VALUES (N'LDTL003', N'Hư hỏng')
INSERT [dbo].[MATSACH] ([MaGNMatSach], [MaSach], [NgayGhiNhan], [MaDG], [TienPhat], [MaNV]) VALUES (N'SM001', N'S002', CAST(N'2019-12-22' AS Date), N'DG0001', 90000, N'NV0015')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0001', N'Nguyễn Xuân Phúc', N'132 Lê Đại Hành', CAST(N'1965-05-25' AS Date), N'012346789', N'BC05', N'CV01', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0002', N'Nguyễn Phú Trọng', N'123 Lê Lợi', CAST(N'1961-06-08' AS Date), N'09364789', N'BC05', N'CV02', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0003', N'Nguyễn Thị Kim Ngân', N'245 Trần Bình Trọng', CAST(N'1969-05-24' AS Date), N'096693459', N'BC05', N'CV02', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0004', N'Ngô Xuân Lịch', N'7 Nguyễn Tri Phương', CAST(N'1966-11-14' AS Date), N'097455634', N'BC04', N'CV03', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0005', N'Tô Lâm', N'47 Phạm Văn Đồng', CAST(N'1960-12-25' AS Date), N'064135447', N'BC03', N'CV04', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0006', N'Phùng Xuân Nhạ', N'227 Nguyễn Văn cừ', CAST(N'1963-06-03' AS Date), N'097854874', N'BC03', N'CV04', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0007', N'Bùi Văn Ga', N'487 Lê Hồng Phong', CAST(N'1965-10-21' AS Date), N'0987636545', N'BC03', N'CV03', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0008', N'Phạm Mạnh Hùng', N'345 Trần Đại Nghĩa', CAST(N'1964-06-12' AS Date), N'0968675213', N'BC03', N'CV04', N'BP01', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0009', N'Nguyễn Tấn Dũng', N'123 Đào Duy Từ', CAST(N'1960-10-30' AS Date), N'0989698697', N'BC05', N'CV01', N'BP01', N'TTNV03')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0010', N'Trần Tuấn Anh', N'74 Sư Vạn Hạnh', CAST(N'1959-05-25' AS Date), N'0987236541', N'BC01', N'CV04', N'BP03', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0011', N'Trịnh Xuân Thanh', N'23 Nguyễn Thương Hiền', CAST(N'1970-05-25' AS Date), N'012346789', N'BC01', N'CV04', N'BP02', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0012', N'Đinh La Thăng', N'125 Nguyễn Chí Thah', CAST(N'1971-05-24' AS Date), N'096363634', N'BC02', N'CV04', N'BP03', N'TTNV02')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0013', N'Phùng Đình Thực', N'132 Hùng Vương', CAST(N'1963-07-25' AS Date), N'0979797979', N'BC03', N'CV04', N'BP04', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0014', N'Nguyễn Xuân Sơn', N'132 Hùng Vương', CAST(N'1962-05-25' AS Date), N'0969696969', N'BC02', N'CV04', N'BP04', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0015', N'Vũ Đức Thuận', N'132 Hùng Vương', CAST(N'1962-05-25' AS Date), N'0969696969', N'BC02', N'CV04', N'BP02', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0016', N'Vũ Hồng Chương', N'132 Hùng Vương', CAST(N'1965-05-25' AS Date), N'0979797979', N'BC01', N'CV04', N'BP03', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0017', N'Ninh Văn Quỳnh', N'132 Hùng Vương', CAST(N'1965-05-25' AS Date), N'0979797979', N'BC01', N'CV04', N'BP04', N'TTNV01')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0018', N'Tần Văn Nguyên', N'132 Hùng Vương', CAST(N'1965-05-25' AS Date), N'0979797979', N'BC01', N'CV04', N'BP04', N'TTNV03')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0019', N'Nguyễn Ngọc Quý', N'132 Hùng Vương', CAST(N'1965-05-25' AS Date), N'0979797979', N'BC01', N'CV04', N'BP04', N'TTNV03')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0020', N'Phạm Tiến Đạt', N'132 Hùng Vương', CAST(N'1965-05-25' AS Date), N'0979797979', N'BC01', N'CV04', N'BP04', N'TTNV02')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [HoTenNV], [DiaChi], [NgaySinh], [DienThoai], [MaBangCap], [MaChucVu], [MaBoPhan], [MaTTNV]) VALUES (N'NV0021', N'Văn Sơn', N'135 Trần Hưng Đạo', CAST(N'2020-01-15' AS Date), N'0962555654', N'BC01', N'CV01', N'BP01', N'TTNV01')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB001', N'Kim Đồng')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB002', N'Tuổi trẻ')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB003', N'NXB giáo dục-đào tạo')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB004', N'NXB khoa học')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB005', N'NXB tổng hợp')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB006', N'NXB chính trị quốc gia')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB007', N'NXB Hội nhà văn')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB008', N'NXB thông tin truyền thông')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB]) VALUES (N'NXB009', N'NXB lao động')
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM001', CAST(N'2019-05-22' AS Date), N'DG0001', CAST(N'2019-05-26' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM002', CAST(N'2019-05-04' AS Date), N'DG0002', CAST(N'2019-05-08' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM003', CAST(N'2018-05-05' AS Date), N'DG0003', CAST(N'2018-05-09' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM004', CAST(N'2019-08-07' AS Date), N'DG0004', CAST(N'2019-08-11' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM005', CAST(N'2019-05-04' AS Date), N'DG0005', CAST(N'2019-05-08' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM006', CAST(N'2019-06-22' AS Date), N'DG0006', CAST(N'2019-05-26' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM007', CAST(N'2018-07-03' AS Date), N'DG0007', CAST(N'2018-07-07' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM008', CAST(N'2019-07-06' AS Date), N'DG0008', CAST(N'2019-07-10' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM009', CAST(N'2019-08-04' AS Date), N'DG0001', CAST(N'2019-08-08' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM010', CAST(N'2017-09-09' AS Date), N'DG0002', CAST(N'2017-09-13' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM011', CAST(N'2018-08-12' AS Date), N'DG0010', CAST(N'2018-08-16' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM012', CAST(N'2019-05-01' AS Date), N'DG0011', CAST(N'2019-05-05' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM013', CAST(N'2019-05-05' AS Date), N'DG0013', CAST(N'2019-05-09' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM014', CAST(N'2019-07-22' AS Date), N'DG0011', CAST(N'2019-07-26' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM015', CAST(N'2018-05-11' AS Date), N'DG0002', CAST(N'2018-05-15' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM016', CAST(N'2020-01-10' AS Date), N'DG0001', CAST(N'2020-01-14' AS Date))
INSERT [dbo].[PHIEUMUONSACH] ([MaPM], [NgayMuon], [MaDG], [NgayHetHan]) VALUES (N'PM017', CAST(N'2020-01-10' AS Date), N'DG0001', CAST(N'2020-01-14' AS Date))
INSERT [dbo].[PHIEUTHUTIENPHAT] ([MaPhieuThu], [MaNV], [SoTienThu], [NgayThu], [MaPT], [ConLai]) VALUES (N'PTTP001', N'NV0019', 10000, CAST(N'2018-12-28' AS Date), N'PT005', 10000)
INSERT [dbo].[PHIEUTHUTIENPHAT] ([MaPhieuThu], [MaNV], [SoTienThu], [NgayThu], [MaPT], [ConLai]) VALUES (N'PTTP002', N'NV0014', 20000, CAST(N'2020-01-10' AS Date), N'PT008', -10000)
INSERT [dbo].[PHIEUTHUTIENPHAT] ([MaPhieuThu], [MaNV], [SoTienThu], [NgayThu], [MaPT], [ConLai]) VALUES (N'PTTP003', N'NV0014', 10000, CAST(N'2020-01-10' AS Date), N'PT005', 10000)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT001', CAST(N'2019-05-28' AS Date), N'PM001', 0, 0, 0)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT002', CAST(N'2019-06-10' AS Date), N'PM002', 0, 0, 0)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT003', CAST(N'2018-05-05' AS Date), N'PM003', 3000, 0, 3)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT004', CAST(N'2019-09-12' AS Date), N'PM004', 0, 0, 0)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT005', CAST(N'2019-05-10' AS Date), N'PM005', 5000, 10000, 5)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT006', CAST(N'2019-07-22' AS Date), N'PM006', 0, 0, 0)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT007', CAST(N'2019-10-10' AS Date), N'PM007', 0, 0, 0)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT008', CAST(N'2020-01-12' AS Date), N'PM008', 6000, -10000, 2)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT009', CAST(N'2019-01-01' AS Date), N'PM009', 0, 0, 0)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT010', CAST(N'2019-12-22' AS Date), N'PM010', 0, 0, 0)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT011', CAST(N'2020-01-10' AS Date), N'PM016', 664008000, 664008000, 664008)
INSERT [dbo].[PHIEUTRASACH] ([MaPT], [NgayTra], [MaPM], [TienPhatKyNay], [TienNo], [SoNgayTraTre]) VALUES (N'PT012', CAST(N'2020-01-10' AS Date), N'PM017', 664008000, 664008000, 664008)
INSERT [dbo].[QUYDINH] ([TuoiToiThieu], [TuoiToiDa], [GiaTriThe], [SoNamXB], [SoSachMuonToiDa], [SoNgayMuonToiDa], [TienPhatTraTre]) VALUES (18, 55, 6, 8, 5, 4, 1000)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S001', N'Vũ trụ lớn thế nào?', CAST(N'2009-01-22' AS Date), N'TG002', N'TLS004', N'NXB004', CAST(N'2019-05-04' AS Date), N'NV0016', 150000, 1, N'TTS03')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S0017', N'Bí kiếp làm giàu?', CAST(N'2016-12-07' AS Date), N'TG003', N'TLS001', N'NXB001', CAST(N'2019-12-04' AS Date), N'NV0016', 90000, 2, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S002', N'Mắt biếc', CAST(N'1999-02-04' AS Date), N'TG001', N'TLS006', N'NXB001', CAST(N'2019-05-04' AS Date), N'NV0016', 90000, 2, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S003', N'Cây chuối non đi giày xanh', CAST(N'1999-02-04' AS Date), N'TG001', N'TLS005', N'NXB005', CAST(N'2019-05-04' AS Date), N'NV0016', 850000, 1, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S004', N'Hạ đỏ', CAST(N'1990-08-01' AS Date), N'TG001', N'TLS002', N'NXB001', CAST(N'2019-05-04' AS Date), N'NV0016', 650000, 1, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S005', N'Nhà giả kim', CAST(N'2016-12-07' AS Date), N'TG003', N'TLS004', N'NXB001', CAST(N'2019-12-04' AS Date), N'NV0016', 90000, 2, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S006', N'Nghệ thuật tinh tế của giao tiếp', CAST(N'2013-03-12' AS Date), N'TG006', N'TLS002', N'NXB002', CAST(N'2018-07-12' AS Date), N'NV0016', 850000, 1, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S007', N'Doremon', CAST(N'2009-01-22' AS Date), N'TG002', N'TLS004', N'NXB004', CAST(N'2019-05-04' AS Date), N'NV0016', 150000, 2, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S008', N'Conan', CAST(N'1999-02-04' AS Date), N'TG001', N'TLS006', N'NXB001', CAST(N'2019-05-04' AS Date), N'NV0016', 90000, 2, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S009', N'Hoàng tử bé', CAST(N'1999-02-04' AS Date), N'TG001', N'TLS005', N'NXB005', CAST(N'2019-05-04' AS Date), N'NV0016', 850000, 1, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S010', N'Bí kiếp luyện rồng', CAST(N'1990-08-01' AS Date), N'TG001', N'TLS002', N'NXB001', CAST(N'2019-05-04' AS Date), N'NV0016', 650000, 1, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S011', N'Sinh tồn', CAST(N'2016-12-07' AS Date), N'TG003', N'TLS006', N'NXB001', CAST(N'2019-12-04' AS Date), N'NV0016', 90000, 2, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S012', N'Nhà kinh tế mới', CAST(N'2013-03-12' AS Date), N'TG002', N'TLS002', N'NXB003', CAST(N'2018-07-12' AS Date), N'NV0016', 850000, 1, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S013', N'Đắc nhân tâm', CAST(N'2009-01-22' AS Date), N'TG002', N'TLS004', N'NXB003', CAST(N'2019-05-04' AS Date), N'NV0016', 150000, 1, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S014', N'Âm nhạc và cuộc sống', CAST(N'1999-02-04' AS Date), N'TG001', N'TLS004', N'NXB001', CAST(N'2019-05-04' AS Date), N'NV0016', 90000, 2, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S015', N'Tôi là ai?', CAST(N'1999-02-04' AS Date), N'TG001', N'TLS005', N'NXB002', CAST(N'2019-05-04' AS Date), N'NV0016', 850000, 2, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S016', N'Tuổi trẻ đáng giá bao nhiêu?', CAST(N'1990-08-01' AS Date), N'TG006', N'TLS002', N'NXB001', CAST(N'2019-05-04' AS Date), N'NV0016', 650000, 1, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S018', N'Tam quốc chí', CAST(N'2013-03-12' AS Date), N'TG006', N'TLS002', N'NXB004', CAST(N'2018-07-12' AS Date), N'NV0016', 850000, 5, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S019', N'Chính trị quốc gia', CAST(N'2009-01-22' AS Date), N'TG002', N'TLS004', N'NXB004', CAST(N'2019-05-04' AS Date), N'NV0016', 150000, 3, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S020', N'Nghệ thuật quân sự', CAST(N'1999-02-04' AS Date), N'TG001', N'TLS006', N'NXB001', CAST(N'2019-05-04' AS Date), N'NV0016', 90000, 2, N'TTS01')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S021', N'Doremon', CAST(N'2020-01-10' AS Date), N'TG007', N'TLS001', N'NXB001', CAST(N'2020-01-10' AS Date), N'NV0016', 20000, 1, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S022', N'Thế giới kết thúc diệu dàng đến thế', CAST(N'2020-01-10' AS Date), N'TG007', N'TLS001', N'NXB001', CAST(N'2020-01-10' AS Date), N'NV0010', 12333333, 4, N'TTS02')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NgayXuatBan], [MaTacGia], [MaTheLoai], [MaNXB], [NgayNhap], [MaNVTiepNhan], [GiaTien], [Ke], [TTS]) VALUES (N'S023', N'Trên đường băng', CAST(N'2020-01-10' AS Date), N'TG005', N'TLS003', N'NXB002', CAST(N'2020-01-10' AS Date), N'NV0010', 2, 3, N'TTS02')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG001', N'Nguyễn Nhật Ánh')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG002', N'Stephen hawking')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG003', N'Dale Canie')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG004', N'Trọng Tấn')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG005', N'Nguyễn Ngọc Tư')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG006', N'Phillip John')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG007', N'Dakasagi')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG009', N'Xuân Diệu')
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia]) VALUES (N'TG010', N'Nguyễn Đình Thi')
INSERT [dbo].[THANHLYSACH] ([MaPhieuThanhLy], [MaNV], [NgayThanhLy]) VALUES (N'PTLS001', N'NV0011', CAST(N'2018-12-22' AS Date))
INSERT [dbo].[THANHLYSACH] ([MaPhieuThanhLy], [MaNV], [NgayThanhLy]) VALUES (N'PTLS002', N'NV0012', CAST(N'2020-01-10' AS Date))
INSERT [dbo].[THELOAISACH] ([MaTheLoai], [TenTheLoai]) VALUES (N'TLS001', N'Thiếu nhi')
INSERT [dbo].[THELOAISACH] ([MaTheLoai], [TenTheLoai]) VALUES (N'TLS002', N'Tiểu thuyết')
INSERT [dbo].[THELOAISACH] ([MaTheLoai], [TenTheLoai]) VALUES (N'TLS003', N'Giáo dục')
INSERT [dbo].[THELOAISACH] ([MaTheLoai], [TenTheLoai]) VALUES (N'TLS004', N'Khoa học - kỹ thuật')
INSERT [dbo].[THELOAISACH] ([MaTheLoai], [TenTheLoai]) VALUES (N'TLS005', N'Lịch sử')
INSERT [dbo].[THELOAISACH] ([MaTheLoai], [TenTheLoai]) VALUES (N'TLS006', N'Truyện ngắn')
INSERT [dbo].[THELOAISACH] ([MaTheLoai], [TenTheLoai]) VALUES (N'TLS007', N'Chính trị')
INSERT [dbo].[TINHTRANGDOCGIA] ([MaTinhTrangDG], [LoaiTinhTrangDG]) VALUES (N'TTDG01', N'Hoạt động')
INSERT [dbo].[TINHTRANGDOCGIA] ([MaTinhTrangDG], [LoaiTinhTrangDG]) VALUES (N'TTDG02', N'Đã Xoá')
INSERT [dbo].[TINHTRANGNHANVIEN] ([MaTinhTrangNV], [LoaiTinhTrang]) VALUES (N'TTNV01', N'Đang làm việc')
INSERT [dbo].[TINHTRANGNHANVIEN] ([MaTinhTrangNV], [LoaiTinhTrang]) VALUES (N'TTNV02', N'Đang nghỉ phép')
INSERT [dbo].[TINHTRANGNHANVIEN] ([MaTinhTrangNV], [LoaiTinhTrang]) VALUES (N'TTNV03', N'Đã ghĩ việc')
INSERT [dbo].[TINHTRANGSACH] ([MaTTSach], [TenTinhTrang]) VALUES (N'TTS01', N'Đang mượn')
INSERT [dbo].[TINHTRANGSACH] ([MaTTSach], [TenTinhTrang]) VALUES (N'TTS02', N'Có thể mượn')
INSERT [dbo].[TINHTRANGSACH] ([MaTTSach], [TenTinhTrang]) VALUES (N'TTS03', N'Bị mất')
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUONSACH] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUONSACH] ([MaPM])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUONSACH]
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[CT_PHIEUTHANHLY]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTHANHLY_LYDOTHANHLY] FOREIGN KEY([MaLyDoThanhLy])
REFERENCES [dbo].[LYDOTHANHLY] ([MaLyDoThanhLy])
GO
ALTER TABLE [dbo].[CT_PHIEUTHANHLY] CHECK CONSTRAINT [FK_CT_PHIEUTHANHLY_LYDOTHANHLY]
GO
ALTER TABLE [dbo].[CT_PHIEUTHANHLY]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTHANHLY_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUTHANHLY] CHECK CONSTRAINT [FK_CT_PHIEUTHANHLY_SACH]
GO
ALTER TABLE [dbo].[CT_PHIEUTHANHLY]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTHANHLY_THANHLYSACH] FOREIGN KEY([MaPhieuThanhLy])
REFERENCES [dbo].[THANHLYSACH] ([MaPhieuThanhLy])
GO
ALTER TABLE [dbo].[CT_PHIEUTHANHLY] CHECK CONSTRAINT [FK_CT_PHIEUTHANHLY_THANHLYSACH]
GO
ALTER TABLE [dbo].[CT_PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTRA_PHIEUTRASACH] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PHIEUTRASACH] ([MaPT])
GO
ALTER TABLE [dbo].[CT_PHIEUTRA] CHECK CONSTRAINT [FK_CT_PHIEUTRA_PHIEUTRASACH]
GO
ALTER TABLE [dbo].[CT_PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTRA_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUTRA] CHECK CONSTRAINT [FK_CT_PHIEUTRA_SACH]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_LOAIDOCGIA] FOREIGN KEY([MaLoaiDG])
REFERENCES [dbo].[LOAIDOCGIA] ([MaLoaiDG])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_LOAIDOCGIA]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_NHANVIEN] FOREIGN KEY([NVLapThe])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_NHANVIEN]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_TINHTRANGDOCGIA] FOREIGN KEY([TTDG])
REFERENCES [dbo].[TINHTRANGDOCGIA] ([MaTinhTrangDG])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_TINHTRANGDOCGIA]
GO
ALTER TABLE [dbo].[MATSACH]  WITH CHECK ADD  CONSTRAINT [FK_MATSACH_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDocGia])
GO
ALTER TABLE [dbo].[MATSACH] CHECK CONSTRAINT [FK_MATSACH_DOCGIA]
GO
ALTER TABLE [dbo].[MATSACH]  WITH CHECK ADD  CONSTRAINT [FK_MATSACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[MATSACH] CHECK CONSTRAINT [FK_MATSACH_NHANVIEN]
GO
ALTER TABLE [dbo].[MATSACH]  WITH CHECK ADD  CONSTRAINT [FK_MATSACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[MATSACH] CHECK CONSTRAINT [FK_MATSACH_SACH]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BANGCAP] FOREIGN KEY([MaBangCap])
REFERENCES [dbo].[BANGCAP] ([MaBangCap])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BANGCAP]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BOPHAN] FOREIGN KEY([MaBoPhan])
REFERENCES [dbo].[BOPHAN] ([MaBoPhan])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BOPHAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TINHTRANGNHANVIEN] FOREIGN KEY([MaTTNV])
REFERENCES [dbo].[TINHTRANGNHANVIEN] ([MaTinhTrangNV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_TINHTRANGNHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONSACH_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDocGia])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_PHIEUMUONSACH_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUTHUTIENPHAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIENPHAT_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUTHUTIENPHAT] CHECK CONSTRAINT [FK_PHIEUTHUTIENPHAT_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTHUTIENPHAT]  WITH CHECK ADD  CONSTRAINT [fk_PHIEUTHUTIENPHAT_PHIEUTRASACH] FOREIGN KEY([MaPT])
REFERENCES [dbo].[PHIEUTRASACH] ([MaPT])
GO
ALTER TABLE [dbo].[PHIEUTHUTIENPHAT] CHECK CONSTRAINT [fk_PHIEUTHUTIENPHAT_PHIEUTRASACH]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_PHIEUMUONSACH] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUONSACH] ([MaPM])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_PHIEUMUONSACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHANVIEN] FOREIGN KEY([MaNVTiepNhan])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHANVIEN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TACGIA] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TACGIA] ([MaTacGia])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TACGIA]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAISACH] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAISACH] ([MaTheLoai])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAISACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TINHTRANGSACH] FOREIGN KEY([TTS])
REFERENCES [dbo].[TINHTRANGSACH] ([MaTTSach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TINHTRANGSACH]
GO
ALTER TABLE [dbo].[THANHLYSACH]  WITH CHECK ADD  CONSTRAINT [FK_THANHLYSACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[THANHLYSACH] CHECK CONSTRAINT [FK_THANHLYSACH_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatPhieuTra]    Script Date: 10/01/2020 9:27:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CapNhatPhieuTra]
@MaPT varchar(6), @TienThu int 
as
	
	UPDATE PHIEUTRASACH set TienNo = TienNo- @TienThu WHERE PHIEUTRASACH.MaPT= @MaPT
GO
/****** Object:  StoredProcedure [dbo].[SP_CapNhatTienPhat]    Script Date: 10/01/2020 9:27:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CapNhatTienPhat]
@MaPT varchar(8), @TienPhat int, @MaPM varchar(6)
as
	Update PHIEUTRASACH set TienNo=TienNo+@TienPhat where PHIEUTRASACH.MaPT=@MaPT and PHIEUTRASACH.MaPM=@MaPM
GO
/****** Object:  StoredProcedure [dbo].[SP_LayMaGhiNhan]    Script Date: 10/01/2020 9:27:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayMaGhiNhan]
as
	SELECT TOP 1 MaGNMatSach FROM MATSACH order by MaGNMatSach Desc
GO
/****** Object:  StoredProcedure [dbo].[SP_LayMaPhieuThu]    Script Date: 10/01/2020 9:27:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayMaPhieuThu]
as
	SELECT TOP 1 MaPhieuThu FROM PHIEUTHUTIENPHAT order by MaPhieuThu Desc
GO
/****** Object:  StoredProcedure [dbo].[SP_LayMaPhieuTraDocGia]    Script Date: 10/01/2020 9:27:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_LayMaPhieuTraDocGia]
@MaDG varchar(8)
as
	select pt.MaPT from PHIEUTRASACH pt join PHIEUMUONSACH pm on pm.MaPM=pt.MaPM
	where pm.MaDG=@MaDG
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemPhieuThuTienPhat]    Script Date: 10/01/2020 9:27:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemPhieuThuTienPhat]
@MaPhieuThu varchar(8), @MaNV varchar(6), @TienThu int, @NgayThu date,@MaPT varchar(8), @TienConLai int
as
	INSERT INTO PHIEUTHUTIENPHAT(MaPhieuThu,MaNV,SoTienThu,NgayThu,MaPT,ConLai)
	VALUES(@MaPhieuThu,@MaNV,@TienThu,@NgayThu,@MaPT,@TienConLai)
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemSachMat]    Script Date: 10/01/2020 9:27:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ThemSachMat]
@MaGNMatSach varchar(6), @MaSach varchar(5),@NgayGhiNhan date, @MaDG varchar(8),@TienPhat int, @MaNV varchar(8)
as
	INSERT INTO MATSACH(MaGNMatSach,MaSach,NgayGhiNhan,MaDG,TienPhat,MaNV)
	VALUES(@MaGNMatSach,@MaSach,@NgayGhiNhan,@MaDG,@TienPhat,@MaNV)
GO

