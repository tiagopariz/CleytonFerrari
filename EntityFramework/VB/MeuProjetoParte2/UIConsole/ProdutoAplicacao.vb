Imports System.Data.Entity

Public Class ProdutoAplicacao

    Public Property banco As DBProduto

    Public Sub New()
        banco = New DBProduto
    End Sub

    Public Sub Salvar(produto As Produto)

        'banco.Produtos.Add(produto)
        'banco.SaveChanges()

        produto.Categoria = banco.Categorias.ToList().Where(Function(x) x.Id = produto.Categoria.Id).FirstOrDefault()
        banco.Produtos.Add(produto)
        banco.SaveChanges()

    End Sub

    Public Function Listar() As IEnumerable(Of Produto)

        Return banco.Produtos.Include(Function(x) x.Categoria).ToList()

    End Function

    Public Sub Alterar(produto As Produto)

        Dim produtoSalvar As Produto = banco.Produtos.Where(Function(x) x.Id = produto.Id).First()
        produtoSalvar.Nome = produto.Nome
        banco.SaveChanges()

    End Sub

    Public Sub Excluir(Id As Int32)

        Dim produtoExcluir As Produto = banco.Produtos.Where(Function(x) x.Id = Id).First()
        banco.Set(Of Produto).Remove(produtoExcluir)
        banco.SaveChanges()

    End Sub

End Class
