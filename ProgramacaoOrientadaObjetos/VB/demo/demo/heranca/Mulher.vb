Public Class Mulher
    Inherits Pessoa

    Private _tamanhoDoBusto As Int32
    Public Property TamanhoDoBusto() As Int32
        Get
            Return _tamanhoDoBusto
        End Get
        Set(value As Int32)
            _tamanhoDoBusto = value
        End Set
    End Property

End Class
