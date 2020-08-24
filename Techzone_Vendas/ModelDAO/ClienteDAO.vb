﻿Imports System.Data.OleDb
Public Class ClienteDAO
    Private command As OleDbCommand
    Private sql As String
    Private dataReader As OleDbDataReader
    Public Sub New()

    End Sub

    Public Overloads Function carregarDados() As ArrayList
        Connection()
        sql = "SELECT * FROM cliente"
        Dim lista As New ArrayList
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                Dim cl As New Cliente
                cl.NomeCliente = dataReader(0)
                cl.NuitCliente = dataReader(1)
                cl.MoradaCliente = dataReader(2)
                lista.Add(cl)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lista
        conexao.Close()
    End Function

    Public Overloads Sub carregarDados(dgvCliente As DataGridView)
        Connection()
        sql = "SELECT * FROM cliente"
        Try
            command = New OleDbCommand(sql, conexao)
            dataReader = command.ExecuteReader()
            dgvCliente.Rows.Clear()
            Do While dataReader.Read = True
                dgvCliente.Rows.Add(dataReader(0), dataReader(1), dataReader(2))
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub


    Public Sub insert(ByVal cliente As Cliente)
        Try
            sql = "INSERT INTO cliente(nome,nuit,morada) VALUES(?,?,?)"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("nome", cliente.NomeCliente)
            command.Parameters.AddWithValue("nuit", Convert.ToString(cliente.NuitCliente))
            command.Parameters.AddWithValue("morada", cliente.MoradaCliente)
            command.ExecuteNonQuery()
            MessageBox.Show("INSERIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show("ERRO AO CADASTRAR " + ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub update(ByVal cliente As Cliente, ByVal nuit As Long)
        Try
            sql = "UPDATE cliente SET nome=?,nuit=?,morada=? WHERE nuit=?"
            Connection()
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("nome", cliente.NomeCliente)
            command.Parameters.AddWithValue("nuit", Convert.ToString(cliente.NuitCliente))
            command.Parameters.AddWithValue("morada", cliente.MoradaCliente)
            command.Parameters.AddWithValue("nuit", Convert.ToString(nuit))
            command.ExecuteNonQuery()
            MessageBox.Show("ACTUALIZADO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Sub delete(ByVal cliente As Cliente)
        Try
            Connection()
            sql = "DELETE FROM cliente WHERE nuit=?"
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("codigo", Convert.ToString(cliente.NuitCliente))
            command.ExecuteNonQuery()
            MessageBox.Show("REMOVIDO COM SUCESSO")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conexao.Close()
    End Sub

    Public Function search_nuit(ByVal nuit As String) As Cliente
        Connection()
        sql = "SELECT * FROM cliente WHERE nuit =?"
        Dim cl As New Cliente
        Try
            command = New OleDbCommand(sql, conexao)
            command.Parameters.AddWithValue("nuit", nuit)
            dataReader = command.ExecuteReader()
            Do While dataReader.Read = True
                cl.NomeCliente = dataReader(0)
                cl.NuitCliente = dataReader(1)
                cl.MoradaCliente = dataReader(2)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cl
        conexao.Close()
    End Function

End Class