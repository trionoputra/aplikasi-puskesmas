Public Class menuutama
    Private Sub KepalaKeluargaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KepalaKeluargaToolStripMenuItem.Click
        FormKepalaKeluarga.ShowDialog()
    End Sub

    Private Sub PoliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PoliToolStripMenuItem.Click
        FormPoli.ShowDialog()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasienToolStripMenuItem.Click
        FormPasien.ShowDialog()
    End Sub

    Private Sub DokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokterToolStripMenuItem.Click
        FormDokter.ShowDialog()
    End Sub

    Private Sub RegistrasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrasiToolStripMenuItem.Click
        FormRegistrasi.ShowDialog()
    End Sub

    Private Sub TindakanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TindakanToolStripMenuItem.Click
        FormTindakan.ShowDialog()
    End Sub

    Private Sub ObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObatToolStripMenuItem.Click
        FormObat.ShowDialog()
    End Sub

    Private Sub RekamMedisUmumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamMedisUmumToolStripMenuItem.Click
        FormRekamMedisUmum.ShowDialog()
    End Sub

    Private Sub ResepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResepToolStripMenuItem.Click
        FormResep.ShowDialog()
    End Sub

    Private Sub SuratRujukanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratRujukanToolStripMenuItem.Click
        FormSuratRujukan.ShowDialog()
    End Sub
    Private Sub SuratSakitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratSakitToolStripMenuItem.Click
        FormSuratSakit.ShowDialog()
    End Sub

    Private Sub SuratSehatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratSehatToolStripMenuItem.Click
        FormSuratSehat.ShowDialog()
    End Sub

    Private Sub DetailObatToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormDetailObat.ShowDialog()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        FormPembayaran.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        FormUser.Show()
    End Sub

    Private Sub menuutama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub menuutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "User : " & _sessionNama
        ToolStripStatusLabel4.Text = "Status : " & _sessionLevel
        dashboarddokter.Visible = False
        Timer2.Enabled = False
        role(_sessionLevel)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RekammedisbumilToolStripMenuItem.Click
        FormRekamMedisBumil.ShowDialog()
    End Sub
  

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = "Waktu : " & Now
    End Sub

    Private Sub TebusResepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TebusResepToolStripMenuItem.Click
        FormTebusResep.ShowDialog()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        _sessionID = ""
        _sessionUsername = ""
        _sessionLevel = ""
        _sessionNama = ""
        LoginForm.Show()
        Me.Close()
    End Sub

    Private Sub LaporanKunjunganPasienPerperiodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanKunjunganPasienPerperiodeToolStripMenuItem.Click
        CetakLaporanKunjungan.ShowDialog()
    End Sub

    Private Sub LaporanPendapatanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPendapatanToolStripMenuItem.Click
        CetakLaporanPendapatan.ShowDialog()
    End Sub

    Private Sub LaporanPasienBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPasienBaruToolStripMenuItem.Click
        CetakLaporanPasienBaru.ShowDialog()
    End Sub

    Private Sub LaporanKunjunganHarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanKunjunganHarianToolStripMenuItem.Click
        CetakLaporanKunjunganHarian.ShowDialog()
    End Sub

    Private Sub role(level As String)

        KepalaKeluargaToolStripMenuItem.Visible = False
        PasienToolStripMenuItem.Visible = False
        PoliToolStripMenuItem.Visible = False
        DokterToolStripMenuItem.Visible = False
        TindakanToolStripMenuItem.Visible = False
        ObatToolStripMenuItem.Visible = False
        DetailObatToolStripMenuItem.Visible = False
        UserToolStripMenuItem.Visible = False

        RegistrasiToolStripMenuItem.Visible = False
        RekamMedisUmumToolStripMenuItem.Visible = False
        RekammedisbumilToolStripMenuItem.Visible = False
        ResepToolStripMenuItem.Visible = False
        SuratSakitToolStripMenuItem.Visible = False
        SuratRujukanToolStripMenuItem.Visible = False
        SuratSehatToolStripMenuItem.Visible = False
        PembayaranToolStripMenuItem.Visible = False
        TebusResepToolStripMenuItem.Visible = False

        LaporanKunjunganPasienPerperiodeToolStripMenuItem.Visible = False
        LaporanKunjunganHarianToolStripMenuItem.Visible = False
        LaporanPasienBaruToolStripMenuItem.Visible = False
        LaporanPendapatanToolStripMenuItem.Visible = False
        LaporanObatExpiredToolStripMenuItem.Visible = False
        LaporanSuratTandaSetoranToolStripMenuItem.Visible = False
        LaporanResepHarianToolStripMenuItem.Visible = False
        LaporanResepPerperiodeToolStripMenuItem.Visible = False
        LaporanObatHampirHabisToolStripMenuItem.Visible = False

        TransaksiToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False

        If level.ToLower = "administrator" Then
            KepalaKeluargaToolStripMenuItem.Visible = True
            PasienToolStripMenuItem.Visible = True
            PoliToolStripMenuItem.Visible = True
            DokterToolStripMenuItem.Visible = True
            TindakanToolStripMenuItem.Visible = True
            ObatToolStripMenuItem.Visible = True
            DetailObatToolStripMenuItem.Visible = True
            UserToolStripMenuItem.Visible = True

            RegistrasiToolStripMenuItem.Visible = True
            RekamMedisUmumToolStripMenuItem.Visible = True
            RekammedisbumilToolStripMenuItem.Visible = True
            ResepToolStripMenuItem.Visible = True
            SuratSakitToolStripMenuItem.Visible = True
            SuratRujukanToolStripMenuItem.Visible = True
            SuratSehatToolStripMenuItem.Visible = True
            PembayaranToolStripMenuItem.Visible = True
            TebusResepToolStripMenuItem.Visible = True

            LaporanKunjunganPasienPerperiodeToolStripMenuItem.Visible = True
            LaporanKunjunganHarianToolStripMenuItem.Visible = True
            LaporanPasienBaruToolStripMenuItem.Visible = True
            LaporanPendapatanToolStripMenuItem.Visible = True
            LaporanObatExpiredToolStripMenuItem.Visible = True
            LaporanSuratTandaSetoranToolStripMenuItem.Visible = True
            LaporanResepHarianToolStripMenuItem.Visible = True
            LaporanResepPerperiodeToolStripMenuItem.Visible = True
            LaporanObatHampirHabisToolStripMenuItem.Visible = True

            TransaksiToolStripMenuItem.Visible = True
            LaporanToolStripMenuItem.Visible = True
            MasterToolStripMenuItem.Visible = True

        ElseIf level.ToLower = "dokter" Then
            RekamMedisUmumToolStripMenuItem.Visible = True
            RekammedisbumilToolStripMenuItem.Visible = True
            ResepToolStripMenuItem.Visible = True
            SuratSakitToolStripMenuItem.Visible = True
            SuratRujukanToolStripMenuItem.Visible = True
            SuratSehatToolStripMenuItem.Visible = True
            TransaksiToolStripMenuItem.Visible = True
            iniDokterDashboard()
        ElseIf level.ToLower = "kepala puskesmas" Then
            LaporanKunjunganPasienPerperiodeToolStripMenuItem.Visible = True
            LaporanKunjunganHarianToolStripMenuItem.Visible = True
            LaporanPasienBaruToolStripMenuItem.Visible = True
            LaporanPendapatanToolStripMenuItem.Visible = True
            LaporanToolStripMenuItem.Visible = True
            LaporanObatExpiredToolStripMenuItem.Visible = True
            LaporanSuratTandaSetoranToolStripMenuItem.Visible = True
            LaporanResepHarianToolStripMenuItem.Visible = True
            LaporanResepPerperiodeToolStripMenuItem.Visible = True
            LaporanObatHampirHabisToolStripMenuItem.Visible = True

        ElseIf level.ToLower = "staff loket" Then
            PasienToolStripMenuItem.Visible = True
            PoliToolStripMenuItem.Visible = True
            DokterToolStripMenuItem.Visible = True
            TindakanToolStripMenuItem.Visible = True

            RegistrasiToolStripMenuItem.Visible = True
            PembayaranToolStripMenuItem.Visible = True

            LaporanKunjunganPasienPerperiodeToolStripMenuItem.Visible = True
            LaporanKunjunganHarianToolStripMenuItem.Visible = True
            LaporanPasienBaruToolStripMenuItem.Visible = True
            LaporanPendapatanToolStripMenuItem.Visible = True
            LaporanSuratTandaSetoranToolStripMenuItem.Visible = True

            TransaksiToolStripMenuItem.Visible = True
            LaporanToolStripMenuItem.Visible = True
            MasterToolStripMenuItem.Visible = True
        ElseIf level.ToLower = "staff apotek" Then
            TebusResepToolStripMenuItem.Visible = True
            ObatToolStripMenuItem.Visible = True
            DetailObatToolStripMenuItem.Visible = True
            TransaksiToolStripMenuItem.Visible = True
            LaporanToolStripMenuItem.Visible = True
            MasterToolStripMenuItem.Visible = True
            LaporanObatExpiredToolStripMenuItem.Visible = True
            LaporanResepHarianToolStripMenuItem.Visible = True
            LaporanResepPerperiodeToolStripMenuItem.Visible = True
            LaporanObatHampirHabisToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub iniDokterDashboard()
        dashboarddokter.Visible = True
        Timer2.Enabled = True
        Dim model As New RegistrasiModel
        DataGridView1.DataSource = model.getDashboardBy(_sessionLevel)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim model As New RegistrasiModel
        DataGridView1.DataSource = model.getDashboardBy(_sessionLevel)
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            Dim poli As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            If (poli.ToLower.Contains("kia") Or poli.ToLower.Contains("bumil") Or poli.ToLower.Contains("hamil")) Then
                Dim formRekamMedisBumil As New FormRekamMedisBumil
                formRekamMedisBumil.isFromDashboard = True
                formRekamMedisBumil.txtkodereg.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                formRekamMedisBumil.txttglreg.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                formRekamMedisBumil.txtnamadokter.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
                formRekamMedisBumil.txtnamapsn.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                formRekamMedisBumil.txtnamapoli.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
                formRekamMedisBumil.ShowDialog()
            Else
                Dim formRekamMedisUmum As New FormRekamMedisUmum
                formRekamMedisUmum.isFromDashboard = True
                formRekamMedisUmum.txtkodereg.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
                formRekamMedisUmum.txttglreg.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
                formRekamMedisUmum.txtnamadokter.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
                formRekamMedisUmum.txtnamapsn.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                formRekamMedisUmum.txtnamapoli.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
                formRekamMedisUmum.ShowDialog()
            End If


        End If
    End Sub

    Private Sub LaoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanObatExpiredToolStripMenuItem.Click
        CetakLaporanObatExpired.ShowDialog()
    End Sub

    Private Sub LaporanSuratTandaSetoranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanSuratTandaSetoranToolStripMenuItem.Click
        CetakLaporanSetoran.ShowDialog()
    End Sub

    Private Sub LaporanResepHarianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanResepHarianToolStripMenuItem.Click
        CetakLaporanResepHarian.ShowDialog()
    End Sub

    Private Sub LaporanResepPerperiodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanResepPerperiodeToolStripMenuItem.Click
        CetakLaporanResepPerperiode.ShowDialog()
    End Sub

    Private Sub LaporanObatHampirHabisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanObatHampirHabisToolStripMenuItem.Click
        CetakLaporanObatHampirAbis.ShowDialog()
    End Sub


    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles DetailObatToolStripMenuItem.Click
        FormDetailObat.ShowDialog()
    End Sub
End Class
