﻿Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Module ConnectionString
    Public conexaoAccess As OleDbConnection
    Public conexaoMysql As New MySqlConnection("server=localhost;userid=root ;password=;database=dbVendas")
    Public connectionString As String = System.Environment.CurrentDirectory.ToString & "\VendasDB.accdb"
   
    Public Sub openConnectionAccess()
        Try
                conexaoAccess = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & connectionString & "")
                conexaoAccess.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub openConnectionMysql()
        Try
            conexaoMysql.Open()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub closeConnectionMysql()
        Try
            If conexaoMysql.State = 0 Then
                conexaoMysql.Close()
            End If
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message)
        End Try
    End Sub


End Module
