Public Class FormTebusResep
    Private editMode As Boolean
    Private laststok As String
    Private Sub FormTebusResep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New ResepModel
        dataGridView1.DataSource = model.getStatusBy(keyword, "1")
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New Resep
                entity.kd_resep = txtkoderesep.Text
                entity.status = 1
                Dim model As New ResepModel
                If Not editMode Then
                        If model.updateStatus(entity) Then
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim obatmodel As New ObatModel
                        For i As Integer = 0 To DataGridView2.RowCount - 1
                            obatmodel.updateSok(DataGridView2.Rows(i).Cells(0).Value, -Val(DataGridView2.Rows(i).Cells(2).Value))
                        Next
                        initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                Else
                    If model.updateStatus(entity) Then
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
      
        txtkoderesep.Clear()
        txttglresep.Clear()
        txtnamadokter.Clear()
        txtnamapoli.Clear()
        txtnamapsn.Clear()
        txtcari.Clear()
        btnhapus.Enabled = False
        txtcari.Enabled = True
        editMode = False
        DataGridView2.Rows.Clear()
        laststok = ""
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkoderesep.Text = "") Then
            MessageBox.Show("Pilih resep", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New ResepModel
            Dim entity As Resep = model.getOBJBy(kode)
            If (entity.kd_resep <> "") Then
                txtkoderesep.Text = entity.kd_resep
                txttglresep.Text = entity.tgl_resep
                txtnamadokter.Text = entity.nm_dok
                txtnamapsn.Text = entity.nm_psn
                txtnamapoli.Text = entity.nm_poli
                laststok = entity.detail
                Dim detail() As String
                detail = entity.detail.Split(",")
                DataGridView2.Rows.Clear()
                For i As Integer = 0 To detail.Length - 1
                    Dim details() As String
                    details = detail(i).Split("|")
                    DataGridView2.Rows.Add()
                    DataGridView2.Rows(i).Cells(0).Value = details(0)
                    DataGridView2.Rows(i).Cells(1).Value = details(1)
                    DataGridView2.Rows(i).Cells(2).Value = details(2)
                    DataGridView2.Rows(i).Cells(3).Value = details(3)
                Next

                editMode = True

                btnhapus.Enabled = True
            Else
                MessageBox.Show("Kode " & entity.kd_rm & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New ResepModel
            Dim entity As New Resep
            entity.kd_resep = kode
            entity.status = 0
            If (model.cekAvailable(kode) = 0) Then
                If (model.updateStatus(entity)) Then
                    Dim obatmodel As New ObatModel
                    Dim detail() As String
                    detail = laststok.Split(",")
                    For j As Integer = 0 To detail.Length - 1
                        Dim details() As String
                        details = detail(j).Split("|")
                        obatmodel.updateSok(detail(0), Val(detail(2)))
                    Next
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
        btnsimpan.Enabled = True
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        save()
    End Sub

    Private Sub btnCariData_Click(sender As Object, e As EventArgs) Handles btnCariData.Click
        fillGrid(txtcari.Text)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        delete(txtkoderesep.Text)
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            fillGrid(txtcari.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dispose()
    End Sub


    Private Sub btnCarireg_Click(sender As Object, e As EventArgs) Handles btnCarireg.Click
        LookupResep.ShowDialog()
        If (_koderesep <> "") Then
            txtkoderesep.Text = _koderesep
            txttglresep.Text = _tglresep
            txtnamadokter.Text = _namadok
            txtnamapsn.Text = _namapsn
            txtnamapoli.Text = _namapoli

            Dim model As New ResepModel
            Dim entity As Resep = model.getOBJBy(_koderesep)
            Dim detail() As String
            detail = entity.detail.Split(",")
            DataGridView2.Rows.Clear()
            For i As Integer = 0 To detail.Length - 1
                Dim details() As String
                details = detail(i).Split("|")
                DataGridView2.Rows.Add()
                DataGridView2.Rows(i).Cells(0).Value = details(0)
                DataGridView2.Rows(i).Cells(1).Value = details(1)
                DataGridView2.Rows(i).Cells(2).Value = details(2)
                DataGridView2.Rows(i).Cells(3).Value = details(3)
            Next
        End If
        _koderesep = ""
        _tglreg = Nothing
        _namadok = ""
        _namapsn = ""
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
            btnsimpan.Enabled = False
        End If
    End Sub



End Class