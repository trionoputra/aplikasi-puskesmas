Public Class ChangePassword
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (cekEmpty()) Then
            Dim data As New User
            Dim res As Boolean = False
            If (_sessionLevel <> "Dokter") Then
                Dim model As New UserModel
                res = model.changePassword(_sessionID, txtpasswordbaru.Text)
            Else
                Dim model As New DokterModel
                res = model.changePassword(_sessionID, txtpasswordbaru.Text)
            End If

            If res Then
                MessageBox.Show("password berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                initForm()
            Else
                MessageBox.Show("Gagal mengubah password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub
    Private Sub initForm()
        txtusername.Text = _sessionUsername
        txtpasswordlama.Clear()
        txtpasswordbaru.Clear()
        txtkofirmasipasswordbaru.Clear()
    End Sub
    Private Function cekEmpty()
        If (txtusername.Text = "") Then
            MessageBox.Show("Username tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtpasswordlama.Text = "") Then
            MessageBox.Show("Password Lama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtpasswordbaru.Text = "") Then
            MessageBox.Show("Password Baru tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkofirmasipasswordbaru.Text = "") Then
            MessageBox.Show("Konfimasi Password Baru tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkofirmasipasswordbaru.Text <> txtpasswordbaru.Text) Then
            MessageBox.Show("Konfirmasi password tidak sama ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim data As New User
        If (_sessionLevel <> "Dokter") Then
            Dim model As New UserModel
            data = model.login(txtusername.Text, txtpasswordlama.Text)
        Else
            Dim model As New DokterModel
            data = model.login(txtusername.Text, txtpasswordlama.Text)
        End If

        If (data.kd_user = "") Then
            MessageBox.Show("password lama salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    
End Class
