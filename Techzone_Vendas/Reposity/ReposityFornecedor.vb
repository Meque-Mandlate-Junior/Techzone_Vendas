Public Class ReposityFornecedor
    Public Sub New()

    End Sub

    Public Sub Insert(ByVal fornecedor As Fornecedor)
        Dim DAOFornecedor As New FornecedorDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            DAOFornecedor.insertAccess(fornecedor)
        Else
            DAOFornecedor.insertMysql(fornecedor)
        End If
    End Sub

    Public Sub update(ByVal fornecedor As Fornecedor, ByVal last_Cod As Integer)
        Dim DAOFornecedor As New FornecedorDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            DAOFornecedor.updateAccess(fornecedor, last_Cod)
        Else
            DAOFornecedor.updateMysql(fornecedor, last_Cod)
        End If
    End Sub

    Public Sub delete(ByVal fornecedor As Fornecedor)
        Dim DAOFornecedor As New FornecedorDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            DAOFornecedor.deleteAccess(fornecedor)
        Else
            DAOFornecedor.deleteMysql(fornecedor)
        End If
    End Sub


    Public Function returnDados() As ArrayList
        Dim lista As New ArrayList
        Dim DAOFornecedor As New FornecedorDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            lista = DAOFornecedor.carregarDadosAccess()
        Else
            lista = DAOFornecedor.carregarDadosMysql()
        End If
        Return lista
    End Function

    Public Function search_cod(ByVal cod As String) As Fornecedor
        Dim DAOFornecedor As New FornecedorDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            Return DAOFornecedor.search_codAccess(cod)
        Else
            Return DAOFornecedor.search_codMysql(cod)
        End If
    End Function

End Class
