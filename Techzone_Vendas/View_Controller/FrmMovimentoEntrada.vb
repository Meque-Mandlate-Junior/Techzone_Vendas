Public Class FrmMovimentoEntrada

    Private Sub FrmMovimentoEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DAOCl As New ProdutoDAO
        DAOCl.carregarDados(dgvProdutos)
        Dim DAOFon As New FornecedorDAO
        DAOFon.carregarDados(dgvFornecedor)
        Dim DAOMov As New MovimentoDAO
        Dim listaMov As New ArrayList
        listaMov = DAOMov.carregarDados()
        Dim Movtest As Movimento
        If (listaMov.Count > 0) Then
            Movtest = listaMov(listaMov.Count - 1)
            txtCodigo.Text = Convert.ToString(Movtest.codigoMS + 1)
        Else
            txtCodigo.Text = "1"
        End If
        Dim DAOTpMov As New TipoMovimentoDAO
        Dim listaTpMov As New ArrayList
        listaTpMov = DAOTpMov.carregarDados()
        For Each item As TipoMovimento In listaTpMov
            If (item.operacaoTM.Equals("Entrada")) Then
                cbTipoMovimento.Items.Add(item.nomeTM)
            End If
        Next
    End Sub

    Private Sub dgvProdutos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        txtCodigoProduto.Text = dgvProdutos.CurrentRow.Cells(0).Value.ToString
        txtNomeProduto.Text = dgvProdutos.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub btnProcurarProd_Click(sender As Object, e As EventArgs) Handles btnProcurarProd.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

  

    Private Sub txtQtd_TextChanged(sender As Object, e As EventArgs) Handles txtQtd.TextChanged
        If String.IsNullOrEmpty(txtQtd.Text) Then
            txtTotal.Text = ""
        Else
            If String.IsNullOrEmpty(txtCodigoProduto.Text) Then
                MessageBox.Show("Imforme o produto")
            Else
                Dim qtd As Integer = Convert.ToInt32(txtQtd.Text)
                Dim precoU As Double = Convert.ToDouble(txtPrecoU.Text)
                txtTotal.Text = Convert.ToString((precoU * qtd))
            End If
        End If
    End Sub

    Private Sub btnProcurarProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarProduto.Click
        Dim DAO As New FornecedorDAO
        Dim forn As New Fornecedor
        forn = DAO.search_codAccess(txtCodigoFornecedor.Text)
        If String.IsNullOrEmpty(forn.nomeFornecedor) Then
            txtNomeFornecedor.Text = ""
            txtCodigoFornecedor.Text = ""
        Else
            txtNomeFornecedor.Text = forn.nomeFornecedor
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btFinalizar_Click(sender As Object, e As EventArgs) Handles btFinalizar.Click
        Dim DAOMov As New MovimentoDAO
        Dim Mov As New Movimento
        Mov.codigoMS = Convert.ToInt64(txtCodigo.Text)
        Mov.fornecedorMS = Convert.ToInt64(txtCodigoFornecedor.Text)
        Dim data As DateTime = dpData.Value
        Mov.dateMS = data
        Mov.tipoMovMS = cbTipoMovimento.Text
        DAOMov.insert(Mov)
        Dim DAOMovP As New MovimentoProdutoDAO
        Dim MovP As New MovimentoProduto
        MovP.movimentoP = Convert.ToInt32(txtCodigo.Text)
        MovP.produtoP = Convert.ToInt32(txtCodigoProduto.Text)
        MovP.precoP = Convert.ToDouble(txtTotal.Text)
        MovP.qtdP = Convert.ToString(txtQtd.Text)
        DAOMovP.insert(MovP)
        MessageBox.Show("Inserido com Sucesso")
        Me.Hide()
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

    Private Sub dgvFornecedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFornecedor.CellDoubleClick
        txtCodigoFornecedor.Text = dgvFornecedor.CurrentRow.Cells(0).Value.ToString
        txtNomeFornecedor.Text = dgvFornecedor.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub dgvProdutos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutos.CellDoubleClick
        txtCodigoProduto.Text = dgvProdutos.CurrentRow.Cells(0).Value.ToString
        txtNomeProduto.Text = dgvProdutos.CurrentRow.Cells(1).Value.ToString
    End Sub
End Class