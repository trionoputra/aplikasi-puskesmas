Public Class UserModel

    Private _table As String = "[user]"
    Private _key As String = "kd_user"

    Public Function save(entity As User) As Boolean
        Dim field(0 To 4) As String
        Dim value(0 To 4) As String

        field(0) = "kd_user"
        field(1) = "username"
        field(2) = "password"
        field(3) = "level"
        field(4) = "nama"

        value(0) = entity.kd_user
        value(1) = entity.username
        value(2) = entity.password
        value(3) = entity.level
        value(4) = entity.nama

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function
    Public Function changePassword(id As String, password As String) As Boolean

        Dim field(0 To 0) As String
        Dim value(0 To 0) As String


        field(0) = "password"
        value(0) = password

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & id & "'")
    End Function
    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT kd_user as [Kode User],nama as [Nama], username AS [Username], level AS [Level] " &
                           " FROM  " & _table)
        Else
            entity = Conn.selectData("SELECT kd_user as [Kode User],nama as [Nama], username AS [Username], level AS [Level] " &
                           " FROM " & _table & " " &
                           " WHERE (kd_user LIKE '%" & keyword & "%') OR " &
                           " (username LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As User
        Dim entity As New User
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select * from " & _table & " where " & _key & " = '" & id & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_user = datatable.Rows(0).Item("kd_user").ToString
            entity.username = datatable.Rows(0).Item("username").ToString
            entity.password = datatable.Rows(0).Item("password").ToString
            entity.level = datatable.Rows(0).Item("level").ToString
            entity.nama = datatable.Rows(0).Item("nama").ToString
        End If
        Return entity
    End Function
    Public Function login(username As String, password As String) As User
        Dim entity As New User
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select * from " & _table & " where username = '" & username & "' and password = '" & password & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_user = datatable.Rows(0).Item("kd_user").ToString
            entity.username = datatable.Rows(0).Item("username").ToString
            entity.level = datatable.Rows(0).Item("level").ToString
            entity.nama = datatable.Rows(0).Item("nama").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As User) As Boolean
        Dim field(0 To 4) As String
        Dim value(0 To 4) As String

        field(0) = "kd_user"
        field(1) = "username"
        field(2) = "password"
        field(3) = "level"
        field(4) = "nama"

        value(0) = entity.kd_user
        value(1) = entity.username
        value(2) = entity.password
        value(3) = entity.level
        value(4) = entity.nama

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_user & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Dim count As Integer = 0
        If _sessionID = value Then
            count = 1
        End If
        Return count
    End Function
    Public Function getLast() As User
        Dim entity As New User
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_user = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function

    Public Function cekUserName(userid As String, username As String) As User
        Dim entity As New User
        Dim Conn As New Conn
        Dim datatable As New DataTable

        If (userid = "") Then
            datatable = Conn.selectData("select * from " & _table & " where username = '" & username & "'")
        Else
            datatable = Conn.selectData("select * from " & _table & " where username = '" & username & "' and " & _key & " <> '" & userid & "' ")
        End If


        If datatable.Rows.Count <> 0 Then
            entity.kd_user = datatable.Rows(0).Item("kd_user").ToString
            entity.username = datatable.Rows(0).Item("username").ToString
            entity.password = datatable.Rows(0).Item("password").ToString
            entity.level = datatable.Rows(0).Item("level").ToString
            entity.nama = datatable.Rows(0).Item("nama").ToString
        End If
        Return entity
    End Function


End Class
