Public Class RekamMedisUmumModel

    Private _table As String = "rekammedis_umum"
    Private _key As String = "kd_rm"

    Public Function save(entity As RekamMedisUmum) As Boolean
        Dim field(0 To 7) As String
        Dim value(0 To 7) As String

        field(0) = "kd_rm"
        field(1) = "tgl_rm"
        field(2) = "anamnesis"
        field(3) = "diagnosa"
        field(4) = "berat_badan"
        field(5) = "tinggi_badan"
        field(6) = "tekanan_darah"
        field(7) = "kd_reg"

        value(0) = entity.kd_rm
        value(1) = entity.tgl_rm
        value(2) = entity.anamnesis
        value(3) = entity.diagnosa
        value(4) = entity.berat_badan
        value(5) = entity.tinggi_badan
        value(6) = entity.tekanan_darah
        value(7) = entity.kd_reg

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT rm.kd_rm as [Kode Rekam medis], rm.tgl_rm as [Tanggal], psn.nm_psn AS [Nama Pasien],rm.anamnesis as Anamnesis,rm.diagnosa as Diagnosa,rm.berat_badan as [Berat Badan],rm.tinggi_badan as [Tinggi Badan],rm.tekanan_darah as [Tekanan Darah], nm_dok AS [Nama Dokter], " &
                           " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] , r.tgl_reg as [Tanggal Registrasi]  " &
                            " FROM " & _table & " rm " &
                             " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk ")
        Else
            entity = Conn.selectData("SELECT rm.kd_rm as [Kode Rekam medis], rm.tgl_rm as [Tanggal], psn.nm_psn AS [Nama Pasien],rm.anamnesis as Anamnesis,rm.diagnosa as Diagnosa,rm.berat_badan as [Berat Badan],rm.tinggi_badan as [Tinggi Badan],rm.tekanan_darah as [Tekanan Darah], nm_dok AS [Nama Dokter], " &
                           " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] , r.tgl_reg as [Tanggal Registrasi] " &
                            " FROM " & _table & " rm " &
                             " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                           " WHERE (d.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (p.kd_poli LIKE '%" & keyword & "%') OR " &
                             " (r.kd_reg LIKE '%" & keyword & "%') OR " &
                              " (rm.kd_rm LIKE '%" & keyword & "%') OR " &
                               " (rm.anamnesis LIKE '%" & keyword & "%') OR " &
                                " (rm.diagnosa LIKE '%" & keyword & "%') OR " &
                            " (d.kd_dok LIKE '%" & keyword & "%') OR " &
                            " (d.nm_dok LIKE '%" & keyword & "%') OR " &
                             " (k.nm_kk LIKE '%" & keyword & "%') OR " &
                               " (psn.nm_psn LIKE '%" & keyword & "%') OR " &
                               " (psn.kd_psn LIKE '%" & keyword & "%') OR " &
                            " (k.kd_kk LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As RekamMedisUmum

        Dim entity As New RekamMedisUmum
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData(" select rm.*,r.tgl_reg,p.nm_poli,d.nm_dok,psn.nm_psn,detail = STUFF(( " &
                                     "  SELECT ',' +  t.kd_tindakan+ '|'+ t.nm_tindakan+ '|'+ cast(t.tarif as varchar(10)) " &
                                     "  FROM dbo.detail_tindakan dt " &
                                      " LEFT JOIN tindakan t ON dt.kd_tindakan = t.kd_tindakan " &
                                    " WHERE rm.kd_rm = dt.kd_rm " &
                                    " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '') " &
                                    " from " & _table & " rm " &
                                     " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where " & _key & " = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.kd_reg = datatable.Rows(0).Item("kd_reg").ToString
            entity.kd_rm = datatable.Rows(0).Item("kd_rm").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm").ToString
            entity.tgl_reg = datatable.Rows(0).Item("tgl_reg").ToString
            entity.detail = datatable.Rows(0).Item("detail").ToString
            entity.anamnesis = datatable.Rows(0).Item("anamnesis").ToString
            entity.diagnosa = datatable.Rows(0).Item("diagnosa").ToString
            entity.berat_badan = datatable.Rows(0).Item("berat_badan").ToString
            entity.tinggi_badan = datatable.Rows(0).Item("tinggi_badan").ToString
            entity.tekanan_darah = datatable.Rows(0).Item("tekanan_darah").ToString
        End If
        Return entity
    End Function
    Public Function getOBJByReg(id As String) As RekamMedisUmum
        Dim entity As New RekamMedisUmum
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData(" select psn.jenis_psn,detail = STUFF(( " &
                                     "  SELECT ',' +  t.kd_tindakan+'|' + t.nm_tindakan + '|' + cast(t.tarif as varchar(10)) " &
                                     "  FROM dbo.detail_tindakan dt " &
                                      " LEFT JOIN tindakan t ON dt.kd_tindakan = t.kd_tindakan " &
                                    " WHERE rm.kd_rm = dt.kd_rm " &
                                    " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '') " &
                                    " from " & _table & " rm " &
                                     " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where rm.kd_rm = '" & id & "' " &
                                        " union all " &
                                    " select psn.jenis_psn,detail = STUFF(( " &
                                     "  SELECT ',' +  t.kd_tindakan+'|' + t.nm_tindakan + '|' + cast(t.tarif as varchar(10)) " &
                                     "  FROM dbo.detail_tindakan dt " &
                                      " LEFT JOIN tindakan t ON dt.kd_tindakan = t.kd_tindakan " &
                                    " WHERE rm.kd_rm_bumil = dt.kd_rm " &
                                    " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '') " &
                                    " from rekammedis_bumil rm " &
                                     " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where rm.kd_rm_bumil = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.detail = datatable.Rows(0).Item("detail").ToString
            entity.jenis_psn = datatable.Rows(0).Item("jenis_psn").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As RekamMedisUmum) As Boolean

        Dim field(0 To 7) As String
        Dim value(0 To 7) As String

        field(0) = "kd_rm"
        field(1) = "tgl_rm"
        field(2) = "anamnesis"
        field(3) = "diagnosa"
        field(4) = "berat_badan"
        field(5) = "tinggi_badan"
        field(6) = "tekanan_darah"
        field(7) = "kd_reg"

        value(0) = entity.kd_rm
        value(1) = entity.tgl_rm
        value(2) = entity.anamnesis
        value(3) = entity.diagnosa
        value(4) = entity.berat_badan
        value(5) = entity.tinggi_badan
        value(6) = entity.tekanan_darah
        value(7) = entity.kd_reg

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_rm & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Dim dt As DataTable = Conn.selectData(" select kd_rm as kd from surat_rujukan where kd_rm = '" & value & "' " &
                                               " union all " &
                                               "  select kd_rm as kd from surat_sakit where kd_rm = '" & value & "' " &
                                                " union all " &
                                               "  select kd_rm as kd from surat_sehat  where kd_rm = '" & value & "' " &
                                               "  union all " &
                                               "  select kd_rm as kd from detail_tindakan   where kd_rm = '" & value & "' " &
                                               "  union all " &
                                               "  select kd_kw as kd from kwitansi k " &
                                               "  left join registrasi r on k.kd_reg = r.kd_reg " &
                                               "  left join rekammedis_umum rm on r.kd_reg = r.kd_reg where kd_rm  = '" & value & "' ")
        Return dt.Rows.Count
    End Function

    Public Function saveDetail(entity As RekamMedisUmum) As Boolean
        Dim field(0 To 1) As String
        Dim value(0 To 1) As String

        field(0) = "kd_rm"
        field(1) = "kd_tindakan"


        value(0) = entity.kd_rm
        value(1) = entity.kd_tindakan


        Dim Conn As New Conn
        Return Conn.insert(field, value, "detail_tindakan")

    End Function

    Public Function deleteDetail(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete("detail_tindakan", _key & " = '" & id & "'")
    End Function
    Public Function getLast() As RekamMedisUmum
        Dim entity As New RekamMedisUmum
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_rm = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function

    Public Function getRekammedisBy(keyword As String, tipe As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        Dim where As String = ""
        If (tipe = "resep") Then
            where = "where (resep.kd_resep is null) "
        ElseIf (tipe = "srskt") Then
            where = "where (surat_sakit.kd_srskt is null) "
        ElseIf (tipe = "srsht") Then
            where = "where (surat_sehat.kd_srsht is null) "
        ElseIf (tipe = "rjkn") Then
            where = "where (surat_rujukan.kd_rjkn is null) "
        ElseIf (tipe = "kwitansi") Then
            where = "where (kwitansi.kd_kw is null) "
        End If

        Dim whererm As String = where
        Dim wherermb As String = where
        If keyword <> "" Then
            whererm &= "(d.kd_poli LIKE '%" & keyword & "%') OR " &
                           " (p.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (r.kd_reg LIKE '%" & keyword & "%') OR " &
                             " (rm.kd_rm LIKE '%" & keyword & "%') OR " &
                              " (rm.anamnesis LIKE '%" & keyword & "%') OR " &
                               " (rm.diagnosa LIKE '%" & keyword & "%') OR " &
                           " (d.kd_dok LIKE '%" & keyword & "%') OR " &
                           " (d.nm_dok LIKE '%" & keyword & "%') OR " &
                            " (k.nm_kk LIKE '%" & keyword & "%') OR " &
                              " (psn.nm_psn LIKE '%" & keyword & "%') OR " &
                              " (psn.kd_psn LIKE '%" & keyword & "%') OR " &
                           " (k.kd_kk LIKE '%" & keyword & "%') "

            wherermb &= "(d.kd_poli LIKE '%" & keyword & "%') OR " &
                           " (p.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (r.kd_reg LIKE '%" & keyword & "%') OR " &
                             " (rm.kd_rm_bumil LIKE '%" & keyword & "%') OR " &
                           " (d.kd_dok LIKE '%" & keyword & "%') OR " &
                           " (d.nm_dok LIKE '%" & keyword & "%') OR " &
                            " (k.nm_kk LIKE '%" & keyword & "%') OR " &
                              " (psn.nm_psn LIKE '%" & keyword & "%') OR " &
                              " (psn.kd_psn LIKE '%" & keyword & "%') OR " &
                           " (k.kd_kk LIKE '%" & keyword & "%') "
        Else

        End If

        entity = Conn.selectData("SELECT rm.kd_rm as [Kode Rekam medis], rm.tgl_rm as [Tanggal], psn.nm_psn AS [Nama Pasien], nm_dok AS [Nama Dokter], " &
                          " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] , r.tgl_reg as [Tanggal Registrasi], rm.diagnosa AS [Diagnosa] " &
                           " FROM " & _table & " rm " &
                            " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                           " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                           " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                           " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                           " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                           " LEFT JOIN resep  ON resep.kd_rm = rm.kd_rm " &
                            " LEFT JOIN surat_sakit  ON surat_sakit.kd_rm = rm.kd_rm " &
                             " LEFT JOIN surat_sehat  ON surat_sehat.kd_rm = rm.kd_rm " &
                              " LEFT JOIN surat_rujukan  ON surat_rujukan.kd_rm = rm.kd_rm " &
                               " LEFT JOIN kwitansi  ON kwitansi.kd_reg = r.kd_reg " &
                          " " & whererm &
                              " union all " &
                           "SELECT rm.kd_rm_bumil as [Kode Rekam medis], rm.tgl_rm as [Tanggal], psn.nm_psn AS [Nama Pasien], nm_dok AS [Nama Dokter], " &
                          " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] , r.tgl_reg as [Tanggal Registrasi], '' as [Diagnosa] " &
                           " FROM rekammedis_bumil rm " &
                            " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                           " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                           " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                           " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                           " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                            " LEFT JOIN resep  ON resep.kd_rm = rm.kd_rm_bumil " &
                            " LEFT JOIN surat_sakit  ON surat_sakit.kd_rm = rm.kd_rm_bumil " &
                             " LEFT JOIN surat_sehat  ON surat_sehat.kd_rm = rm.kd_rm_bumil " &
                              " LEFT JOIN surat_rujukan  ON surat_rujukan.kd_rm = rm.kd_rm_bumil " &
                               " LEFT JOIN kwitansi  ON kwitansi.kd_reg = r.kd_reg " &
                          " " & wherermb)

        Return entity
    End Function
End Class
