Imports System.Data.Entity
Imports Repositorio
Imports Dominio

Public Class ListaDeProdutoAplicacao

    Property Banco As DBProduto

    Public Sub New()
        Banco = New DBProduto()
    End Sub

    Public Sub Salvar(listaDeProduto As ListaDeProduto)
        listaDeProduto.Produtos =
            listaDeProduto.Produtos.Select(Function(produto) Banco.Produtos.FirstOrDefault(Function(x) x.Id = produto.Id)).ToList()
        Banco.ListaDeProdutos.Add(listaDeProduto)
        Banco.SaveChanges()
    End Sub

    Public Function Listar() As IEnumerable(Of ListaDeProduto)
        Return Banco.ListaDeProdutos _
                    .Include(Function(x) x.Produtos) _
                    .Include(Function(x) x.Produtos.Select(Function(c) c.Categoria)) _
                    .ToList()
    End Function

    Public Sub Alterar(listaDeProduto As ListaDeProduto)
        Dim listaSalvar As ListaDeProduto =
            Banco.ListaDeProdutos.Where(Function(x) x.Id = listaDeProduto.Id).First()
        listaSalvar.Produtos =
            listaDeProduto.Produtos.Select(Function(produto) Banco.Produtos.FirstOrDefault(Function(x) x.Id = produto.Id)).ToList()
        listaSalvar.Descricao = listaDeProduto.Descricao
        Banco.SaveChanges()
    End Sub

    Public Sub Excluir(id As Int32)
        Dim listaExcuir As ListaDeProduto =
            Banco.ListaDeProdutos.Where(Function(x) x.Id = id).First()
        listaExcuir.Produtos = Nothing
        Banco.Set(Of ListaDeProduto)().Remove(listaExcuir)
        Banco.SaveChanges()
    End Sub

End Class
