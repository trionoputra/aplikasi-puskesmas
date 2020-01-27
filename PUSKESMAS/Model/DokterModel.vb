Public Class DokterModel

    Private _table As String = "dokter"
    Private _key As String = "kd_dok"

    Public Function save(entity As Dokter) As Boolean
        Dim field(0 To 7) As String
        Dim value(0 To 7) As String

        field(0) = "kd_dok"
        field(1) = "nm_dok"
        field(2) = "alamat_dok"
        field(3) = "jk_dok"
        field(4) = "notelp_dok"
        field(5) = "tgl_lahir_dok"
        field(6) = "kd_poli"
        field(7) = "password"


        value(0) = entity.kd_dok
        value(1) = entity.nm_dok
        value(2) = entity.alamat_dok
        value(3) = entity.jk_dok
        value(4) = entity.notelp_dok
        value(5) = entity.tgl_lahir_dok.ToString
        value(6) = entity.kd_poli
        value(7) = entity.password

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then

            entity = Conn.selectData("SELECT kd_dok as [Kode Dokter], nm_dok AS Nama,d.kd_poli as [Kode Poli],p.nm_poli as [Nama Poli], " &
                           " alamat_dok AS Alamat,jk_dok AS [Jenis Kelamin], notelp_dok AS [No. Telepon], " &
                           " tgl_lahir_dok AS [Tanggal Lahir] " &
                            " FROM " & _table & " d " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli ")
        Else
            entity = Conn.selectData("SELECT kd_dok as [Kode Dokter], nm_dok AS Nama,d.kd_poli as [Kode Poli],p.nm_poli as [Nama Poli], " &
                           " alamat_dok AS Alamat,jk_dok AS [Jenis Kelamin], notelp_dok AS [No. Telepon], " &
                           " tgl_lahir_dok AS [Tanggal Lahir] " &
                            " FROM " & _table & " d " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                           " WHERE (d.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (kd_dok LIKE '%" & keyword & "%') OR " &
                            " (nm_dok LIKE '%" & keyword & "%') OR " &
                           " (jk_dok LIKE '%" & keyword & "%') OR " &
                            " (notelp_dok LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As Dokter
        Dim entity As New Dokter
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select d.*,p.nm_poli from " & _table & " d LEFT JOIN poli p ON p.kd_poli = d.kd_poli  where " & _key & " = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.kd_poli = datatable.Rows(0).Item("kd_poli").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.kd_dok = datatable.Rows(0).Item("kd_dok").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.alamat_dok = datatable.Rows(0).Item("alamat_dok").ToString
            entity.jk_dok = datatable.Rows(0).Item("jk_dok").ToString
            entity.notelp_dok = datatable.Rows(0).Item("notelp_dok").ToString
            entity.tgl_lahir_dok = datatable.Rows(0).Item("tgl_lahir_dok")
            entity.password = datatable.Rows(0).Item("password")
        End If
        Return entity
    End Function
    Public Function update(entity As Dokter) As Boolean

        Dim field(0 To 7) As String
        Dim value(0 To 7) As String

        field(0) = "kd_dok"
        field(1) = "nm_dok"
        field(2) = "alamat_dok"
        field(3) = "jk_dok"
        field(4) = "notelp_dok"
        field(5) = "tgl_lahir_dok"
        field(6) = "kd_poli"
        field(7) = "password"


        value(0) = entity.kd_dok
        value(1) = entity.nm_dok
        value(2) = entity.alamat_dok
        value(3) = entity.jk_dok
        value(4) = entity.notelp_dok
        value(5) = entity.tgl_lahir_dok.ToString
        value(6) = entity.kd_poli
        value(7) = entity.password

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_dok & "'")
    End Function

    Public Function changePassword(id As String, password As String) As Boolean

        Dim field(0 To 0) As String
        Dim value(0 To 0) As String


        field(0) = "password"
        value(0) = password

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & id & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, "registrasi", _key & " = '" & value & "'")
    End Function
    Public Function login(username As String, password As String) As User
        Dim entity As New User
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select * from " & _table & " where kd_dok = '" & username & "' and password = '" & password & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_user = datatable.Rows(0).Item("kd_dok").ToString
            entity.username = datatable.Rows(0).Item("kd_dok").ToString
            entity.nama = datatable.Rows(0).Item("nm_dok").ToString
            entity.level = "Dokter"
        End If
        Return entity
    End Function

    Public Function getLast() As Dokter
        Dim entity As New Dokter
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_dok = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
End Class
