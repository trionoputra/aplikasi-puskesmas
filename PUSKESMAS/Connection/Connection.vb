Imports System.Data.OleDb
Imports System.Data.SqlClient
Public MustInherit Class connnection
    Public cnn As SqlConnection
    Dim cmd As SqlCommand
    Dim cnnString As String
    Public Sub New()
        cnnString = System.Configuration.ConfigurationManager.ConnectionStrings("PUSKESMAS.My.MySettings.puskesmasConnectionString").ConnectionString
        cnn = New SqlConnection(cnnString)
    End Sub
    Public Function nonQuery(ByVal sql) As Boolean
        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            cmd.ExecuteNonQuery()
            cnn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
