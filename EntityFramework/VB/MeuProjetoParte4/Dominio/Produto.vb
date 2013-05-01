Public Class Produto

    Public Property Id As Int32
    Public Property Nome As String
    Public Property Categoria As Categoria

    Private m_ListaDeProdutos As ICollection(Of ListaDeProduto)
    Public Overridable Property ListaDeProdutos() As ICollection(Of ListaDeProduto)
        Get
            Return m_ListaDeProdutos
        End Get
        Set(value As ICollection(Of ListaDeProduto))
            m_ListaDeProdutos = value
        End Set
    End Property

End Class
