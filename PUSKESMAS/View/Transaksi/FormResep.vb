Public Class FormResep
    Private editMode As Boolean
    Private laststok As String
    Private Sub FormResep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New ResepModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New Resep
                entity.kd_resep = txtkode.Text
                entity.tgl_resep = dttanggal.Value.Date
                entity.kd_rm = txtkoderm.Text
                entity.status = 0
                Dim model As New ResepModel
                If Not editMode Then
                    If model.count(entity.kd_resep) = 0 Then
                        If model.save(entity) Then
                            Dim entityDetail As New Resep
                            entityDetail.kd_resep = entity.kd_resep
                            For i As Integer = 0 To DataGridView2.RowCount - 1
                                entityDetail.kd_obat = DataGridView2.Rows(i).Cells(0).Value
                                entityDetail.jml_obat = DataGridView2.Rows(i).Cells(2).Value
                                entityDetail.aturan_pakai = DataGridView2.Rows(i).Cells(3).Value
                                model.saveDetail(entityDetail)
                            Next
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cetak(entity.kd_resep)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_rm & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If model.update(entity) Then
                        model.deleteDetail(entity.kd_resep)
                        Dim entityDetail As New Resep
                        entityDetail.kd_resep = entity.kd_resep
                        For i As Integer = 0 To DataGridView2.RowCount - 1
                            entityDetail.kd_obat = DataGridView2.Rows(i).Cells(0).Value
                            entityDetail.jml_obat = DataGridView2.Rows(i).Cells(2).Value
                            entityDetail.aturan_pakai = DataGridView2.Rows(i).Cells(3).Value
                            model.saveDetail(entityDetail)

                            Dim obatmodel As New ObatModel
                            Dim detail() As String
                            detail = laststok.Split(",")
                            For j As Integer = 0 To detail.Length - 1
                                Dim details() As String
                                details = detail(j).Split("|")
                                If (entityDetail.kd_obat = details(0)) Then
                                    ' obatmodel.updateSok(entityDetail.kd_obat, Val(entity.jml_obat) - Val(details(2)))
                                End If
                            Next

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
        laststok = ""
        txtkode.Text = autoCode()
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
        btncetak.Enabled = False
        DataGridView2.Rows.Clear()
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkoderm.Text = "") Then
            MessageBox.Show("Pilih rekam medis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (DataGridView2.Rows.Count = 0) Then
            MessageBox.Show("Pilih obat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else


            Dim model As New ObatModel
            For i As Integer = 0 To DataGridView2.RowCount - 1

                If Not IsNumeric(DataGridView2.Rows(i).Cells(2).Value) Then
                    MessageBox.Show("jumlah harus angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                ElseIf Val(DataGridView2.Rows(i).Cells(2).Value <= 0) Then
                    MessageBox.Show("jumlah minimal 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                If Not IsNumeric(DataGridView2.Rows(i).Cells(3).Value) Then
                    MessageBox.Show("aturan pakai harus angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                ElseIf Val(DataGridView2.Rows(i).Cells(3).Value <= 0) Then
                    MessageBox.Show("aturan pakai minimal 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                Dim obat As Obat = model.getOBJBy(DataGridView2.Rows(i).Cells(0).Value)

                If editMode Then
                    Dim obatmodel As New ObatModel
                    Dim detail() As String
                    detail = laststok.Split(",")
                    For j As Integer = 0 To detail.Length - 1
                        Dim details() As String
                        details = detail(j).Split("|")
                        If (DataGridView2.Rows(i).Cells(0).Value = details(0)) Then
                            If Val(DataGridView2.Rows(i).Cells(2).Value) > (Val(obat.stok) + Val(details(2))) Then
                                MessageBox.Show("Stok obat " & obat.nm_obat & " tidak cukup, sisa stok " & (Val(obat.stok) + Val(details(2))), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    Next
                Else
                    If (Val(obat.stok) < Val(DataGridView2.Rows(i).Cells(2).Value)) Then
                        MessageBox.Show("Stok obat " & obat.nm_obat & " tidak cukup, sisa stok " & obat.stok, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If


                End If


            Next

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
                txtkode.Text = entity.kd_resep
                dttanggal.Text = entity.tgl_resep
                txtkoderm.Text = entity.kd_rm
                txttglrm.Text = entity.tgl_rm
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
                    DataGridView2.Rows(i).Cells(4).Value = "hapus"
                Next
                btncetak.Enabled = True
                editMode = True
                txtkode.Enabled = False
                btnhapus.Enabled = True
            Else
                MessageBox.Show("Kode " & entity.kd_rm & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New ResepModel
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
        Dim model As New ResepModel
        Dim code As String
        Dim entity As Resep = model.getLast()
        If (entity.kd_resep = "") Then
            code = "RSP0000001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_resep, 4, Len(entity.kd_resep) - 3)) + 1
            If (Len(code) = 1) Then
                code = "RSP000000" & code
            ElseIf (Len(code) = 2) Then
                code = "RSP00000" & code
            ElseIf (Len(code) = 3) Then
                code = "RSP0000" & code
            ElseIf (Len(code) = 4) Then
                code = "RSP000" & code
            ElseIf (Len(code) = 5) Then
                code = "RSP00" & code
            ElseIf (Len(code) = 6) Then
                code = "RSP0" & code
            Else
                code = "RSP" & code
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

    Private Sub txtberatbadan_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttinggibadan_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttekanandarah_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub btnCarireg_Click(sender As Object, e As EventArgs) Handles btnCarireg.Click
        Dim lookup As New LookupRekammedisUmum
        lookup.tipe = "resep"
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
        _anamnesis = ""
        _diagnosa = ""
        _beratbadan = ""
        _tinggibadan = ""
        _tekanandarah = ""
    End Sub
    Private Sub cetak(ByVal kode As String)
        Dim model As New ResepModel
        Dim tbReport As DataTable = model.getCetak(kode)
        Dim objRpt As New RptResep
        objRpt.SetDataSource(tbReport)
        ReportViewer.CrystalReportViewer1.ReportSource = objRpt
        ReportViewer.CrystalReportViewer1.Refresh()
        ReportViewer.ShowDialog()
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        LookupObat.ShowDialog()
        If (_kodeobat <> "") Then
            Dim hassame As Boolean = False
            For i As Integer = 0 To DataGridView2.RowCount - 1
                If _kodeobat = DataGridView2.Rows(i).Cells(0).Value Then
                    hassame = True
                End If
            Next

            If hassame Then
                MessageBox.Show("obat sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim index As Integer = DataGridView2.RowCount
                DataGridView2.Rows.Add()
                DataGridView2.Rows(index).Cells(0).Value = _kodeobat
                DataGridView2.Rows(index).Cells(1).Value = _namaobat
                DataGridView2.Rows(index).Cells(2).Value = 1
                DataGridView2.Rows(index).Cells(3).Value = 1
                DataGridView2.Rows(index).Cells(4).Value = "hapus"
            End If
        End If
        _kodetidakan = ""
        _namatindakan = ""
        _tariff = ""
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If TypeOf DataGridView2.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            DataGridView2.Rows.RemoveAt(e.RowIndex)
        End If

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

    Private Sub DataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        SendKeys.Send("{F2}")
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        cetak(txtkode.Text)
    End Sub
End Class