﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSuratSakit
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.dttanggalakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dttanggalmulai = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtlamasakit = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.txtnamapoli = New System.Windows.Forms.TextBox()
        Me.txtnamapsn = New System.Windows.Forms.TextBox()
        Me.btnCarireg = New System.Windows.Forms.Button()
        Me.txtkoderm = New System.Windows.Forms.TextBox()
        Me.txttglrm = New System.Windows.Forms.TextBox()
        Me.dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(812, 306)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage1.Controls.Add(Me.btncetak)
        Me.TabPage1.Controls.Add(Me.dttanggalakhir)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.dttanggalmulai)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtlamasakit)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dttanggal)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnbatal)
        Me.TabPage1.Controls.Add(Me.btnhapus)
        Me.TabPage1.Controls.Add(Me.btnsimpan)
        Me.TabPage1.Controls.Add(Me.txtkode)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(804, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form Surat Sakit"
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(500, 217)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(97, 27)
        Me.btncetak.TabIndex = 75
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'dttanggalakhir
        '
        Me.dttanggalakhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttanggalakhir.Location = New System.Drawing.Point(182, 114)
        Me.dttanggalakhir.Name = "dttanggalakhir"
        Me.dttanggalakhir.Size = New System.Drawing.Size(179, 23)
        Me.dttanggalakhir.TabIndex = 71
        Me.dttanggalakhir.Value = New Date(2015, 6, 23, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 15)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Tanggal Akhir"
        '
        'dttanggalmulai
        '
        Me.dttanggalmulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttanggalmulai.Location = New System.Drawing.Point(182, 84)
        Me.dttanggalmulai.Name = "dttanggalmulai"
        Me.dttanggalmulai.Size = New System.Drawing.Size(179, 23)
        Me.dttanggalmulai.TabIndex = 69
        Me.dttanggalmulai.Value = New Date(2015, 6, 23, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Tanggal Mulai"
        '
        'txtlamasakit
        '
        Me.txtlamasakit.Location = New System.Drawing.Point(182, 144)
        Me.txtlamasakit.Name = "txtlamasakit"
        Me.txtlamasakit.Size = New System.Drawing.Size(75, 23)
        Me.txtlamasakit.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Lama Sakit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtnamadokter)
        Me.GroupBox1.Controls.Add(Me.txtnamapoli)
        Me.GroupBox1.Controls.Add(Me.txtnamapsn)
        Me.GroupBox1.Controls.Add(Me.btnCarireg)
        Me.GroupBox1.Controls.Add(Me.txtkoderm)
        Me.GroupBox1.Controls.Add(Me.txttglrm)
        Me.GroupBox1.Location = New System.Drawing.Point(448, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 194)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Rekam Medis"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 15)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Nama Dokter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Nama Poli"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Nama Pasien"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 15)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Tanggal Rekam medis"
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Enabled = False
        Me.txtnamadokter.Location = New System.Drawing.Point(163, 155)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(149, 23)
        Me.txtnamadokter.TabIndex = 58
        '
        'txtnamapoli
        '
        Me.txtnamapoli.Enabled = False
        Me.txtnamapoli.Location = New System.Drawing.Point(163, 125)
        Me.txtnamapoli.Name = "txtnamapoli"
        Me.txtnamapoli.Size = New System.Drawing.Size(149, 23)
        Me.txtnamapoli.TabIndex = 57
        '
        'txtnamapsn
        '
        Me.txtnamapsn.Enabled = False
        Me.txtnamapsn.Location = New System.Drawing.Point(162, 91)
        Me.txtnamapsn.Name = "txtnamapsn"
        Me.txtnamapsn.Size = New System.Drawing.Size(149, 23)
        Me.txtnamapsn.TabIndex = 56
        '
        'btnCarireg
        '
        Me.btnCarireg.Location = New System.Drawing.Point(247, 28)
        Me.btnCarireg.Name = "btnCarireg"
        Me.btnCarireg.Size = New System.Drawing.Size(64, 27)
        Me.btnCarireg.TabIndex = 54
        Me.btnCarireg.Text = "Cari"
        Me.btnCarireg.UseVisualStyleBackColor = True
        '
        'txtkoderm
        '
        Me.txtkoderm.Enabled = False
        Me.txtkoderm.Location = New System.Drawing.Point(21, 31)
        Me.txtkoderm.Name = "txtkoderm"
        Me.txtkoderm.Size = New System.Drawing.Size(219, 23)
        Me.txtkoderm.TabIndex = 54
        '
        'txttglrm
        '
        Me.txttglrm.Enabled = False
        Me.txttglrm.Location = New System.Drawing.Point(162, 61)
        Me.txttglrm.Name = "txttglrm"
        Me.txttglrm.Size = New System.Drawing.Size(149, 23)
        Me.txttglrm.TabIndex = 55
        '
        'dttanggal
        '
        Me.dttanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttanggal.Location = New System.Drawing.Point(182, 54)
        Me.dttanggal.Name = "dttanggal"
        Me.dttanggal.Size = New System.Drawing.Size(179, 23)
        Me.dttanggal.TabIndex = 58
        Me.dttanggal.Value = New Date(2015, 6, 23, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Tanggal"
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(695, 217)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(87, 27)
        Me.btnbatal.TabIndex = 49
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(601, 217)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(87, 27)
        Me.btnhapus.TabIndex = 48
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(397, 217)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(97, 27)
        Me.btnsimpan.TabIndex = 47
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(182, 23)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(175, 23)
        Me.txtkode.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Kode Surat Sakit"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage2.Controls.Add(Me.dataGridView1)
        Me.TabPage2.Controls.Add(Me.txtcari)
        Me.TabPage2.Controls.Add(Me.btnCariData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(804, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Surat Sakit"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(3, 37)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.ReadOnly = True
        Me.dataGridView1.Size = New System.Drawing.Size(962, 386)
        Me.dataGridView1.TabIndex = 51
        '
        'txtcari
        '
        Me.txtcari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcari.Location = New System.Drawing.Point(626, 8)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(172, 23)
        Me.txtcari.TabIndex = 30
        '
        'btnCariData
        '
        Me.btnCariData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCariData.Location = New System.Drawing.Point(538, 6)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(84, 27)
        Me.btnCariData.TabIndex = 31
        Me.btnCariData.Text = "Cari"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(681, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 33)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormSuratSakit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(815, 363)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormSuratSakit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCarireg As System.Windows.Forms.Button
    Friend WithEvents txtkoderm As System.Windows.Forms.TextBox
    Friend WithEvents txtlamasakit As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dttanggalakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dttanggalmulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnamadokter As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapoli As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapsn As System.Windows.Forms.TextBox
    Friend WithEvents txttglrm As System.Windows.Forms.TextBox
    Friend WithEvents btncetak As System.Windows.Forms.Button
End Class
