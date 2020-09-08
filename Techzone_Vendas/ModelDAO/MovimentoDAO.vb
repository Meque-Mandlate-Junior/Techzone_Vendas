Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class MovimentoDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Private commandMysql As MysqlCommand
    Private dataReaderMysql As MySqlDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        openConnectionAccess()
        sql = "SELECT * FROM Movimento"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim mvs As New Movimento
                mvs.codigoMS = dataReader(0)
                mvs.clienteMS = dataReader(1)
                mvs.fornecedorMS = dataReader(2)
                mvs.dateMS = dataReader(3)
                mvs.tipoMovMS = dataReader(4)
                lista.Add(mvs)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
        Return lista
    End Function

    Public Overloads Function carregarDadosMysql() As ArrayList
        openConnectionAccess()
        sql = "SELECT * FROM Movimento"
        Dim lista As New ArrayList
        Try
            commandMysql = New MysqlCommand(sql, conexaoMysql)
            dataReaderMysql = commandMysql.ExecuteReader()
            Do While dataReader.Read = True
                Dim mvs As New Movimento
                mvs.codigoMS = dataReader(0)
                mvs.clienteMS = dataReader(1)
                mvs.fornecedorMS = dataReader(2)
                mvs.dateMS = dataReader(3)
                mvs.tipoMovMS = dataReader(4)
                lista.Add(mvs)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
        Return lista
    End Function

    Public Sub carregarDadosSaida(dgv As DataGridView)
        openConnectionAccess()
        sql = "SELECT * FROM Movimento"
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            dgv.Rows.Clear()
            Do While dataReader.Read = True
                dgv.Rows.Add(dataReader(0), dataReader(1), dataReader(3), dataReader(4))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub
    Public Overloads Sub carregarDadosEntrada(dgv As DataGridView)
        openConnectionAccess()
        sql = "SELECT * FROM Movimento"
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            dgv.Rows.Clear()
            Do While dataReader.Read = True
                dgv.Rows.Add(dataReader(0), dataReader(2), dataReader(3), dataReader(4))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub


    Public Sub insert(ByVal mvs As Movimento)
        Try
            sql = "INSERT INTO Movimento (codigo,cliente,fornecedor,data,tipoMovimento) VALUES(?,?,?,?,?)"
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(mvs.codigoMS))
            command.Parameters.AddWithValue("cliente", Convert.ToString(mvs.clienteMS))
            command.Parameters.AddWithValue("fornecedor", Convert.ToString(mvs.fornecedorMS))
            command.Parameters.AddWithValue("data", Convert.ToString(mvs.dateMS))
            command.Parameters.AddWithValue("tipoMovimento", mvs.tipoMovMS)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub


    Public Sub insertMysql(ByVal mvs As Movimento)
        Try
            sql = "INSERT INTO Movimento (codigo,cliente,fornecedor,data,tipoMovimento) VALUES(?,?,?,?,?)"
            openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(mvs.codigoMS))
            commandMysql.Parameters.AddWithValue("cliente", Convert.ToString(mvs.clienteMS))
            commandMysql.Parameters.AddWithValue("fornecedor", Convert.ToString(mvs.fornecedorMS))
            commandMysql.Parameters.AddWithValue("data", Convert.ToString(mvs.dateMS))
            commandMysql.Parameters.AddWithValue("tipoMovimento", mvs.tipoMovMS)
            commandMysql.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Sub update(ByVal mvs As Movimento, ByVal cod As Long)
        Try
            sql = "UPDATE Movimento SET cliente=?, fornecedor=?,data=?,TipoMovimento=? WHERE codigo=?"
            openConnectionAccess()
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("cliente", Convert.ToString(mvs.clienteMS))
            command.Parameters.AddWithValue("fornecedor", Convert.ToString(mvs.fornecedorMS))
            command.Parameters.AddWithValue("data", Convert.ToString(mvs.dateMS))
            command.Parameters.AddWithValue("tipoMovimento", mvs.tipoMovMS)
            command.Parameters.AddWithValue("data", Convert.ToString(cod))
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub updateMysql(ByVal mvs As Movimento, ByVal cod As Long)
        Try
            sql = "UPDATE Movimento SET cliente=?, fornecedor=?,data=?,TipoMovimento=? WHERE codigo=?"
            openConnectionMysql()
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("cliente", Convert.ToString(mvs.clienteMS))
            commandMysql.Parameters.AddWithValue("fornecedor", Convert.ToString(mvs.fornecedorMS))
            commandMysql.Parameters.AddWithValue("data", Convert.ToString(mvs.dateMS))
            commandMysql.Parameters.AddWithValue("tipoMovimento", mvs.tipoMovMS)
            commandMysql.Parameters.AddWithValue("data", Convert.ToString(cod))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub

    Public Sub delete(ByVal mvs As Movimento)
        Try
            openConnectionAccess()
            sql = "DELETE FROM Movimento WHERE codigo =?"
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", Convert.ToString(mvs.codigoMS))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoAccess.Close()
    End Sub

    Public Sub deleteMysql(ByVal mvs As Movimento)
        Try
            openConnectionMysql()
            sql = "DELETE FROM Movimento WHERE codigo =?"
            commandMysql = New MySqlCommand(sql, conexaoMysql)
            commandMysql.Parameters.AddWithValue("codigo", Convert.ToString(mvs.codigoMS))
            commandMysql.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexaoMysql.Close()
    End Sub


    Public Function search_cod(ByVal cod As String) As Movimento
        openConnectionAccess()
        sql = "SELECT * FROM Movimento WHERE codigo =?"
        Dim mvs As New Movimento
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            command.Parameters.AddWithValue("codigo", cod)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                mvs.codigoMS = dataReader(0)
                mvs.clienteMS = dataReader(1)
                mvs.fornecedorMS = dataReader(2)
                mvs.dateMS = dataReader(3)
                mvs.tipoMovMS = dataReader(4)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return mvs
        conexaoAccess.Close()
    End Function

    Public Function search_Like(ByRef sql As String) As ArrayList
        openConnectionAccess()
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexaoAccess)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim mvs As New Movimento
                mvs.codigoMS = dataReader(0)
                mvs.clienteMS = dataReader(1)
                mvs.fornecedorMS = dataReader(2)
                mvs.dateMS = dataReader(3)
                mvs.tipoMovMS = dataReader(4)
                lista.Add(mvs)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexaoAccess.Close()
    End Function
End Class
