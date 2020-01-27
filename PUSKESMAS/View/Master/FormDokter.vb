Public Class FormDokter
    Private editMode As Boolean
    Private Sub FormDokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New DokterModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New Dokter
                entity.kd_poli = txtkodepoli.Text
                entity.kd_dok = txtkode.Text
                entity.nm_dok = txtnama.Text
                entity.alamat_dok = txtalamat.Text
                entity.tgl_lahir_dok = dttanggal.Value.Date
                entity.notelp_dok = txtnotelp.Text
                entity.password = txtpassword.Text
                If (radiopria.Checked) Then
                    entity.jk_dok = radiopria.Text
                Else
                    entity.jk_dok = radiowanita.Text
                End If

                Dim model As New DokterModel
                If Not editMode Then
                    If model.count(entity.kd_dok) = 0 Then
                        If model.save(entity) Then
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_dok & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtkode.Clear()
        txtnama.Clear()
        txtkodepoli.Clear()
        txtnamapoli.Clear()
        txtalamat.Clear()
        txtnotelp.Clear()
        txtpassword.Clear()
        txtcari.Clear()
        radiopria.Checked = True
        btnhapus.Enabled = False
        txtcari.Enabled = True
        txtkode.Enabled = True
        editMode = False
        dttanggal.Text = Date.Now.Date
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkodepoli.Text = "") Then
            MessageBox.Show("pilih poli", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtnama.Text = "") Then
            MessageBox.Show("Nama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtalamat.Text = "") Then
            MessageBox.Show("Alamat tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtnotelp.Text = "") Then
            MessageBox.Show("No.Telepon tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtpassword.Text = "") Then
            MessageBox.Show("Password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New DokterModel
            Dim entity As Dokter = model.getOBJBy(kode)
            If (entity.kd_dok <> "") Then
                txtkode.Text = entity.kd_dok
                txtnama.Text = entity.nm_dok
                txtkodepoli.Text = entity.kd_poli
                txtnamapoli.Text = entity.nm_poli
                txtalamat.Text = entity.alamat_dok
                dttanggal.Value = entity.tgl_lahir_dok
                txtnotelp.Text = entity.notelp_dok
                txtpassword.Text = entity.password
                If entity.jk_dok = radiopria.Text Then
                    radiopria.Checked = True
                Else
                    radiowanita.Checked = True
                End If
                txtkode.Enabled = False
                btnhapus.Enabled = True
                editMode = True
            Else
                MessageBox.Show("Kode " & entity.kd_dok & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New DokterModel
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
 
    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        initForm()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        save()
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

    Private Sub btnCarikk_Click(sender As Object, e As EventArgs) Handles btnCarikk.Click
        LookupPoli.ShowDialog()
        If (_kodepoli <> "") Then
            txtkodepoli.Text = _kodepoli
            txtnamapoli.Text = _namapoli
        End If
        _kodepoli = ""
        _namapoli = ""
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub txtnotelp_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtnotelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

End Class