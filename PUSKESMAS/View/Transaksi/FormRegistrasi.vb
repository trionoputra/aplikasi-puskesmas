Public Class FormRegistrasi
    Private editMode As Boolean
    Private Sub FormRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New RegistrasiModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New Registrasi
                entity.kd_reg = txtkode.Text
                entity.kd_dok = txtkodedokter.Text
                entity.kd_psn = txtkodepsn.Text
                entity.tgl_reg = dttanggal.Value.Date

                Dim model As New RegistrasiModel
                If Not editMode Then
                    If model.count(entity.kd_reg) = 0 Then
                        If model.save(entity) Then
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cetak(entity.kd_reg)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_reg & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtkodepsn.Clear()
        txtnamapsn.Clear()
        txtkodedokter.Clear()
        txtnamadokter.Clear()
        txtkodepoli.Clear()
        txtnamapoli.Clear()
        lblnamakk.Text = "Nama KK"
        lbltgllahirkk.Text = "Tanggal Lahir KK"
        txtalamat.Clear()
        txttgllahir.Clear()
        txttgllahirkk.Clear()
        txtnotelpon.Clear()
        txtnamakk.Clear()
        editMode = False
        txtcari.Clear()
        btnhapus.Enabled = False
        txtcari.Enabled = True
        txtkode.Enabled = False
        btnCetak.Enabled = False
        dttanggal.Text = Date.Now.Date
        fillGrid("")
        btnsimpan.Enabled = True
        btncaridokter.Enabled = True
        btnCaripasien.Enabled = True
        dttanggal.Enabled = True
    End Sub

    Private Function cekEmpty()

        If (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkodepsn.Text = "") Then
            MessageBox.Show("pilih pasien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkodedokter.Text = "") Then
            MessageBox.Show("pilih dokter/ poli", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New RegistrasiModel
            Dim entity As Registrasi = model.getOBJBy(kode)
            If (entity.kd_reg <> "") Then
                txtkode.Text = entity.kd_reg
                dttanggal.Value = entity.tgl_reg

                txtkodepsn.Text = entity.kd_psn
                txtnamapsn.Text = entity.nm_psn
                txtkodedokter.Text = entity.kd_dok
                txtnamadokter.Text = entity.nm_dok
                txtkodepoli.Text = entity.kd_poli
                txtnamapoli.Text = entity.nm_poli
                txtnamakk.Text = entity.nm_kk
                txtalamat.Text = entity.alamat
                txttgllahir.Text = entity.tgl_lahir
                txttgllahirkk.Text = entity.tgl_lahir_kk
                txtnotelpon.Text = entity.no_telpon
                If (entity.nm_poli.ToLower().Contains("kia") Or entity.nm_poli.ToLower().Contains("hamil") Or entity.nm_poli.ToLower().Contains("bumil")) Then
                    lblnamakk.Text = "Nama Suami"
                    lbltgllahirkk.Text = "Tanggal Lahir Suami"
                End If

                editMode = True
                txtkode.Enabled = False
                btnhapus.Enabled = True
                btnCetak.Enabled = True
            Else
                MessageBox.Show("Kode " & entity.kd_reg & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New RegistrasiModel
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
        Dim model As New RegistrasiModel
        Dim code As String
        Dim entity As Registrasi = model.getLast()
        Dim format As String = "REG" & Now.Date.ToString("yyMMdd")
        If (entity.kd_reg = "") Then
            code = format & "001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_reg, 10, Len(entity.kd_reg) - 9)) + 1
            If (Len(code) = 1) Then
                code = format & "00" & code
            ElseIf (Len(code) = 2) Then
                code = format & "0" & code
            Else
                code = format & code
            End If
        End If

        Return code
    End Function
    Private Sub cetak(ByVal kode As String)
        Dim model As New RegistrasiModel
        Dim tbReport As DataTable = model.getCetak(kode)
        Dim objRpt As New RptRegistrasi
        objRpt.SetDataSource(tbReport)
        ReportViewer.CrystalReportViewer1.ReportSource = objRpt
        ReportViewer.CrystalReportViewer1.Refresh()
        ReportViewer.ShowDialog()
    End Sub
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

    Private Sub btnCarikk_Click(sender As Object, e As EventArgs) Handles btnCaripasien.Click
        LookupPasien.ShowDialog()
        If (_kodepsn <> "") Then
            txtkodepsn.Text = _kodepsn
            txtnamapsn.Text = _namapsn


            txtnamakk.Text = _namakk
            txtalamat.Text = _alamatpsn
            txttgllahir.Text = _tgllahirpsn
            txttgllahirkk.Text = _tgllahirkk
            txtnotelpon.Text = _notelponpsn
        End If
        _tgllahirpsn = ""
        _alamatpsn = ""
        _tgllahirkk = ""
        _notelponpsn = ""
        _kodekk = ""
        _namakk = ""
        _kodepsn = ""
        _namapsn = ""
    End Sub

    Private Sub btncaridokter_Click(sender As Object, e As EventArgs) Handles btncaridokter.Click
        LookupDok.ShowDialog()
        If (_kodedok <> "") Then
            txtkodedokter.Text = _kodedok
            txtnamadokter.Text = _namadok

            txtkodepoli.Text = _kodepoli
            txtnamapoli.Text = _namapoli
            If (_namapoli.ToLower().Contains("kia") Or _namapoli.ToLower().Contains("hamil") Or _namapoli.ToLower().Contains("bumil")) Then
                lblnamakk.Text = "Nama Suami"
                lbltgllahirkk.Text = "Tanggal Lahir Suami"
            End If
        End If
        
        _kodedok = ""
        _namadok = ""
        _kodepoli = ""
        _namapoli = ""
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
            btnsimpan.Enabled = False
            btncaridokter.Enabled = False
            btnCaripasien.Enabled = False
            dttanggal.Enabled = False
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        cetak(txtkode.Text)
    End Sub
End Class