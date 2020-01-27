Public Class KKModel

    Private _table As String = "kk"
    Private _key As String = "kd_kk"

    Public Function save(entity As KK) As Boolean
        Dim field(0 To 8) As String
        Dim value(0 To 8) As String

        field(0) = "kd_kk"
        field(1) = "nm_kk"
        field(2) = "alamat_kk"
        field(3) = "pekerjaan_kk"
        field(4) = "jk_kk"
        field(5) = "notelp_kk"
        field(6) = "tgl_lahir_kk"
        field(7) = "jenis_kk"
        field(8) = "tgl_daftar_kk"

        value(0) = entity.kd_kk
        value(1) = entity.nm_kk
        value(2) = entity.alamat_kk
        value(3) = entity.pekerjaan_kk
        value(4) = entity.jk_kk
        value(5) = entity.notelp_kk
        value(6) = entity.tgl_lahir_kk.ToString
        value(7) = entity.jenis_kk
        value(8) = entity.tgl_daftar_kk

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT kd_kk as [Kode KK], nm_kk AS Nama, pekerjaan_kk AS Pekerjaan, " &
                           " alamat_kk AS Alamat,jk_kk AS [Jenis Kelamin], notelp_kk AS [No. Telepon], " &
                           " tgl_lahir_kk AS [Tanggal Lahir],jenis_kk AS Jenis,tgl_daftar_kk AS [Tanggal Daftar] " &
                            " FROM " & _table)
        Else
            entity = Conn.selectData("SELECT kd_kk as [Kode KK], nm_kk AS Nama, pekerjaan_kk AS Pekerjaan, " &
                           " alamat_kk AS Alamat,jk_kk AS [Jenis Kelamin], notelp_kk AS [No. Telepon], " &
                           " tgl_lahir_kk AS [Tanggal Lahir],jenis_kk AS Jenis,tgl_daftar_kk AS [Tanggal Daftar] " &
                           " FROM " & _table & " " &
                           " WHERE (kd_kk LIKE '%" & keyword & "%') OR " &
                           " (nm_kk LIKE '%" & keyword & "%') OR " &
                           " (pekerjaan_kk LIKE '%" & keyword & "%') OR " &
                           " (jk_kk LIKE '%" & keyword & "%') OR " &
                            " (notelp_kk LIKE '%" & keyword & "%') OR " &
                            " (notelp_kk LIKE '%" & keyword & "%') OR " &
                           " (jenis_kk LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As KK
        Dim entity As New KK
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select * from " & _table & " where " & _key & " = '" & id & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_kk = datatable.Rows(0).Item("kd_kk").ToString
            entity.nm_kk = datatable.Rows(0).Item("nm_kk").ToString
            entity.pekerjaan_kk = datatable.Rows(0).Item("pekerjaan_kk").ToString
            entity.alamat_kk = datatable.Rows(0).Item("alamat_kk").ToString
            entity.jk_kk = datatable.Rows(0).Item("jk_kk").ToString
            entity.notelp_kk = datatable.Rows(0).Item("notelp_kk").ToString
            entity.tgl_lahir_kk = datatable.Rows(0).Item("tgl_lahir_kk")
            entity.jenis_kk = datatable.Rows(0).Item("jenis_kk").ToString
            entity.tgl_daftar_kk = datatable.Rows(0).Item("tgl_daftar_kk").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As KK) As Boolean
        Dim field(0 To 7) As String
        Dim value(0 To 7) As String

        field(0) = "kd_kk"
        field(1) = "nm_kk"
        field(2) = "alamat_kk"
        field(3) = "pekerjaan_kk"
        field(4) = "jk_kk"
        field(5) = "notelp_kk"
        field(6) = "tgl_lahir_kk"
        field(7) = "jenis_kk"

        value(0) = entity.kd_kk
        value(1) = entity.nm_kk
        value(2) = entity.alamat_kk
        value(3) = entity.pekerjaan_kk
        value(4) = entity.jk_kk
        value(5) = entity.notelp_kk
        value(6) = entity.tgl_lahir_kk.ToString
        value(7) = entity.jenis_kk

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_kk & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function

    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, "pasien", _key & " = '" & value & "'")
    End Function

End Class
