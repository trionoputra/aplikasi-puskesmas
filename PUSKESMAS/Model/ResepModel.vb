Public Class ResepModel

    Private _table As String = "resep"
    Private _key As String = "kd_resep"

    Public Function save(entity As Resep) As Boolean
        Dim field(0 To 3) As String
        Dim value(0 To 3) As String

        field(0) = "kd_resep"
        field(1) = "tgl_resep"
        field(2) = "kd_rm"
        field(3) = "status"

        value(0) = entity.kd_resep
        value(1) = entity.tgl_resep
        value(2) = entity.kd_rm
        value(3) = entity.status

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT rp.kd_resep as [Kode Resep],rp.tgl_resep as [Tanggal Resep], rm.kd_rm as [Kode Rekam medis], rm.tgl_rm as [Tanggal Rekam Medis], psn.nm_psn AS [Nama Pasien], nm_dok AS [Nama Dokter], " &
                           " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] " &
                            " FROM " & _table & " rp " &
                            " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on rp.kd_rm = rm.kd_rm " &
                             " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk ")
        Else
            entity = Conn.selectData("SELECT rp.kd_resep as [Kode Resep],rp.tgl_resep as [Tanggal Resep], rm.kd_rm as [Kode Rekam medis], rm.tgl_rm as [Tanggal Rekam Medis], psn.nm_psn AS [Nama Pasien], nm_dok AS [Nama Dokter], " &
                           " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] " &
                            " FROM " & _table & " rp " &
                            " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on rp.kd_rm = rm.kd_rm " &
                             " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                           " WHERE (d.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (p.kd_poli LIKE '%" & keyword & "%') OR " &
                             " (r.kd_reg LIKE '%" & keyword & "%') OR " &
                              " (rp.kd_resep LIKE '%" & keyword & "%') OR " &
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
    Public Function getStatusBy(keyword As String, status As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT rp.kd_resep as [Kode Resep],rp.tgl_resep as [Tanggal Resep], rm.kd_rm as [Kode Rekam medis], rm.tgl_rm as [Tanggal Rekam Medis], psn.nm_psn AS [Nama Pasien], nm_dok AS [Nama Dokter], " &
                           " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] " &
                            " FROM " & _table & " rp " &
                            " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on rp.kd_rm = rm.kd_rm " &
                             " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk where rp.status = " & status)
        Else
            entity = Conn.selectData("SELECT rp.kd_resep as [Kode Resep],rp.tgl_resep as [Tanggal Resep], rm.kd_rm as [Kode Rekam medis], rm.tgl_rm as [Tanggal Rekam Medis], psn.nm_psn AS [Nama Pasien], nm_dok AS [Nama Dokter], " &
                           " p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] " &
                            " FROM " & _table & " rp " &
                            " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on rp.kd_rm = rm.kd_rm " &
                             " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                           " WHERE rp.status = " & status & " and (d.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (p.kd_poli LIKE '%" & keyword & "%') OR " &
                             " (r.kd_reg LIKE '%" & keyword & "%') OR " &
                              " (rp.kd_resep LIKE '%" & keyword & "%') OR " &
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
    Public Function getOBJBy(id As String) As Resep

        Dim entity As New Resep
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData(" select rp.kd_resep,rp.tgl_resep,rm.*,r.tgl_reg,p.nm_poli,d.nm_dok,psn.nm_psn,detail = STUFF(( " &
                                     "  SELECT ',' +  dr.kd_obat+'|'+o.nm_obat+'|'+cast(dr.jml_obat as varchar(10))+'|'+dr.aturan_pakai " &
                                     "  FROM dbo.detail_resep dr " &
                                      " LEFT JOIN obat o ON dr.kd_obat = o.kd_obat " &
                                    " WHERE rp.kd_resep = dr.kd_resep " &
                                    " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '') " &
                                    " from " & _table & " rp " &
                                    " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on rp.kd_rm = rm.kd_rm " &
                                     " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where " & _key & " = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.kd_resep = datatable.Rows(0).Item("kd_resep").ToString
            entity.tgl_resep = datatable.Rows(0).Item("tgl_resep").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.kd_rm = datatable.Rows(0).Item("kd_rm").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm").ToString
            entity.detail = datatable.Rows(0).Item("detail").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As Resep) As Boolean

        Dim field(0 To 2) As String
        Dim value(0 To 2) As String

        field(0) = "kd_resep"
        field(1) = "tgl_resep"
        field(2) = "kd_rm"

        value(0) = entity.kd_resep
        value(1) = entity.tgl_resep
        value(2) = entity.kd_rm

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_resep & "'")
    End Function
    Public Function updateStatus(entity As Resep) As Boolean

        Dim field(0 To 0) As String
        Dim value(0 To 0) As String

        field(0) = "status"
        value(0) = entity.status

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_resep & "'")
    End Function
    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return 0 'Conn.countrow(_key, "detail_resep", _key & " = '" & value & "'")
    End Function

    Public Function saveDetail(entity As Resep) As Boolean
        Dim field(0 To 3) As String
        Dim value(0 To 3) As String

        field(0) = "kd_resep"
        field(1) = "kd_obat"
        field(2) = "jml_obat"
        field(3) = "aturan_pakai"

        value(0) = entity.kd_resep
        value(1) = entity.kd_obat
        value(2) = entity.jml_obat
        value(3) = entity.aturan_pakai

        Dim Conn As New Conn
        Return Conn.insert(field, value, "detail_resep")

    End Function
    Public Function getCetak(id As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData(" select d.*,r.tgl_resep,o.nm_obat,psn.kd_psn,psn.nm_psn from detail_resep d " &
                                      " LEFT JOIN resep r ON r.kd_resep = d.kd_resep " &
                                      " LEFT JOIN obat o ON o.kd_obat = d.kd_obat " &
                                      " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on r.kd_rm = rm.kd_rm " &
                                       " LEFT JOIN registrasi rr ON rm.kd_reg = rr.kd_reg " &
                                       " LEFT JOIN dokter dd ON rr.kd_dok = dd.kd_dok " &
                                       " LEFT JOIN poli pp ON dd.kd_poli = pp.kd_poli " &
                                       " LEFT JOIN pasien psn ON rr.kd_psn = psn.kd_psn " &
                                    " where d." & _key & " = '" & id & "'  ")

        Return entity

    End Function
    Public Function getCetakLaporanHarian(tanggal As Date) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData("select rp.tgl_resep,psn.nm_psn,r.kd_reg,pp.nm_poli,psn.jenis_psn from resep rp " &
                               " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on rp.kd_rm = rm.kd_rm " &
                               " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                               " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                               " LEFT JOIN poli pp ON d.kd_poli = pp.kd_poli " &
                               " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                               " WHERE  rp.tgl_resep  = '" & tanggal & "' order by psn.jenis_psn asc")

        Return entity
    End Function
    Public Function getCetakLaporanPeriode(datefrom As Date, dateto As Date) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData("select rp.tgl_resep,psn.jenis_psn,COUNT(rp.kd_resep) jumlah from resep rp " &
                                "    LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on rp.kd_rm = rm.kd_rm " &
                                "   LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                "    LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                 " where rp.tgl_resep  >= '" & datefrom & "' and  rp.tgl_resep <= '" & dateto & "' " &
                                "    group by rp.tgl_resep,psn.jenis_psn")

        Return entity
    End Function
    Public Function deleteDetail(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete("detail_resep", _key & " = '" & id & "'")
    End Function
    Public Function getLast() As Resep
        Dim entity As New Resep
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_resep = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
End Class
