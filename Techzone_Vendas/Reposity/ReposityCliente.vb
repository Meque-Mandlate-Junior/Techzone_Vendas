Public Class ReposityCliente
    Public Sub New()

    End Sub

    Public Sub Insert(ByVal cliente As Cliente)
        Dim DAOCliente As New ClienteDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            DAOCliente.insertAccess(cliente)
        Else
            DAOCliente.insertMysql(cliente)
        End If
    End Sub

    Public Sub update(ByVal cliente As Cliente, ByVal last_Cod As Integer)
        Dim DAOCliente As New ClienteDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            DAOCliente.updateAccess(cliente, last_Cod)
        Else
            DAOCliente.updateMysql(cliente, last_Cod)
        End If
    End Sub

    Public Sub delete(ByVal cliente As Cliente)
        Dim DAOCliente As New ClienteDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            DAOCliente.deleteAccess(cliente)
        Else
            DAOCliente.deleteMysql(cliente)
        End If
    End Sub


    Public Function returnDados() As ArrayList
        Dim lista As New ArrayList
        Dim DAOCliente As New ClienteDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            lista = DAOCliente.carregarDadosAccess()
        Else
            lista = DAOCliente.carregarDadosMysql()
        End If
        Return lista
    End Function

    Public Function search_cod(ByVal cod As String) As Cliente
        Dim DAOCliente As New ClienteDAO
        If (My.Settings.IndexTipoBanco = 1) Then
            Return DAOCliente.search_nuitAccess(cod)
        Else
            Return DAOCliente.search_nuitMysql(cod)
        End If
    End Function

End Class
