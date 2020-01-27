Public Class FormPasien
    Private editMode As Boolean
    Private Sub FormPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New PasienModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New Pasien
                entity.kd_kk = txtkodekk.Text
                entity.kd_psn = txtkode.Text
                entity.nm_psn = txtnama.Text
                entity.pekerjaan_psn = txtpekerjaan.Text
                entity.alamat_psn = txtalamat.Text
                entity.tgl_lahir_psn = dttanggal.Value.Date
                entity.notelp_psn = txtnotelp.Text
                entity.jenis_psn = cmbjenis.SelectedItem.ToString
                entity.status_kel_psn = cmbstatuskel.SelectedItem
                entity.tgl_daftar_psn = Now.Date
                If (radiopria.Checked) Then
                    entity.jk_psn = radiopria.Text
                Else
                    entity.jk_psn = radiowanita.Text
                End If

                Dim model As New PasienModel
                If Not editMode Then
                    If model.count(entity.kd_psn) = 0 Then
                        If model.save(entity) Then
                            MessageBox.Show("Data berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cetak(entity.kd_psn)
                            initForm()
                        Else
                            MessageBox.Show("Gagal menyimpan data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Kode " & entity.kd_psn & " sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        editMode = False
        txtkode.Text = autoCode()
        txtnama.Clear()
        txtkodekk.Clear()
        txtnamakk.Clear()
        txtalamat.Clear()
        txtpekerjaan.Clear()
        txtnotelp.Clear()
        txtcari.Clear()
        radiopria.Checked = True
        cmbjenis.SelectedIndex = 0
        cmbstatuskel.SelectedIndex = 0
        btnhapus.Enabled = False
        btnCetak.Enabled = False
        txtcari.Enabled = True
        txtkode.Enabled = False
        dttanggal.Text = Date.Now.Date
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkodekk.Text = "") Then
            MessageBox.Show("pilih kepala keluarga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtnama.Text = "") Then
            MessageBox.Show("Nama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtpekerjaan.Text = "") Then
            MessageBox.Show("Pekerjaan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtalamat.Text = "") Then
            MessageBox.Show("Alamat tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtnotelp.Text = "") Then
            MessageBox.Show("No.Telepon tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Dim days = DateDiff(DateInterval.Day, Now.Date, dttanggal.Value)
            If (days >= 0) Then
                MessageBox.Show("Tanggal Lahir tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub cari(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New PasienModel
            Dim entity As Pasien = model.getOBJBy(kode)
            If (entity.kd_psn <> "") Then
                txtkode.Text = entity.kd_psn
                txtnama.Text = entity.nm_psn
                txtkodekk.Text = entity.kd_kk
                txtnamakk.Text = entity.nm_kk
                txtpekerjaan.Text = entity.pekerjaan_psn
                txtalamat.Text = entity.alamat_psn
                dttanggal.Value = entity.tgl_lahir_psn
                txtnotelp.Text = entity.notelp_psn
                cmbjenis.SelectedItem = entity.jenis_psn
                cmbstatuskel.SelectedItem = entity.status_kel_psn
                If entity.jk_psn = radiopria.Text Then
                    radiopria.Checked = True
                Else
                    radiowanita.Checked = True
                End If

                btnhapus.Enabled = True
                btnCetak.Enabled = True
                editMode = True
            Else
                MessageBox.Show("Kode " & entity.kd_kk & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub delete(ByVal kode As String)
        If MsgBox("Yakin ingin hapus ?", vbYesNo, "Confirmation") = vbYes Then
            Dim model As New PasienModel
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
    Private Sub cetak(ByVal kode As String)
        Dim model As New PasienModel
        Dim tbReport As DataTable = model.getCetak(kode)
        Dim objRpt As New RptKartuPengunjung
        objRpt.SetDataSource(tbReport)
        ReportViewer.CrystalReportViewer1.ReportSource = objRpt
        ReportViewer.CrystalReportViewer1.Refresh()
        ReportViewer.ShowDialog()
    End Sub
    Private Function autoCode() As String
        Dim model As New PasienModel
        Dim code As String
        Dim entity As Pasien = model.getLast()
        If (entity.kd_psn = "") Then
            code = "PSN0000001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_psn, 4, Len(entity.kd_psn) - 3)) + 1
            If (Len(code) = 1) Then
                code = "PSN000000" & code
            ElseIf (Len(code) = 2) Then
                code = "PSN00000" & code
            ElseIf (Len(code) = 3) Then
                code = "PSN0000" & code
            ElseIf (Len(code) = 4) Then
                code = "PSN000" & code
            ElseIf (Len(code) = 5) Then
                code = "PSN00" & code
            ElseIf (Len(code) = 6) Then
                code = "PSN0" & code
            Else
                code = "PSN" & code
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

    Private Sub btnCarikk_Click(sender As Object, e As EventArgs) Handles btnCarikk.Click
        LookupKK.ShowDialog()
        If _kodekk <> "" Then
            txtkodekk.Text = _kodekk
            txtnamakk.Text = _namakk
        End If
        _kodekk = ""
        _namakk = ""
    End Sub

    Private Sub txtnotelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnotelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            cari(dataGridView1.Rows(e.RowIndex).Cells(0).Value)
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        cetak(txtkode.Text)
    End Sub

End Class