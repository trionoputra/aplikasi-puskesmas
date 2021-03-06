USE [puskesmas]
GO
/****** Object:  Table [dbo].[user]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[user]
GO
/****** Object:  Table [dbo].[tindakan]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[tindakan]
GO
/****** Object:  Table [dbo].[surat_sehat]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[surat_sehat]
GO
/****** Object:  Table [dbo].[surat_sakit]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[surat_sakit]
GO
/****** Object:  Table [dbo].[surat_rujukan]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[surat_rujukan]
GO
/****** Object:  Table [dbo].[resep]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[resep]
GO
/****** Object:  Table [dbo].[rekammedis_umum]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[rekammedis_umum]
GO
/****** Object:  Table [dbo].[rekammedis_bumil]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[rekammedis_bumil]
GO
/****** Object:  Table [dbo].[registrasi]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[registrasi]
GO
/****** Object:  Table [dbo].[poli]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[poli]
GO
/****** Object:  Table [dbo].[pasien]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[pasien]
GO
/****** Object:  Table [dbo].[obat]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[obat]
GO
/****** Object:  Table [dbo].[kwitansi]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[kwitansi]
GO
/****** Object:  Table [dbo].[kk]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[kk]
GO
/****** Object:  Table [dbo].[dokter]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[dokter]
GO
/****** Object:  Table [dbo].[detail_tindakan]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[detail_tindakan]
GO
/****** Object:  Table [dbo].[detail_resep]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[detail_resep]
GO
/****** Object:  Table [dbo].[detail_obat]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[detail_obat]
GO
/****** Object:  Table [dbo].[detail_kwitansi]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[detail_kwitansi]
GO
/****** Object:  Table [dbo].[antenatal_care]    Script Date: 6/22/2015 8:41:59 AM ******/
DROP TABLE [dbo].[antenatal_care]
GO
ALTER DATABASE [puskesmas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [puskesmas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [puskesmas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [puskesmas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [puskesmas] SET ARITHABORT OFF 
GO
ALTER DATABASE [puskesmas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [puskesmas] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [puskesmas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [puskesmas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [puskesmas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [puskesmas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [puskesmas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [puskesmas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [puskesmas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [puskesmas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [puskesmas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [puskesmas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [puskesmas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [puskesmas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [puskesmas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [puskesmas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [puskesmas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [puskesmas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [puskesmas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [puskesmas] SET  MULTI_USER 
GO
ALTER DATABASE [puskesmas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [puskesmas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [puskesmas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [puskesmas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [puskesmas]
GO
/****** Object:  Table [dbo].[antenatal_care]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[antenatal_care](
	[kd_ante] [varchar](12) NOT NULL,
	[tgl_ante] [date] NULL,
	[jamkesmas] [varchar](6) NULL,
	[cara_masuk] [varchar](10) NULL,
	[usia_kelinis] [varchar](6) NULL,
	[transfer_ke] [varchar](4) NULL,
	[anamnesia] [varchar](30) NULL,
	[bb] [varchar](6) NULL,
	[td] [varchar](8) NULL,
	[status_gizi] [varchar](6) NULL,
	[tfu] [varchar](6) NULL,
	[refleks_patella] [varchar](2) NULL,
	[djj] [varchar](6) NULL,
	[kepala_thd_pap] [varchar](6) NULL,
	[tbj] [varchar](8) NULL,
	[presentasi] [varchar](6) NULL,
	[jumlah_janin] [varchar](6) NULL,
	[status_imunisasi] [varchar](6) NULL,
	[catat_dibuku_kia] [varchar](6) NULL,
	[fe] [varchar](6) NULL,
	[hb_dilakukan] [varchar](6) NULL,
	[hb_hasil] [varchar](6) NULL,
	[anemia] [varchar](6) NULL,
	[pretein_urie] [varchar](6) NULL,
	[gula_darah] [varchar](6) NULL,
	[reduksi] [varchar](6) NULL,
	[gol_darah] [varchar](2) NULL,
	[siphilis] [varchar](6) NULL,
	[vct] [varchar](6) NULL,
	[periksa_darah] [varchar](6) NULL,
	[serologi] [varchar](6) NULL,
	[arv] [varchar](6) NULL,
	[injeksi_tt] [varchar](6) NULL,
	[therapi] [varchar](30) NULL,
	[kd_rm] [varchar](10) NULL,
 CONSTRAINT [PK_antenatal_care] PRIMARY KEY CLUSTERED 
(
	[kd_ante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detail_kwitansi]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detail_kwitansi](
	[kd_kw] [varchar](10) NULL,
	[kd_uraian] [varchar](10) NULL,
	[uraian] [varchar](50) NULL,
	[tarif] [decimal](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detail_obat]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detail_obat](
	[id_detail_obat] [int] IDENTITY(1,1) NOT NULL,
	[kd_obat] [varchar](10) NULL,
	[no_batch] [varchar](10) NULL,
	[exp_date] [date] NULL,
	[tgl_masuk] [date] NULL,
	[jml_masuk] [int] NULL,
 CONSTRAINT [PK_detail_obat1] PRIMARY KEY CLUSTERED 
(
	[id_detail_obat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detail_resep]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detail_resep](
	[kd_resep] [varchar](10) NULL,
	[kd_obat] [varchar](10) NULL,
	[jml_obat] [int] NULL,
	[aturan_pakai] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detail_tindakan]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detail_tindakan](
	[kd_rm] [varchar](10) NOT NULL,
	[kd_tindakan] [varchar](10) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dokter]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dokter](
	[kd_dok] [varchar](10) NOT NULL,
	[nm_dok] [varchar](30) NULL,
	[alamat_dok] [varchar](50) NULL,
	[jk_dok] [varchar](12) NULL,
	[tgl_lahir_dok] [date] NULL,
	[notelp_dok] [varchar](15) NULL,
	[kd_poli] [varchar](10) NULL,
	[password] [varchar](32) NULL,
 CONSTRAINT [PK_dok] PRIMARY KEY CLUSTERED 
(
	[kd_dok] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kk]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kk](
	[kd_kk] [varchar](10) NOT NULL,
	[nm_kk] [varchar](30) NULL,
	[pekerjaan_kk] [varchar](30) NULL,
	[alamat_kk] [varchar](50) NULL,
	[jk_kk] [varchar](12) NULL,
	[tgl_lahir_kk] [date] NULL,
	[notelp_kk] [varchar](15) NULL,
	[jenis_kk] [varchar](6) NULL,
	[tgl_daftar_kk] [date] NULL,
 CONSTRAINT [PK_kk] PRIMARY KEY CLUSTERED 
(
	[kd_kk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kwitansi]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kwitansi](
	[kd_kw] [varchar](10) NOT NULL,
	[tgl_kw] [date] NULL,
	[total_bayar] [decimal](18, 0) NULL,
	[kd_reg] [varchar](12) NULL,
	[status] [varchar](10) NULL,
 CONSTRAINT [PK_kwitansi] PRIMARY KEY CLUSTERED 
(
	[kd_kw] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[obat]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[obat](
	[kd_obat] [varchar](10) NOT NULL,
	[nm_obat] [varchar](30) NULL,
	[satuan_obat] [varchar](10) NULL,
	[stok] [int] NULL,
 CONSTRAINT [PK_obat] PRIMARY KEY CLUSTERED 
(
	[kd_obat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pasien]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[pasien](
	[kd_psn] [varchar](10) NOT NULL,
	[nm_psn] [varchar](30) NULL,
	[pekerjaan_psn] [varchar](30) NULL,
	[alamat_psn] [varchar](50) NULL,
	[jk_psn] [varchar](12) NULL,
	[tgl_lahir_psn] [date] NULL,
	[notelp_psn] [varchar](15) NULL,
	[jenis_psn] [varchar](6) NULL,
	[status_kel_psn] [varchar](8) NULL,
	[kd_kk] [varchar](10) NULL,
	[tgl_daftar_psn] [date] NULL,
 CONSTRAINT [PK_pasien] PRIMARY KEY CLUSTERED 
(
	[kd_psn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[poli]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[poli](
	[kd_poli] [varchar](10) NOT NULL,
	[nm_poli] [varchar](30) NULL,
 CONSTRAINT [PK_poli] PRIMARY KEY CLUSTERED 
(
	[kd_poli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[registrasi]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[registrasi](
	[kd_reg] [varchar](12) NOT NULL,
	[kd_psn] [varchar](10) NOT NULL,
	[kd_dok] [varchar](10) NOT NULL,
	[tgl_reg] [date] NULL,
 CONSTRAINT [PK_reg] PRIMARY KEY CLUSTERED 
(
	[kd_reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rekammedis_bumil]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rekammedis_bumil](
	[kd_rm_bumil] [varchar](10) NOT NULL,
	[tgl_rm] [date] NULL,
	[posyandu] [varchar](30) NULL,
	[nm_kader] [varchar](30) NULL,
	[nm_dukun] [varchar](30) NULL,
	[jamkesmas] [varchar](6) NULL,
	[gol_darah] [varchar](2) NULL,
	[granida] [varchar](3) NULL,
	[partis] [varchar](3) NULL,
	[aborus] [varchar](3) NULL,
	[hidup] [varchar](3) NULL,
	[tgl_periksa] [date] NULL,
	[tgl_hpht] [date] NULL,
	[taksiran_persalinan] [date] NULL,
	[bb_sblm_hamil] [varchar](3) NULL,
	[tb] [varchar](3) NULL,
	[buku_kia] [varchar](15) NULL,
	[riwayat_komplikasi_kebidanan] [varchar](30) NULL,
	[penyakit_kronis_alergi] [varchar](30) NULL,
	[tgl_persalinan] [date] NULL,
	[penolong] [varchar](30) NULL,
	[tempat] [varchar](30) NULL,
	[pendamping] [varchar](30) NULL,
	[transportasi] [varchar](20) NULL,
	[pendonor] [varchar](30) NULL,
	[kd_reg] [varchar](12) NULL,
	[cara_masuk] [varchar](10) NULL,
	[usia_kelinis] [varchar](6) NULL,
	[transfer_ke] [varchar](4) NULL,
	[anamnesia] [varchar](30) NULL,
	[bb] [varchar](6) NULL,
	[td] [varchar](8) NULL,
	[status_gizi] [varchar](6) NULL,
	[tfu] [varchar](6) NULL,
	[refleks_patella] [varchar](2) NULL,
	[djj] [varchar](6) NULL,
	[kepala_thd_pap] [varchar](6) NULL,
	[tbj] [varchar](8) NULL,
	[presentasi] [varchar](6) NULL,
	[jumlah_janin] [varchar](6) NULL,
	[status_imunisasi] [varchar](6) NULL,
	[catat_dibuku_kia] [varchar](6) NULL,
	[fe] [varchar](6) NULL,
	[hb_dilakukan] [varchar](6) NULL,
	[hb_hasil] [varchar](6) NULL,
	[anemia] [varchar](6) NULL,
	[pretein_urie] [varchar](6) NULL,
	[gula_darah] [varchar](6) NULL,
	[reduksi] [varchar](6) NULL,
	[siphilis] [varchar](6) NULL,
	[vct] [varchar](6) NULL,
	[periksa_darah] [varchar](6) NULL,
	[serologi] [varchar](6) NULL,
	[arv] [varchar](6) NULL,
	[injeksi_tt] [varchar](6) NULL,
	[therapi] [varchar](30) NULL,
 CONSTRAINT [PK_bumil] PRIMARY KEY CLUSTERED 
(
	[kd_rm_bumil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rekammedis_umum]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rekammedis_umum](
	[kd_rm] [varchar](10) NOT NULL,
	[tgl_rm] [date] NULL,
	[anamnesis] [varchar](50) NULL,
	[diagnosa] [varchar](50) NULL,
	[berat_badan] [varchar](6) NULL,
	[tinggi_badan] [varchar](6) NULL,
	[tekanan_darah] [varchar](6) NULL,
	[kd_reg] [varchar](12) NULL,
 CONSTRAINT [PK_rekammedis_umum] PRIMARY KEY CLUSTERED 
(
	[kd_rm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[resep]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[resep](
	[kd_resep] [varchar](10) NOT NULL,
	[tgl_resep] [date] NULL,
	[kd_rm] [varchar](10) NULL,
	[status] [varchar](1) NULL,
 CONSTRAINT [PK_resep] PRIMARY KEY CLUSTERED 
(
	[kd_resep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[surat_rujukan]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[surat_rujukan](
	[kd_rjkn] [varchar](10) NOT NULL,
	[tgl_rjkn] [date] NULL,
	[alamat_rjkn] [varchar](50) NULL,
	[poli_rjkn] [varchar](30) NULL,
	[rs_rjkn] [varchar](30) NULL,
	[kd_rm] [varchar](10) NULL,
	[diagnosa] [varchar](30) NULL,
 CONSTRAINT [PK_surat_rujukan] PRIMARY KEY CLUSTERED 
(
	[kd_rjkn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[surat_sakit]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[surat_sakit](
	[kd_srskt] [varchar](10) NOT NULL,
	[tgl_srskt] [date] NULL,
	[lm_skt] [int] NULL,
	[tgl_mulai] [date] NULL,
	[tgl_akhir] [date] NULL,
	[kd_rm] [varchar](10) NULL,
 CONSTRAINT [PK_surat_sakit] PRIMARY KEY CLUSTERED 
(
	[kd_srskt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[surat_sehat]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[surat_sehat](
	[kd_srsht] [varchar](10) NOT NULL,
	[tgl_srsht] [date] NULL,
	[keperluan] [varchar](30) NULL,
	[keadaan] [varchar](30) NULL,
	[tensi] [varchar](6) NULL,
	[bb] [varchar](6) NULL,
	[tb] [varchar](6) NULL,
	[kd_rm] [varchar](10) NULL,
 CONSTRAINT [PK_surat_sehat] PRIMARY KEY CLUSTERED 
(
	[kd_srsht] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tindakan]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tindakan](
	[kd_tindakan] [varchar](10) NOT NULL,
	[nm_tindakan] [varchar](30) NULL,
	[tarif] [decimal](18, 0) NULL,
 CONSTRAINT [PK_tidakan] PRIMARY KEY CLUSTERED 
(
	[kd_tindakan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user]    Script Date: 6/22/2015 8:41:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[kd_user] [varchar](10) NULL,
	[nama] [varchar](30) NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](32) NULL,
	[level] [varchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [puskesmas] SET  READ_WRITE 
GO
