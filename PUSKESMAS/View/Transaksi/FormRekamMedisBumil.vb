Public Class FormRekamMedisBumil
    Private editMode As Boolean
    Public isFromDashboard As Boolean
    Private Sub FormRekamMedisBumil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
    End Sub

    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New RekamMedisBumilModel
        dataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub save()
        Try
            If cekEmpty() Then
                Dim entity As New RekamMedisBumil
                entity.kd_rm = txtkode.Text
                entity.tgl_rm = dttanggal.Value.Date
                entity.kd_reg = txtkodereg.Text
                entity.posyandu = txtposyandu.Text
                entity.nm_kader = txtnmkader.Text
                entity.nm_dukun = txtnmdukun.Text
                entity.jamkesmas = cmbjamkesmas.Text
                entity.gol_darah = cmbgoldarah.Text
                entity.granida = txtgranida.Text
                entity.partis = txtpartis.Text
                entity.aborus = txtaborus.Text
                entity.hidup = txthidup.Text
                entity.tgl_periksa = dtperiksa.Value.Date
                entity.tgl_hpht = dthpht.Value.Date
                entity.taksiran_persalinan = dttaksiranpersalinan.Value.Date
                entity.bb_sblm_hamil = txtbbsebelumhamil.Text
                entity.tb = txttb.Text
                entity.buku_kia = cmbbukukia.Text
                entity.riwayat_komplikasi_kebidanan = txtriwayatkomplikasikebidanan.Text
                entity.penyakit_kronis_alergi = txtpenyakitkronis.Text
                entity.tgl_persalinan = dtpersalinan.Value.Date
                entity.penolong = cmbpenolong.Text
                entity.tempat = cmbtempat.Text
                entity.pendamping = cmbpendamping.Text
                entity.transportasi = cmbtransportasi.Text
                entity.pendonor = cmbpendonor.Text
                entity.cara_masuk = cmbcaramasuk.Text
                entity.usia_kelinis = txtusiaklinis.Text
                entity.transfer_ke = txttransferke.Text
                entity.anamnesia = txtamnesia.Text
                entity.bb = txtbb.Text
                entity.td = txttd.Text
                entity.status_gizi = txtstatusgizi.Text
                entity.tfu = txttfu.Text
                entity.refleks_patella = cmbreflekspatella.Text
                entity.djj = txtdjj.Text
                entity.kepala_thd_pap = cmbkepathdpap.Text
                entity.tbj = txttbj.Text
                entity.presentasi = cmbpresentasi.Text
                entity.jumlah_janin = cmbjumlahjanin.Text
                entity.status_imunisasi = cmbstatusimunisasi.Text
                entity.catat_dibuku_kia = cmbcatatdibukukia.Text
                entity.fe = txtfe.Text
                entity.hb_dilakukan = cmbhbdilakukan.Text
                entity.hb_hasil = txthbhasil.Text
                entity.anemia = cmbanemia.Text
                entity.pretein_urie = cmbpreteinurie.Text
                entity.gula_darah = txtguladarah.Text
                entity.reduksi = cmbreduksi.Text
                entity.gol_darah = cmbgoldarah.Text
                entity.siphilis = txtsiphilis.Text
                entity.vct = cmbvct.Text
                entity.periksa_darah = cmbperiksadarah.Text
                entity.serologi = cmbserologi.Text
                entity.arv = txtarv.Text
                entity.injeksi_tt = txtinjeksitt.Text
                entity.therapi = txttherapi.Text

                Dim model As New RekamMedisBumilModel
                If Not editMode Then
                    If model.count(entity.kd_rm) = 0 Then
                        If model.save(entity) Then
                            Dim entityDetail As New RekamMedisBumil
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
                        Dim entityDetail As New RekamMedisBumil
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
        txtposyandu.Clear()
        txtnmkader.Clear()
        txtnmdukun.Clear()
        cmbjamkesmas.SelectedIndex = 0
        cmbgoldarah.SelectedIndex = 0
        txtgranida.Clear()
        txtpartis.Clear()
        txtaborus.Clear()
        txthidup.Clear()
        dtperiksa.Text = Now.Date
        dthpht.Text = Now.Date
        dttaksiranpersalinan.Text = Now.Date
        txtbbsebelumhamil.Clear()
        txttb.Clear()
        cmbbukukia.SelectedIndex = 0
        txtriwayatkomplikasikebidanan.Clear()
        txtpenyakitkronis.Clear()
        dtpersalinan.Text = Now.Date
        cmbpenolong.SelectedIndex = 0
        cmbtempat.SelectedIndex = 0
        cmbpendamping.SelectedIndex = 0
        cmbtransportasi.SelectedIndex = 0
        cmbpendonor.SelectedIndex = 0
        cmbcaramasuk.SelectedIndex = 0
        txtusiaklinis.Clear()
        txttransferke.Clear()
        txtamnesia.Clear()
        txtbb.Clear()
        txttd.Clear()
        txttfu.Clear()
        txtstatusgizi.Clear()
        cmbreflekspatella.SelectedIndex = 0
        txtdjj.Clear()
        cmbkepathdpap.SelectedIndex = 0
        txttbj.Clear()
        cmbpresentasi.SelectedIndex = 0
        cmbjumlahjanin.SelectedIndex = 0
        cmbstatusimunisasi.SelectedIndex = 0
        cmbcatatdibukukia.SelectedIndex = 0
        txtfe.Clear()
        cmbhbdilakukan.SelectedIndex = 0
        txthbhasil.Clear()
        cmbanemia.SelectedIndex = 0
        cmbpreteinurie.SelectedIndex = 0
        txtguladarah.Clear()
        cmbreduksi.SelectedIndex = 0
        cmbgoldarah.SelectedIndex = 0
        txtsiphilis.Clear()
        cmbvct.SelectedIndex = 0
        cmbperiksadarah.SelectedIndex = 0
        cmbserologi.SelectedIndex = 0
        txtarv.Clear()
        txtinjeksitt.Clear()
        txttherapi.Clear()
        DataGridView2.Rows.Clear()
        fillGrid("")
    End Sub

    Private Function cekEmpty()
        If (txtkode.Text = "") Then
            MessageBox.Show("Kode tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtgranida.Text = "") Then
            MessageBox.Show("Granida tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtpartis.Text = "") Then
            MessageBox.Show("Partis tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtaborus.Text = "") Then
            MessageBox.Show("Aborus tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txthidup.Text = "") Then
            MessageBox.Show("Hidup tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtbbsebelumhamil.Text = "") Then
            MessageBox.Show("BB Sebelum Hamil tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttb.Text = "") Then
            MessageBox.Show("Tekanan darah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtriwayatkomplikasikebidanan.Text = "") Then
            MessageBox.Show("Riwayat Komplikasi Kebidanan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtpenyakitkronis.Text = "") Then
            MessageBox.Show("Penyakit kronis dan alergi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtusiaklinis.Text = "") Then
            MessageBox.Show("Usia klinis tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttransferke.Text = "") Then
            MessageBox.Show("Transfer ke tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtamnesia.Text = "") Then
            MessageBox.Show("Amnesia tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtbb.Text = "") Then
            MessageBox.Show("Berat badan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttd.Text = "") Then
            MessageBox.Show("Tekanan darah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtstatusgizi.Text = "") Then
            MessageBox.Show("Status gizi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtdjj.Text = "") Then
            MessageBox.Show("DJJ tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttbj.Text = "") Then
            MessageBox.Show("TBJ tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtfe.Text = "") Then
            MessageBox.Show("FE tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txthbhasil.Text = "") Then
            MessageBox.Show("HB Hasil tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtguladarah.Text = "") Then
            MessageBox.Show("Gula darah tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtsiphilis.Text = "") Then
            MessageBox.Show("Siphilis tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtarv.Text = "") Then
            MessageBox.Show("ARV tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txtinjeksitt.Text = "") Then
            MessageBox.Show("Injeksi TT tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (txttherapi.Text = "") Then
            MessageBox.Show("Therapi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim model As New RekamMedisBumilModel
            Dim entity As RekamMedisBumil = model.getOBJBy(kode)
            If (entity.kd_rm <> "") Then
                txtkode.Text = entity.kd_rm
                dttanggal.Text = entity.tgl_rm
                txtposyandu.Text = entity.posyandu
                txtnmkader.Text = entity.nm_kader
                txtnmdukun.Text = entity.nm_dukun
                cmbjamkesmas.Text = entity.jamkesmas
                cmbgoldarah.Text = entity.gol_darah
                txtgranida.Text = entity.granida
                txtpartis.Text = entity.partis
                txtaborus.Text = entity.aborus
                txthidup.Text = entity.hidup
                dtperiksa.Text = entity.tgl_periksa
                dthpht.Text = entity.tgl_hpht
                dttaksiranpersalinan.Text = entity.taksiran_persalinan
                txtbbsebelumhamil.Text = entity.bb_sblm_hamil
                txttb.Text = entity.tb
                cmbbukukia.Text = entity.buku_kia
                txtriwayatkomplikasikebidanan.Text = entity.riwayat_komplikasi_kebidanan
                txtpenyakitkronis.Text = entity.penyakit_kronis_alergi
                dtpersalinan.Text = entity.tgl_persalinan
                cmbpenolong.Text = entity.penolong
                cmbtempat.Text = entity.tempat
                cmbpendamping.Text = entity.pendamping
                cmbtransportasi.Text = entity.transportasi
                cmbpendonor.Text = entity.pendonor
                cmbcaramasuk.Text = entity.cara_masuk
                txtusiaklinis.Text = entity.usia_kelinis
                txttransferke.Text = entity.transfer_ke
                txtamnesia.Text = entity.anamnesia
                txtbb.Text = entity.bb
                txttd.Text = entity.td
                txtstatusgizi.Text = entity.status_gizi
                txttfu.Text = entity.tfu
                cmbreflekspatella.Text = entity.refleks_patella
                txtdjj.Text = entity.djj
                cmbkepathdpap.Text = entity.kepala_thd_pap
                txttbj.Text = entity.tbj
                cmbpresentasi.Text = entity.presentasi
                cmbjumlahjanin.Text = entity.jumlah_janin
                cmbstatusimunisasi.Text = entity.status_imunisasi
                cmbcatatdibukukia.Text = entity.catat_dibuku_kia
                txtfe.Text = entity.fe
                cmbhbdilakukan.Text = entity.hb_dilakukan
                txthbhasil.Text = entity.hb_hasil
                cmbanemia.Text = entity.anemia
                cmbpreteinurie.Text = entity.pretein_urie
                txtguladarah.Text = entity.gula_darah
                cmbreduksi.Text = entity.reduksi
                cmbgoldarah.Text = entity.gol_darah
                txtsiphilis.Text = entity.siphilis
                cmbvct.Text = entity.vct
                cmbperiksadarah.Text = entity.periksa_darah
                cmbserologi.Text = entity.serologi
                txtarv.Text = entity.arv
                txtinjeksitt.Text = entity.injeksi_tt
                txttherapi.Text = entity.therapi
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
            Dim model As New RekamMedisBumilModel
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
        Dim model As New RekamMedisBumilModel
        Dim code As String
        Dim entity As RekamMedisBumil = model.getLast()
        If (entity.kd_rm = "") Then
            code = "RMB000001"
        Else
            code = Val(Microsoft.VisualBasic.Mid(entity.kd_rm, 4, Len(entity.kd_rm) - 3)) + 1
            If (Len(code) = 1) Then
                code = "RMB00000" & code
            ElseIf (Len(code) = 2) Then
                code = "RMB0000" & code
            ElseIf (Len(code) = 3) Then
                code = "RMB000" & code
            ElseIf (Len(code) = 4) Then
                code = "RMB00" & code
            ElseIf (Len(code) = 5) Then
                code = "RMB0" & code
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

    Private Sub txtberatbadan_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttinggibadan_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub txttekanandarah_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub btnCarireg_Click(sender As Object, e As EventArgs) Handles btnCarireg.Click
        Dim lookup As New LookupRegistrasi
        lookup.isBumil = True
        lookup.ShowDialog()
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

    Private Sub txttekanandarah_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btncarirekamedis_Click(sender As Object, e As EventArgs) Handles btncarirekamedis.Click
        LookupRekammedisBumil.ShowDialog()
        If (_kdrm <> "") Then
            cariRekam(_kdrm)
        End If
        _kdrm = ""
        _kodereg = ""
        _tglrm = Nothing
        _namadok = ""
        _namapsn = ""
        _namapoli = ""
    End Sub
    Private Sub cariRekam(ByVal kode)
        If kode = "" Then
            MessageBox.Show("isi kode yang ingin dicari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim model As New RekamMedisBumilModel
            Dim entity As RekamMedisBumil = model.getOBJBy(kode)
            If (entity.kd_rm <> "") Then
                dttanggal.Text = entity.tgl_rm
                txtposyandu.Text = entity.posyandu
                txtnmkader.Text = entity.nm_kader
                txtnmdukun.Text = entity.nm_dukun
                cmbjamkesmas.Text = entity.jamkesmas
                cmbgoldarah.Text = entity.gol_darah
                txtgranida.Text = entity.granida
                txtpartis.Text = entity.partis
                txtaborus.Text = entity.aborus
                txthidup.Text = entity.hidup
                dtperiksa.Text = entity.tgl_periksa
                dthpht.Text = entity.tgl_hpht
                dttaksiranpersalinan.Text = entity.taksiran_persalinan
                txtbbsebelumhamil.Text = entity.bb_sblm_hamil
                txttb.Text = entity.tb
                cmbbukukia.Text = entity.buku_kia
                txtriwayatkomplikasikebidanan.Text = entity.riwayat_komplikasi_kebidanan
                txtpenyakitkronis.Text = entity.penyakit_kronis_alergi
                dtpersalinan.Text = entity.tgl_persalinan
                cmbpenolong.Text = entity.penolong
                cmbtempat.Text = entity.tempat
                cmbpendamping.Text = entity.pendamping
                cmbtransportasi.Text = entity.transportasi
                cmbpendonor.Text = entity.pendonor
                'txtkodereg.Text = entity.kd_reg
                'txttglreg.Text = entity.tgl_reg
                'txtnamadokter.Text = entity.nm_dok
                'txtnamapsn.Text = entity.nm_psn
                'txtnamapoli.Text = entity.nm_poli
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
                btnhapus.Enabled = False
            Else
                MessageBox.Show("Kode " & entity.kd_rm & " tidak terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub Label42_Click(sender As Object, e As EventArgs) Handles Label42.Click

    End Sub
    Private Sub cmbanemia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbanemia.SelectedIndexChanged

    End Sub
End Class