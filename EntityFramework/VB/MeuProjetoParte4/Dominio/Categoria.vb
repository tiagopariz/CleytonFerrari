Public Class Categoria

    Public Property Id As Int32
    Public Property Descricao As String

    Private m_produtos As IEnumerable(Of Produto)
    Public Overridable Property produtos() As IEnumerable(Of Produto)
        Get
            Return m_produtos
        End Get
        Set(value As IEnumerable(Of Produto))
            m_produtos = value
        End Set
    End Property

End Class
