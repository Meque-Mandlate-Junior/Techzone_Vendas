Imports System.Data.OleDb
Public Class FrmControlProduto

    Public Sub filtroMeses()
        If (cbPeriodo.SelectedIndex = 0) Then

        ElseIf (cbPeriodo.SelectedIndex = 1) Then
            dpDataInicio.Value = "01/01/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "31/02/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 2) Then
            dpDataInicio.Value = "01/02/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "28/02/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 3) Then
            dpDataInicio.Value = "01/03/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "31/03/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 4) Then
            dpDataInicio.Value = "01/04/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "30/04/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 5) Then
            dpDataInicio.Value = "01/05/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "31/05/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 6) Then
            dpDataInicio.Value = "01/06/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "30/06/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 7) Then
            dpDataInicio.Value = "01/07/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "31/07/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 8) Then
            dpDataInicio.Value = "01/08/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "31/08/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 9) Then
            dpDataInicio.Value = "01/09/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "30/09/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 10) Then
            dpDataInicio.Value = "01/10/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "31/10/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 11) Then
            dpDataInicio.Value = "01/11/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "30/11/" & dpDataInicio.Value.Year
        ElseIf (cbPeriodo.SelectedIndex = 12) Then
            dpDataInicio.Value = "01/12/" & dpDataInicio.Value.Year
            dpDataTermino.Value = "31/12/" & dpDataInicio.Value.Year
        End If
    End Sub
    Public Sub preencherDGVProdutos_lc(ByVal lista As ArrayList)
        Dim command As OleDbCommand
        Dim sql As String
        Dim dataReader As OleDbDataReader
        For Each prod As Produto In lista
            Dim valorEntradas As Double = 0
            Dim valorSaidas As Double = 0
            Dim lucroProduto As Double = 0
            Dim precoUnitarioEntrada As Double = 0
            Dim precoUnitarioSaidas As Double = 0
            Try
                ConnectionString.Connection()
                sql = "Select tipoMovimento.operacao , MovimentoProduto.qtd,MovimentoProduto.preco From ((MovimentoProduto " & _
                   "inner join movimento  on movimento.codigo = movimentoProduto.movimento ) " & _
                    "inner join tipoMovimento on tipoMovimento.nome =movimento.tipoMovimento) " & _
                    "Where (MovimentoProduto.produto =" & prod.codigoProduto & ") AND (Movimento.data BETWEEN #" & dpDataInicio.Value.Month & "/" & dpDataInicio.Value.Day & "/" & _
                    "" & dpDataInicio.Value.Year & "# AND #" & dpDataTermino.Value.Month & "/" & dpDataTermino.Value.Day & "/" & dpDataTermino.Value.Year & "# )"
                command = New OleDbCommand(sql, conexao)
                dataReader = command.ExecuteReader()
                Do While dataReader.Read = True
                    If (dataReader(0) = "Entrada") Then
                        valorEntradas = Convert.ToDouble(dataReader(1) + valorEntradas)
                        precoUnitarioEntrada = dataReader(2) / dataReader(1)
                    Else
                        valorSaidas = Convert.ToDouble(dataReader(1) + valorSaidas)
                        precoUnitarioSaidas = dataReader(2) / dataReader(1)
                        lucroProduto = lucroProduto + ((precoUnitarioSaidas * dataReader(1)) - (precoUnitarioEntrada * dataReader(1)))
                    End If

                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            ConnectionString.conexao.Close()
            dgvProdutos_lc.Rows.Add(prod.codigoProduto, prod.nomeProduto, lucroProduto)
        Next
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCodProduto.TextChanged

    End Sub



    Private Sub txtProcuraProd_TextChanged(sender As Object, e As EventArgs) Handles txtProcuraProd.TextChanged
        Dim DAO As New ProdutoDAO
        Dim listaProdutos As New ArrayList
        Dim sql As String
        dgvProdutos_lc.Rows.Clear()
        If String.IsNullOrEmpty(txtProcuraProd.Text) Then
            sql = "Select * From produto"
        Else
            If (rbCodigo.Checked) Then
                sql = "Select * From produto Where codigo Like '%" & txtProcuraProd.Text & "%'"
            Else
                sql = "Select * From produto Where nome Like '%" & txtProcuraProd.Text & "%'"
            End If
        End If
        listaProdutos = DAO.search_Like(sql)
        preencherDGVProdutos_lc(listaProdutos)
    End Sub

    Private Sub dgvProdutos_lc_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutos_lc.CellDoubleClick
        Dim codigoProduto, nomeProduto, lucroProduto As String
        codigoProduto = dgvProdutos_lc.CurrentRow.Cells(0).Value.ToString
        nomeProduto = dgvProdutos_lc.CurrentRow.Cells(1).Value.ToString
        lucroProduto = dgvProdutos_lc.CurrentRow.Cells(2).Value.ToString
        Dim command As OleDbCommand
        Dim sql As String
        Dim dataReader As OleDbDataReader
        Dim qtdEntrada As Integer = 0
        Dim qtdSaidas As Integer = 0
        Dim valorEntradas As Double = 0
        Dim valorSaidas As Double = 0
        Dim precoUnitarioEntrada As Double = 0
        Dim precoUnitarioSaidas As Double = 0
        dgvLucroProduto.Rows.Clear()
        Try

            ConnectionString.Connection()
            sql = "Select tipoMovimento.operacao,movimento.data,MovimentoProduto.qtd,MovimentoProduto.Preco From ((MovimentoProduto " & _
               "inner join movimento on movimento.codigo = movimentoProduto.movimento ) " & _
                "inner join tipoMovimento on tipoMovimento.nome = movimento.tipoMovimento) " & _
                 "Where (MovimentoProduto.produto =" & codigoProduto & ") AND (Movimento.data BETWEEN #" & dpDataInicio.Value.Month & "/" & dpDataInicio.Value.Day & "/" & _
                    "" & dpDataInicio.Value.Year & "# AND #" & dpDataTermino.Value.Month & "/" & dpDataTermino.Value.Day & "/" & dpDataTermino.Value.Year & "# )"
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                If (dataReader(0) = "Saida") Then
                    precoUnitarioSaidas = dataReader(3) / dataReader(2)
                    dgvLucroProduto.Rows.Add(dataReader(0), dataReader(1), precoUnitarioSaidas, dataReader(2), dataReader(3), (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2))))
                    qtdSaidas = qtdSaidas + dataReader(2)
                    valorSaidas = Convert.ToDouble(dataReader(3) + valorSaidas)
                Else
                    precoUnitarioEntrada = dataReader(3) / dataReader(2)
                    dgvLucroProduto.Rows.Add(dataReader(0), dataReader(1), precoUnitarioEntrada, dataReader(2), dataReader(3), 0)
                    qtdEntrada = qtdEntrada + dataReader(2)
                    valorEntradas = Convert.ToDouble(dataReader(3) + valorEntradas)

                End If
            Loop
            txtCodProduto.Text = codigoProduto
            txtNomeProduto.Text = nomeProduto
            txtLucro.Text = lucroProduto
            txtQtdEntradas.Text = qtdEntrada
            txtQtdSaidas.Text = qtdSaidas
            txtStock.Text = qtdEntrada - qtdSaidas
            txtValorEntradas.Text = valorEntradas
            txtValorSaidas.Text = valorSaidas
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ConnectionString.conexao.Close()
    End Sub

    Private Sub FrmControlProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPeriodo.SelectedIndex = 0
        dpDataInicio.Value = "01/01/" & dpDataInicio.Value.Year() & ""
        dpDataTermino.Value = "01/12/" & dpDataInicio.Value.Year() & ""
        Dim DAO As New ProdutoDAO
        Dim lista As New ArrayList
        lista = DAO.carregarDados()
        dgvProdutos_lc.Rows.Clear()
        preencherDGVProdutos_lc(lista)
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


    Private Sub btnProcurarProd_Click(sender As Object, e As EventArgs) Handles btnProcurarProd.Click
        Dim DAO As New ProdutoDAO
        Dim listaProdutos As New ArrayList
        Dim sql As String
        dgvProdutos_lc.Rows.Clear()
        If String.IsNullOrEmpty(txtProcuraProd.Text) Then
            sql = "Select * From produto"
        Else
            If (rbCodigo.Checked) Then
                sql = "Select * From produto Where codigo Like '%" & txtProcuraProd.Text & "%'"
            Else
                sql = "Select * From produto Where nome Like '%" & txtProcuraProd.Text & "%'"
            End If
        End If
        listaProdutos = DAO.search_Like(sql)
        preencherDGVProdutos_lc(listaProdutos)
    End Sub

    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        Dim DAO As New ProdutoDAO
        Dim listaProdutos As New ArrayList
        Dim sql As String
        dgvLucroProduto.Rows.Clear()
        txtCodProduto.Text = ""
        txtNomeProduto.Text = ""
        txtLucro.Text = ""
        txtQtdEntradas.Text = ""
        txtQtdSaidas.Text = ""
        txtStock.Text = ""
        txtValorEntradas.Text = ""
        txtValorSaidas.Text = ""
        dgvProdutos_lc.Rows.Clear()
        sql = "Select * From produto"
        listaProdutos = DAO.search_Like(sql)
        preencherDGVProdutos_lc(listaProdutos)
    End Sub

    Private Sub btnGrafico_Click(sender As Object, e As EventArgs) Handles btnGrafico.Click
        If (String.IsNullOrEmpty(txtCodProduto.Text)) Then
            MessageBox.Show("Selecione um Produto para que possa ser gerado o grafico", "Grafico", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim frm As New FrmGraficoProduto
            frm.prtyCodigoProduto = txtCodProduto.Text
            frm.prtyDataInicio = dpDataInicio.Value
            frm.prtyDataTermino = dpDataTermino.Value
            frm.ShowDialog()
        End If
    End Sub
End Class