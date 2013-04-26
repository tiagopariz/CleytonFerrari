Imports System.Collections.Generic

Module Module1

    Sub Main()

        'Dim banco As New DBProduto()
        'Dim app As New ProdutoAplicacao()

        'Dim produto01 As New Produto
        'With produto01
        '    '.Id = 1 'Autoincremento
        '    '.Id = 2
        '    .Nome = "feijão"
        '    '.Categoria = "Alimentos"
        'End With

        'banco.Produtos.Add(produto01)
        'banco.SaveChanges()

        'app.Salvar(produto01)
        'app.Alterar(produto01)
        'app.Excluir(2)

        'Dim produtosNoBancoDeDados As IEnumerable(Of Produto) = app.Listar() 'banco.Produtos.ToList()
        'Console.WriteLine("{0} - {1}", produto01.Id, produto01.Nome)
        'Console.WriteLine("{0} - {1}",
        '                  produtosNoBancoDeDados.First().Id,
        '                  produtosNoBancoDeDados.First().Nome)

        'For Each produtoNaLista In app.Listar()
        '    Console.WriteLine("{0} - {1} - {2}", produtoNaLista.Id, produtoNaLista.Nome, produtoNaLista.Categoria)
        'Next

        'Console.ReadKey()

        Dim appCategoria As CategoriaAplicacao = New CategoriaAplicacao

        Dim cat01 As New Categoria
        cat01.Id = 1
        cat01.Descricao = "Enlatados Grandes"

        'appCategoria.Salvar(cat01)
        appCategoria.Alterar(cat01)

        Dim appProduto As New ProdutoAplicacao
        Dim prod01 As New Produto

        prod01.Nome = "Açúcar"
        prod01.Categoria = appCategoria.Listar().Where(Function(x) x.Id = 4).FirstOrDefault()

        'appProduto.Salvar(prod01)

        Console.WriteLine("Listagem de Produtos")

        Dim listaDeProdutos = appProduto.Listar()

        For Each Produto In listaDeProdutos
            Console.WriteLine("{0} - {1} - {2}", Produto.Id, Produto.Nome, Produto.Categoria.Descricao)
        Next

        Console.WriteLine("Listagem de categorias")

        Dim listaDeCategorias = appCategoria.Listar()

        For Each categoria In listaDeCategorias
            Console.WriteLine("{0} - {1}", categoria.Id, categoria.Descricao)
        Next

        Console.ReadKey()

    End Sub

End Module
