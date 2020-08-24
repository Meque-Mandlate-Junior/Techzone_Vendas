Public Class Cliente
    Private nome As String
    Private nuit As Long
    Private morada As String
    Public Sub New() 'Construtor

    End Sub
    Public Sub New(ByVal nome As String, ByVal nuit As Long, ByVal morada As String) 'Construtor
        nome = nome
        nuit = nuit
        morada = morada
    End Sub
    'Get e Set
    Public Property NomeCliente() As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property
    Public Property NuitCliente() As Long
        Get
            Return nuit
        End Get
        Set(value As Long)
            nuit = value
        End Set
    End Property
    Public Property MoradaCliente() As String
        Get
            Return morada
        End Get
        Set(value As String)
            morada = value
        End Set
    End Property
    Public Shadows Function toString() As String
        Return "_" + Convert.ToString(nuit) + "_" + morada + "_" + nome
    End Function
End Class
