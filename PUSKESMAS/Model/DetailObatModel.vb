Public Class DetailObatModel

    Private _table As String = "detail_obat"
    Private _key As String = "id_detail_obat"
    Public Function save(entity As DetailObat) As Boolean
        Dim field(0 To 4) As String
        Dim value(0 To 4) As String

        field(0) = "kd_obat"
        field(1) = "no_batch"
        field(2) = "exp_date"
        field(3) = "jml_masuk"
        field(4) = "tgl_masuk"

        value(0) = entity.kd_obat
        value(1) = entity.no_batch
        value(2) = entity.exp_date
        value(3) = entity.jml_masuk
        value(4) = entity.tgl_masuk

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT d.id_detail_obat as [ID Detail],d.kd_obat as [Kode Obat], o.nm_obat AS [Nama Obat],d.tgl_masuk as [Tanggal Masuk],d.jml_masuk as [Jumlah], d.no_batch AS [No. Batch], d.exp_date AS [Expired Date] " &
                           " FROM  " & _table & " d " &
                           " LEFT JOIN obat o ON d.kd_obat = o.kd_obat")
        Else
            entity = Conn.selectData("SELECT d.id_detail_obat as [ID Detail],d.kd_obat as [Kode Obat], o.nm_obat AS [Nama Obat],d.tgl_masuk as [Tanggal Masuk],d.jml_masuk as [Jumlah], d.no_batch AS [No. Batch], d.exp_date AS [Expired Date] " &
                           " FROM  " & _table & " d " &
                           " LEFT JOIN obat o ON d.kd_obat = o.kd_obat" &
                           " WHERE (o.kd_obat LIKE '%" & keyword & "%') OR (o.nm_obat LIKE '%" & keyword & "%') " &
                           " or (d.no_batch LIKE '%" & keyword & "%') or (d.id_detail_obat LIKE '%" & keyword & "%')")
        End If
        Return entity
    End Function
    Public Function count(value As String, value2 As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, "kd_obat = '" & value & "' and no_batch = '" & value2 & "'")
    End Function
    Public Function getOBJBy(id As String) As DetailObat
        Dim entity As New DetailObat
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select d.*,o.nm_obat from " & _table & " d LEFT JOIN obat o ON d.kd_obat = o.kd_obat where " & _key & " = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.id_detail_obat = datatable.Rows(0).Item("id_detail_obat").ToString
            entity.kd_obat = datatable.Rows(0).Item("kd_obat").ToString
            entity.nm_obat = datatable.Rows(0).Item("nm_obat").ToString
            entity.no_batch = datatable.Rows(0).Item("no_batch").ToString
            entity.exp_date = datatable.Rows(0).Item("exp_date").ToString
            entity.tgl_masuk = datatable.Rows(0).Item("tgl_masuk").ToString
            entity.jml_masuk = datatable.Rows(0).Item("jml_masuk").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As DetailObat) As Boolean
        Dim field(0 To 4) As String
        Dim value(0 To 4) As String

        field(0) = "kd_obat"
        field(1) = "no_batch"
        field(2) = "exp_date"
        field(3) = "jml_masuk"
        field(4) = "tgl_masuk"

        value(0) = entity.kd_obat
        value(1) = entity.no_batch
        value(2) = entity.exp_date
        value(3) = entity.jml_masuk
        value(4) = entity.tgl_masuk

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.id_detail_obat & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow("kd_obat", "detail_resep", "kd_obat = '" & value & "'")
    End Function
   
End Class
