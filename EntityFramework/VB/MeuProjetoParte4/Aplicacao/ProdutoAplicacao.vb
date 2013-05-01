Imports System.Data.Entity
Imports Repositorio
Imports Dominio

Public Class ProdutoAplicacao

    Public Property Banco As DBProduto

    Public Sub New()
        Banco = New DBProduto
    End Sub

    Public Sub Salvar(produto As Produto)

        'banco.Produtos.Add(produto)
        'banco.SaveChanges()

        produto.Categoria = Banco.Categorias.ToList().Where(Function(x) x.Id = produto.Categoria.Id).FirstOrDefault()
        Banco.Produtos.Add(produto)
        Banco.SaveChanges()

    End Sub

    Public Function Listar() As IEnumerable(Of Produto)

        Return Banco.Produtos.Include(Function(x) x.Categoria).ToList()

    End Function

    Public Sub Alterar(produto As Produto)

        Dim produtoSalvar As Produto = Banco.Produtos.Where(Function(x) x.Id = produto.Id).First()
        produtoSalvar.Nome = produto.Nome
        Banco.SaveChanges()

    End Sub

    Public Sub Excluir(id As Int32)

        Dim produtoExcluir As Produto = Banco.Produtos.First(Function(x) x.Id = id)
        Banco.Set(Of Produto).Remove(produtoExcluir)
        Banco.SaveChanges()

    End Sub

End Class
