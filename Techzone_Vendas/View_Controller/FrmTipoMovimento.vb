Public Class FrmTipoMovimento

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim tpMov As New TipoMovimento
        Dim DAO As New TipoMovimentoDAO
        If String.IsNullOrEmpty(cbOperacao.Text) Then
            MessageBox.Show("Imforme a Operação")
        Else
            If String.IsNullOrEmpty(txtNome.Text) Then
                MessageBox.Show("Imforme o Nome")
            Else
                tpMov.nomeTM = txtNome.Text
                tpMov.operacaoTM = cbOperacao.Text
                DAO.insert(tpMov)
            End If
        End If
        DAO.carregarDados(dgvTipoMov)
        txtNome.Text = ""
        cbOperacao.Text = ""
    End Sub

    Private Sub dgvTipoMov_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoMov.CellContentClick
        txtNome.Text = dgvTipoMov.CurrentRow.Cells(0).Value.ToString
        cbOperacao.Text = dgvTipoMov.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim tpMov As New TipoMovimento
        Dim DAO As New TipoMovimentoDAO
        tpMov.nomeTM = txtNome.Text
        DAO.delete(tpMov)
        DAO.carregarDados(dgvTipoMov)
        txtNome.Text = ""
        cbOperacao.Text = ""
    End Sub

    Private Sub FrmTipoMovimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DAO As New TipoMovimentoDAO
        DAO.carregarDados(dgvTipoMov)
    End Sub
End Class