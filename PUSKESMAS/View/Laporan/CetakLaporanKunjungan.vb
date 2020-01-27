Public Class CetakLaporanKunjungan
    Private Sub CetakLaporanKunjungan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cetak()
        Dim model As New RegistrasiModel
        'narik data pengunjung
        Dim tbReport As DataTable = model.getCetakPengunjung(dtfrom.Value.Date, dtto.Value.Date)

        If (tbReport.Rows.Count <> 0) Then

            Dim objRpt As New RptKunjunganPasien
            'set data pengunjung ke crystal report
            objRpt.SetDataSource(tbReport)

            'kirim parameter 
            objRpt.SetParameterValue("from", dtfrom.Value.Date)
            objRpt.SetParameterValue("to", dtto.Value.Date)
            '    objRpt.SetParameterValue("user", _sessionNama)
            ReportViewer.CrystalReportViewer1.ReportSource = objRpt
            ReportViewer.CrystalReportViewer1.Refresh()
            ReportViewer.ShowDialog()
        Else
            MessageBox.Show("Data tidak tersedia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        cetak()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub
End Class