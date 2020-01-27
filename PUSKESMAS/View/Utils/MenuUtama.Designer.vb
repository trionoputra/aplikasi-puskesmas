<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuutama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuutama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KepalaKeluargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TindakanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekamMedisUmumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekammedisbumilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratRujukanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratSakitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratSehatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TebusResepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKunjunganPasienPerperiodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPendapatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPasienBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanKunjunganHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanObatExpiredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanSuratTandaSetoranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanResepHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanResepPerperiodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanObatHampirHabisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dashboarddokter = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.dashboarddokter.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 102)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(312, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KepalaKeluargaToolStripMenuItem, Me.PasienToolStripMenuItem, Me.PoliToolStripMenuItem, Me.DokterToolStripMenuItem, Me.TindakanToolStripMenuItem, Me.ObatToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MasterToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'KepalaKeluargaToolStripMenuItem
        '
        Me.KepalaKeluargaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.KepalaKeluargaToolStripMenuItem.Name = "KepalaKeluargaToolStripMenuItem"
        Me.KepalaKeluargaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.KepalaKeluargaToolStripMenuItem.Text = "Kepala Keluarga"
        '
        'PoliToolStripMenuItem
        '
        Me.PoliToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.PoliToolStripMenuItem.Name = "PoliToolStripMenuItem"
        Me.PoliToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.PoliToolStripMenuItem.Text = "Poli"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.PasienToolStripMenuItem.Text = "Pasien"
        '
        'DokterToolStripMenuItem
        '
        Me.DokterToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.DokterToolStripMenuItem.Name = "DokterToolStripMenuItem"
        Me.DokterToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DokterToolStripMenuItem.Text = "Dokter"
        '
        'TindakanToolStripMenuItem
        '
        Me.TindakanToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.TindakanToolStripMenuItem.Name = "TindakanToolStripMenuItem"
        Me.TindakanToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TindakanToolStripMenuItem.Text = "Tindakan"
        '
        'ObatToolStripMenuItem
        '
        Me.ObatToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.ObatToolStripMenuItem.Name = "ObatToolStripMenuItem"
        Me.ObatToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ObatToolStripMenuItem.Text = "Obat"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrasiToolStripMenuItem, Me.PembayaranToolStripMenuItem, Me.RekamMedisUmumToolStripMenuItem, Me.RekammedisbumilToolStripMenuItem, Me.ResepToolStripMenuItem, Me.SuratRujukanToolStripMenuItem, Me.SuratSakitToolStripMenuItem, Me.SuratSehatToolStripMenuItem, Me.DetailObatToolStripMenuItem, Me.TebusResepToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'DetailObatToolStripMenuItem
        '
        Me.DetailObatToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.DetailObatToolStripMenuItem.Name = "DetailObatToolStripMenuItem"
        Me.DetailObatToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DetailObatToolStripMenuItem.Text = "Detail Obat"
        '
        'RegistrasiToolStripMenuItem
        '
        Me.RegistrasiToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.RegistrasiToolStripMenuItem.Name = "RegistrasiToolStripMenuItem"
        Me.RegistrasiToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RegistrasiToolStripMenuItem.Text = "Registrasi"
        '
        'RekamMedisUmumToolStripMenuItem
        '
        Me.RekamMedisUmumToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.RekamMedisUmumToolStripMenuItem.Name = "RekamMedisUmumToolStripMenuItem"
        Me.RekamMedisUmumToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RekamMedisUmumToolStripMenuItem.Text = "Rekam Medis Umum"
        '
        'RekammedisbumilToolStripMenuItem
        '
        Me.RekammedisbumilToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.RekammedisbumilToolStripMenuItem.Name = "RekammedisbumilToolStripMenuItem"
        Me.RekammedisbumilToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RekammedisbumilToolStripMenuItem.Text = "Rekam Medis Bumil"
        '
        'ResepToolStripMenuItem
        '
        Me.ResepToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.ResepToolStripMenuItem.Name = "ResepToolStripMenuItem"
        Me.ResepToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ResepToolStripMenuItem.Text = "Resep"
        '
        'SuratRujukanToolStripMenuItem
        '
        Me.SuratRujukanToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.SuratRujukanToolStripMenuItem.Name = "SuratRujukanToolStripMenuItem"
        Me.SuratRujukanToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SuratRujukanToolStripMenuItem.Text = "Surat Rujukan"
        '
        'SuratSakitToolStripMenuItem
        '
        Me.SuratSakitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.SuratSakitToolStripMenuItem.Name = "SuratSakitToolStripMenuItem"
        Me.SuratSakitToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SuratSakitToolStripMenuItem.Text = "Surat Sakit"
        '
        'SuratSehatToolStripMenuItem
        '
        Me.SuratSehatToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.SuratSehatToolStripMenuItem.Name = "SuratSehatToolStripMenuItem"
        Me.SuratSehatToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.SuratSehatToolStripMenuItem.Text = "Surat Sehat"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'TebusResepToolStripMenuItem
        '
        Me.TebusResepToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.TebusResepToolStripMenuItem.Name = "TebusResepToolStripMenuItem"
        Me.TebusResepToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TebusResepToolStripMenuItem.Text = "Tebus Resep"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanKunjunganPasienPerperiodeToolStripMenuItem, Me.LaporanPendapatanToolStripMenuItem, Me.LaporanPasienBaruToolStripMenuItem, Me.LaporanKunjunganHarianToolStripMenuItem, Me.LaporanObatExpiredToolStripMenuItem, Me.LaporanSuratTandaSetoranToolStripMenuItem, Me.LaporanResepHarianToolStripMenuItem, Me.LaporanResepPerperiodeToolStripMenuItem, Me.LaporanObatHampirHabisToolStripMenuItem})
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanKunjunganPasienPerperiodeToolStripMenuItem
        '
        Me.LaporanKunjunganPasienPerperiodeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanKunjunganPasienPerperiodeToolStripMenuItem.Name = "LaporanKunjunganPasienPerperiodeToolStripMenuItem"
        Me.LaporanKunjunganPasienPerperiodeToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanKunjunganPasienPerperiodeToolStripMenuItem.Text = "Laporan Kunjungan Pasien Perperiode"
        '
        'LaporanPendapatanToolStripMenuItem
        '
        Me.LaporanPendapatanToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanPendapatanToolStripMenuItem.Name = "LaporanPendapatanToolStripMenuItem"
        Me.LaporanPendapatanToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanPendapatanToolStripMenuItem.Text = "Laporan Pendapatan"
        '
        'LaporanPasienBaruToolStripMenuItem
        '
        Me.LaporanPasienBaruToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanPasienBaruToolStripMenuItem.Name = "LaporanPasienBaruToolStripMenuItem"
        Me.LaporanPasienBaruToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanPasienBaruToolStripMenuItem.Text = "Laporan Pasien Baru"
        '
        'LaporanKunjunganHarianToolStripMenuItem
        '
        Me.LaporanKunjunganHarianToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanKunjunganHarianToolStripMenuItem.Name = "LaporanKunjunganHarianToolStripMenuItem"
        Me.LaporanKunjunganHarianToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanKunjunganHarianToolStripMenuItem.Text = "Laporan Register Kunjungan  Pasien"
        '
        'LaporanObatExpiredToolStripMenuItem
        '
        Me.LaporanObatExpiredToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanObatExpiredToolStripMenuItem.Name = "LaporanObatExpiredToolStripMenuItem"
        Me.LaporanObatExpiredToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanObatExpiredToolStripMenuItem.Text = "Laporan Obat Expired"
        '
        'LaporanSuratTandaSetoranToolStripMenuItem
        '
        Me.LaporanSuratTandaSetoranToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanSuratTandaSetoranToolStripMenuItem.Name = "LaporanSuratTandaSetoranToolStripMenuItem"
        Me.LaporanSuratTandaSetoranToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanSuratTandaSetoranToolStripMenuItem.Text = "Laporan Surat Tanda Setoran"
        '
        'LaporanResepHarianToolStripMenuItem
        '
        Me.LaporanResepHarianToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanResepHarianToolStripMenuItem.Name = "LaporanResepHarianToolStripMenuItem"
        Me.LaporanResepHarianToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanResepHarianToolStripMenuItem.Text = "Laporan Resep Harian"
        '
        'LaporanResepPerperiodeToolStripMenuItem
        '
        Me.LaporanResepPerperiodeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanResepPerperiodeToolStripMenuItem.Name = "LaporanResepPerperiodeToolStripMenuItem"
        Me.LaporanResepPerperiodeToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanResepPerperiodeToolStripMenuItem.Text = "Laporan Resep Perperiode"
        '
        'LaporanObatHampirHabisToolStripMenuItem
        '
        Me.LaporanObatHampirHabisToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.LaporanObatHampirHabisToolStripMenuItem.Name = "LaporanObatHampirHabisToolStripMenuItem"
        Me.LaporanObatHampirHabisToolStripMenuItem.Size = New System.Drawing.Size(275, 22)
        Me.LaporanObatHampirHabisToolStripMenuItem.Text = "Laporan Obat Hampir Habis"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UbahPasswordToolStripMenuItem})
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'UbahPasswordToolStripMenuItem
        '
        Me.UbahPasswordToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info
        Me.UbahPasswordToolStripMenuItem.Name = "UbahPasswordToolStripMenuItem"
        Me.UbahPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UbahPasswordToolStripMenuItem.Text = "Ubah Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 541)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(974, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'dashboarddokter
        '
        Me.dashboarddokter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dashboarddokter.Controls.Add(Me.DataGridView1)
        Me.dashboarddokter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboarddokter.Location = New System.Drawing.Point(14, 137)
        Me.dashboarddokter.Name = "dashboarddokter"
        Me.dashboarddokter.Size = New System.Drawing.Size(946, 480)
        Me.dashboarddokter.TabIndex = 2
        Me.dashboarddokter.TabStop = False
        Me.dashboarddokter.Text = "Data Antrian Registrasi"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(932, 451)
        Me.DataGridView1.TabIndex = 0
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(303, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 51)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PEMERINTAH KOTA ADMINISTRASI JAKARTA SELATAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                     SUKU DINAS KES" & _
    "EHATAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           PUSKESMAS KELURAHAN TEBET BARAT"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(222, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 76)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'menuutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(974, 563)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dashboarddokter)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "menuutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.dashboarddokter.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KepalaKeluargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DokterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TindakanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekamMedisUmumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratRujukanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratSakitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuratSehatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekammedisbumilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TebusResepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbahPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanKunjunganPasienPerperiodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPendapatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPasienBaruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanKunjunganHarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dashboarddokter As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LaporanObatExpiredToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanSuratTandaSetoranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanResepHarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanResepPerperiodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanObatHampirHabisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DetailObatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
