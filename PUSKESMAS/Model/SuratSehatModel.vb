Public Class SuratSehatModel

    Private _table As String = "surat_sehat"
    Private _key As String = "kd_srsht"

    Public Function save(entity As SuratSehat) As Boolean
        Dim field(0 To 6) As String
        Dim value(0 To 6) As String

        field(0) = "kd_srsht"
        field(1) = "tgl_srsht"
        field(2) = "keperluan"
        field(3) = "tensi"
        field(4) = "bb"
        field(5) = "tb"
        field(6) = "kd_rm"

        value(0) = entity.kd_srsht
        value(1) = entity.tgl_srsht
        value(2) = entity.keperluan
        value(3) = entity.tensi
        value(4) = entity.bb
        value(5) = entity.tb
        value(6) = entity.kd_rm

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT s.kd_srsht as [Kode Surat Sehat],s.tgl_srsht as [Tanggal Surat Sehat],s.keperluan as [Keperluan],s.tensi as [Tensi],s.bb as [Berat Badan],s.tb as [Tinggi Badan], rm.kd_rm as [Kode Rekam medis] " &
                            " FROM " & _table & " s " &
                              " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm ")
        Else
            entity = Conn.selectData("SELECT s.kd_srsht as [Kode Surat Sehat],s.tgl_srsht as [Tanggal Surat Sehat],s.keperluan as [Keperluan],s.tensi as [Tensi],s.bb as [Berat Badan],s.tb as [Tinggi Badan], rm.kd_rm as [Kode Rekam medis] " &
                             " FROM " & _table & " s " &
                               " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on s.kd_rm = rm.kd_rm " &
                           " WHERE (s.kd_srsht LIKE '%" & keyword & "%') OR " &
                            " (s.keperluan LIKE '%" & keyword & "%') OR " &
                            " (s.keadaan LIKE '%" & keyword & "%') OR " &
                            " (rm.kd_rm LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As SuratSehat

        Dim entity As New SuratSehat
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
            entity.kd_srsht = datatable.Rows(0).Item("kd_srsht").ToString
            entity.tgl_srsht = datatable.Rows(0).Item("tgl_srsht").ToString
            entity.keperluan = datatable.Rows(0).Item("keperluan").ToString
            entity.bb = datatable.Rows(0).Item("bb").ToString
            entity.tensi = datatable.Rows(0).Item("tensi").ToString
            entity.tb = datatable.Rows(0).Item("tb").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.kd_rm = datatable.Rows(0).Item("kd_rm").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm")
        End If
        Return entity
    End Function
    Public Function update(entity As SuratSehat) As Boolean

        Dim field(0 To 6) As String
        Dim value(0 To 6) As String

         field(0) = "kd_srsht"
        field(1) = "tgl_srsht"
        field(2) = "keperluan"
        field(3) = "tensi"
        field(4) = "bb"
        field(5) = "tb"
        field(6) = "kd_rm"

        value(0) = entity.kd_srsht
        value(1) = entity.tgl_srsht
        value(2) = entity.keperluan
        value(3) = entity.tensi
        value(4) = entity.bb
        value(5) = entity.tb
        value(6) = entity.kd_rm

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_srsht & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return 0 'Conn.countrow(_key, "detail_resep", _key & " = '" & value & "'")
    End Function
    Public Function getLast() As SuratSehat
        Dim entity As New SuratSehat
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_srsht = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
    Public Function getCetak(id As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData(" select s.*,d.nm_dok,psn.nm_psn,CASE WHEN DateDiff(YEAR,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(YEAR ,GETDATE(),psn.tgl_lahir_psn)))+' Tahun' WHEN DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn)))+' Bulan'  WHEN DateDiff(DAY,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(DAY ,GETDATE(),psn.tgl_lahir_psn)))+' Hari' ELSE 'none' END as Umur,psn.jk_psn,psn.pekerjaan_psn,psn.alamat_psn " &
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
