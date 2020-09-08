Public Class frmConfiguracaoesBD

    Private Sub frmConfiguracaoesBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim indexTipoBanco As New Integer
        indexTipoBanco = My.Settings.IndexTipoBanco
        If (indexTipoBanco = 1) Then
            cbTipoBanco.SelectedIndex = 0
        Else
            cbTipoBanco.SelectedIndex = 1
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If (cbTipoBanco.SelectedIndex = 0) Then
            My.Settings.IndexTipoBanco = 1
            MessageBox.Show("Troca de banco de dados efectuado com sucesso", "Tronca de Banco", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Settings.Save()
        Else
            My.Settings.IndexTipoBanco = 2
            MessageBox.Show("Troca de banco de dados efectuado com sucesso", "Tronca de Banco", MessageBoxButtons.OK, MessageBoxIcon.Information)
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
End Class