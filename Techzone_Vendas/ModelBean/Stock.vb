Public Class Stock
    Private codigo, produto, qtd As Integer
    Public Sub New()

    End Sub
    Public ReadOnly Property codigoStock() As Integer
        Get
            Return codigo
        End Get
    End Property
    Public Property produtoStock() As Integer
        Get
            Return produto
        End Get
        Set(value As Integer)
            produto = value
        End Set
    End Property
    Public Property qtdStock() As Integer
        Get
            Return qtd
        End Get
        Set(value As Integer)
            qtd = value
        End Set
    End Property
End Class
