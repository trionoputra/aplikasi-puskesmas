Public Class CetakLaporanPasienBaru
    Private Sub CetakLaporanPasienBaru_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cetak()
      
        Dim model As New PasienModel
        Dim tbReport As DataTable = model.getCetakPasienBaru(dtfrom.Value.Date, dtto.Value.Date)
        If (tbReport.Rows.Count <> 0) Then
            Dim objRpt As New RptPasienBaru
            objRpt.SetDataSource(tbReport)
            objRpt.SetParameterValue("from", dtfrom.Value.Date)
            objRpt.SetParameterValue("to", dtto.Value.Date)
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