Public Class TindakanModel

    Private _table As String = "tindakan"
    Private _key As String = "kd_tindakan"

    Public Function save(entity As Tindakan) As Boolean
        Dim field(0 To 2) As String
        Dim value(0 To 2) As String

        field(0) = "kd_tindakan"
        field(1) = "nm_tindakan"
        field(2) = "tarif"

        value(0) = entity.kd_tindakan
        value(1) = entity.nm_tindakan
        value(2) = entity.tarif

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT kd_tindakan as [Kode Tindakan], nm_tindakan AS [Nama Tindakan], tarif AS [Tarif] " &
                           " FROM  " & _table)
        Else
            entity = Conn.selectData("SELECT kd_tindakan as [Kode Tindakan], nm_tindakan AS [Nama Tindakan], tarif AS [Tarif] " &
                           " FROM " & _table & " " &
                           " WHERE (kd_poli LIKE '%" & keyword & "%') OR " &
                           " (nm_poli LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As Tindakan
        Dim entity As New Tindakan
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select * from " & _table & " where " & _key & " = '" & id & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_tindakan = datatable.Rows(0).Item("kd_tindakan").ToString
            entity.nm_tindakan = datatable.Rows(0).Item("nm_tindakan").ToString
            entity.tarif = datatable.Rows(0).Item("tarif").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As Tindakan) As Boolean
        Dim field(0 To 2) As String
        Dim value(0 To 2) As String

        field(0) = "kd_tindakan"
        field(1) = "nm_tindakan"
        field(2) = "tarif"

        value(0) = entity.kd_tindakan
        value(1) = entity.nm_tindakan
        value(2) = entity.tarif

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_tindakan & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, "detail_tindakan", _key & " = '" & value & "'")
    End Function
    Public Function getLast() As Tindakan
        Dim entity As New Tindakan
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_tindakan = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
End Class
