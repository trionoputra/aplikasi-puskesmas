Public Class FormPembayaran
    Private editMode As Boolean
    Private biayaRegistrasi As Integer
    Private isFree As Boolean
    Private Sub FormPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New KwitansiModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New Kwitansi
                entity.kd_kw = txtkode.Text
                entity.tgl_kw = dttanggal.Value.Date
                entity.kd_reg = txtkodereg.Text
                entity.total_bayar = 0
                For i As Integer = 0 To DataGridView2.RowCount - 1
                    entity.total_bayar = entity.total_bayar + DataGridView2.Rows(i).Cells(3).Value
                Next

                If (txttotal.Text = 0) Then
                    entity.status = "Gratis"
                Else
                    entity.status = "Bayar"
                End If
                Dim model As New KwitansiModel
                If Not editMode Then
                    If model.count(entity.kd_kw) = 0 Then
                        If model.save(entity) Then
                            Dim entityDetail As New Kwitansi
                            entityDetail.kd_kw = entity.kd_kw
                            For i As Integer = 0 To DataGridView2.RowCount - 1
                                entityDetail.kd_uraian = DataGridView2.Rows(i).Cells(4).Value
                                entityDetail.uraian = DataGridView2.Rows(i).Cells(1).Value
                                entityDetail.tarif = DataGridView2.Rows(i).Cells(3).Value
                                model.saveDetail(entityDetail)
                            Next
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cetak(entity.kd_kw)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_rm & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If model.update(entity) Then
                        Dim entityDetail As New Kwitansi
                        model.deleteDetail(entity.kd_kw)
                        entityDetail.kd_kw = entity.kd_kw
                        For i As Integer = 0 To DataGridView2.RowCount - 1
                            entityDetail.kd_uraian = DataGridView2.Rows(i).Cells(4).Value
                            entityDetail.uraian = DataGridView2.Rows(i).Cells(1).Value
                            entityDetail.tarif = DataGridView2.Rows(i).Cells(2).Value
                            model.saveDetail(entityDetail)
                        Next
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
        biayaRegistrasi = 2000
        txtkode.Text = autoCode()
        txttotal.Clear()
        dttanggal.Text = Now.Date
        txtkodereg.Clear()
        txttglreg.Clear()
        txtnamadokter.Clear()
        txtnamapoli.Clear()
        txtnamapsn.Clear()
        txtcari.Clear()
        txtkdrm.Clear()
        DataGridView2.Rows.Clear()
        btnhapus.Enabled = False
        txtcari.Enabled = True
        txtkode.Enabled = False
        btncetak.Enabled = False
        editMode = False
        isFree = False
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkodereg.Text = "") Then
            MessageBox.Show("Pilih Registrasi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New KwitansiModel
            Dim entity As Kwitansi = model.getOBJBy(kode)
            If (entity.kd_kw <> "") Then
                txtkode.Text = entity.kd_kw
                dttanggal.Text = entity.tgl_kw
                txtkode.Text = entity.kd_kw
                txtkdrm.Text = entity.kd_rm
                txtkodereg.Text = entity.kd_reg
                txttglreg.Text = entity.tgl_reg
                txtnamadokter.Text = entity.nm_dok
                txtnamapsn.Text = entity.nm_psn
                txtnamapoli.Text = entity.nm_poli
                cariDetailKwitansi(entity.kd_kw)
                editMode = True
                txtkode.Enabled = False
                btnhapus.Enabled = True
                btncetak.Enabled = True
            Else
                MessageBox.Show("Kode " & entity.kd_kw & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New KwitansiModel
            If (model.cekAvailable(kode) = 0) Then
                If (model.delete(kode)) Then
                    model.deleteDetail(kode)
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
        Dim model As New KwitansiModel
        Dim code As String
        Dim entity As Kwitansi = model.getLast()
        If (entity.kd_kw = "") Then
            code = "KWT0000001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_kw, 4, Len(entity.kd_kw) - 3)) + 1
            If (Len(code) = 1) Then
                code = "KWT000000" & code
            ElseIf (Len(code) = 2) Then
                code = "KWT00000" & code
            ElseIf (Len(code) = 3) Then
                code = "KWT0000" & code
            ElseIf (Len(code) = 4) Then
                code = "KWT000" & code
            ElseIf (Len(code) = 5) Then
                code = "KWT00" & code
            ElseIf (Len(code) = 6) Then
                code = "KWT0" & code
            Else
                code = "KWT" & code
            End If
        End If

        Return code
    End Function
    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        initForm()
        btnsimpan.Enabled = True
    End Sub
    Private Sub cariDetail(ByVal kode As String)
        Dim model As New RekamMedisUmumModel
        Dim entity As RekamMedisUmum = model.getOBJByReg(kode)
        Dim total As Integer = 0
        DataGridView2.Rows.Clear()
        DataGridView2.Rows.Add()
        DataGridView2.Rows(0).Cells(0).Value = 1
        DataGridView2.Rows(0).Cells(1).Value = "Registrasi"
        DataGridView2.Rows(0).Cells(2).Value = biayaRegistrasi
        DataGridView2.Rows(0).Cells(3).Value = biayaRegistrasi
        DataGridView2.Rows(0).Cells(4).Value = "REG1"
        If (entity.jenis_psn = "JamKes") Then
            isFree = True
            DataGridView2.Rows(0).Cells(2).Value = 0
        Else
            total += biayaRegistrasi
        End If
        If (entity.detail <> "") Then
            Dim detail() As String
            detail = entity.detail.Split(",")

            Dim j As Integer = 1
            For i As Integer = 0 To detail.Length - 1
                Dim details() As String
                details = detail(i).Split("|")
                DataGridView2.Rows.Add()
                DataGridView2.Rows(j).Cells(0).Value = j + 1
                DataGridView2.Rows(j).Cells(1).Value = details(1)
                If (entity.jenis_psn = "JamKes") Then
                    DataGridView2.Rows(j).Cells(2).Value = 0
                    total += 0
                Else
                    DataGridView2.Rows(j).Cells(2).Value = details(2)
                    total += details(2)
                End If
                DataGridView2.Rows(j).Cells(3).Value = details(2)
                DataGridView2.Rows(j).Cells(4).Value = details(0)
                j = j + 1
            Next
        End If
        txttotal.Text = total
    End Sub
    Private Sub cariDetailKwitansi(ByVal kode As String)
        Dim model As New KwitansiModel
        Dim entity As Kwitansi = model.getOBJBy(kode)
        Dim total As Integer = 0
        DataGridView2.Rows.Clear()
        If (entity.jenis_psn = "JamKes") Then
            isFree = True
        End If
        If (entity.detail <> "") Then
            Dim detail() As String
            detail = entity.detail.Split(",")

            Dim j As Integer = 0
            For i As Integer = 0 To detail.Length - 1
                Dim details() As String
                details = detail(i).Split("|")
                DataGridView2.Rows.Add()
                DataGridView2.Rows(j).Cells(0).Value = j + 1
                DataGridView2.Rows(j).Cells(1).Value = details(1)
                If (entity.jenis_psn = "JamKes") Then
                    DataGridView2.Rows(j).Cells(2).Value = 0
                    total += 0
                Else
                    DataGridView2.Rows(j).Cells(2).Value = details(2)
                    total += details(2)
                End If
                DataGridView2.Rows(j).Cells(3).Value = details(2)
                DataGridView2.Rows(j).Cells(4).Value = details(0)
                j = j + 1
            Next
        End If
        txttotal.Text = total
    End Sub
    Private Sub cetak(ByVal kode As String)
        Dim model As New KwitansiModel
        Dim tbReport As DataTable = model.getCetak(kode)
        Dim objRpt As New RptKwitansi
        objRpt.SetDataSource(tbReport)
        If (isFree) Then
            objRpt.SetParameterValue("biaya", 0)
        Else
            objRpt.SetParameterValue("biaya", biayaRegistrasi)
        End If
        ReportViewer.CrystalReportViewer1.ReportSource = objRpt
        ReportViewer.CrystalReportViewer1.Refresh()
        ReportViewer.ShowDialog()
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
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
            btnsimpan.Enabled = False
        End If
    End Sub

    Private Sub btnCarireg_Click_1(sender As Object, e As EventArgs) Handles btnCarireg.Click
        Dim lookup As New LookupRekammedisUmum
        lookup.tipe = "kwitansi"
        lookup.ShowDialog()
        If (_kdrm <> "") Then
            txtkodereg.Text = _kodereg
            txttglreg.Text = _tglreg
            txtnamadokter.Text = _namadok
            txtnamapsn.Text = _namapsn
            txtnamapoli.Text = _namapoli
            txtkdrm.Text = _kdrm
            cariDetail(_kdrm)
        End If
        _kdrm = ""
        _kodereg = ""
        _tglreg = Nothing
        _namadok = ""
        _namapsn = ""
        _namapoli = ""

    End Sub
    Private Sub btnsimpancetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        cetak(txtkode.Text)
    End Sub

   
End Class