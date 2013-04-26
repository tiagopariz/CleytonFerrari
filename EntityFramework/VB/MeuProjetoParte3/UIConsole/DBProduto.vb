Imports System.Data.Entity

Public Class DBProduto
    Inherits DbContext

    Property Produtos As DbSet(Of Produto)

    Property Categorias As DbSet(Of Categoria)

    Property ListaDeProdutos As DbSet(Of ListaDeProduto)

End Class
