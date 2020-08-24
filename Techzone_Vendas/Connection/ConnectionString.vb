Imports System.Data.OleDb
Module ConnectionString
    Public conexao As OleDbConnection
    Public connectionString As String = System.Environment.CurrentDirectory.ToString & "\VendasDB.accdb"
    Public Sub Connection()
        Try
            conexao = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & connectionString & "")
            conexao.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
