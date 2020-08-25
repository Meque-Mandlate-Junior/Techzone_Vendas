Imports System.Data.OleDb
Public Class FrmStock
    Public Sub actualizar()
        dgvStock.Rows.Clear()
        Dim command As OleDbCommand
        Dim sql As String
        Dim dataReader As OleDbDataReader
        Dim DAOProduto As New ProdutoDAO
        Dim listaProdutos As New ArrayList
        listaProdutos = DAOProduto.carregarDados()
        For Each prod As Produto In listaProdutos
            Dim qtdEntrada As Integer = 0
            Dim qtdSaida As Integer = 0
            Try
                ConnectionString.openConnectionAccess()
                sql = "SELECT TipoMovimento.operacao, MovimentoProduto.qtd FROM ((MovimentoProduto " & _
                    "INNER JOIN Movimento ON MovimentoProduto.movimento = Movimento.codigo) " & _
                    "INNER JOIN TipoMovimento ON Movimento.tipoMovimento = TipoMovimento.nome) " & _
                    "Where MovimentoProduto.produto =" & prod.codigoProduto & ""
                command = New OleDbCommand(sql, ConnectionString.conexaoAccess)
                dataReader = command.ExecuteReader()
                Do While dataReader.Read = True
                    If (dataReader(0) = "Entrada") Then
                        qtdEntrada = dataReader(1) + qtdEntrada
                    Else
                        qtdSaida = dataReader(1) + qtdSaida
                    End If
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            ConnectionString.conexaoAccess.Close()
            Dim total As Double = qtdEntrada - qtdSaida
            dgvStock.Rows.Add(prod.nomeProduto, Convert.ToString(total))

        Next
    End Sub


    Private Sub FrmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Private Sub btnProcessarEntrada_Click(sender As Object, e As EventArgs) Handles btnProcessarEntrada.Click
        FrmMovimentoEntrada.Show()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizar()
    End Sub
End Class