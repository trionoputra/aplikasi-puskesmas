Public Class LoginForm
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (cekEmpty()) Then

            Dim data As New User
            If (cmblevel.Text <> "Dokter") Then
                Dim model As New UserModel
                data = model.login(UsernameTextBox.Text, PasswordTextBox.Text)
            Else
                Dim model As New DokterModel
                data = model.login(UsernameTextBox.Text, PasswordTextBox.Text)
            End If

            If (data.kd_user <> "") Then
                _sessionID = data.kd_user
                _sessionUsername = data.username
                _sessionLevel = data.level
                _sessionNama = data.nama
                menuutama.Show()
                Me.Close()
            Else
                MessageBox.Show("Username atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmblevel.SelectedIndex = 0
    End Sub
    Private Sub initForm()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub
    Private Function cekEmpty()
        If (UsernameTextBox.Text = "") Then
            MessageBox.Show("Username tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (PasswordTextBox.Text = "") Then
            MessageBox.Show("Password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

   

End Class
