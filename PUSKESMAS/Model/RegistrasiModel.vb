Public Class RegistrasiModel

    Private _table As String = "registrasi"
    Private _key As String = "kd_reg"

    Public Function save(entity As Registrasi) As Boolean
        Dim field(0 To 3) As String
        Dim value(0 To 3) As String

        field(0) = "kd_reg"
        field(1) = "kd_dok"
        field(2) = "kd_psn"
        field(3) = "tgl_reg"

        value(0) = entity.kd_reg
        value(1) = entity.kd_dok
        value(2) = entity.kd_psn
        value(3) = entity.tgl_reg
       
        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT r.kd_reg as [Kode Registrasi], r.tgl_reg as [Tanggal Registrasi],psn.kd_psn as [Kode Pasien], psn.nm_psn AS [Nama Pasien],d.kd_poli as [Kode Poli],p.nm_poli as [Nama Poli],r.kd_dok as [Kode Dokter], nm_dok AS [Nama Dokter],k.kd_kk as [Kode KK], K.nm_kk AS [Nama KK] " &
                            " FROM " & _table & " r " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk ")
        Else
            entity = Conn.selectData("SELECT r.kd_reg as [Kode Registrasi], r.tgl_reg as [Tanggal Registrasi],psn.kd_psn as [Kode Pasien], psn.nm_psn AS [Nama Pasien],d.kd_poli as [Kode Poli],p.nm_poli as [Nama Poli],r.kd_dok as [Kode Dokter], nm_dok AS [Nama Dokter],k.kd_kk as [Kode KK], K.nm_kk AS [Nama KK] " &
                            " FROM " & _table & " r " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                           " WHERE (d.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (p.kd_poli LIKE '%" & keyword & "%') OR " &
                             " (r.kd_reg LIKE '%" & keyword & "%') OR " &
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
    Public Function getOBJBy(id As String) As Registrasi

        Dim entity As New Registrasi
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData(" select r.*,d.nm_dok,psn.nm_psn,p.kd_poli,p.nm_poli,k.kd_kk,k.nm_kk,k.tgl_lahir_kk,psn.alamat_psn,psn.tgl_lahir_psn,psn.notelp_psn from " & _table & " r " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where " & _key & " = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.kd_poli = datatable.Rows(0).Item("kd_poli").ToString
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString

            entity.kd_dok = datatable.Rows(0).Item("kd_dok").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString

            entity.kd_psn = datatable.Rows(0).Item("kd_psn").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString

            entity.kd_kk = datatable.Rows(0).Item("kd_kk").ToString
            entity.nm_kk = datatable.Rows(0).Item("nm_kk").ToString

            entity.kd_reg = datatable.Rows(0).Item("kd_reg").ToString
            entity.tgl_reg = datatable.Rows(0).Item("tgl_reg").ToString

            entity.no_telpon = datatable.Rows(0).Item("notelp_psn").ToString
            entity.tgl_lahir = datatable.Rows(0).Item("tgl_lahir_psn").ToString
            entity.tgl_lahir_kk = datatable.Rows(0).Item("tgl_lahir_kk").ToString
            entity.alamat = datatable.Rows(0).Item("alamat_psn").ToString
           
        End If
        Return entity
    End Function
    Public Function update(entity As Registrasi) As Boolean

        Dim field(0 To 3) As String
        Dim value(0 To 3) As String

        field(0) = "kd_reg"
        field(1) = "kd_dok"
        field(2) = "kd_psn"
        field(3) = "tgl_reg"

        value(0) = entity.kd_reg
        value(1) = entity.kd_dok
        value(2) = entity.kd_psn
        value(3) = entity.tgl_reg

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_reg & "'")
    End Function
    Public Function getCetak(id As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData(" select r.*,d.nm_dok,psn.nm_psn,p.kd_poli,p.nm_poli,k.kd_kk,k.nm_kk from " & _table & " r " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where " & _key & " = '" & id & "'  ")

        Return entity
    End Function
    Public Function getCetakKunjunganHarian(datefrom As Date, poli As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn

        entity = Conn.selectData(" select psn.nm_psn,psn.kd_psn,psn.alamat_psn,k.nm_kk,psn.jenis_psn,r.kd_reg,CASE WHEN DateDiff(YEAR,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(YEAR ,GETDATE(),psn.tgl_lahir_psn)))+' Tahun' WHEN DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(MONTH ,GETDATE(),psn.tgl_lahir_psn)))+' Bulan'  WHEN DateDiff(DAY,GETDATE(),psn.tgl_lahir_psn) < 0 THEN CONVERT(varchar(10), abs(DateDiff(DAY ,GETDATE(),psn.tgl_lahir_psn)))+' Hari' ELSE 'none' END as Umur from " & _table & " r " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where r.tgl_reg  = '" & datefrom & "' and p.kd_poli = '" & poli & "' order by psn.jenis_psn desc ")

        Return entity
    End Function

    Public Function getCetakPengunjung(datefrom As Date, dateto As Date) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        entity = Conn.selectData(" SELECT r.tgl_reg, sum((CASE WHEN psn.jenis_psn = 'Umum' THEN 1 ELSE 0 END)) as umum,sum((CASE WHEN psn.jenis_psn = 'JamKes' THEN 1 ELSE 0 END)) as gratis " &
                                 " from " & _table & " r " &
                                 " left join pasien psn on psn.kd_psn = r.kd_psn " &
                                 " where r.tgl_reg  >= '" & datefrom & "' and r.tgl_reg <= '" & dateto & "' " &
                                 " group by r.tgl_reg")
        Return entity
    End Function
    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Dim dt As DataTable = Conn.selectData(" select kd_reg as kd from rekammedis_umum r where  r.kd_reg = '" & value & "' " &
                                                " union all " &
                                                "  select kd_reg as kd from rekammedis_bumil m where m.kd_reg  = '" & value & "'")
        Return dt.Rows.Count
    End Function
    Public Function getLast() As Registrasi
        Dim entity As New Registrasi
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_reg = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function

    Public Function getPoliBy(keyword As String, ByVal isBumil As Boolean, level As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        Dim where As String = "WHERE rmb.kd_rm_bumil is null and rm.kd_rm is null and (lower(p.nm_poli) NOT LIKE '%bumil%' and lower(p.nm_poli) NOT LIKE '%hamil%' and lower(p.nm_poli) NOT LIKE '%kia%') "
        If isBumil Then
            where = "WHERE  rmb.kd_rm_bumil is null and rm.kd_rm is null and  (lower(p.nm_poli) LIKE '%bumil%' or lower(p.nm_poli)  LIKE '%hamil%' or lower(p.nm_poli)  LIKE '%kia%') "
        End If

        If level = "Dokter" Then
            where &= " and (d.kd_dok = '" & _sessionID & "' ) "
        End If

        If keyword <> "" Then
            where &= " and (d.kd_poli LIKE '%" & keyword & "%') OR " &
                            " (p.kd_poli LIKE '%" & keyword & "%') OR " &
                             " (r.kd_reg LIKE '%" & keyword & "%') OR " &
                            " (d.kd_dok LIKE '%" & keyword & "%') OR " &
                            " (d.nm_dok LIKE '%" & keyword & "%') OR " &
                             " (k.nm_kk LIKE '%" & keyword & "%') OR " &
                               " (psn.nm_psn LIKE '%" & keyword & "%') OR " &
                               " (psn.kd_psn LIKE '%" & keyword & "%') OR " &
                            " (k.kd_kk LIKE '%" & keyword & "%') "
        End If


        entity = Conn.selectData("SELECT r.kd_reg as [Kode Registrasi], r.tgl_reg as [Tanggal Registrasi],psn.kd_psn as [Kode Pasien], psn.nm_psn AS [Nama Pasien],d.kd_poli as [Kode Poli],p.nm_poli as [Nama Poli],r.kd_dok as [Kode Dokter], nm_dok AS [Nama Dokter],k.kd_kk as [Kode KK], K.nm_kk AS [Nama KK] " &
                            " FROM " & _table & " r " &
                        " LEFT JOIN rekammedis_bumil rmb ON rmb.kd_reg = r.kd_reg " &
                         " LEFT JOIN rekammedis_umum rm ON rm.kd_reg = r.kd_reg " &
                        " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                        " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                        " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                        " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " & where)


        Return entity
    End Function

    Public Function getDashboardBy(level As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        Dim where As String = "WHERE rmb.kd_rm_bumil is null and rm.kd_rm is null "

        If level = "Dokter" Then
            where &= " and (d.kd_dok = '" & _sessionID & "' ) "
        End If

        entity = Conn.selectData("SELECT r.kd_reg as [Kode Registrasi], r.tgl_reg as [Tanggal Registrasi],psn.kd_psn as [Kode Pasien], psn.nm_psn AS [Nama Pasien],d.kd_poli as [Kode Poli],p.nm_poli as [Nama Poli],r.kd_dok as [Kode Dokter], nm_dok AS [Nama Dokter],k.kd_kk as [Kode KK], K.nm_kk AS [Nama KK] " &
                            " FROM " & _table & " r " &
                        " LEFT JOIN rekammedis_bumil rmb ON rmb.kd_reg = r.kd_reg " &
                         " LEFT JOIN rekammedis_umum rm ON rm.kd_reg = r.kd_reg " &
                        " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                        " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                        " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                        " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " & where)
        Return entity
    End Function

End Class
