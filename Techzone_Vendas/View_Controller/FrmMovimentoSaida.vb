Public Class FrmMovimentoSaida
    Private precoTotal As Double
    Private listaProdutos As New ArrayList
    Public Property Preco() As Double
        Get
            Return PrecoToTal
        End Get
        Set(value As Double)
            precoTotal = value
        End Set
    End Property
    Public Property Produtos() As ArrayList
        Get
            Return listaProdutos
        End Get
        Set(value As ArrayList)
            listaProdutos = value
        End Set
    End Property

    Private Sub FrmMovimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim DAOCl As New ClienteDAO
        Dim listaTpMov As New ArrayList
        listaTpMov = DAOTpMov.carregarDados()
        For Each item As TipoMovimento In listaTpMov
            If (item.operacaoTM.Equals("Saida")) Then
                cbTipoMovimento.Items.Add(item.nomeTM)
            End If
        Next

        DAOCl.carregarDados(dgvClientes)
        txtPreco.Text = Convert.ToString(precoTotal)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
       
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btFinalizar_Click(sender As Object, e As EventArgs) Handles btFinalizar.Click
        Dim DAOMov As New MovimentoDAO
        Dim Mov As New Movimento
        Mov.codigoMS = Convert.ToInt64(txtCodigo.Text)
        Mov.clienteMS = Convert.ToInt64(txtNuitCliente.Text)
        Dim data As DateTime = dpData.Value
        Mov.dateMS = data
        Mov.tipoMovMS = cbTipoMovimento.Text
        DAOMov.insert(Mov)
        Dim DAOMovP As New MovimentoProdutoDAO
        For Each prodAD As ProdutosAquiridos In listaProdutos
            Dim MovP As New MovimentoProduto
            MovP.movimentoP = Convert.ToInt32(txtCodigo.Text)
            MovP.produtoP = prodAD.produto.codigoProduto
            MovP.precoP = (prodAD.produto.precoVendaProduto) * prodAD.qtd
            MovP.qtdP = prodAD.qtd
            DAOMovP.insert(MovP)
        Next
        MessageBox.Show("Inserido com Sucesso")
        Dim form As New FrmPrincipal
        form.listvAD.Clear()
        form.limpar_NovoRegisto()
        form.Refresh()
        Me.Hide()

    End Sub


    Private Sub btnProcurarProduto_Click(sender As Object, e As EventArgs) Handles btnProcurarProduto.Click
        Dim DAO As New ClienteDAO
        Dim cl As New Cliente
        cl = DAO.search_nuit(txtNuitCliente.Text)
        If String.IsNullOrEmpty(cl.NomeCliente) Then
            txtNuitCliente.Text = ""
            txtNomeCliente.Text = ""
        Else
            txtNomeCliente.Text = cl.NomeCliente
        End If
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        txtNuitCliente.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
        txtNomeCliente.Text = dgvClientes.CurrentRow.Cells(0).Value.ToString

    End Sub
End Class