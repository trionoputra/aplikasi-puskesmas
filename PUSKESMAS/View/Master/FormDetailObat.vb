Public Class FormDetailObat
    Private editMode As Boolean
    Private id As Integer
    Private lastStok As Integer
    Private Sub FormDetailObat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New DetailObatModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New DetailObat
                entity.no_batch = txtkode.Text
                entity.kd_obat = txtkodeobat.Text
                entity.exp_date = dttanggal.Text
                entity.tgl_masuk = dttanggalmasuk.Text
                entity.jml_masuk = txtjumlah.Text
                Dim model As New DetailObatModel
                If Not editMode Then
                    If model.count(entity.kd_obat, entity.no_batch) = 0 Then
                        If model.save(entity) Then
                            Dim model2 As New ObatModel
                            model2.updateSok(entity.kd_obat, Val(entity.jml_masuk))
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.no_batch & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    entity.id_detail_obat = id
                    If model.update(entity) Then
                        Dim model2 As New ObatModel

                        model2.updateSok(entity.kd_obat, Val(entity.jml_masuk) - lastStok)
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
        lastStok = Nothing
        editMode = False
        txtkode.Clear()
        dttanggal.Text = Now.Date
        dttanggalmasuk.Text = Now.Date
        txtjumlah.Clear()
        txtcari.Clear()
        btnhapus.Enabled = False
        txtcari.Enabled = True
        id = -1
        txtkode.Enabled = True
        txtnamaobat.Clear()
        txtkodeobat.Clear()
        btnCariobat.Enabled = True

        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkode.Text = "") Then
            MessageBox.Show("No. Batch tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkodeobat.Text = "") Then
            MessageBox.Show("pilih obat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtjumlah.Text = "") Then
            MessageBox.Show("jumlah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = 0 Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New DetailObatModel
            Dim entity As DetailObat = model.getOBJBy(kode)
            If (entity.id_detail_obat <> 0) Then
                txtkode.Text = entity.no_batch
                txtkodeobat.Text = entity.kd_obat
                txtnamaobat.Text = entity.nm_obat
                dttanggal.Text = entity.exp_date
                dttanggalmasuk.Text = entity.tgl_masuk
                txtjumlah.Text = entity.jml_masuk
                lastStok = entity.jml_masuk
                id = entity.id_detail_obat
                txtkode.Enabled = False
                btnhapus.Enabled = True
                btnCariobat.Enabled = False
                editMode = True
            Else
                MessageBox.Show("Kode " & entity.id_detail_obat & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New DetailObatModel
            If (model.cekAvailable(txtkodeobat.Text) = 0) Then
                If (model.delete(kode)) Then
                    Dim model2 As New ObatModel
                    model2.updateSok(txtkodeobat.Text, -lastStok)
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
        delete(id)
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            fillGrid(txtcari.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dispose()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

    Private Sub btnCariobat_Click(sender As Object, e As EventArgs) Handles btnCariobat.Click
        LookupObat.ShowDialog()
        If (_kodeobat <> "") Then
            txtkodeobat.Text = _kodeobat
            txtnamaobat.Text = _namaobat
        End If
        _kodeobat = ""
        _namaobat = ""
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick

    End Sub
End Class