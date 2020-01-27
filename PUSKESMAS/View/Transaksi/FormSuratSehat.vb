Public Class FormSuratSehat
    Private editMode As Boolean
    Private Sub FormSuratSehat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New SuratSehatModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New SuratSehat
                entity.kd_srsht = txtkode.Text
                entity.tgl_srsht = dttanggal.Value.Date
                entity.keperluan = txtkeperluan.Text
                entity.bb = txtbb.Text
                entity.tb = txttb.Text
                entity.tensi = txttensi.Text
                entity.kd_rm = txtkoderm.Text

                Dim model As New SuratSehatModel
                If Not editMode Then
                    If model.count(entity.kd_srsht) = 0 Then
                        If model.save(entity) Then
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cetak(entity.kd_srsht)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_rm & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtkeperluan.Clear()
        txtbb.Clear()
        txttb.Clear()
        txttensi.Clear()
        btncetak.Enabled = False
        dttanggal.Text = Now.Date
        txtkoderm.Clear()
        txttglrm.Clear()
        txtnamadokter.Clear()
        txtnamapoli.Clear()
        txtnamapsn.Clear()
        txtcari.Clear()
        btnhapus.Enabled = False
        txtcari.Enabled = True
        txtkode.Enabled = False
        editMode = False
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkoderm.Text = "") Then
            MessageBox.Show("Pilih Rekam medis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtbb.Text = "") Then
            MessageBox.Show("Berat Badan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttb.Text = "") Then
            MessageBox.Show("Tinggi Badan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttensi.Text = "") Then
            MessageBox.Show("Tensi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkeperluan.Text = "") Then
            MessageBox.Show("Keperluan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New SuratSehatModel
            Dim entity As SuratSehat = model.getOBJBy(kode)
            If (entity.kd_srsht <> "") Then
                txtkode.Text = entity.kd_srsht
                dttanggal.Text = entity.tgl_srsht
                txtkeperluan.Text = entity.keperluan
                txtbb.Text = entity.bb
                txttb.Text = entity.tb
                txttensi.Text = entity.tensi

                txtkoderm.Text = entity.kd_rm
                txttglrm.Text = entity.tgl_rm
                txtnamadokter.Text = entity.nm_dok
                txtnamapsn.Text = entity.nm_psn
                txtnamapoli.Text = entity.nm_poli
                editMode = True
                txtkode.Enabled = False
                btncetak.Enabled = True
                btnhapus.Enabled = True
            Else
                MessageBox.Show("Kode " & entity.kd_rm & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New SuratSehatModel
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
        Dim model As New SuratSehatModel
        Dim code As String
        Dim entity As SuratSehat = model.getLast()
        If (entity.kd_srsht = "") Then
            code = "SRSHT00001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_srsht, 6, Len(entity.kd_srsht) - 5)) + 1
            If (Len(code) = 1) Then
                code = "SRSHT0000" & code
            ElseIf (Len(code) = 2) Then
                code = "SRSHT000" & code
            ElseIf (Len(code) = 3) Then
                code = "SRSHT00" & code
            ElseIf (Len(code) = 4) Then
                code = "SRSHT0" & code
            Else
                code = "SRSHT" & code
            End If
        End If

        Return code
    End Function
    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        initForm()
        btnsimpan.Enabled = True
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

    Private Sub txtberatbadan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbb.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttinggibadan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttb.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttekanandarah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttensi.KeyPress

    End Sub

    Private Sub btnCarireg_Click(sender As Object, e As EventArgs) Handles btnCarireg.Click
        Dim lookup As New LookupRekammedisUmum
        lookup.tipe = "srsht"
        lookup.ShowDialog()
        If (_kdrm <> "") Then
            txtkoderm.Text = _kdrm
            txttglrm.Text = _tglrm
            txtnamadokter.Text = _namadok
            txtnamapsn.Text = _namapsn
            txtnamapoli.Text = _namapoli

        End If
        _kdrm = ""
        _tglrm = Nothing
        _namadok = ""
        _namapsn = ""
        _namapoli = ""

    End Sub
    Private Sub cetak(ByVal kode As String)
        Dim model As New SuratSehatModel
        Dim tbReport As DataTable = model.getCetak(kode)
        Dim objRpt As New RptSuratSehat
        objRpt.SetDataSource(tbReport)
        ReportViewer.CrystalReportViewer1.ReportSource = objRpt
        ReportViewer.CrystalReportViewer1.Refresh()
        ReportViewer.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
            btnsimpan.Enabled = False
        End If
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        cetak(txtkode.Text)
    End Sub

End Class