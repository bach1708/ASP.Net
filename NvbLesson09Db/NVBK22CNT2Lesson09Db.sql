USE [NvbK22CNT2Lesson09Db]
GO
/****** Object:  Table [dbo].[nvbKhoa]    Script Date: 6/17/2024 5:31:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvbKhoa](
	[NvbMaKH] [nchar](10) NOT NULL,
	[NvbTenKH] [nvarchar](50) NULL,
	[NvbTrangThai] [bit] NULL,
 CONSTRAINT [PK_nvbKhoa] PRIMARY KEY CLUSTERED 
(
	[NvbMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nvbSinhVien]    Script Date: 6/17/2024 5:31:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvbSinhVien](
	[NvbMaSV] [nvarchar](50) NOT NULL,
	[NvbHoSV] [nvarchar](50) NULL,
	[NvbTenSV] [nvarchar](50) NULL,
	[NvbNgaySinh] [date] NULL,
	[NvbPhai] [bit] NULL,
	[NvbPhone] [nchar](10) NULL,
	[NvbEmail] [nvarchar](50) NULL,
	[NvbMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_nvbSinhVien] PRIMARY KEY CLUSTERED 
(
	[NvbMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nvbKhoa] ([NvbMaKH], [NvbTenKH], [NvbTrangThai]) VALUES (N'K22CNT2   ', N'K22CNT2', 1)
GO
INSERT [dbo].[nvbSinhVien] ([NvbMaSV], [NvbHoSV], [NvbTenSV], [NvbNgaySinh], [NvbPhai], [NvbPhone], [NvbEmail], [NvbMaKH]) VALUES (N'2210900003', N'Nông Văn', N'Bách ', CAST(N'2001-08-17' AS Date), 1, N'0387387894', N'kunkontkls@gmail.com', N'K22CNT2   ')
GO
