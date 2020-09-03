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
        Dim rpProd As New ReposityProduto
        Dim lista As New ArrayList
        dgvProdutos.Rows.Clear()
        lista = rpProd.returnDados()
        For Each produto As Produto In lista
            dgvProdutos.Rows.Add(produto.codigoProduto, produto.nomeProduto, produto.precoVendaProduto)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProcuraPorCodigo(txtCodigo.Text)
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim prod As New Produto
        prod.nomeProduto = txtNome.Text
        prod.codigoProduto = Convert.ToInt64((txtCodigo.Text).Trim)
        prod.precoVendaProduto = Convert.ToInt64((txtPreco.Text))
        Dim rpProd As New ReposityProduto
        rpProd.Insert(prod)
        Dim lista As New ArrayList
        lista = rpProd.returnDados()
        dgvProdutos.Rows.Clear()
        For Each produto As Produto In lista
            dgvProdutos.Rows.Add(produto.codigoProduto, produto.nomeProduto, produto.precoVendaProduto)
        Next
        txtNome.Text = ""
        txtCodigo.Text = ""
        txtPreco.Text = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim prod As New Produto
        prod.nomeProduto = txtNome.Text
        prod.codigoProduto = Convert.ToInt64((txtCodigo.Text).Trim)
        prod.precoVendaProduto = Convert.ToInt64((txtPreco.Text))
        Dim rpProd As New ReposityProduto
        Dim item As String = dgvProdutos.CurrentRow.Cells(0).Value.ToString()
        If (item.Length < 1) Then
            item = InputBox("Informe o Codigo do Registo que pretende Alterar")
            rpProd.update(prod, Convert.ToInt64(item))
        Else
            rpProd.update(prod, Convert.ToInt64(item))
        End If
        Dim lista As New ArrayList
        dgvProdutos.Rows.Clear()
        lista = rpProd.returnDados()
        For Each produto As Produto In lista
            dgvProdutos.Rows.Add(produto.codigoProduto, produto.nomeProduto, produto.precoVendaProduto)
        Next
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim prod As New Produto
        Dim rpProd As New ReposityProduto
        Dim value As String = InputBox("Informe o Nuit do Registro que Pretende Remover")
        prod = rpProd.search_cod(value)
        If String.IsNullOrEmpty(prod.nomeProduto) Then
            MessageBox.Show("Falha Registo com o Nuit _" + value + " _não Encontrado!")
        Else
            rpProd.delete(prod)
        End If
        Dim lista As New ArrayList
        dgvProdutos.Rows.Clear()
        lista = rpProd.returnDados()
        For Each produto As Produto In lista
            dgvProdutos.Rows.Add(produto.codigoProduto, produto.nomeProduto, produto.precoVendaProduto)
        Next
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