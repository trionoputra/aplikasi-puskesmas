Public Class SuratRujukanModel

    Private _table As String = "surat_rujukan"
    Private _key As String = "kd_rjkn"

    Public Function save(entity As SuratRujukan) As Boolean
        Dim field(0 To 6) As String
        Dim value(0 To 6) As String

        field(0) = "kd_rjkn"
        field(1) = "tgl_rjkn"

        field(2) = "alamat_rjkn"
        field(3) = "poli_rjkn"
        field(4) = "rs_rjkn"
        field(5) = "kd_rm"
        field(6) = "diagnosa"

        value(0) = entity.kd_rjkn
        value(1) = entity.tgl_rjkn

        value(2) = entity.alamat_rjkn
        value(3) = entity.poli_rjkn
        value(4) = entity.rs_rjkn
        value(5) = entity.kd_rm
        value(6) = entity.diagnosa

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT s.kd_rjkn as [Kode Surat Rujukan],s.tgl_rjkn as [Tanggal Surat Rujukan],s.alamat_rjkn as [Alamat Rujukan],s.poli_rjkn as [Poli Rujukan],s.poli_rjkn as [Rumah Sakit Rujukan], rm.kd_rm as [Kode Rekam medis],s.diagnosa [Diagnosa] " &
                            " FROM " & _table & " s " &
                             " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm ")
        Else
            entity = Conn.selectData("SELECT s.kd_rjkn as [Kode Surat Rujukan],s.tgl_rjkn as [Tanggal Surat Rujukan],s.alamat_rjkn as [Alamat Rujukan],s.poli_rjkn as [Poli Rujukan],s.rs_rjkn as [Rumah Sakit Rujukan], s.kd_rm as [Kode Rekam medis],s.diagnosa [Diagnosa] " &
                             " FROM " & _table & " s " &
                               " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm " &
                           " WHERE (s.kd_rjkn LIKE '%" & keyword & "%') OR " &
                            " (s.alamat_rjkn LIKE '%" & keyword & "%') OR " &
                             " (s.poli_rjkn LIKE '%" & keyword & "%') OR " &
                              " (s.alamat_rjkn LIKE '%" & keyword & "%') OR " &
                               " (s.rs LIKE '%" & keyword & "%') OR " &
                            " (rm.kd_rm LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As SuratRujukan

        Dim entity As New SuratRujukan
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData(" select s.*,rm.tgl_rm,r.tgl_reg,p.nm_poli,d.nm_dok,psn.nm_psn " &
                                    " from " & _table & " s " &
                                     " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm " &
                                    " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where " & _key & " = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.kd_rjkn = datatable.Rows(0).Item("kd_rjkn").ToString
            entity.tgl_rjkn = datatable.Rows(0).Item("tgl_rjkn").ToString
            entity.alamat_rjkn = datatable.Rows(0).Item("alamat_rjkn").ToString

            entity.poli_rjkn = datatable.Rows(0).Item("poli_rjkn").ToString
            entity.rs_rjkn = datatable.Rows(0).Item("rs_rjkn").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.kd_rm = datatable.Rows(0).Item("kd_rm").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm").ToString
            entity.diagnosa = datatable.Rows(0).Item("diagnosa").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As SuratRujukan) As Boolean

        Dim field(0 To 6) As String
        Dim value(0 To 6) As String

        field(0) = "kd_rjkn"
        field(1) = "tgl_rjkn"

        field(2) = "alamat_rjkn"
        field(3) = "poli_rjkn"
        field(4) = "rs_rjkn"
        field(5) = "kd_rm"
        field(6) = "diagnosa"

        value(0) = entity.kd_rjkn
        value(1) = entity.tgl_rjkn

        value(2) = entity.alamat_rjkn
        value(3) = entity.poli_rjkn
        value(4) = entity.rs_rjkn
        value(5) = entity.kd_rm
        value(6) = entity.diagnosa

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_rjkn & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return 0 'Conn.countrow(_key, "detail_resep", _key & " = '" & value & "'")
    End Function
    Public Function getLast() As SuratRujukan
        Dim entity As New SuratRujukan
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_rjkn = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function

    Public Function getCetak(id As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData(" select s.*,d.nm_dok,psn.nm_psn,CASE WHEN DateDiff(YEAR,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(YEAR ,GETDATE(),psn.tgl_lahir_psn)))+' Tahun' WHEN DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn)))+' Bulan'  WHEN DateDiff(DAY,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(DAY ,GETDATE(),psn.tgl_lahir_psn)))+' Hari' ELSE 'none' END as Umur,psn.jk_psn " &
                                    " from " & _table & " s " &
                                    " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm " &
                                    " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where " & _key & " = '" & id & "'  ")

        Return entity
    End Function

End Class
