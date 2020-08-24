Public Class TipoMovimento
    Private nome As String
    Private operacao As String

    Public Sub New()

    End Sub

    Public Property nomeTM() As String
        Get
            Return nome
        End Get
        Set(value As String)
            nome = value
        End Set
    End Property
    Public Property operacaoTM() As String
        Get
            Return operacao
        End Get
        Set(value As String)
            operacao = value
        End Set
    End Property

End Class
