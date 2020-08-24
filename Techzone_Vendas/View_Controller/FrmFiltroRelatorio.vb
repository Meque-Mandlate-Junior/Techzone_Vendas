Public Class FrmFiltroRelatorio
    Public Sub filtroMeses()
        If (cbPeriodo.SelectedIndex = 0) Then

        ElseIf (cbPeriodo.SelectedIndex = 1) Then
            dpDataInicio.Value = CDate("01/01/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/02/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 2) Then
            dpDataInicio.Value = CDate("01/02/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("28/02/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 3) Then
            dpDataInicio.Value = CDate("01/03/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/03/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 4) Then
            dpDataInicio.Value = CDate("01/04/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/04/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 5) Then
            dpDataInicio.Value = CDate("01/05/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/05/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 6) Then
            dpDataInicio.Value = CDate("01/06/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/06/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 7) Then
            dpDataInicio.Value = CDate("01/07/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/07/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 8) Then
            dpDataInicio.Value = CDate("01/08/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/08/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 9) Then
            dpDataInicio.Value = CDate("01/09/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/09/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 10) Then
            dpDataInicio.Value = CDate("01/10/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/10/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 11) Then
            dpDataInicio.Value = CDate("01/11/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/11/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 12) Then
            dpDataInicio.Value = CDate("01/12/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/12/" & dpDataInicio.Value.Year)
        End If
    End Sub
    Private Sub FrmFiltroRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPeriodo.SelectedIndex = 0
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim frm As New FrmReportView
        frm.proOperacao = "Entrada"
        frm.proDataInicio = CDate(FormatDateTime(dpDataInicio.Value, vbShortDate))
        frm.proDataTermino = CDate(FormatDateTime(dpDataTermino.Value, vbShortDate))
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub cbPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodo.SelectedIndexChanged
        filtroMeses()
    End Sub

    Private Sub dpDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dpDataInicio.ValueChanged
        If (dpDataInicio.Value.Month <> cbPeriodo.SelectedIndex) Then
            filtroMeses()
        End If
    End Sub

    Private Sub dpDataTermino_ValueChanged(sender As Object, e As EventArgs) Handles dpDataTermino.ValueChanged
        If (dpDataTermino.Value.Month <> cbPeriodo.SelectedIndex) Then
            filtroMeses()
        End If
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class