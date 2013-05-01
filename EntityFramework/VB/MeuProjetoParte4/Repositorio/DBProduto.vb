Imports System.Data.Entity
Imports Dominio

Public Class DBProduto
    Inherits DbContext

    Public Sub New()
        MyBase.New("CadastroDeProdutos") 'Atribui o nome ao BD

    End Sub

    Property Produtos As DbSet(Of Produto)

    Property Categorias As DbSet(Of Categoria)

    Property ListaDeProdutos As DbSet(Of ListaDeProduto)

End Class
