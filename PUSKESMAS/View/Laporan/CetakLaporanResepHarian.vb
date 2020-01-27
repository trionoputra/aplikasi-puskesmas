Public Class CetakLaporanResepHarian
    Private Sub CetakLaporanResepHarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
    Private Sub cetak()
        Dim model As New ResepModel
        Dim tbReport As DataTable = model.getCetakLaporanHarian(dtfrom.Value.Date)
        If (tbReport.Rows.Count <> 0) Then
            Dim objRpt As New RptResepHarian
            objRpt.SetDataSource(tbReport)
            objRpt.SetParameterValue("from", dtfrom.Value.Date)
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