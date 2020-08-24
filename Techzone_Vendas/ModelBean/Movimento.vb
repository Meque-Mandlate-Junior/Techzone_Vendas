Public Class Movimento
    Private codigo, cliente, fornecedor As Integer
    Private tipoMovimento As String
    Private data As DateTime

    Public Sub New()

    End Sub

    Public Property codigoMS() As Integer
        Get
            Return codigo
        End Get
        Set(value As Integer)
            codigo = value
        End Set
    End Property

    Public Property fornecedorMS() As Integer
        Get
            Return cliente
        End Get
        Set(value As Integer)
            cliente = value
        End Set
    End Property
    Public Property clienteMS() As Integer
        Get
            Return fornecedor
        End Get
        Set(value As Integer)
            fornecedor = value
        End Set
    End Property

    Public Property dateMS() As DateTime
        Get
            Return data
        End Get
        Set(value As DateTime)
            data = value
        End Set
    End Property
    Public Property tipoMovMS() As String
        Get
            Return tipoMovimento
        End Get
        Set(value As String)
            tipoMovimento = value
        End Set
    End Property
End Class
