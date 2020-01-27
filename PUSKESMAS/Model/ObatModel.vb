Public Class ObatModel

    Private _table As String = "obat"
    Private _key As String = "kd_obat"

    Public Function save(entity As Obat) As Boolean
        Dim field(0 To 3) As String
        Dim value(0 To 3) As String

        field(0) = "kd_obat"
        field(1) = "nm_obat"
        field(2) = "satuan_obat"
        field(3) = "stok"

        value(0) = entity.kd_obat
        value(1) = entity.nm_obat
        value(2) = entity.satuan_obat
        value(3) = entity.stok

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT kd_obat as [Kode Obat], nm_obat AS [Nama Obat], satuan_obat AS [Satuan], isNull(stok,0) AS [Stok] " &
                           " FROM  " & _table)
        Else
            entity = Conn.selectData("SELECT kd_obat as [Kode Obat], nm_obat AS [Nama Obat], satuan_obat AS [Satuan], isNull(stok,0) AS [Stok] " &
                           " FROM " & _table & " " &
                           " WHERE (kd_obat LIKE '%" & keyword & "%') OR " &
                           " (nm_obat LIKE '%" & keyword & "%') or (satuan_obat LIKE '%" & keyword & "%')")
        End If
        Return entity
    End Function
    Public Function count(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, _table, _key & " = '" & value & "'")
    End Function
    Public Function getOBJBy(id As String) As Obat
        Dim entity As New Obat
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select * from " & _table & " where " & _key & " = '" & id & "'")
        If datatable.Rows.Count <> 0 Then
            entity.kd_obat = datatable.Rows(0).Item("kd_obat").ToString
            entity.nm_obat = datatable.Rows(0).Item("nm_obat").ToString
            entity.satuan_obat = datatable.Rows(0).Item("satuan_obat").ToString
            entity.stok = datatable.Rows(0).Item("stok").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As Obat) As Boolean
        Dim field(0 To 4) As String
        Dim value(0 To 4) As String

        field(0) = "kd_obat"
        field(1) = "nm_obat"
        field(2) = "satuan_obat"

        value(0) = entity.kd_obat
        value(1) = entity.nm_obat
        value(2) = entity.satuan_obat

        Dim Conn As New Conn
        Return Conn.update(field, value, _table, _key & " = '" & entity.kd_obat & "'")
    End Function

    Public Function delete(id As String) As Boolean
        Dim Conn As New Conn
        Return Conn.delete(_table, _key & " = '" & id & "'")
    End Function
    Public Function cekAvailable(value As String) As Integer
        Dim Conn As New Conn
        Return Conn.countrow(_key, "detail_obat", _key & " = '" & value & "'")
    End Function
    Public Function getLast() As Obat
        Dim entity As New Obat
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_obat = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
    Public Function getCetakObatExpired() As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        entity = Conn.selectData(" SELECT  do.*,o.nm_obat,o.satuan_obat" &
                                 " from detail_obat do " &
                                 " left join obat o on o.kd_obat = do.kd_obat " &
                                 " where do.exp_date  <= DATEADD(day,90,getdate()) ")
        Return entity
    End Function
    Public Function getCetakObatHampirAbis() As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        entity = Conn.selectData("select o.kd_obat,o.nm_obat,o.satuan_obat,SUM(ISNULL(do.jml_masuk,0)) as qty_awal,(SUM(ISNULL(do.jml_masuk,0)) - SUM(ISNULL(dr.jml_keluar,0))) as qty_akhir  " &
                                  " , floor(SUM(ISNULL(do.jml_masuk,0)) * 0.2) " &
                                  "  from obat o " &
                                    " left join (select kd_obat,sum(jml_masuk) as jml_masuk  from detail_obat group by kd_obat )do on do.kd_obat = o.kd_obat  " &
                             " left join (select detail_resep.kd_obat,sum(jml_obat) as jml_keluar  from detail_resep LEFT JOIN resep on resep.kd_resep  = detail_resep.kd_resep where resep.status = 1  group by detail_resep.kd_obat )dr on dr.kd_obat = o.kd_obat  " &
                            " group by  o.kd_obat,o.nm_obat,o.satuan_obat " &
                            " HAVING (SUM(ISNULL(do.jml_masuk,0)) - SUM(ISNULL(dr.jml_keluar,0))) < floor(SUM(ISNULL(do.jml_masuk,0)) * 0.2) ")
        Return entity
    End Function
    Public Function updateSok(kode As String, jumlah As Integer) As Boolean

        Dim Conn As New Conn
        Return Conn.nonQuery("update " & _table & " set stok = stok + (" & jumlah & ")  where " & _key & " = '" & kode & "'")
    End Function
End Class
