Public Class Fornecedor
    Private codigo As Long
    Private nome As String
    Private Endereco As String
    Public Sub New() 'Construtor

    End Sub
    'Get e Set
    Public Property codigoFornecedor() As Long
        Get
            Return codigo
        End Get
        Set(value As Long)
            codigo = value
        End Set
    End Property
    Public Property nomeFornecedor() As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property

    Public Property enderecoFornecedor() As String
        Get
            Return Endereco
        End Get
        Set(value As String)
            Endereco = value
        End Set
    End Property
    Public Shadows Function toString() As String
        Return "_" + Convert.ToString(codigo) + "_" + Endereco + "_" + nome
    End Function
End Class
