﻿Public Class LookupRekammedisBumil
    Private Sub LookupRekammedisBumil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillGrid("")
    End Sub
    Private Sub fillGrid(ByVal keyword As String)
        Dim model As New RekamMedisBumilModel
        DataGridView1.DataSource = model.getBy(keyword)
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        If e.KeyChar = Chr(13) Then
            fillGrid(txtcari.Text)
        End If
    End Sub

    Private Sub btnCariData_Click(sender As Object, e As EventArgs) Handles btnCariData.Click
        fillGrid(txtcari.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dispose()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If (e.RowIndex <> -1) Then
            _kdrm = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            _tglrm = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            _namapsn = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            _namadok = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            _namapoli = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            _kodereg = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            _tglreg = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Dispose()
        End If
    End Sub

End Class