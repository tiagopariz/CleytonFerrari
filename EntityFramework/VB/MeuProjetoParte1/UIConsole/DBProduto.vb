Imports System.Data.Entity

Public Class DBProduto
    Inherits DbContext

    'Tabela
    Property Produtos As DbSet(Of Produto)


End Class
