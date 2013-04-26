Imports System.ComponentModel.DataAnnotations

Public Class ListaDeProduto

    <Key> _
    Property Id As Integer
    Property Descricao As String
    Property Produtos As ICollection(Of Produto)

End Class
