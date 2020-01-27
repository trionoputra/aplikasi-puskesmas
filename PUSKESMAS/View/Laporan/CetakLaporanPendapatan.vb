Public Class CetakLaporanPendapatan
    Private Sub CetakLaporanPendapatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cetak()
        Dim model As New KwitansiModel
        Dim tbReport As DataTable = model.getCetakPendapatan(dtfrom.Value.Date, dtto.Value.Date)

        If (tbReport.Rows.Count <> 0) Then
            Dim objRpt As New RptPendapatan
            objRpt.SetDataSource(tbReport)
            objRpt.SetParameterValue("from", dtfrom.Value.Date)
            objRpt.SetParameterValue("to", dtto.Value.Date)
            ' objRpt.SetParameterValue("user", _sessionNama)
            Dim total As Double = 0
            For i As Integer = 0 To tbReport.Rows.Count - 1
                total += tbReport.Rows(i).Item("total")
            Next

            objRpt.SetParameterValue("terbilang", TERBILANG(total))
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
    Public Function TERBILANG(ByVal x As Double) As String
        Dim tampung As Double
        Dim teks As String
        Dim bagian As String
        Dim i As Integer
        Dim tanda As Boolean

        Dim letak(5)
        letak(1) = "RIBU "
        letak(2) = "JUTA "
        letak(3) = "MILYAR "
        letak(4) = "TRILYUN "

        If (x < 0) Then
            TERBILANG = ""
            Exit Function
        End If

        If (x = 0) Then
            TERBILANG = "NOL"
            Exit Function
        End If

        If (x < 2000) Then
            tanda = True
        End If
        teks = ""

        If (x >= 1.0E+15) Then
            TERBILANG = "NILAI TERLALU BESAR"
            Exit Function
        End If

        For i = 4 To 1 Step -1
            tampung = Int(x / (10 ^ (3 * i)))
            If (tampung > 0) Then
                bagian = ratusan(tampung, tanda)
                teks = teks & bagian & letak(i)
            End If
            x = x - tampung * (10 ^ (3 * i))
        Next

        teks = teks & ratusan(x, False)
        TERBILANG = teks & "RUPIAH"
    End Function

    Function ratusan(ByVal y As Double, ByVal flag As Boolean) As String
        Dim tmp As Double
        Dim bilang As String
        Dim bag As String
        Dim j As Integer

        Dim angka(9)
        angka(1) = "SE"
        angka(2) = "DUA "
        angka(3) = "TIGA "
        angka(4) = "EMPAT "
        angka(5) = "LIMA "
        angka(6) = "ENAM "
        angka(7) = "TUJUH "
        angka(8) = "DELAPAN "
        angka(9) = "SEMBILAN "

        Dim posisi(2)
        posisi(1) = "PULUH "
        posisi(2) = "RATUS "

        bilang = ""
        For j = 2 To 1 Step -1
            tmp = Int(y / (10 ^ j))
            If (tmp > 0) Then
                bag = angka(tmp)
                If (j = 1 And tmp = 1) Then
                    y = y - tmp * 10 ^ j
                    If (y >= 1) Then
                        posisi(j) = "BELAS "
                    Else
                        angka(y) = "SE"
                    End If
                    bilang = bilang & angka(y) & posisi(j)
                    ratusan = bilang
                    Exit Function
                Else
                    bilang = bilang & bag & posisi(j)
                End If
            End If
            y = y - tmp * 10 ^ j
        Next

        If (flag = False) Then
            angka(1) = "SATU "
        End If
        bilang = bilang & angka(y)
        ratusan = bilang
    End Function

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Dispose()
    End Sub
End Class