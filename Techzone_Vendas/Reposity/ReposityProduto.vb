Public Class ReposityProduto

    Public Sub New()

    End Sub

    Public Sub Insert(ByVal produto As Produto)
        If (My.Settings.IndexTipoBanco = 1) Then
            Dim DAOProduto As New ProdutoDAO
            DAOProduto.insert(produto)
        Else
            Dim DAOProduto As New ProdutoDAO
            DAOProduto.insertMysql(produto)
        End If
    End Sub

    Public Sub update(ByVal produto As Produto, ByVal last_Cod As Integer)
        If (My.Settings.IndexTipoBanco = 1) Then
            Dim DAOProduto As New ProdutoDAO
            DAOProduto.update(produto, last_Cod)
        Else
            Dim DAOProduto As New ProdutoDAO
            DAOProduto.updateMysql(produto, last_Cod)
        End If
    End Sub

    Public Sub delete(ByVal produto As Produto)
        If (My.Settings.IndexTipoBanco = 1) Then
            Dim DAOProduto As New ProdutoDAO
            DAOProduto.deleteAccess(produto)
        Else
            Dim DAOProduto As New ProdutoDAO
            DAOProduto.deleteMysql(produto)
        End If
    End Sub


    Public Function returnDados() As ArrayList
        Dim lista As New ArrayList
        If (My.Settings.IndexTipoBanco = 1) Then
            Dim DAOProduto As New ProdutoDAO
            lista = DAOProduto.carregarDados()
        Else
            Dim DAOProduto As New ProdutoDAO
            lista = DAOProduto.carregarDadosMysql()
        End If
        Return lista
    End Function

    Public Function search_cod(ByVal cod As String) As Produto
        Dim DAOProduto As New ProdutoDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            Return DAOProduto.search_cod(cod)
        Else
            Return DAOProduto.search_codMysql(cod)
        End If
    End Function
End Class
