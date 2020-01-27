Public Class CetakLaporanKunjunganHarian
    Private Sub CetakLaporanKunjunganHarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim model As New PoliModel
        Dim poli As DataTable = model.getBy("")
        ComboBox1.DataSource = poli
        ComboBox1.DisplayMember = "Nama Poli"
        ComboBox1.ValueMember = "Kode Poli"
    End Sub
    Private Sub cetak()
        Dim model As New RegistrasiModel
        Dim tbReport As DataTable = model.getCetakKunjunganHarian(dtfrom.Value.Date, ComboBox1.SelectedValue)
        If (tbReport.Rows.Count <> 0) Then
            Dim objRpt As New RptKunjunganHarian
            objRpt.SetDataSource(tbReport)
            objRpt.SetParameterValue("from", dtfrom.Value.Date)
            objRpt.SetParameterValue("poli", ComboBox1.Text)
            objRpt.SetParameterValue("total", tbReport.Rows.Count)
            Dim totalB As Double = 0
            Dim totalG As Double = 0
            For i As Integer = 0 To tbReport.Rows.Count - 1
                If tbReport.Rows(i).Item("jenis_psn") = "Umum" Then
                    totalB += 1
                Else
                    totalG += 1
                End If
            Next
            objRpt.SetParameterValue("totalG", totalG)
            objRpt.SetParameterValue("totalB", totalB)
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