Public Class RekamMedisBumilModel

    Private _table As String = "rekammedis_bumil"
    Private _key As String = "kd_rm_bumil"

    Public Function save(entity As RekamMedisBumil) As Boolean
        Dim field(0 To 55) As String
        Dim value(0 To 55) As String

        field(0) = "kd_rm_bumil"
        field(1) = "tgl_rm"
        field(2) = "posyandu"
        field(3) = "nm_kader"
        field(4) = "nm_dukun"
        field(5) = "jamkesmas"
        field(6) = "gol_darah"
        field(7) = "granida"
        field(8) = "partis"
        field(9) = "aborus"
        field(10) = "hidup"
        field(11) = "tgl_periksa"
        field(12) = "tgl_hpht"
        field(13) = "taksiran_persalinan"
        field(14) = "bb_sblm_hamil"
        field(15) = "tb"
        field(16) = "buku_kia"
        field(17) = "riwayat_komplikasi_kebidanan"
        field(18) = "penyakit_kronis_alergi"
        field(19) = "tgl_persalinan"
        field(20) = "penolong"
        field(21) = "tempat"
        field(22) = "pendamping"
        field(23) = "transportasi"
        field(24) = "pendonor"
        field(25) = "kd_reg"
        field(26) = "cara_masuk"
        field(27) = "usia_kelinis"
        field(28) = "transfer_ke"
        field(29) = "anamnesia"
        field(30) = "bb"
        field(31) = "td"
        field(32) = "status_gizi"
        field(33) = "tfu"
        field(34) = "refleks_patella"
        field(35) = "djj"
        field(36) = "kepala_thd_pap"
        field(37) = "tbj"
        field(38) = "presentasi"
        field(39) = "jumlah_janin"
        field(40) = "status_imunisasi"
        field(41) = "catat_dibuku_kia"
        field(42) = "fe"
        field(43) = "hb_dilakukan"
        field(44) = "hb_hasil"
        field(45) = "anemia"
        field(46) = "pretein_urie"
        field(47) = "gula_darah"
        field(48) = "reduksi"
        field(49) = "siphilis"
        field(50) = "vct"
        field(51) = "periksa_darah"
        field(52) = "serologi"
        field(53) = "arv"
        field(54) = "injeksi_tt"
        field(55) = "therapi"

        value(0) = entity.kd_rm
        value(1) = entity.tgl_rm
        value(2) = entity.posyandu
        value(3) = entity.nm_kader
        value(4) = entity.nm_dukun
        value(5) = entity.jamkesmas
        value(6) = entity.gol_darah
        value(7) = entity.granida
        value(8) = entity.partis
        value(9) = entity.aborus
        value(10) = entity.hidup
        value(11) = entity.tgl_periksa
        value(12) = entity.tgl_hpht
        value(13) = entity.taksiran_persalinan
        value(14) = entity.bb_sblm_hamil
        value(15) = entity.tb
        value(16) = entity.buku_kia
        value(17) = entity.riwayat_komplikasi_kebidanan
        value(18) = entity.penyakit_kronis_alergi
        value(19) = entity.tgl_persalinan
        value(20) = entity.penolong
        value(21) = entity.tempat
        value(22) = entity.pendamping
        value(23) = entity.transportasi
        value(24) = entity.pendonor
        value(25) = entity.kd_reg
        value(26) = entity.cara_masuk
        value(27) = entity.usia_kelinis
        value(28) = entity.transfer_ke
        value(29) = entity.anamnesia
        value(30) = entity.bb
        value(31) = entity.td
        value(32) = entity.status_gizi
        value(33) = entity.tfu
        value(34) = entity.refleks_patella
        value(35) = entity.djj
        value(36) = entity.kepala_thd_pap
        value(37) = entity.tbj
        value(38) = entity.presentasi
        value(39) = entity.jumlah_janin
        value(40) = entity.status_imunisasi
        value(41) = entity.catat_dibuku_kia
        value(42) = entity.fe
        value(43) = entity.hb_dilakukan
        value(44) = entity.hb_hasil
        value(45) = entity.anemia
        value(46) = entity.pretein_urie
        value(47) = entity.gula_darah
        value(48) = entity.reduksi
        value(49) = entity.siphilis
        value(50) = entity.vct
        value(51) = entity.periksa_darah
        value(52) = entity.serologi
        value(53) = entity.arv
        value(54) = entity.injeksi_tt
        value(55) = entity.therapi

        Dim Conn As New Conn
        Return Conn.insert(field, value, _table)

    End Function

    Public Function getBy(keyword As String) As DataTable
        Dim entity As New DataTable
        Dim Conn As New Conn
        If keyword = "" Then
            entity = Conn.selectData("SELECT rm.kd_rm_bumil as [Kode Rekam medis], rm.tgl_rm as [Tanggal], psn.nm_psn AS [Nama Pasien], " &
                           " nm_dok AS [Nama Dokter],p.nm_poli as [Nama Poli], rm.kd_reg as [Kode Registrasi] , r.tgl_reg as [Tanggal Registrasi]  " &
                            " FROM " & _table & " rm " &
                             " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                            " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                            " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                            " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                            " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk ")
        Else
            entity = Conn.selectData("SELECT rm.kd_rm_bumil as [Kode Rekam medis], rm.tgl_rm as [Tanggal], psn.nm_psn AS [Nama Pasien], nm_dok AS [Nama Dokter], " &
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
                              " (rm.kd_rm_bumil LIKE '%" & keyword & "%') OR " &
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
    Public Function getOBJBy(id As String) As RekamMedisBumil

        Dim entity As New RekamMedisBumil
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData(" select rm.*,r.tgl_reg,p.nm_poli,d.nm_dok,psn.nm_psn,detail = STUFF(( " &
                                     "  SELECT ',' +  t.kd_tindakan+ '|'+ t.nm_tindakan+ '|'+ cast(t.tarif as varchar(10)) " &
                                     "  FROM dbo.detail_tindakan dt " &
                                      " LEFT JOIN tindakan t ON dt.kd_tindakan = t.kd_tindakan " &
                                    " WHERE rm.kd_rm_bumil = dt.kd_rm " &
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
            entity.kd_rm = datatable.Rows(0).Item("kd_rm_bumil").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm").ToString
            entity.tgl_reg = datatable.Rows(0).Item("tgl_reg").ToString
            entity.detail = datatable.Rows(0).Item("detail").ToString
            entity.posyandu = datatable.Rows(0).Item("posyandu").ToString
            entity.nm_kader = datatable.Rows(0).Item("nm_kader").ToString
            entity.nm_dukun = datatable.Rows(0).Item("nm_dukun").ToString
            entity.jamkesmas = datatable.Rows(0).Item("jamkesmas").ToString
            entity.gol_darah = datatable.Rows(0).Item("gol_darah").ToString
            entity.granida = datatable.Rows(0).Item("granida").ToString
            entity.partis = datatable.Rows(0).Item("partis").ToString
            entity.aborus = datatable.Rows(0).Item("aborus").ToString
            entity.hidup = datatable.Rows(0).Item("hidup").ToString
            entity.tgl_periksa = datatable.Rows(0).Item("tgl_periksa").ToString
            entity.tgl_hpht = datatable.Rows(0).Item("tgl_hpht").ToString
            entity.taksiran_persalinan = datatable.Rows(0).Item("taksiran_persalinan").ToString
            entity.bb_sblm_hamil = datatable.Rows(0).Item("bb_sblm_hamil").ToString
            entity.tb = datatable.Rows(0).Item("tb").ToString
            entity.buku_kia = datatable.Rows(0).Item("buku_kia").ToString
            entity.riwayat_komplikasi_kebidanan = datatable.Rows(0).Item("riwayat_komplikasi_kebidanan").ToString
            entity.penyakit_kronis_alergi = datatable.Rows(0).Item("penyakit_kronis_alergi").ToString
            entity.tgl_persalinan = datatable.Rows(0).Item("tgl_persalinan").ToString
            entity.penolong = datatable.Rows(0).Item("penolong").ToString
            entity.tempat = datatable.Rows(0).Item("tempat").ToString
            entity.pendamping = datatable.Rows(0).Item("pendamping").ToString
            entity.transportasi = datatable.Rows(0).Item("transportasi").ToString
            entity.pendonor = datatable.Rows(0).Item("pendonor").ToString
            entity.cara_masuk = datatable.Rows(0).Item("cara_masuk").ToString
            entity.usia_kelinis = datatable.Rows(0).Item("usia_kelinis").ToString
            entity.transfer_ke = datatable.Rows(0).Item("transfer_ke").ToString
            entity.anamnesia = datatable.Rows(0).Item("anamnesia").ToString
            entity.bb = datatable.Rows(0).Item("bb").ToString
            entity.td = datatable.Rows(0).Item("td").ToString
            entity.status_gizi = datatable.Rows(0).Item("status_gizi").ToString
            entity.tfu = datatable.Rows(0).Item("tfu").ToString
            entity.refleks_patella = datatable.Rows(0).Item("refleks_patella").ToString
            entity.djj = datatable.Rows(0).Item("djj").ToString
            entity.kepala_thd_pap = datatable.Rows(0).Item("kepala_thd_pap").ToString
            entity.tbj = datatable.Rows(0).Item("tbj").ToString
            entity.presentasi = datatable.Rows(0).Item("presentasi").ToString
            entity.jumlah_janin = datatable.Rows(0).Item("jumlah_janin").ToString
            entity.status_imunisasi = datatable.Rows(0).Item("status_imunisasi").ToString
            entity.catat_dibuku_kia = datatable.Rows(0).Item("catat_dibuku_kia").ToString
            entity.fe = datatable.Rows(0).Item("fe").ToString
            entity.hb_dilakukan = datatable.Rows(0).Item("hb_dilakukan").ToString
            entity.hb_hasil = datatable.Rows(0).Item("hb_hasil").ToString
            entity.anemia = datatable.Rows(0).Item("anemia").ToString
            entity.pretein_urie = datatable.Rows(0).Item("pretein_urie").ToString
            entity.gula_darah = datatable.Rows(0).Item("gula_darah").ToString
            entity.reduksi = datatable.Rows(0).Item("reduksi").ToString
            entity.gol_darah = datatable.Rows(0).Item("gol_darah").ToString
            entity.siphilis = datatable.Rows(0).Item("siphilis").ToString
            entity.vct = datatable.Rows(0).Item("vct").ToString
            entity.periksa_darah = datatable.Rows(0).Item("periksa_darah").ToString
            entity.serologi = datatable.Rows(0).Item("serologi").ToString
            entity.arv = datatable.Rows(0).Item("arv").ToString
            entity.injeksi_tt = datatable.Rows(0).Item("injeksi_tt").ToString
            entity.therapi = datatable.Rows(0).Item("therapi").ToString
        End If
        Return entity
    End Function
    Public Function getOBJByReg(id As String) As RekamMedisBumil
        Dim entity As New RekamMedisBumil
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData(" select rm.*,r.tgl_reg,p.nm_poli,d.nm_dok,psn.nm_psn,detail = STUFF(( " &
                                     "  SELECT ',' +  t.kd_tindakan+'|' + t.nm_tindakan + '|' + cast(t.tarif as varchar(10)) " &
                                     "  FROM dbo.detail_tindakan dt " &
                                      " LEFT JOIN tindakan t ON dt.kd_tindakan = t.kd_tindakan " &
                                    " WHERE rm.kd_rm_bumil = dt.kd_rm " &
                                    " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 1, '') " &
                                    " from " & _table & " rm " &
                                     " LEFT JOIN registrasi r ON rm.kd_reg = r.kd_reg " &
                                    " LEFT JOIN dokter d ON r.kd_dok = d.kd_dok " &
                                    " LEFT JOIN poli p ON d.kd_poli = p.kd_poli " &
                                    " LEFT JOIN pasien psn ON r.kd_psn = psn.kd_psn " &
                                    " LEFT JOIN kk k ON psn.kd_kk = k.kd_kk " &
                                    " where rm.kd_reg = '" & id & "'  ")
        If datatable.Rows.Count <> 0 Then
            entity.nm_poli = datatable.Rows(0).Item("nm_poli").ToString
            entity.nm_dok = datatable.Rows(0).Item("nm_dok").ToString
            entity.nm_psn = datatable.Rows(0).Item("nm_psn").ToString
            entity.kd_reg = datatable.Rows(0).Item("kd_reg").ToString
            entity.kd_rm = datatable.Rows(0).Item("kd_rm").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm").ToString
            entity.tgl_reg = datatable.Rows(0).Item("tgl_reg").ToString
            entity.detail = datatable.Rows(0).Item("detail").ToString
            entity.tgl_rm = datatable.Rows(0).Item("tgl_rm").ToString
            entity.posyandu = datatable.Rows(0).Item("posyandu").ToString
            entity.nm_kader = datatable.Rows(0).Item("nm_kader").ToString
            entity.nm_dukun = datatable.Rows(0).Item("nm_dukun").ToString
            entity.jamkesmas = datatable.Rows(0).Item("jamkesmas").ToString
            entity.gol_darah = datatable.Rows(0).Item("gol_darah").ToString
            entity.granida = datatable.Rows(0).Item("granida").ToString
            entity.partis = datatable.Rows(0).Item("partis").ToString
            entity.aborus = datatable.Rows(0).Item("aborus").ToString
            entity.hidup = datatable.Rows(0).Item("hidup").ToString
            entity.tgl_periksa = datatable.Rows(0).Item("tgl_periksa").ToString
            entity.tgl_hpht = datatable.Rows(0).Item("tgl_hpht").ToString
            entity.taksiran_persalinan = datatable.Rows(0).Item("taksiran_persalinan").ToString
            entity.bb_sblm_hamil = datatable.Rows(0).Item("bb_sblm_hamil").ToString
            entity.tb = datatable.Rows(0).Item("tb").ToString
            entity.buku_kia = datatable.Rows(0).Item("buku_kia").ToString
            entity.riwayat_komplikasi_kebidanan = datatable.Rows(0).Item("riwayat_komplikasi_kebidanan").ToString
            entity.penyakit_kronis_alergi = datatable.Rows(0).Item("penyakit_kronis_alergi").ToString
            entity.tgl_persalinan = datatable.Rows(0).Item("tgl_persalinan").ToString
            entity.tempat = datatable.Rows(0).Item("tempat").ToString
            entity.pendamping = datatable.Rows(0).Item("pendamping").ToString
            entity.penolong = datatable.Rows(0).Item("penolong").ToString
            entity.transportasi = datatable.Rows(0).Item("transportasi").ToString
            entity.pendonor = datatable.Rows(0).Item("pendonor").ToString
            entity.cara_masuk = datatable.Rows(0).Item("cara_masuk").ToString
            entity.usia_kelinis = datatable.Rows(0).Item("usia_kelinis").ToString
            entity.transfer_ke = datatable.Rows(0).Item("transfer_ke").ToString
            entity.anamnesia = datatable.Rows(0).Item("anamnesia").ToString
            entity.bb = datatable.Rows(0).Item("bb").ToString
            entity.td = datatable.Rows(0).Item("td").ToString
            entity.status_gizi = datatable.Rows(0).Item("status_gizi").ToString
            entity.tfu = datatable.Rows(0).Item("tfu").ToString
            entity.refleks_patella = datatable.Rows(0).Item("refleks_patella").ToString
            entity.djj = datatable.Rows(0).Item("djj").ToString
            entity.kepala_thd_pap = datatable.Rows(0).Item("kepala_thd_pap").ToString
            entity.tbj = datatable.Rows(0).Item("tbj").ToString
            entity.presentasi = datatable.Rows(0).Item("presentasi").ToString
            entity.jumlah_janin = datatable.Rows(0).Item("jumlah_janin").ToString
            entity.status_imunisasi = datatable.Rows(0).Item("status_imunisasi").ToString
            entity.catat_dibuku_kia = datatable.Rows(0).Item("catat_dibuku_kia").ToString
            entity.fe = datatable.Rows(0).Item("fe").ToString
            entity.hb_dilakukan = datatable.Rows(0).Item("hb_dilakukan").ToString
            entity.hb_hasil = datatable.Rows(0).Item("hb_hasil").ToString
            entity.anemia = datatable.Rows(0).Item("anemia").ToString
            entity.pretein_urie = datatable.Rows(0).Item("pretein_urie").ToString
            entity.gula_darah = datatable.Rows(0).Item("gula_darah").ToString
            entity.reduksi = datatable.Rows(0).Item("reduksi").ToString
            entity.gol_darah = datatable.Rows(0).Item("gol_darah").ToString
            entity.siphilis = datatable.Rows(0).Item("siphilis").ToString
            entity.vct = datatable.Rows(0).Item("vct").ToString
            entity.periksa_darah = datatable.Rows(0).Item("periksa_darah").ToString
            entity.serologi = datatable.Rows(0).Item("serologi").ToString
            entity.arv = datatable.Rows(0).Item("arv").ToString
            entity.injeksi_tt = datatable.Rows(0).Item("injeksi_tt").ToString
            entity.therapi = datatable.Rows(0).Item("therapi").ToString
        End If
        Return entity
    End Function
    Public Function update(entity As RekamMedisBumil) As Boolean

        Dim field(0 To 55) As String
        Dim value(0 To 55) As String

        field(0) = "kd_rm_bumil"
        field(1) = "tgl_rm"
        field(2) = "posyandu"
        field(3) = "nm_kader"
        field(4) = "nm_dukun"
        field(5) = "jamkesmas"
        field(6) = "gol_darah"
        field(7) = "granida"
        field(8) = "partis"
        field(9) = "aborus"
        field(10) = "hidup"
        field(11) = "tgl_periksa"
        field(12) = "tgl_hpht"
        field(13) = "taksiran_persalinan"
        field(14) = "bb_sblm_hamil"
        field(15) = "tb"
        field(16) = "buku_kia"
        field(17) = "riwayat_komplikasi_kebidanan"
        field(18) = "penyakit_kronis_alergi"
        field(19) = "tgl_persalinan"
        field(20) = "penolong"
        field(21) = "tempat"
        field(22) = "pendamping"
        field(23) = "transportasi"
        field(24) = "pendonor"
        field(25) = "kd_reg"
        field(26) = "cara_masuk"
        field(27) = "usia_kelinis"
        field(28) = "transfer_ke"
        field(29) = "anamnesia"
        field(30) = "bb"
        field(31) = "td"
        field(32) = "status_gizi"
        field(33) = "tfu"
        field(34) = "refleks_patella"
        field(35) = "djj"
        field(36) = "kepala_thd_pap"
        field(37) = "tbj"
        field(38) = "presentasi"
        field(39) = "jumlah_janin"
        field(40) = "status_imunisasi"
        field(41) = "catat_dibuku_kia"
        field(42) = "fe"
        field(43) = "hb_dilakukan"
        field(44) = "hb_hasil"
        field(45) = "anemia"
        field(46) = "pretein_urie"
        field(47) = "gula_darah"
        field(48) = "reduksi"
        field(49) = "siphilis"
        field(50) = "vct"
        field(51) = "periksa_darah"
        field(52) = "serologi"
        field(53) = "arv"
        field(54) = "injeksi_tt"
        field(55) = "therapi"

        value(0) = entity.kd_rm
        value(1) = entity.tgl_rm
        value(2) = entity.posyandu
        value(3) = entity.nm_kader
        value(4) = entity.nm_dukun
        value(5) = entity.jamkesmas
        value(6) = entity.gol_darah
        value(7) = entity.granida
        value(8) = entity.partis
        value(9) = entity.aborus
        value(10) = entity.hidup
        value(11) = entity.tgl_periksa
        value(12) = entity.tgl_hpht
        value(13) = entity.taksiran_persalinan
        value(14) = entity.bb_sblm_hamil
        value(15) = entity.tb
        value(16) = entity.buku_kia
        value(17) = entity.riwayat_komplikasi_kebidanan
        value(18) = entity.penyakit_kronis_alergi
        value(19) = entity.tgl_persalinan
        value(20) = entity.penolong
        value(21) = entity.tempat
        value(22) = entity.pendamping
        value(23) = entity.transportasi
        value(24) = entity.pendonor
        value(25) = entity.kd_reg
        value(26) = entity.cara_masuk
        value(27) = entity.usia_kelinis
        value(28) = entity.transfer_ke
        value(29) = entity.anamnesia
        value(30) = entity.bb
        value(31) = entity.td
        value(32) = entity.status_gizi
        value(33) = entity.tfu
        value(34) = entity.refleks_patella
        value(35) = entity.djj
        value(36) = entity.kepala_thd_pap
        value(37) = entity.tbj
        value(38) = entity.presentasi
        value(39) = entity.jumlah_janin
        value(40) = entity.status_imunisasi
        value(41) = entity.catat_dibuku_kia
        value(42) = entity.fe
        value(43) = entity.hb_dilakukan
        value(44) = entity.hb_hasil
        value(45) = entity.anemia
        value(46) = entity.pretein_urie
        value(47) = entity.gula_darah
        value(48) = entity.reduksi
        value(49) = entity.siphilis
        value(50) = entity.vct
        value(51) = entity.periksa_darah
        value(52) = entity.serologi
        value(53) = entity.arv
        value(54) = entity.injeksi_tt
        value(55) = entity.therapi


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
                                               "  left join rekammedis_bumil rm on r.kd_reg = r.kd_reg where kd_rm_bumil  = '" & value & "' ")
        Return dt.Rows.Count
    End Function

    Public Function saveDetail(entity As RekamMedisBumil) As Boolean
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
        Return Conn.delete("detail_tindakan", "kd_rm = '" & id & "'")
    End Function
    Public Function getLast() As RekamMedisBumil
        Dim entity As New RekamMedisBumil
        Dim Conn As New Conn
        Dim datatable As New DataTable
        datatable = Conn.selectData("select  max(" & _key & ") as " & _key & " from " & _table)
        If datatable.Rows.Count <> 0 Then
            entity.kd_rm = datatable.Rows(0).Item(_key).ToString
        End If
        Return entity
    End Function
End Class
