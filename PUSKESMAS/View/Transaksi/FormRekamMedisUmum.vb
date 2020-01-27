Public Class FormRekamMedisUmum
    Private editMode As Boolean
    Public isFromDashboard As Boolean
    Private Sub FormRekamMedisUmum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New RekamMedisUmumModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New RekamMedisUmum
                entity.kd_rm = txtkode.Text
                entity.tgl_rm = dttanggal.Value.Date
                entity.diagnosa = txtdiagnosa.Text
                entity.anamnesis = txtanamnesis.Text
                entity.berat_badan = txtberatbadan.Text
                entity.tinggi_badan = txttinggibadan.Text
                entity.tekanan_darah = txttekanandarah.Text
                entity.kd_reg = txtkodereg.Text

                Dim model As New RekamMedisUmumModel
                If Not editMode Then
                    If model.count(entity.kd_rm) = 0 Then
                        If model.save(entity) Then
                            Dim entityDetail As New RekamMedisUmum
                            entityDetail.kd_rm = entity.kd_rm
                            For i As Integer = 0 To DataGridView2.RowCount - 1
                                entityDetail.kd_tindakan = DataGridView2.Rows(i).Cells(0).Value
                                model.saveDetail(entityDetail)
                            Next
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_rm & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If model.update(entity) Then
                        model.deleteDetail(entity.kd_rm)
                        Dim entityDetail As New RekamMedisUmum
                        entityDetail.kd_rm = entity.kd_rm
                        For i As Integer = 0 To DataGridView2.RowCount - 1
                            entityDetail.kd_tindakan = DataGridView2.Rows(i).Cells(0).Value
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
        txtkode.Text = autoCode()
        txtanamnesis.Clear()
        txtdiagnosa.Clear()
        txtberatbadan.Clear()
        txttinggibadan.Clear()
        txttekanandarah.Clear()
        dttanggal.Text = Now.Date
      
        If Not isFromDashboard Then
            txtkodereg.Clear()
            txttglreg.Clear()
            txtnamadokter.Clear()
            txtnamapoli.Clear()
            txtnamapsn.Clear()
        End If

        txtcari.Clear()
        btnhapus.Enabled = False
        txtcari.Enabled = True
        txtkode.Enabled = False
        editMode = False

        DataGridView2.Rows.Clear()
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtanamnesis.Text = "") Then
            MessageBox.Show("Anamnesis tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtdiagnosa.Text = "") Then
            MessageBox.Show("diagnosa tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtberatbadan.Text = "") Then
            MessageBox.Show("Berat badan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttinggibadan.Text = "") Then
            MessageBox.Show("Tinggi badan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttekanandarah.Text = "") Then
            MessageBox.Show("Tekanan darah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkodereg.Text = "") Then
            MessageBox.Show("pilih registrasi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New RekamMedisUmumModel
            Dim entity As RekamMedisUmum = model.getOBJBy(kode)
            If (entity.kd_rm <> "") Then
                txtkode.Text = entity.kd_rm
                dttanggal.Text = entity.tgl_reg
                txtanamnesis.Text = entity.anamnesis
                txtdiagnosa.Text = entity.diagnosa
                txtberatbadan.Text = entity.berat_badan
                txttinggibadan.Text = entity.tinggi_badan
                txttekanandarah.Text = entity.tekanan_darah
                txtkodereg.Text = entity.kd_reg
                txttglreg.Text = entity.tgl_reg
                txtnamadokter.Text = entity.nm_dok
                txtnamapsn.Text = entity.nm_psn
                txtnamapoli.Text = entity.nm_poli
                editMode = True
                If (entity.detail <> "") Then
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
                        DataGridView2.Rows(i).Cells(3).Value = "hapus"
                    Next
                End If
                txtkode.Enabled = False
                btnhapus.Enabled = True
            Else
                MessageBox.Show("Kode " & entity.kd_rm & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New RekamMedisUmumModel
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
        Dim model As New RekamMedisUmumModel
        Dim code As String
        Dim entity As RekamMedisUmum = model.getLast()
        If (entity.kd_rm = "") Then
            code = "RM0000001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_rm, 3, Len(entity.kd_rm) - 2)) + 1
            If (Len(code) = 1) Then
                code = "RM000000" & code
            ElseIf (Len(code) = 2) Then
                code = "RM00000" & code
            ElseIf (Len(code) = 3) Then
                code = "RM0000" & code
            ElseIf (Len(code) = 4) Then
                code = "RM000" & code
            ElseIf (Len(code) = 5) Then
                code = "RM00" & code
            ElseIf (Len(code) = 6) Then
                code = "RM0" & code
            Else
                code = "RM" & code
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

    Private Sub txtberatbadan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtberatbadan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttinggibadan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttinggibadan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttekanandarah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttekanandarah.KeyPress

    End Sub

    Private Sub btnCarireg_Click(sender As Object, e As EventArgs) Handles btnCarireg.Click
        LookupRegistrasi.ShowDialog()
        If (_kodereg <> "") Then
            txtkodereg.Text = _kodereg
            txttglreg.Text = _tglreg
            txtnamadokter.Text = _namadok
            txtnamapsn.Text = _namapsn
            txtnamapoli.Text = _namapoli
        End If
        _kodereg = ""
        _tglreg = Nothing
        _namadok = ""
        _namapsn = ""
        _namapoli = ""

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        LookupTindakan.ShowDialog()
        If (_kodetidakan <> "") Then
            Dim hassame As Boolean = False
            For i As Integer = 0 To DataGridView2.RowCount - 1
                If _kodetidakan = DataGridView2.Rows(i).Cells(0).Value Then
                    hassame = True
                End If
            Next

            If hassame Then
                MessageBox.Show("tindakan sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim index As Integer = DataGridView2.RowCount
                DataGridView2.Rows.Add()
                DataGridView2.Rows(index).Cells(0).Value = _kodetidakan
                DataGridView2.Rows(index).Cells(1).Value = _namatindakan
                DataGridView2.Rows(index).Cells(2).Value = _tariff
                DataGridView2.Rows(index).Cells(3).Value = "hapus"
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

    Private Sub txttekanandarah_TextChanged(sender As Object, e As EventArgs) Handles txttekanandarah.TextChanged

    End Sub
End Class