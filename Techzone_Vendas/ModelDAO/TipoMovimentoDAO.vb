﻿Imports System.Data.OleDb
Public Class TipoMovimentoDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        Connection()
        sql = "SELECT * FROM tipoMovimento"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim mov As New TipoMovimento
                mov.nomeTM = dataReader(0)
                mov.operacaoTM = dataReader(1)
                lista.Add(mov)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexao.Close()
    End Function

    Public Overloads Sub carregarDados(dgvTpMov As DataGridView)
        Connection()
        sql = "SELECT * FROM tipoMovimento"
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            dgvTpMov.Rows.Clear()
            Do While dataReader.Read = True
                dgvTpMov.Rows.Add(dataReader(0), dataReader(1))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub


    Public Sub insert(ByVal mov As TipoMovimento)
        Try
            Connection()
            sql = "INSERT INTO tipoMovimento(nome,operacao) VALUES(?,?)"
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("nome", mov.nomeTM)
            command.Parameters.AddWithValue("operacao", mov.operacaoTM)
            command.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub update(ByVal mov As TipoMovimento, ByVal nome As Long)
        Try
            sql = "UPDATE tipoMovimento SET nome=?,operacao=? WHERE nome=?"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("nome", mov.nomeTM)
            command.Parameters.AddWithValue("operacao", mov.operacaoTM)
            command.Parameters.AddWithValue("nome", nome)
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub delete(ByVal mov As TipoMovimento)
        Try
            Connection()
            sql = "DELETE FROM tipoMovimento WHERE nome=?"
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("nome", mov.nomeTM)
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Function search_nome(ByVal nome As String) As TipoMovimento
        Connection()
        sql = "SELECT * FROM tipoMovimento WHERE nome =?"
        Dim mov As New TipoMovimento
        Try
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("nome", nome)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                mov.nomeTM = dataReader(0)
                mov.operacaoTM = dataReader(1)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return mov
        conexao.Close()
    End Function

    Public Function search_Like(ByRef sql As String) As ArrayList
        Connection()
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim mov As New TipoMovimento
                mov.nomeTM = dataReader(0)
                mov.operacaoTM = dataReader(1)
                lista.Add(mov)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexao.Close()
    End Function
End Class
