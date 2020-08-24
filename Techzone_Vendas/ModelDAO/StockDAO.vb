Imports System.Data.OleDb
Public Class StockDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        Connection()
        sql = "SELECT * FROM stock"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim stk As New Stock
                stk.produtoStock = dataReader(1)
                stk.qtdStock = dataReader(2)
                lista.Add(stk)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexao.Close()
    End Function

    Public Overloads Sub carregarDados(dgvStock As DataGridView)
     
        Connection()
        sql = "SELECT * FROM stock"
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            dgvStock.Rows.Clear()
            conexao.Close()
            Dim ctrl As Integer = 0
            Do While dataReader.Read = True
                dgvStock.Rows.Add(dataReader(1), dataReader(2))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conexao.Close()
        End Try

    End Sub


    Public Sub insert(ByVal stk As Stock)
        Try
            sql = "INSERT INTO stock(produto,qtd) VALUES(?,?)"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("produto", Convert.ToString(stk.produtoStock))
            command.Parameters.AddWithValue("qtd", Convert.ToString(stk.qtdStock))
            command.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub update(ByVal stk As Stock, ByVal cod As Long)
        Try
            sql = "UPDATE stock SET produto=?,qtd=? WHERE produto=?"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("produto", Convert.ToString(stk.produtoStock))
            command.Parameters.AddWithValue("qtd", Convert.ToString(stk.qtdStock))
            command.Parameters.AddWithValue("produto", Convert.ToString(cod))
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub delete(ByVal stk As Stock)
        Try
            Connection()
            sql = "DELETE FROM stock WHERE produto=?"
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("produto", Convert.ToString(stk.produtoStock))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Function search_pro(ByVal cod As String) As Stock
        Connection()
        sql = "SELECT * FROM stock WHERE produto =?"
        Dim stk As New Stock
        Try
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("produto", cod)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                stk.produtoStock = dataReader(1)
                stk.qtdStock = dataReader(2)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return stk
        conexao.Close()
    End Function
End Class


