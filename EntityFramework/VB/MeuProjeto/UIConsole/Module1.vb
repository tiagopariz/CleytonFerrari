Imports System.Collections.Generic

Module Module1

    Sub Main()

        'Dim banco As New DBProduto()
        Dim app As New ProdutoAplicacao()

        Dim produto01 As New Produto
        With produto01
            '.Id = 1 'Autoincremento
            '.Id = 2
            .Nome = "feijão"
            .Categoria = "Alimentos"
        End With

        'banco.Produtos.Add(produto01)
        'banco.SaveChanges()

        app.Salvar(produto01)
        'app.Alterar(produto01)
        'app.Excluir(2)

        'Dim produtosNoBancoDeDados As IEnumerable(Of Produto) = app.Listar() 'banco.Produtos.ToList()
        'Console.WriteLine("{0} - {1}", produto01.Id, produto01.Nome)
        'Console.WriteLine("{0} - {1}",
        '                  produtosNoBancoDeDados.First().Id,
        '                  produtosNoBancoDeDados.First().Nome)

        For Each produtoNaLista In app.Listar()
            Console.WriteLine("{0} - {1} - {2}", produtoNaLista.Id, produtoNaLista.Nome, produtoNaLista.Categoria)
        Next

        Console.ReadKey()

    End Sub

End Module
