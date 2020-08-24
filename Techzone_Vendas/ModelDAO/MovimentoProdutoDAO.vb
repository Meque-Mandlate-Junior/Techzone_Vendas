Imports System.Data.OleDb
Public Class MovimentoProdutoDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        Connection()
        sql = "SELECT * FROM MovimentoProduto"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim mvP As New MovimentoProduto
                mvP.codigoP = dataReader(0)
                mvP.movimentoP = dataReader(1)
                mvP.produtoP = dataReader(2)
                mvP.qtdP = dataReader(3)
                mvP.precoP = dataReader(4)
                lista.Add(mvP)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
        Return lista
    End Function

    Public Overloads Sub carregarDados(dgv As DataGridView)
        Connection()
        sql = "SELECT * FROM MovimentoProduto"
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            dgv.Rows.Clear()
            Do While dataReader.Read = True
                dgv.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(3))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub
 


    Public Sub insert(ByVal mvP As MovimentoProduto)
        Try
            sql = "INSERT INTO MovimentoProduto(movimento,produto,qtd,preco) VALUES(?,?,?,?)"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("movimento", Convert.ToString(mvP.movimentoP))
            command.Parameters.AddWithValue("produto", Convert.ToString(mvP.produtoP))
            command.Parameters.AddWithValue("qtd", Convert.ToString(mvP.qtdP))
            command.Parameters.AddWithValue("preco", Convert.ToString(mvP.precoP))
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub update(ByVal mvP As MovimentoProduto, ByVal cod As Long)
        Try
            sql = "UPDATE MovimentoProduto SET movimento=?,produto=?,qtd=?,preco=? WHERE codigo=?"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("movimento", Convert.ToString(mvP.movimentoP))
            command.Parameters.AddWithValue("produto", Convert.ToString(mvP.produtoP))
            command.Parameters.AddWithValue("qtd", Convert.ToString(mvP.qtdP))
            command.Parameters.AddWithValue("preco", Convert.ToString(mvP.precoP))
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub delete(ByVal mvP As MovimentoProduto)
        Try
            Connection()
            sql = "DELETE FROM MovimentoProduto WHERE codigo =?"
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", Convert.ToString(mvP.codigoP))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Function search_cod(ByVal cod As String) As MovimentoProduto
        Connection()
        sql = "SELECT * FROM MovimentoProduto WHERE codigo =?"
        Dim mvP As New MovimentoProduto
        Try
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", cod)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                mvP.codigoP = dataReader(0)
                mvP.movimentoP = dataReader(1)
                mvP.produtoP = dataReader(2)
                mvP.qtdP = dataReader(3)
                mvP.precoP = dataReader(4)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return mvP
        conexao.Close()
    End Function

    Public Function search_Like(ByRef sql As String) As ArrayList
        Connection()
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim mvP As New MovimentoProduto
                mvP.codigoP = dataReader(0)
                mvP.movimentoP = dataReader(1)
                mvP.produtoP = dataReader(2)
                mvP.qtdP = dataReader(3)
                mvP.precoP = dataReader(4)
                lista.Add(mvP)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexao.Close()
    End Function

    Public Sub join(ByVal sql As String, ByRef dgv As DataGridView)
        Connection()
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            dgv.Rows.Clear()
            Do While dataReader.Read = True
                dgv.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub
End Class
