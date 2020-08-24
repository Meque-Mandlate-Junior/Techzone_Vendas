Imports System.Data.OleDb
Public Class ProdutoDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        ConnectionString.Connection()
        sql = "SELECT * FROM produto"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim prod As New Produto
                prod.codigoProduto = dataReader(0)
                prod.nomeProduto = dataReader(1)
                prod.precoVendaProduto = dataReader(2)
                lista.Add(prod)
            Loop
            If (dataReader.Read = False) Then
                ConnectionString.conexao.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ConnectionString.conexao.Close()
        End Try
        Return lista

    End Function

    Public Overloads Sub carregarDados(dgvProduto As DataGridView)
        Connection()
        sql = "SELECT * FROM produto"
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            dgvProduto.Rows.Clear()
            Do While dataReader.Read = True
                dgvProduto.Rows.Add(dataReader(0), dataReader(1), dataReader(2))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub


    Public Sub insert(ByVal prod As Produto)
        Try
            sql = "INSERT INTO produto(codigo,nome,precoVenda) VALUES(?,?,?)"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
            command.Parameters.AddWithValue("nome", prod.nomeProduto)
            command.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
            command.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub update(ByVal prod As Produto, ByVal cod As Long)
        Try
            If cod = prod.codigoProduto Then
                sql = "UPDATE produto SET nome=?,precoVenda=? WHERE codigo=?"
                Connection()
                command = New OleDbCommand(sql, conexao)
                command.Parameters.AddWithValue("nome", prod.nomeProduto)
                command.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
                command.Parameters.AddWithValue("codigo", Convert.ToString(cod))
                command.ExecuteNonQuery()
            Else
                sql = "UPDATE produto SET codigo=?,nome=?,precoVenda=? WHERE codigo=?"
                Connection()
                command = New OleDbCommand(sql, conexao)
                command.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
                command.Parameters.AddWithValue("nome", prod.nomeProduto)
                command.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
                command.Parameters.AddWithValue("codigo", Convert.ToString(cod))
                command.ExecuteNonQuery()
            End If
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub delete(ByVal prod As Produto)
        Try
            Connection()
            sql = "DELETE FROM produto WHERE codigo =?"
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Function search_cod(ByVal cod As String) As Produto
        Connection()
        sql = "SELECT * FROM Produto WHERE codigo =?"
        Dim prod As New Produto
        Try
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", cod)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                prod.codigoProduto = dataReader(0)
                prod.nomeProduto = dataReader(1)
                prod.precoVendaProduto = dataReader(2)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return prod
        conexao.Close()
    End Function

    Public Function search_Like(ByRef sql As String) As ArrayList
        Connection()
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim prod As New Produto
                prod.codigoProduto = dataReader(0)
                prod.nomeProduto = dataReader(1)
                prod.precoVendaProduto = dataReader(2)
                lista.Add(prod)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexao.Close()
    End Function
End Class
