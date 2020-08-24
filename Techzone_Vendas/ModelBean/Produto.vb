Public Class Produto
    Private codigo As Integer
    Private nome As String
    Private precoVenda As Double

    Public Sub New()

    End Sub
    Public Sub New(ByVal cod As Integer, ByVal nom As String, ByVal _
                   precoVen As Double)
        codigo = cod
        nome = nom
        precoVenda = precoVen
    End Sub

    Public Property codigoProduto() As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property
    Public Property nomeProduto() As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property
    Public Property precoVendaProduto() As Double
        Get
            Return precoVenda
        End Get
        Set(value As Double)
            precoVenda = value
        End Set
    End Property
End Class
