Public Class Homem
    Inherits Pessoa

    Private _tamanhoBarba As Int32
    Public Property tamanhoBarba() As Int32
        Get
            Return _tamanhoBarba
        End Get
        Set(ByVal value As Int32)
            _tamanhoBarba = value
        End Set
    End Property


End Class
