Imports System.Data.Entity

Public Class ListaDeProdutoAplicacao

    Property banco As DBProduto

    Public Sub New()
        banco = New DBProduto()
    End Sub

    Public Sub Salvar(listaDeProduto As ListaDeProduto)
        listaDeProduto.Produtos =
            listaDeProduto.Produtos.Select(Function(produto) banco.Produtos.FirstOrDefault(Function(x) x.Id = produto.Id)).ToList()
        banco.ListaDeProdutos.Add(listaDeProduto)
        banco.SaveChanges()
    End Sub

    Public Function Listar() As IEnumerable(Of ListaDeProduto)
        Return banco.ListaDeProdutos _
                    .Include(Function(x) x.Produtos) _
                    .Include(Function(x) x.Produtos.Select(Function(c) c.Categoria)) _
                    .ToList()
    End Function

    Public Sub Alterar(listaDeProduto As ListaDeProduto)
        Dim listaSalvar As ListaDeProduto =
            banco.ListaDeProdutos.Where(Function(x) x.Id = listaDeProduto.Id).First()
        listaSalvar.Produtos =
            listaDeProduto.Produtos.Select(Function(produto) banco.Produtos.FirstOrDefault(Function(x) x.Id = produto.Id)).ToList()
        listaSalvar.Descricao = listaDeProduto.Descricao
        banco.SaveChanges()
    End Sub

    Public Sub Excluir(Id As Int32)
        Dim listaExcuir As ListaDeProduto =
            banco.ListaDeProdutos.Where(Function(x) x.Id = Id).First()
        listaExcuir.Produtos = Nothing
        banco.Set(Of ListaDeProduto)().Remove(listaExcuir)
        banco.SaveChanges()
    End Sub

End Class
