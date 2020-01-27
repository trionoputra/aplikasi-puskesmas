Public Class SuratSakitModel

    Private _table As String = "surat_sakit"
    Private _key As String = "kd_srskt"

    Public Function save(entity As SuratSakit) As Boolean
        Dim field(0 To 5) As String
        Dim value(0 To 5) As String

        field(0) = "kd_srskt"
        field(1) = "tgl_srskt"
        field(2) = "lm_skt"
        field(3) = "tgl_mulai"
        field(4) = "tgl_akhir"
        field(5) = "kd_rm"

        value(0) = entity.kd_srskt
        value(1) = entity.tgl_srskt
        value(2) = entity.lm_skt
        value(3) = entity.tgl_mulai
        value(4) = entity.tgl_akhir
        value(5) = entity.kd_rm

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT s.kd_srskt as [Kode Surat Sakit],s.tgl_srskt as [Tanggal Surat Sakit],s.lm_skt as [Lama Sakit],s.tgl_mulai as [Tanggal Mulai],s.tgl_akhir as [Tanggal Akhir], rm.kd_rm as [Kode Rekam medis] " &
                            " FROM " & _table & " s " &
                             " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm ")
        Else
            entity = Conn.selectData("SELECT s.kd_srskt as [Kode Surat Sakit],s.tgl_srskt as [Tanggal Surat Sakit],s.lm_skt as [Lama Sakit],s.tgl_mulai as [Tanggal Mulai],s.tgl_akhir as [Tanggal Akhir], rm.kd_rm as [Kode Rekam medis] " &
                             " FROM " & _table & " s " &
                               " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm " &
                           " WHERE (s.kd_srskt LIKE '%" & keyword & "%') OR " &
                            " (rm.kd_rm LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As SuratSakit

        Dim entity As New SuratSakit
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

           
            entity.kd_srskt = datatable.Rows(0).Item("kd_srskt").ToString
            entity.tgl_srskt = datatable.Rows(0).Item("tgl_srskt").ToString
            entity.lm_skt = datatable.Rows(0).Item("lm_skt").ToString
            entity.tgl_mulai = datatable.Rows(0).Item("tgl_mulai").ToString
            entity.tgl_akhir = datatable.Rows(0).Item("tgl_akhir").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.kd_rm = datatable.Rows(0).Item("kd_rm").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As SuratSakit) As Boolean

        Dim field(0 To 5) As String
        Dim value(0 To 5) As String

        field(0) = "kd_srskt"
        field(1) = "tgl_srskt"
        field(2) = "lm_skt"
        field(3) = "tgl_mulai"
        field(4) = "tgl_akhir"
        field(5) = "kd_rm"

        value(0) = entity.kd_srskt
        value(1) = entity.tgl_srskt
        value(2) = entity.lm_skt
        value(3) = entity.tgl_mulai
        value(4) = entity.tgl_akhir
        value(5) = entity.kd_rm

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_srskt & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return 0 'Conn.countrow(_key, "detail_resep", _key & " = '" & value & "'")
    End Function
    Public Function getLast() As SuratSakit
        Dim entity As New SuratSakit
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_srskt = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
    Public Function getCetak(id As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData(" select s.*,d.nm_dok,psn.nm_psn,CASE WHEN DateDiff(YEAR,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(YEAR ,GETDATE(),psn.tgl_lahir_psn)))+' Tahun' WHEN DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn)))+' Bulan'  WHEN DateDiff(DAY,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(DAY ,GETDATE(),psn.tgl_lahir_psn)))+' Hari' ELSE 'none' END as Umur,psn.jk_psn,psn.pekerjaan_psn " &
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
