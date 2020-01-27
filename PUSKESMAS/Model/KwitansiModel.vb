Public Class KwitansiModel

    Private _table As String = "kwitansi"
    Private _key As String = "kd_kw"

    Public Function save(entity As Kwitansi) As Boolean
        Dim field(0 To 4) As String
        Dim value(0 To 4) As String

        field(0) = "kd_kw"
        field(1) = "tgl_kw"
        field(2) = "total_bayar"
        field(3) = "kd_reg"
        field(4) = "status"

        value(0) = entity.kd_kw
        value(1) = entity.tgl_kw
        value(2) = entity.total_bayar
        value(3) = entity.kd_reg
        value(4) = entity.status

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT kd_kw as [Kode Kwitansi], tgl_kw AS [Tanggal Kwitansi], total_bayar AS [Total], status AS [Status] " &
                           " FROM  " & _table)
        Else
            entity = Conn.selectData("SELECT kd_kw as [Kode Kwitansi], tgl_kw AS [Tanggal Kwitansi], total_bayar AS [Total], status AS [Status] " &
                           " FROM " & _table & " " &
                           " WHERE (kd_kw LIKE '%" & keyword & "%') OR (kd_reg LIKE '%" & keyword & "%') OR " &
                           " (tgl_kw LIKE '%" & keyword & "%') ")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As Kwitansi
        Dim entity As New Kwitansi
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select p.*,rm.kd_rm,r.tgl_reg,pp.nm_poli,d.nm_dok,psn.nm_psn,psn.jenis_psn,detail = STUFF(( " &
                                     "  SELECT ',' + dt.kd_uraian+'|'+dt.uraian+'|' + cast(dt.tarif as varchar(10)) " &
                                     "  FROM dbo.detail_kwitansi dt " &
                                    " WHERE p.kd_kw = dt.kd_kw " &
                                    " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '') " &
                                    " from " & _table & " p " &
                                     " LEFT JOIN (select kd_rm,tgl_rm,kd_reg from rekammedis_umum union all select kd_rm_bumil as kd_rm ,tgl_rm,kd_reg from rekammedis_bumil) rm on p.kd_reg = rm.kd_reg " &
                                      " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli pp ON d.kd_poli = pp.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    "where " & _key & " = '" & id & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_kw = datatable.Rows(0).Item("kd_kw").ToString
            entity.kd_rm = datatable.Rows(0).Item("kd_rm").ToString
            entity.tgl_kw = datatable.Rows(0).Item("tgl_kw").ToString
            entity.total_bayar = datatable.Rows(0).Item("total_bayar").ToString
            entity.kd_reg = datatable.Rows(0).Item("kd_reg").ToString
            entity.detail = datatable.Rows(0).Item("detail").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.tgl_reg = datatable.Rows(0).Item("tgl_reg").ToString
            entity.jenis_psn = datatable.Rows(0).Item("jenis_psn").ToString
            entity.status = datatable.Rows(0).Item("status").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As Kwitansi) As Boolean
        Dim field(0 To 4) As String
        Dim value(0 To 4) As String

        field(0) = "kd_kw"
        field(1) = "tgl_kw"
        field(2) = "total_bayar"
        field(3) = "kd_reg"
        field(4) = "status"

        value(0) = entity.kd_kw
        value(1) = entity.tgl_kw
        value(2) = entity.total_bayar
        value(3) = entity.kd_reg
        value(4) = entity.status

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_kw & "'")
    End Function
    Public Function getCetak(id As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData(" select pp.nm_poli,d.nm_dok,psn.kd_psn,psn.nm_psn,(CASE WHEN psn.jenis_psn = 'Umum' THEN dt.tarif  ELSE 0 END) as tarif ,dt.uraian as nm_tindakan,k.kd_kw,k.tgl_kw,k.status  from detail_kwitansi dt " &
                                           " LEFT JOIN kwitansi k ON k.kd_kw = dt.kd_kw " &
                                       " LEFT JOIN registrasi r ON r.kd_reg = k.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli pp ON d.kd_poli = pp.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " where dt." & _key & " = '" & id & "'  ")

        Return entity
    End Function
    Public Function getCetakPendapatan(datefrom As Date, dateto As Date) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        entity = Conn.selectData(" SELECT k.tgl_kw, sum((CASE WHEN psn.jenis_psn = 'Umum' THEN k.total_bayar  ELSE 0 END)) as umum,sum((CASE WHEN psn.jenis_psn = 'JamKes' THEN k.total_bayar ELSE 0 END)) as gratis, SUM(k.total_bayar) as total " &
                                " from " & _table & " k " &
                                " left join registrasi r on r.kd_reg = k.kd_reg  " &
                                " left join pasien psn on psn.kd_psn = r.kd_psn " &
                                " where k.tgl_kw  >= '" & datefrom & "' and k.tgl_kw <= '" & dateto & "' " &
                                " group by k.tgl_kw")



        Return entity
    End Function
    Public Function getCetakSetoran(datefrom As Date) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        entity = Conn.selectData(" SELECT dk.uraian,COUNT(dk.kd_uraian) volume, sum(dk.tarif) jumlah,max(dk.tarif) tarif from detail_kwitansi dk " &
                                 " LEFT JOIN kwitansi k on k.kd_kw = dk.kd_kw" &
                                 "  where k.tgl_kw  = '" & datefrom & "' group by dk.uraian,dk.tarif ")



        Return entity
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function saveDetail(entity As Kwitansi) As Boolean
        Dim field(0 To 3) As String
        Dim value(0 To 3) As String

        field(0) = "kd_uraian"
        field(1) = "kd_kw"
        field(2) = "uraian"
        field(3) = "tarif"

        value(0) = entity.kd_uraian
        value(1) = entity.kd_kw
        value(2) = entity.uraian
        value(3) = entity.tarif

        Dim Conn As New Conn
        Return Conn.insert(field, value, "detail_kwitansi")

    End Function

    Public Function deleteDetail(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete("detail_kwitansi", "kd_kw = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return 0 'Conn.countrow(_key, "detail_tindakan", _key & " = '" & value & "'")
    End Function
    Public Function getLast() As Kwitansi
        Dim entity As New Kwitansi
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_kw = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
End Class
