Public Class PoliModel

    Private _table As String = "poli"
    Private _key As String = "kd_poli"

    Public Function save(p As Poli) As Boolean
        Dim field(0 To 1) As String
        Dim value(0 To 1) As String

        field(0) = "kd_poli"
        field(1) = "nm_poli"

        value(0) = p.kd_poli
        value(1) = p.nm_poli
        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT kd_poli as [Kode Poli], nm_poli AS [Nama Poli] " &
                           " FROM  " & _table)
        Else
            entity = Conn.selectData("SELECT kd_poli as [Kode Poli], nm_poli AS [Nama Poli] " &
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
    Public Function getOBJBy(id As String) As Poli
        Dim entity As New Poli
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select * from " & _table & " where " & _key & " = '" & id & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_poli = datatable.Rows(0).Item("kd_poli").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As Poli) As Boolean
        Dim field(0 To 1) As String
        Dim value(0 To 1) As String

        field(0) = "kd_poli"
        field(1) = "nm_poli"

        value(0) = entity.kd_poli
        value(1) = entity.nm_poli

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_poli & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, "dokter", _key & " = '" & value & "'")
    End Function

    Public Function getLast() As Poli
        Dim entity As New Poli
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_poli = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function

End Class
