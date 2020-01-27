Public Class FormTindakan
    Private editMode As Boolean
    Private Sub FormTindakan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New TindakanModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New Tindakan
                entity.kd_tindakan = txtkode.Text
                entity.nm_tindakan = txtnama.Text
                entity.tarif = txttarif.Text

                Dim model As New TindakanModel
                If Not editMode Then
                    If model.count(entity.kd_tindakan) = 0 Then
                        If model.save(entity) Then
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_tindakan & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If model.update(entity) Then
                        MessageBox.Show("Data berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        initForm()
                    Else
                        MessageBox.Show("Gagal mengubah data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub initForm()
        txtkode.Text = autoCode()
        txtnama.Clear()
        txttarif.Clear()
        txtcari.Clear()
        btnhapus.Enabled = False
        txtcari.Enabled = True
        txtkode.Enabled = False
        editMode = False
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtnama.Text = "") Then
            MessageBox.Show("Nama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttarif.Text = "") Then
            MessageBox.Show("Tarif tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New TindakanModel
            Dim entity As Tindakan = model.getOBJBy(kode)
            If (entity.kd_tindakan <> "") Then
                txtkode.Text = entity.kd_tindakan
                txtnama.Text = entity.nm_tindakan
                txttarif.Text = entity.tarif
                txtkode.Enabled = False
                btnhapus.Enabled = True
                editMode = True
            Else
                MessageBox.Show("Kode " & entity.kd_tindakan & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New TindakanModel
            If (model.cekAvailable(kode) = 0) Then
                If (model.delete(kode)) Then
                    MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    initForm()
                Else
                    MessageBox.Show("gagal menghapus data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("data sedang digunakan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Function autoCode() As String
        Dim model As New TindakanModel
        Dim code As String
        Dim entity As Tindakan = model.getLast()
        If (entity.kd_tindakan = "") Then
            code = "TDK0000001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_tindakan, 4, Len(entity.kd_tindakan) - 3)) + 1
            If (Len(code) = 1) Then
                code = "TDK000000" & code
            ElseIf (Len(code) = 2) Then
                code = "TDK00000" & code
            ElseIf (Len(code) = 3) Then
                code = "TDK0000" & code
            ElseIf (Len(code) = 4) Then
                code = "TDK000" & code
            ElseIf (Len(code) = 5) Then
                code = "TDK00" & code
            ElseIf (Len(code) = 6) Then
                code = "TDK0" & code
            Else
                code = "TDK" & code
            End If
        End If

        Return code
    End Function
    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        initForm()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        save()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs)
        cari(txtkode.Text)
    End Sub

    Private Sub btnCariData_Click(sender As Object, e As EventArgs) Handles btnCariData.Click
        fillGrid(txtcari.Text)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        delete(txtkode.Text)
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            fillGrid(txtcari.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dispose()
    End Sub

    Private Sub txttarif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttarif.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

End Class