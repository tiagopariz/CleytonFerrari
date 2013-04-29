Public Class Pessoa

    Private _nome As String
    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Private _idade As Int32
    Public Property Idade() As Int32
        Get
            Return _idade
        End Get
        Set(ByVal value As Int32)
            _idade = value
        End Set
    End Property


End Class
