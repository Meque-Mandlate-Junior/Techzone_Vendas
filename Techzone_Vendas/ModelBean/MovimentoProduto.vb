Public Class MovimentoProduto
    Private cod, movimento As Integer
    Private produto As Integer
    Private qtd As Integer
    Private preco As Double

    Public Sub New()

    End Sub
    Public Property codigoP() As Integer
        Get
            Return cod
        End Get
        Set(value As Integer)
            cod = value
        End Set
    End Property
    Public Property movimentoP() As Integer
        Get
            Return movimento
        End Get
        Set(value As Integer)
            movimento = value
        End Set
    End Property

    Public Property produtoP() As Integer
        Get
            Return produto
        End Get
        Set(value As Integer)
            produto = value
        End Set
    End Property

    Public Property qtdP() As Integer
        Get
            Return qtd
        End Get
        Set(value As Integer)
            qtd = value
        End Set
    End Property

    Public Property precoP() As Double
        Get
            Return preco
        End Get
        Set(value As Double)
            preco = value
        End Set
    End Property
End Class
