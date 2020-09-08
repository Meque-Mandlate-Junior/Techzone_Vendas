Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class FornecedorDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Private commandMysql As MySqlCommand
    Private sql_Mysql As String
    Private dataReaderMysql As MySqlDataReader

    Public Sub New()

    End Sub

    Public Overloads Function carregarDadosAccess() As ArrayList
        openConnectionAccess()
        sql = "SELECT * FROM fornecedor"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim forn As New Fornecedor
                forn.codigoFornecedor = dataReader(0)
                forn.nomeFornecedor = dataReader(1)
                forn.enderecoFornecedor = dataReader(2)
                lista.Add(forn)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexaoAccess.Close()
    End Function

    Public Overloads Function carregarDadosMysql() As ArrayList
        openConnectionMysql()
        sql = "SELECT * FROM fornecedor"
        Dim lista As New ArrayList
        Try
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            dataReaderMysql = commandMysql.ExecuteReader()
            Do While dataReaderMysql.Read = True
                Dim forn As New Fornecedor
                forn.codigoFornecedor = dataReaderMysql(0)
                forn.nomeFornecedor = dataReaderMysql(1)
                forn.enderecoFornecedor = dataReaderMysql(2)
                lista.Add(forn)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexaoMysql.Close()
    End Function

    Public Overloads Sub carregarDados(dgvFornecedor As DataGridView)
        openConnectionAccess()
        sql = "SELECT * FROM fornecedor"
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            dgvFornecedor.Rows.Clear()
            Do While dataReader.Read = True
                dgvFornecedor.Rows.Add(dataReader(0), dataReader(1), dataReader(2))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub


    Public Sub insertAccess(ByVal forn As Fornecedor)
        Try
            sql = "INSERT INTO fornecedor(codigo,nome,endereco) VALUES(?,?,?)"
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            command.Parameters.AddWithValue("nome", forn.nomeFornecedor)
            command.Parameters.AddWithValue("endereco", forn.enderecoFornecedor)
            command.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show("ERRO AO CADASTRAR " + ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub insertMysql(ByVal forn As Fornecedor)
        Try
            sql = "INSERT INTO fornecedor(codigo,nome,endereco) VALUES(?,?,?)"
            openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            commandMysql.Parameters.AddWithValue("nome", forn.nomeFornecedor)
            commandMysql.Parameters.AddWithValue("endereco", forn.enderecoFornecedor)
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show("ERRO AO CADASTRAR " + ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Sub updateAccess(ByVal forn As Fornecedor, ByVal cod As Long)
        Try
            sql = "UPDATE fornecedor SET codigo=?,nome=?,endereco=? WHERE codigo=?"
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            command.Parameters.AddWithValue("nome", forn.nomeFornecedor)
            command.Parameters.AddWithValue("endereco", forn.enderecoFornecedor)
            command.Parameters.AddWithValue("codigo", Convert.ToString(cod))
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub


    Public Sub updateMysql(ByVal forn As Fornecedor, ByVal cod As Long)
        Try
            sql = "UPDATE fornecedor SET codigo=?,nome=?,endereco=? WHERE codigo=?"
            openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            commandMysql.Parameters.AddWithValue("nome", forn.nomeFornecedor)
            commandMysql.Parameters.AddWithValue("endereco", forn.enderecoFornecedor)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(cod))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Sub deleteAccess(ByVal forn As Fornecedor)
        Try
            openConnectionAccess()
            sql = "DELETE FROM fornecedor WHERE codigo=?"
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub deleteMysql(ByVal forn As Fornecedor)
        Try
            openConnectionMysql()
            sql = "DELETE FROM fornecedor WHERE codigo=?"
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Function search_codAccess(ByVal cod As String) As Fornecedor
        openConnectionAccess()
        sql = "SELECT * FROM fornecedor WHERE codigo =?"
        Dim forn As New Fornecedor
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", cod)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                forn.codigoFornecedor = dataReader(0)
                forn.nomeFornecedor = dataReader(1)
                forn.enderecoFornecedor = dataReader(2)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return forn
        conexaoAccess.Close()
    End Function

    Public Function search_codMysql(ByVal cod As String) As Fornecedor
        openConnectionMysql()
        sql = "SELECT * FROM fornecedor WHERE codigo =?"
        Dim forn As New Fornecedor
        Try
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", cod)
            dataReaderMysql = commandMysql.ExecuteReader()
            Do While dataReaderMysql.Read = True
                forn.codigoFornecedor = dataReaderMysql(0)
                forn.nomeFornecedor = dataReaderMysql(1)
                forn.enderecoFornecedor = dataReaderMysql(2)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return forn
        conexaoMysql.Close()
    End Function
End Class
