<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class ChangePassword
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpasswordlama As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpasswordlama = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.txtpasswordbaru = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtkofirmasipasswordbaru = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(63, 63)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(257, 27)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(63, 95)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(257, 27)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password Lama"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtusername
        '
        Me.txtusername.Enabled = False
        Me.txtusername.Location = New System.Drawing.Point(236, 69)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(189, 23)
        Me.txtusername.TabIndex = 1
        '
        'txtpasswordlama
        '
        Me.txtpasswordlama.Location = New System.Drawing.Point(236, 99)
        Me.txtpasswordlama.Name = "txtpasswordlama"
        Me.txtpasswordlama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswordlama.Size = New System.Drawing.Size(189, 23)
        Me.txtpasswordlama.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.Info
        Me.OK.Location = New System.Drawing.Point(140, 214)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(90, 28)
        Me.OK.TabIndex = 4
        Me.OK.Text = "Simpan"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(249, 214)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(90, 28)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "Keluar"
        '
        'txtpasswordbaru
        '
        Me.txtpasswordbaru.Location = New System.Drawing.Point(236, 129)
        Me.txtpasswordbaru.Name = "txtpasswordbaru"
        Me.txtpasswordbaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasswordbaru.Size = New System.Drawing.Size(189, 23)
        Me.txtpasswordbaru.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(63, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Password Baru"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtkofirmasipasswordbaru
        '
        Me.txtkofirmasipasswordbaru.Location = New System.Drawing.Point(236, 159)
        Me.txtkofirmasipasswordbaru.Name = "txtkofirmasipasswordbaru"
        Me.txtkofirmasipasswordbaru.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtkofirmasipasswordbaru.Size = New System.Drawing.Size(189, 23)
        Me.txtkofirmasipasswordbaru.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(63, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&Konfirmasi Password Baru"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Update Password"
        '
        'ChangePassword
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(488, 254)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtkofirmasipasswordbaru)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpasswordbaru)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtpasswordlama)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpasswordbaru As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkofirmasipasswordbaru As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
