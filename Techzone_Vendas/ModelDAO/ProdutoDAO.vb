Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class ProdutoDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Private commandMysql As MySqlCommand
    Private sql_Mysql As String
    Private dataReaderMysql As MySqlDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        sql = "SELECT * FROM produto"
        Dim lista As New ArrayList
        Try
            ConnectionString.openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
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
            ConnectionString.conexaoAccess.Close()
        End Try
        Return lista
    End Function
    Public Overloads Function carregarDadosMysql() As ArrayList
        sql = "SELECT * FROM produto"
        Dim lista As New ArrayList
        Try
            ConnectionString.openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            dataReaderMysql = commandMysql.ExecuteReader()
            Do While dataReaderMysql.Read = True
                Dim prod As New Produto
                prod.codigoProduto = dataReaderMysql(0)
                prod.nomeProduto = dataReaderMysql(1)
                prod.precoVendaProduto = dataReaderMysql(2)
                lista.Add(prod)
            Loop
          
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
            ConnectionString.conexaoMysql.Close()
        Return lista

    End Function

    Public Overloads Sub carregarDados(dgvProduto As DataGridView)
        sql = "SELECT * FROM produto"
        Try
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            dgvProduto.Rows.Clear()
            Do While dataReader.Read = True
                dgvProduto.Rows.Add(dataReader(0), dataReader(1), dataReader(2))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub


    Public Sub insert(ByVal prod As Produto)
        Try
            sql = "INSERT INTO produto(codigo,nome,precoVenda) VALUES(?,?,?)"
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
            command.Parameters.AddWithValue("nome", prod.nomeProduto)
            command.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
            command.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub insertMysql(ByVal prod As Produto)
        Try
            sql = "INSERT INTO produto(codigo,nome,precoVenda) VALUES(?,?,?)"
            openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
            commandMysql.Parameters.AddWithValue("nome", prod.nomeProduto)
            commandMysql.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Sub update(ByVal prod As Produto, ByVal cod As Long)
        Try
            If cod = prod.codigoProduto Then
                sql = "UPDATE produto SET nome=?,precoVenda=? WHERE codigo=?"
                openConnectionAccess()
                command = New OleDbCommand(sql, conexaoAccess)
                command.Parameters.AddWithValue("nome", prod.nomeProduto)
                command.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
                command.Parameters.AddWithValue("codigo", Convert.ToString(cod))
                command.ExecuteNonQuery()
            Else
                sql = "UPDATE produto SET codigo=?,nome=?,precoVenda=? WHERE codigo=?"
                openConnectionAccess()
                command = New OleDbCommand(sql, conexaoAccess)
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
        conexaoAccess.Close()
    End Sub

    Public Sub updateMysql(ByVal prod As Produto, ByVal cod As Long)
        Try
            If cod = prod.codigoProduto Then
                sql = "UPDATE produto SET nome=?,precoVenda=? WHERE codigo=?"
                openConnectionMysql()
                commandMysql = New MySqlCommand(sql, conexaoMysql)
                commandMysql.Parameters.AddWithValue("nome", prod.nomeProduto)
                commandMysql.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
                commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(cod))
                commandMysql.ExecuteNonQuery()
            Else
                sql = "UPDATE produto SET codigo=?,nome=?,precoVenda=? WHERE codigo=?"
                openConnectionMysql()
                commandMysql = New MySqlCommand(sql, conexaoMysql)
                commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
                commandMysql.Parameters.AddWithValue("nome", prod.nomeProduto)
                commandMysql.Parameters.AddWithValue("precoVenda", Convert.ToString(prod.precoVendaProduto))
                commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(cod))
                commandMysql.ExecuteNonQuery()
            End If
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub



    Public Sub deleteAccess(ByVal prod As Produto)
        Try
            openConnectionAccess()
            sql = "DELETE FROM produto WHERE codigo =?"
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub


    Public Sub deleteMysql(ByVal prod As Produto)
        Try
            openConnectionMysql()
            sql = "DELETE FROM produto WHERE codigo =?"
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(prod.codigoProduto))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Function search_cod(ByVal cod As String) As Produto
        openConnectionAccess()
        sql = "SELECT * FROM Produto WHERE codigo =?"
        Dim prod As New Produto
        Try
            command = New OleDbCommand(sql, conexaoAccess)
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
        conexaoAccess.Close()
    End Function

    Public Function search_codMysql(ByVal cod As String) As Produto
        openConnectionMysql()
        sql = "SELECT * FROM Produto WHERE codigo =?"
        Dim prod As New Produto
        Try
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", cod)
            dataReaderMysql = commandMysql.ExecuteReader()
            Do While dataReaderMysql.Read = True
                prod.codigoProduto = dataReaderMysql(0)
                prod.nomeProduto = dataReaderMysql(1)
                prod.precoVendaProduto = dataReaderMysql(2)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
        Return prod
    End Function


    Public Function search_Like(ByRef sql As String) As ArrayList
        openConnectionAccess()
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexaoAccess)
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
        conexaoAccess.Close()
    End Function
End Class
