Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class MovimentoProdutoDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Private commandMysql As MySqlCommand
    Private dataReaderMysql As MySqlDataReader

    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        openConnectionAccess()
        sql = "SELECT * FROM MovimentoProduto"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexaoAccess)
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
        conexaoAccess.Close()
        Return lista
    End Function

    Public Overloads Sub carregarDados(dgv As DataGridView)
        openConnectionAccess()
        sql = "SELECT * FROM MovimentoProduto"
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            dgv.Rows.Clear()
            Do While dataReader.Read = True
                dgv.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(3))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub insert(ByVal mvP As MovimentoProduto)
        Try
            sql = "INSERT INTO MovimentoProduto(movimento,produto,qtd,preco) VALUES(?,?,?,?)"
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("movimento", Convert.ToString(mvP.movimentoP))
            command.Parameters.AddWithValue("produto", Convert.ToString(mvP.produtoP))
            command.Parameters.AddWithValue("qtd", Convert.ToString(mvP.qtdP))
            command.Parameters.AddWithValue("preco", Convert.ToString(mvP.precoP))
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub insertMysql(ByVal mvP As MovimentoProduto)
        Try
            sql = "INSERT INTO MovimentoProduto(movimento,produto,qtd,preco) VALUES(?,?,?,?)"
            openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("movimento", Convert.ToString(mvP.movimentoP))
            commandMysql.Parameters.AddWithValue("produto", Convert.ToString(mvP.produtoP))
            commandMysql.Parameters.AddWithValue("qtd", Convert.ToString(mvP.qtdP))
            commandMysql.Parameters.AddWithValue("preco", Convert.ToString(mvP.precoP))
            commandMysql.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Sub update(ByVal mvP As MovimentoProduto, ByVal cod As Long)
        Try
            sql = "UPDATE MovimentoProduto SET movimento=?,produto=?,qtd=?,preco=? WHERE codigo=?"
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("movimento", Convert.ToString(mvP.movimentoP))
            command.Parameters.AddWithValue("produto", Convert.ToString(mvP.produtoP))
            command.Parameters.AddWithValue("qtd", Convert.ToString(mvP.qtdP))
            command.Parameters.AddWithValue("preco", Convert.ToString(mvP.precoP))
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub updateMysql(ByVal mvP As MovimentoProduto, ByVal cod As Long)
        Try
            sql = "UPDATE MovimentoProduto SET movimento=?,produto=?,qtd=?,preco=? WHERE codigo=?"
            openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("movimento", Convert.ToString(mvP.movimentoP))
            commandMysql.Parameters.AddWithValue("produto", Convert.ToString(mvP.produtoP))
            commandMysql.Parameters.AddWithValue("qtd", Convert.ToString(mvP.qtdP))
            commandMysql.Parameters.AddWithValue("preco", Convert.ToString(mvP.precoP))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Sub delete(ByVal mvP As MovimentoProduto)
        Try
            openConnectionAccess()
            sql = "DELETE FROM MovimentoProduto WHERE codigo =?"
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(mvP.codigoP))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub


    Public Sub deleteMysql(ByVal mvP As MovimentoProduto)
        Try
            openConnectionMysql()
            sql = "DELETE FROM MovimentoProduto WHERE codigo =?"
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(mvP.codigoP))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Function search_cod(ByVal cod As String) As MovimentoProduto
        openConnectionAccess()
        sql = "SELECT * FROM MovimentoProduto WHERE codigo =?"
        Dim mvP As New MovimentoProduto
        Try
            command = New OleDbCommand(sql, conexaoAccess)
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
        conexaoAccess.Close()
    End Function

    Public Function search_Like(ByRef sql As String) As ArrayList
        openConnectionAccess()
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexaoAccess)
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
        conexaoAccess.Close()
    End Function

    Public Sub join(ByVal sql As String, ByRef dgv As DataGridView)
        openConnectionAccess()
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            dgv.Rows.Clear()
            Do While dataReader.Read = True
                dgv.Rows.Add(dataReader(0), dataReader(1), dataReader(2), dataReader(3), dataReader(4))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub
End Class
