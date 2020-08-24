Public Class FrmProduto
    Public Sub ProcuraPorCodigo(ByVal cod As String)
        Dim DAO As New ProdutoDAO
        Dim prod As New Produto
        prod = DAO.search_cod(cod)
        txtCodigo.Text = prod.codigoProduto
        txtNome.Text = prod.nomeProduto
        txtPreco.Text = prod.precoVendaProduto
    End Sub


    Private Sub FrmProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DAO As New ProdutoDAO
        DAO.carregarDados(dgvProdutos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProcuraPorCodigo(txtCodigo.Text)
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim prod As New Produto
        prod.nomeProduto = txtNome.Text
        prod.codigoProduto = Convert.ToInt64((txtCodigo.Text).Trim)
        prod.precoVendaProduto = Convert.ToInt64((txtPreco.Text))
        Dim DAO As New ProdutoDAO
        DAO.insert(prod)
        DAO.carregarDados(dgvProdutos)
        txtNome.Text = ""
        txtCodigo.Text = ""
        txtPreco.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim prod As New Produto
        prod.nomeProduto = txtNome.Text
        prod.codigoProduto = Convert.ToInt64((txtCodigo.Text).Trim)
        prod.precoVendaProduto = Convert.ToInt64((txtPreco.Text))
        Dim DAO As New ProdutoDAO
        Dim item As String = dgvProdutos.CurrentRow.Cells(0).Value.ToString()
        If (item.Length < 1) Then
            item = InputBox("Informe o Codigo do Registo que pretende Alterar")
            DAO.update(prod, Convert.ToInt64(item))
        Else
            DAO.update(prod, Convert.ToInt64(item))
        End If
        DAO.carregarDados(dgvProdutos)
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim prod As New Produto
        Dim DAO As New ProdutoDAO
        Dim value As String = InputBox("Informe o Nuit do Registro que Pretende Remover")
        prod = DAO.search_cod(value)
        If String.IsNullOrEmpty(prod.nomeProduto) Then
            MessageBox.Show("Falha Registo com o Nuit _" + value + " _não Encontrado!")
        Else
            DAO.delete(prod)
        End If
        DAO.carregarDados(dgvProdutos) '
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnbtnControleProdutos_Click(sender As Object, e As EventArgs) Handles btnbtnControleProdutos.Click
        FrmControlProduto.ShowDialog()
    End Sub

    Private Sub dgvProdutos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutos.CellDoubleClick
        txtCodigo.Text = dgvProdutos.CurrentRow.Cells(0).Value.ToString
        txtNome.Text = dgvProdutos.CurrentRow.Cells(1).Value.ToString
        txtPreco.Text = dgvProdutos.CurrentRow.Cells(2).Value.ToString
    End Sub
End Class