Public Class CetakLaporanObatExpired
    Private Sub CetakLaporanObatExpired_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cetak()
        Dim model As New ObatModel
        Dim tbReport As DataTable = model.getCetakObatExpired()

        If (tbReport.Rows.Count <> 0) Then
            Dim objRpt As New RptObatExpired
            objRpt.SetDataSource(tbReport)
            ' objRpt.SetParameterValue("user", _sessionNama)
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