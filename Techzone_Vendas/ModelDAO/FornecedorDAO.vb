Imports System.Data.OleDb
Public Class FornecedorDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        Connection()
        sql = "SELECT * FROM fornecedor"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
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
        conexao.Close()
    End Function

    Public Overloads Sub carregarDados(dgvFornecedor As DataGridView)
        Connection()
        sql = "SELECT * FROM fornecedor"
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            dgvFornecedor.Rows.Clear()
            Do While dataReader.Read = True
                dgvFornecedor.Rows.Add(dataReader(0), dataReader(1), dataReader(2))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub


    Public Sub insert(ByVal forn As Fornecedor)
        Try
            sql = "INSERT INTO fornecedor(codigo,nome,endereco) VALUES(?,?,?)"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            command.Parameters.AddWithValue("nome", forn.nomeFornecedor)
            command.Parameters.AddWithValue("endereco", forn.enderecoFornecedor)
            command.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show("ERRO AO CADASTRAR " + ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub update(ByVal forn As Fornecedor, ByVal cod As Long)
        Try
            sql = "UPDATE fornecedor SET codigo=?,nome=?,endereco=? WHERE codigo=?"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            command.Parameters.AddWithValue("nome", forn.nomeFornecedor)
            command.Parameters.AddWithValue("endereco", forn.enderecoFornecedor)
            command.Parameters.AddWithValue("codigo", Convert.ToString(cod))
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub delete(ByVal forn As Fornecedor)
        Try
            Connection()
            sql = "DELETE FROM fornecedor WHERE codigo=?"
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", Convert.ToString(forn.codigoFornecedor))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Function search_cod(ByVal cod As String) As Fornecedor
        Connection()
        sql = "SELECT * FROM fornecedor WHERE codigo =?"
        Dim forn As New Fornecedor
        Try
            command = New OleDbCommand(sql, conexao)
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
        conexao.Close()
    End Function
End Class
