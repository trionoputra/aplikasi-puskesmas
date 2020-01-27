<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistrasi
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
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnamapoli = New System.Windows.Forms.TextBox()
        Me.txtkodepoli = New System.Windows.Forms.TextBox()
        Me.btncaridokter = New System.Windows.Forms.Button()
        Me.txtkodedokter = New System.Windows.Forms.TextBox()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.lbltgllahirkk = New System.Windows.Forms.Label()
        Me.txttgllahirkk = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnotelpon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttgllahir = New System.Windows.Forms.TextBox()
        Me.lblnamakk = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnamakk = New System.Windows.Forms.TextBox()
        Me.btnCaripasien = New System.Windows.Forms.Button()
        Me.txtkodepsn = New System.Windows.Forms.TextBox()
        Me.txtnamapsn = New System.Windows.Forms.TextBox()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(939, 466)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage1.Controls.Add(Me.btnCetak)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnbatal)
        Me.TabPage1.Controls.Add(Me.btnhapus)
        Me.TabPage1.Controls.Add(Me.btnsimpan)
        Me.TabPage1.Controls.Add(Me.txtkode)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dttanggal)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(931, 438)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form Registrasi"
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(605, 380)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(83, 27)
        Me.btnCetak.TabIndex = 59
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtnamapoli)
        Me.GroupBox2.Controls.Add(Me.txtkodepoli)
        Me.GroupBox2.Controls.Add(Me.btncaridokter)
        Me.GroupBox2.Controls.Add(Me.txtkodedokter)
        Me.GroupBox2.Controls.Add(Me.txtnamadokter)
        Me.GroupBox2.Location = New System.Drawing.Point(476, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 166)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Dokter / Poli"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Nama Poli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Kode Poli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Nama Dokter"
        '
        'txtnamapoli
        '
        Me.txtnamapoli.Enabled = False
        Me.txtnamapoli.Location = New System.Drawing.Point(114, 120)
        Me.txtnamapoli.Name = "txtnamapoli"
        Me.txtnamapoli.Size = New System.Drawing.Size(152, 23)
        Me.txtnamapoli.TabIndex = 57
        '
        'txtkodepoli
        '
        Me.txtkodepoli.Enabled = False
        Me.txtkodepoli.Location = New System.Drawing.Point(114, 90)
        Me.txtkodepoli.Name = "txtkodepoli"
        Me.txtkodepoli.Size = New System.Drawing.Size(152, 23)
        Me.txtkodepoli.TabIndex = 56
        '
        'btncaridokter
        '
        Me.btncaridokter.Location = New System.Drawing.Point(203, 27)
        Me.btncaridokter.Name = "btncaridokter"
        Me.btncaridokter.Size = New System.Drawing.Size(64, 27)
        Me.btncaridokter.TabIndex = 54
        Me.btncaridokter.Text = "Cari"
        Me.btncaridokter.UseVisualStyleBackColor = True
        '
        'txtkodedokter
        '
        Me.txtkodedokter.Enabled = False
        Me.txtkodedokter.Location = New System.Drawing.Point(20, 30)
        Me.txtkodedokter.Name = "txtkodedokter"
        Me.txtkodedokter.Size = New System.Drawing.Size(175, 23)
        Me.txtkodedokter.TabIndex = 54
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Enabled = False
        Me.txtnamadokter.Location = New System.Drawing.Point(114, 60)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(152, 23)
        Me.txtnamadokter.TabIndex = 55
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.lbltgllahirkk)
        Me.GroupBox1.Controls.Add(Me.txttgllahirkk)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtnotelpon)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txttgllahir)
        Me.GroupBox1.Controls.Add(Me.lblnamakk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtnamakk)
        Me.GroupBox1.Controls.Add(Me.btnCaripasien)
        Me.GroupBox1.Controls.Add(Me.txtkodepsn)
        Me.GroupBox1.Controls.Add(Me.txtnamapsn)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 106)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 300)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pasien"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 15)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Alamat"
        '
        'txtalamat
        '
        Me.txtalamat.Enabled = False
        Me.txtalamat.Location = New System.Drawing.Point(135, 157)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(277, 69)
        Me.txtalamat.TabIndex = 67
        '
        'lbltgllahirkk
        '
        Me.lbltgllahirkk.AutoSize = True
        Me.lbltgllahirkk.Location = New System.Drawing.Point(8, 261)
        Me.lbltgllahirkk.Name = "lbltgllahirkk"
        Me.lbltgllahirkk.Size = New System.Drawing.Size(96, 15)
        Me.lbltgllahirkk.TabIndex = 66
        Me.lbltgllahirkk.Text = "Tanggal Lahir KK"
        '
        'txttgllahirkk
        '
        Me.txttgllahirkk.Enabled = False
        Me.txttgllahirkk.Location = New System.Drawing.Point(136, 260)
        Me.txttgllahirkk.Name = "txttgllahirkk"
        Me.txttgllahirkk.Size = New System.Drawing.Size(167, 23)
        Me.txttgllahirkk.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "No. Telepon"
        '
        'txtnotelpon
        '
        Me.txtnotelpon.Enabled = False
        Me.txtnotelpon.Location = New System.Drawing.Point(136, 127)
        Me.txtnotelpon.Name = "txtnotelpon"
        Me.txtnotelpon.Size = New System.Drawing.Size(167, 23)
        Me.txtnotelpon.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Tanggal Lahir"
        '
        'txttgllahir
        '
        Me.txttgllahir.Enabled = False
        Me.txttgllahir.Location = New System.Drawing.Point(136, 97)
        Me.txttgllahir.Name = "txttgllahir"
        Me.txttgllahir.Size = New System.Drawing.Size(167, 23)
        Me.txttgllahir.TabIndex = 61
        '
        'lblnamakk
        '
        Me.lblnamakk.AutoSize = True
        Me.lblnamakk.Location = New System.Drawing.Point(8, 233)
        Me.lblnamakk.Name = "lblnamakk"
        Me.lblnamakk.Size = New System.Drawing.Size(56, 15)
        Me.lblnamakk.TabIndex = 60
        Me.lblnamakk.Text = "Nama KK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nama Pasien"
        '
        'txtnamakk
        '
        Me.txtnamakk.Enabled = False
        Me.txtnamakk.Location = New System.Drawing.Point(136, 233)
        Me.txtnamakk.Name = "txtnamakk"
        Me.txtnamakk.Size = New System.Drawing.Size(167, 23)
        Me.txtnamakk.TabIndex = 57
        '
        'btnCaripasien
        '
        Me.btnCaripasien.Location = New System.Drawing.Point(203, 27)
        Me.btnCaripasien.Name = "btnCaripasien"
        Me.btnCaripasien.Size = New System.Drawing.Size(64, 27)
        Me.btnCaripasien.TabIndex = 54
        Me.btnCaripasien.Text = "Cari"
        Me.btnCaripasien.UseVisualStyleBackColor = True
        '
        'txtkodepsn
        '
        Me.txtkodepsn.Enabled = False
        Me.txtkodepsn.Location = New System.Drawing.Point(20, 30)
        Me.txtkodepsn.Name = "txtkodepsn"
        Me.txtkodepsn.Size = New System.Drawing.Size(175, 23)
        Me.txtkodepsn.TabIndex = 54
        '
        'txtnamapsn
        '
        Me.txtnamapsn.Enabled = False
        Me.txtnamapsn.Location = New System.Drawing.Point(135, 63)
        Me.txtnamapsn.Name = "txtnamapsn"
        Me.txtnamapsn.Size = New System.Drawing.Size(167, 23)
        Me.txtnamapsn.TabIndex = 55
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(790, 380)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(87, 27)
        Me.btnbatal.TabIndex = 49
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(695, 380)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(87, 27)
        Me.btnhapus.TabIndex = 48
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(511, 380)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(87, 27)
        Me.btnsimpan.TabIndex = 47
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(178, 30)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(175, 23)
        Me.txtkode.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Tanggal"
        '
        'dttanggal
        '
        Me.dttanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttanggal.Location = New System.Drawing.Point(178, 60)
        Me.dttanggal.Name = "dttanggal"
        Me.dttanggal.Size = New System.Drawing.Size(175, 23)
        Me.dttanggal.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Kode Registrasi"
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
        Me.TabPage2.Size = New System.Drawing.Size(931, 438)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Registrasi"
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
        Me.dataGridView1.Size = New System.Drawing.Size(856, 288)
        Me.dataGridView1.TabIndex = 51
        '
        'txtcari
        '
        Me.txtcari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcari.Location = New System.Drawing.Point(687, 7)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(172, 23)
        Me.txtcari.TabIndex = 30
        '
        'btnCariData
        '
        Me.btnCariData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCariData.Location = New System.Drawing.Point(596, 5)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(84, 27)
        Me.btnCariData.TabIndex = 31
        Me.btnCariData.Text = "Cari"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(800, 493)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 33)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormRegistrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(943, 540)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormRegistrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnamapoli As System.Windows.Forms.TextBox
    Friend WithEvents txtkodepoli As System.Windows.Forms.TextBox
    Friend WithEvents btncaridokter As System.Windows.Forms.Button
    Friend WithEvents txtkodedokter As System.Windows.Forms.TextBox
    Friend WithEvents txtnamadokter As System.Windows.Forms.TextBox
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttgllahir As System.Windows.Forms.TextBox
    Friend WithEvents lblnamakk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnamakk As System.Windows.Forms.TextBox
    Friend WithEvents btnCaripasien As System.Windows.Forms.Button
    Friend WithEvents txtkodepsn As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapsn As System.Windows.Forms.TextBox
    Friend WithEvents lbltgllahirkk As System.Windows.Forms.Label
    Friend WithEvents txttgllahirkk As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnotelpon As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
End Class
