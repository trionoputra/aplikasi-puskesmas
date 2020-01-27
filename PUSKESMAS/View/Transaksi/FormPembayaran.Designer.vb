<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnamadokter = New System.Windows.Forms.TextBox()
        Me.txtnamapoli = New System.Windows.Forms.TextBox()
        Me.txtnamapsn = New System.Windows.Forms.TextBox()
        Me.txttglreg = New System.Windows.Forms.TextBox()
        Me.btnCarireg = New System.Windows.Forms.Button()
        Me.txtkodereg = New System.Windows.Forms.TextBox()
        Me.dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtkdrm = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btnCariData = New System.Windows.Forms.Button()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nm_tindakan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biayadb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_tindakan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(689, 569)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 33)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(827, 554)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage1.Controls.Add(Me.txttotal)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Controls.Add(Me.btncetak)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.dttanggal)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btnbatal)
        Me.TabPage1.Controls.Add(Me.btnhapus)
        Me.TabPage1.Controls.Add(Me.btnsimpan)
        Me.TabPage1.Controls.Add(Me.txtkdrm)
        Me.TabPage1.Controls.Add(Me.txtkode)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(819, 526)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form Pembayaran"
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(624, 421)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(175, 23)
        Me.txttotal.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Total Bayar"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.nm_tindakan, Me.biaya, Me.biayadb, Me.kd_tindakan})
        Me.DataGridView2.Location = New System.Drawing.Point(19, 215)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(778, 181)
        Me.DataGridView2.TabIndex = 66
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(514, 467)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(97, 27)
        Me.btncetak.TabIndex = 65
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Controls.Add(Me.txttglreg)
        Me.GroupBox1.Controls.Add(Me.btnCarireg)
        Me.GroupBox1.Controls.Add(Me.txtkodereg)
        Me.GroupBox1.Location = New System.Drawing.Point(441, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 201)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Registrasi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 15)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Nama Dokter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Nama Poli"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Nama Pasien"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Tanggal Registrasi"
        '
        'txtnamadokter
        '
        Me.txtnamadokter.Enabled = False
        Me.txtnamadokter.Location = New System.Drawing.Point(163, 155)
        Me.txtnamadokter.Name = "txtnamadokter"
        Me.txtnamadokter.Size = New System.Drawing.Size(149, 23)
        Me.txtnamadokter.TabIndex = 69
        '
        'txtnamapoli
        '
        Me.txtnamapoli.Enabled = False
        Me.txtnamapoli.Location = New System.Drawing.Point(163, 125)
        Me.txtnamapoli.Name = "txtnamapoli"
        Me.txtnamapoli.Size = New System.Drawing.Size(149, 23)
        Me.txtnamapoli.TabIndex = 68
        '
        'txtnamapsn
        '
        Me.txtnamapsn.Enabled = False
        Me.txtnamapsn.Location = New System.Drawing.Point(162, 91)
        Me.txtnamapsn.Name = "txtnamapsn"
        Me.txtnamapsn.Size = New System.Drawing.Size(149, 23)
        Me.txtnamapsn.TabIndex = 67
        '
        'txttglreg
        '
        Me.txttglreg.Enabled = False
        Me.txttglreg.Location = New System.Drawing.Point(162, 61)
        Me.txttglreg.Name = "txttglreg"
        Me.txttglreg.Size = New System.Drawing.Size(149, 23)
        Me.txttglreg.TabIndex = 66
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
        'txtkodereg
        '
        Me.txtkodereg.Enabled = False
        Me.txtkodereg.Location = New System.Drawing.Point(21, 31)
        Me.txtkodereg.Name = "txtkodereg"
        Me.txtkodereg.Size = New System.Drawing.Size(219, 23)
        Me.txtkodereg.TabIndex = 54
        '
        'dttanggal
        '
        Me.dttanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttanggal.Location = New System.Drawing.Point(173, 54)
        Me.dttanggal.Name = "dttanggal"
        Me.dttanggal.Size = New System.Drawing.Size(179, 23)
        Me.dttanggal.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Tanggal"
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(713, 467)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(87, 27)
        Me.btnbatal.TabIndex = 49
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(618, 467)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(87, 27)
        Me.btnhapus.TabIndex = 48
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(407, 467)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(100, 27)
        Me.btnsimpan.TabIndex = 47
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtkdrm
        '
        Me.txtkdrm.Enabled = False
        Me.txtkdrm.Location = New System.Drawing.Point(373, 303)
        Me.txtkdrm.Name = "txtkdrm"
        Me.txtkdrm.Size = New System.Drawing.Size(219, 23)
        Me.txtkdrm.TabIndex = 74
        Me.txtkdrm.Visible = False
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(173, 23)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(179, 23)
        Me.txtkode.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Kode Kwitasi"
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
        Me.TabPage2.Size = New System.Drawing.Size(819, 526)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Pembayaran"
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
        Me.dataGridView1.Size = New System.Drawing.Size(805, 419)
        Me.dataGridView1.TabIndex = 51
        '
        'txtcari
        '
        Me.txtcari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcari.Location = New System.Drawing.Point(625, 7)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(172, 23)
        Me.txtcari.TabIndex = 30
        '
        'btnCariData
        '
        Me.btnCariData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCariData.Location = New System.Drawing.Point(534, 5)
        Me.btnCariData.Name = "btnCariData"
        Me.btnCariData.Size = New System.Drawing.Size(84, 27)
        Me.btnCariData.TabIndex = 31
        Me.btnCariData.Text = "Cari"
        Me.btnCariData.UseVisualStyleBackColor = True
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        '
        'nm_tindakan
        '
        Me.nm_tindakan.HeaderText = "Nama"
        Me.nm_tindakan.Name = "nm_tindakan"
        Me.nm_tindakan.ReadOnly = True
        Me.nm_tindakan.Width = 420
        '
        'biaya
        '
        Me.biaya.HeaderText = "Biaya"
        Me.biaya.Name = "biaya"
        Me.biaya.ReadOnly = True
        '
        'biayadb
        '
        Me.biayadb.HeaderText = "biayadb"
        Me.biayadb.Name = "biayadb"
        Me.biayadb.ReadOnly = True
        Me.biayadb.Visible = False
        '
        'kd_tindakan
        '
        Me.kd_tindakan.HeaderText = "Kode Tindakan"
        Me.kd_tindakan.Name = "kd_tindakan"
        Me.kd_tindakan.ReadOnly = True
        Me.kd_tindakan.Visible = False
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(832, 616)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button4)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents dttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents btnCariData As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCarireg As System.Windows.Forms.Button
    Friend WithEvents txtkodereg As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnamadokter As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapoli As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapsn As System.Windows.Forms.TextBox
    Friend WithEvents txttglreg As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtkdrm As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nm_tindakan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biayadb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kd_tindakan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
