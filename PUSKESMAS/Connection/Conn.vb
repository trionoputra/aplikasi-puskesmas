Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Conn
    Inherits connnection
    Dim cmd As SqlCommand
    Dim table As New DataTable
    Dim reader As SqlDataReader
    Public Function selectData(ByVal sql As String) As DataTable
        Try
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            table.Load(reader)
            Return table
        Catch ex As Exception
            Debug.Print("Sql exception")
        End Try
        Return table
    End Function
    Public Function countrow(ByVal fieldname As String, ByVal tablename As String, ByVal condition As String) As Integer
        Dim result As Integer
        Try
            Dim sql As String
            If condition = "" Then
                sql = "SELECT COUNT(" + fieldname + ") FROM " + tablename
            Else
                sql = "SELECT COUNT(" + fieldname + ") FROM " + tablename + " WHERE " + condition
            End If
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            While reader.Read
                result = reader.Item(0)
            End While
            cnn.Close()
            reader.Close()
            Return result
        Catch ex As Exception
            cnn.Close()
            Return result
        End Try
    End Function


    Public Function lookup(ByVal fieldname As String, ByVal tablename As String, ByVal condition As String) As String
        Dim result As String = ""

        Try
            Dim sql As String
            If condition = "" Then
                sql = "select " + fieldname + " FROM " + tablename
            Else
                sql = "select " + fieldname + " FROM " + tablename + " WHERE " + condition
            End If
            cnn.Open()
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            While reader.Read
                result = reader.Item(0)
            End While
            cnn.Close()
            reader.Close()
            Return result
        Catch ex As Exception
            cnn.Close()
            Return 0
        End Try
    End Function
    Public Function getMaxID(ByVal tablename As String, ByVal fieldName As String) As Double
        Dim id As Double = 1
        Try
            cnn.Open()
            Dim sql As String
            sql = "SELECT MAX(" + fieldName + ") FROM " + tablename
            cmd = New SqlCommand(sql, cnn)
            reader = cmd.ExecuteReader
            While reader.Read
                id = reader.Item(0) + 1
            End While
            reader.Close()
            cnn.Close()
            Return id
        Catch ex As Exception
            'reader.Close()
            cnn.Close()
            Return 1
        End Try
        reader.Close()
        cnn.Close()
        Return 0
    End Function
    Public Function insert(ByVal fields() As String, ByVal values() As String, ByVal table As String) As Boolean
        Try
            Dim sql As String
            sql = "Insert INTO " + table + " ("
            Dim i As Integer
            i = 0
            For Each field In fields
                If i = 0 Then
                    sql = sql + "" + field
                Else
                    sql = sql + "," + field
                End If
                i = i + 1
            Next
            i = 0
            sql = sql + ") VALUES ("
            For Each value In values
                If i = 0 Then
                    sql = sql + "'" + value + "'"
                Else
                    sql = sql + ",'" + value + "'"
                End If
                i = i + 1
            Next
            sql = sql + ")"
            If nonQuery(sql) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function update(ByVal fields() As String, ByVal values() As String, ByVal table As String, ByVal conditon As String) As String
        Try
            Dim sql As String
            sql = "UPDATE " + table + " SET "
            Dim i As Integer
            i = 0
            For Each field In fields
                If i = 0 Then
                    sql = sql + "" + field + "='" + values(i) + "'"
                Else
                    sql = sql + "," + field + "='" + values(i) + "'"
                End If
                i = i + 1
            Next
            sql = sql + " WHERE " + conditon
            If nonQuery(sql) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
        Return False
    End Function
    Public Function delete(ByVal table As String, ByVal condition As String) As Boolean
        Dim sql As String
        sql = "DELETE FROM " + table + " WHERE " + condition
        If nonQuery(sql) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
