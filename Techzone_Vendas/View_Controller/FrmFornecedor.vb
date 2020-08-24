Public Class FrmFornecedor
    Public Sub ProcuraPorCodigo(ByVal cod As String)
        Dim DAO As New FornecedorDAO
        Dim forn As New Fornecedor
        forn = DAO.search_cod(cod)
        txtCodigo.Text = forn.codigoFornecedor
        txtNome.Text = forn.nomeFornecedor
        txtEndereco.Text = forn.enderecoFornecedor
    End Sub
    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim forn As New Fornecedor
        forn.nomeFornecedor = txtNome.Text
        forn.codigoFornecedor = Convert.ToInt64((txtCodigo.Text).Trim)
        forn.enderecoFornecedor = txtEndereco.Text
        Dim DAO As New FornecedorDAO
        DAO.insert(forn)
        DAO.carregarDados(dgvFornecedor)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim forn As New Fornecedor
        forn.nomeFornecedor = txtNome.Text
        forn.codigoFornecedor = Convert.ToInt64((txtCodigo.Text).Trim)
        forn.enderecoFornecedor = txtEndereco.Text
        Dim DAO As New FornecedorDAO
        Dim item As String = dgvFornecedor.CurrentRow.Cells(1).Value.ToString()
        If (item.Length < 1) Then
            item = InputBox("Informe o Codigo do Registo que pretende Alterar")
            DAO.update(forn, Convert.ToInt64(item))
        Else
            DAO.update(forn, Convert.ToInt64(item))
        End If
        DAO.carregarDados(dgvFornecedor)
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim forn As New Fornecedor
        Dim DAO As New FornecedorDAO
        Dim cod As String = InputBox("Informe o Nuit do Registro que Pretende Remover")
        forn = DAO.search_cod(cod)
        If String.IsNullOrEmpty(forn.nomeFornecedor) Then
            MessageBox.Show("Falha Registo com o Nuit _" + cod + " _não Encontrado!")
        Else
            DAO.delete(forn)
        End If
        DAO.carregarDados(dgvFornecedor)
    End Sub

    Private Sub FrmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DAO As New FornecedorDAO
        DAO.carregarDados(dgvFornecedor)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProcuraPorCodigo(txtCodigo.Text)
    End Sub

    Private Sub dgvFornecedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFornecedor.CellContentClick
        txtCodigo.Text = dgvFornecedor.CurrentRow.Cells(0).Value.ToString
        txtNome.Text = dgvFornecedor.CurrentRow.Cells(1).Value.ToString
        txtEndereco.Text = dgvFornecedor.CurrentRow.Cells(2).Value.ToString
    End Sub
End Class