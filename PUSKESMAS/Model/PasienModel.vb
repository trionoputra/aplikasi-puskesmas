Public Class PasienModel

    Private _table As String = "pasien"
    Private _key As String = "kd_psn"

    Public Function save(entity As Pasien) As Boolean
        Dim field(0 To 11) As String
        Dim value(0 To 11) As String

        field(0) = "kd_psn"
        field(1) = "nm_psn"
        field(2) = "alamat_psn"
        field(3) = "pekerjaan_psn"
        field(4) = "jk_psn"
        field(5) = "notelp_psn"
        field(6) = "tgl_lahir_psn"
        field(7) = "jenis_psn"
        field(8) = "status_kel_psn"
        field(9) = "kd_kk"
        field(10) = "tgl_daftar_psn"
        field(11) = "jenis_psn"

        value(0) = entity.kd_psn
        value(1) = entity.nm_psn
        value(2) = entity.alamat_psn
        value(3) = entity.pekerjaan_psn
        value(4) = entity.jk_psn
        value(5) = entity.notelp_psn
        value(6) = entity.tgl_lahir_psn.ToString
        value(7) = entity.jenis_psn
        value(8) = entity.status_kel_psn
        value(9) = entity.kd_kk
        value(10) = entity.tgl_daftar_psn
        value(11) = entity.jenis_psn


        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT kd_psn as [Kode Pasien], nm_psn AS Nama, pekerjaan_psn AS Pekerjaan, " &
                           " alamat_psn AS Alamat,jk_psn AS [Jenis Kelamin], notelp_psn AS [No. Telepon], " &
                           " tgl_lahir_psn AS [Tanggal Lahir],jenis_psn AS Jenis ,status_kel_psn AS [Status Keluarga],p.kd_kk as [Kode KK],k.nm_kk as [Nama KK],tgl_daftar_psn AS [Tanggal Daftar],k.tgl_lahir_kk as [Tanggal Lahir KK] " &
                            " FROM " & _table & " p " &
                            " LEFT JOIN kk k ON p.kd_kk = k.kd_kk ")
        Else
            entity = Conn.selectData("SELECT kd_psn as [Kode Pasien], nm_psn AS Nama, pekerjaan_psn AS Pekerjaan, " &
                           " alamat_psn AS Alamat,jk_psn AS [Jenis Kelamin], notelp_psn AS [No. Telepon], " &
                           " tgl_lahir_psn AS [Tanggal Lahir],jenis_psn AS Jenis ,status_kel_psn AS [Status Keluarga],p.kd_kk as [Kode KK],k.nm_kk as [Nama KK],tgl_daftar_psn AS [Tanggal Daftar],k.tgl_lahir_kk as [Tanggal Lahir KK] " &
                            " FROM " & _table & " p " &
                           " LEFT JOIN kk k ON p.kd_kk = k.kd_kk " &
                           " WHERE (kd_kk LIKE '%" & keyword & "%') OR " &
                            " (kd_psn LIKE '%" & keyword & "%') OR " &
                            " (nm_psn LIKE '%" & keyword & "%') OR " &
                           " (pekerjaan_psn LIKE '%" & keyword & "%') OR " &
                           " (jk_psn LIKE '%" & keyword & "%') OR " &
                            " (notelp_psn LIKE '%" & keyword & "%') OR " &
                            " (status_kel_psn LIKE '%" & keyword & "%') OR " &
                           " (jenis_psn LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As Pasien
        Dim entity As New Pasien
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select p.*,k.nm_kk from " & _table & " p LEFT JOIN kk k ON p.kd_kk = k.kd_kk  where " & _key & " = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.kd_kk = datatable.Rows(0).Item("kd_kk").ToString
            entity.nm_kk = datatable.Rows(0).Item("nm_kk").ToString
            entity.kd_psn = datatable.Rows(0).Item("kd_psn").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.pekerjaan_psn = datatable.Rows(0).Item("pekerjaan_psn").ToString
            entity.alamat_psn = datatable.Rows(0).Item("alamat_psn").ToString
            entity.jk_psn = datatable.Rows(0).Item("jk_psn").ToString
            entity.notelp_psn = datatable.Rows(0).Item("notelp_psn").ToString
            entity.tgl_lahir_psn = datatable.Rows(0).Item("tgl_lahir_psn")
            entity.jenis_psn = datatable.Rows(0).Item("jenis_psn").ToString
            entity.status_kel_psn = datatable.Rows(0).Item("status_kel_psn").ToString

        End If
        Return entity
    End Function
    Public Function update(entity As Pasien) As Boolean

        Dim field(0 To 9) As String
        Dim value(0 To 9) As String

        field(0) = "kd_psn"
        field(1) = "nm_psn"
        field(2) = "alamat_psn"
        field(3) = "pekerjaan_psn"
        field(4) = "jk_psn"
        field(5) = "notelp_psn"
        field(6) = "tgl_lahir_psn"
        field(7) = "jenis_psn"
        field(8) = "status_kel_psn"
        field(9) = "kd_kk"

        value(0) = entity.kd_psn
        value(1) = entity.nm_psn
        value(2) = entity.alamat_psn
        value(3) = entity.pekerjaan_psn
        value(4) = entity.jk_psn
        value(5) = entity.notelp_psn
        value(6) = entity.tgl_lahir_psn.ToString
        value(7) = entity.jenis_psn
        value(8) = entity.status_kel_psn
        value(9) = entity.kd_kk

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_psn & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function

    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, "registrasi", _key & " = '" & value & "'")
    End Function

    Public Function getCetak(id As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
      
        entity = Conn.selectData("SELECT  p.*,CASE WHEN DateDiff(YEAR,GETDATE(),p.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(YEAR ,GETDATE(),p.tgl_lahir_psn)))+' Tahun' WHEN DateDiff(MONTH ,GETDATE(),p.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(MONTH ,GETDATE(),p.tgl_lahir_psn)))+' Bulan'  WHEN DateDiff(DAY,GETDATE(),p.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(DAY ,GETDATE(),p.tgl_lahir_psn)))+' Hari' ELSE 'none' END as Umur" &
                       " FROM " & _table & " p " &
                       " WHERE (kd_psn = '" & id & "') ")

        Return entity
    End Function
    Public Function getCetakPasienBaru(datefrom As Date, dateto As Date) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData("SELECT  p.*,CASE WHEN DateDiff(YEAR,GETDATE(),p.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(YEAR ,GETDATE(),p.tgl_lahir_psn)))+' Tahun' WHEN DateDiff(MONTH ,GETDATE(),p.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(MONTH ,GETDATE(),p.tgl_lahir_psn)))+' Bulan'  WHEN DateDiff(DAY,GETDATE(),p.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(DAY ,GETDATE(),p.tgl_lahir_psn)))+' Hari' ELSE 'none' END as Umur" &
                       " FROM " & _table & " p " &
                       " WHERE  p.tgl_daftar_psn  >= '" & datefrom & "' and p.tgl_daftar_psn<= '" & dateto & "' ")

        Return entity
    End Function

    Public Function getLast() As Pasien
        Dim entity As New Pasien
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_psn = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
End Class
