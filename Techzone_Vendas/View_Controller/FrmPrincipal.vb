Public Class FrmPrincipal
    Public Sub limpar_NovoRegisto()
        txtProcuraProd.Text = ""
        txtCodigoProduto.Text = ""
        txtNomeProduto.Text = ""
        txtQtd.Text = ""
        txtSubTotal.Text = ""
        txtTotal.Text = ""
        listvAD.Clear()
    End Sub
    Private Sub btnTipoMovimento_Click(sender As Object, e As EventArgs) Handles btnTipoMovimento.Click
        FrmTipoMovimento.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        FrmCliente.ShowDialog()
    End Sub


    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DAO As New ProdutoDAO
        DAO.carregarDados(dgvProdutos)
    End Sub

    Private Sub btnProcurarProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarProduto.Click
        Dim DAO As New ProdutoDAO
        Dim prod As New Produto
        prod = DAO.search_cod(txtCodigoProduto.Text)
        If String.IsNullOrEmpty(prod.nomeProduto) Then
            txtNomeProduto.Text = ""
            txtCodigoProduto.Text = ""
        Else
            txtNomeProduto.Text = prod.nomeProduto
        End If
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnProcurarProd.Click
        Dim DAO As New ProdutoDAO
        Dim data As ArrayList
        Dim sql As String
        If String.IsNullOrEmpty(txtProcuraProd.Text) Then
            DAO.carregarDados(dgvProdutos)
        Else
            If (rbProduto.Checked) Then
                sql = "SELECT * FROM produto Where nome Like '%" & txtProcuraProd.Text & "%'"
                data = DAO.search_Like(sql)
                dgvProdutos.Rows.Clear()
                For Each prod As Produto In data
                    dgvProdutos.Rows.Add(prod.codigoProduto, prod.nomeProduto, prod.precoVendaProduto)
                Next
            Else
                sql = "SELECT * FROM produto Where codigo Like '%" & txtProcuraProd.Text & "%'"
                data = DAO.search_Like(sql)
                dgvProdutos.Rows.Clear()
                For Each prod As Produto In data
                    dgvProdutos.Rows.Add(prod.codigoProduto, prod.nomeProduto, prod.precoVendaProduto)
                Next
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim DAO As New ProdutoDAO
        Dim prod As New Produto
        If String.IsNullOrEmpty(txtQtd.Text) Then
        Else
            If String.IsNullOrEmpty(txtCodigoProduto.Text) Then
                MessageBox.Show("Imforme o produto")
            Else
                prod = DAO.search_cod(txtCodigoProduto.Text)
                Dim listvItems As New ListViewItem
                listvItems.Text = txtCodigoProduto.Text + ""
                listvItems.SubItems.Add(txtNomeProduto.Text + "")
                listvItems.SubItems.Add(txtQtd.Text + "")
                listvItems.SubItems.Add(txtSubTotal.Text + "")
                listvAD.Items.Add(listvItems)
                If String.IsNullOrEmpty(txtTotal.Text) Then
                    txtTotal.Text = txtSubTotal.Text
                Else
                    txtTotal.Text = Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtSubTotal.Text)
                End If
                txtCodigoProduto.Text = ""
                txtNomeProduto.Text = ""
                txtQtd.Text = ""
                txtSubTotal.Text = ""
            End If
        End If
    End Sub

    Private Sub txtQtd_TextChanged(sender As Object, e As EventArgs) Handles txtQtd.TextChanged
        Dim DAO As New ProdutoDAO
        Dim prod As New Produto
        If String.IsNullOrEmpty(txtQtd.Text) Then
        Else
            If String.IsNullOrEmpty(txtCodigoProduto.Text) Then
                MessageBox.Show("Imforme o produto")
            Else
                prod = DAO.search_cod(txtCodigoProduto.Text)
                Dim qtd As Integer = Convert.ToInt32(txtQtd.Text)
                Dim subTotal, precoProd As Double
                precoProd = prod.precoVendaProduto()
                subTotal = precoProd * qtd
                txtSubTotal.Text = subTotal
            End If
        End If
    End Sub

    Private Sub btnRemoverTudo_Click(sender As Object, e As EventArgs) Handles btnRemoverTudo.Click
        If ((MessageBox.Show("Realmente deseja Limpar os registro", "Limpar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) = DialogResult.OK) Then
            txtTotal.Text = ""
            listvAD.Items.Clear()
        End If
    End Sub

    Private Sub btnProdutos_Click(sender As Object, e As EventArgs) Handles btnProdutos.Click
        FrmProduto.ShowDialog()
    End Sub

    Private Sub btnFornecedor_Click(sender As Object, e As EventArgs) Handles btnFornecedor.Click
        FrmFornecedor.ShowDialog()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        FrmStock.ShowDialog()
    End Sub


    Private Sub btnProcessarSaida_Click(sender As Object, e As EventArgs) Handles btnProcessarSaida.Click
        Dim FrMovSaida As New FrmMovimentoSaida
        If String.IsNullOrEmpty(txtTotal.Text) Then
            MessageBox.Show("Selecione os produtos que deseja movimentar")
        Else
            FrMovSaida.Preco = Convert.ToDouble(txtTotal.Text)
            Dim listaProdutos As New ArrayList
            For i As Integer = 0 To listvAD.Items.Count - 1
                Dim item = listvAD.Items(i)
                Dim prod As New ProdutosAquiridos
                Dim DAO As New ProdutoDAO
                Dim produto As New Produto
                produto = DAO.search_cod(item.Text)
                prod.produto = produto
                prod.qtd = item.SubItems(2).Text
                listaProdutos.Add(prod)
            Next
            FrMovSaida.Produtos = listaProdutos
            FrMovSaida.ShowDialog()
        End If
    End Sub

    Private Sub txtProcuraProd_TextChanged(sender As Object, e As EventArgs) Handles txtProcuraProd.TextChanged
        Dim DAO As New ProdutoDAO
        Dim data As ArrayList
        Dim sql As String
        If String.IsNullOrEmpty(txtProcuraProd.Text) Then
            DAO.carregarDados(dgvProdutos)
        Else
            If (rbProduto.Checked) Then
                sql = "SELECT * FROM produto Where nome Like '%" & txtProcuraProd.Text & "%'"
                data = DAO.search_Like(sql)
                dgvProdutos.Rows.Clear()
                For Each prod As Produto In data
                    dgvProdutos.Rows.Add(prod.codigoProduto, prod.nomeProduto, prod.precoVendaProduto)
                Next
            Else
                sql = "SELECT * FROM produto Where codigo Like '%" & txtProcuraProd.Text & "%'"
                data = DAO.search_Like(sql)
                dgvProdutos.Rows.Clear()
                For Each prod As Produto In data
                    dgvProdutos.Rows.Add(prod.codigoProduto, prod.nomeProduto, prod.precoVendaProduto)
                Next
            End If
        End If
    End Sub

    Private Sub btnRegistoMov_Click(sender As Object, e As EventArgs) Handles btnRegistoMov.Click
        FrmRegistosMov.ShowDialog()
    End Sub

    Private Sub btnRelaMovimentos_Click(sender As Object, e As EventArgs) Handles btnRelaMovimentos.Click
        FrmFiltroRelatorio.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNomeProduto_TextChanged(sender As Object, e As EventArgs) Handles txtNomeProduto.TextChanged

    End Sub

    Private Sub dgvProdutos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutos.CellDoubleClick
        txtCodigoProduto.Text = dgvProdutos.CurrentRow.Cells(0).Value.ToString
        txtNomeProduto.Text = dgvProdutos.CurrentRow.Cells(1).Value.ToString
    End Sub
End Class