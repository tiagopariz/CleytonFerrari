Imports System.Data.Entity

Public Class DBProduto
    Inherits DbContext

    'Tabela
    Property Produtos As DbSet(Of Produto)
    Property Categorias As DbSet(Of Categoria)

End Class
