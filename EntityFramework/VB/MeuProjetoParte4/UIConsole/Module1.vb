Imports System.Collections.Generic
Imports Aplicacao
Imports Dominio

Module Module1

    Sub Main()
        '''''''''AULA 01'''''''''''
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

        '''''''''AULA 02'''''''''''
        'Dim appCategoria As CategoriaAplicacao = New CategoriaAplicacao
        'Dim cat01 As New Categoria
        'cat01.Id = 1
        'cat01.Descricao = "Enlatados Grandes"
        ''appCategoria.Salvar(cat01)
        'appCategoria.Alterar(cat01)
        'Dim appProduto As New ProdutoAplicacao
        'Dim prod01 As New Produto
        'prod01.Nome = "Açúcar"
        'prod01.Categoria = appCategoria.Listar().Where(Function(x) x.Id = 4).FirstOrDefault()
        ''appProduto.Salvar(prod01)
        'Console.WriteLine("Listagem de Produtos")
        'Dim listaDeProdutos = appProduto.Listar()
        'For Each Produto In listaDeProdutos
        '    Console.WriteLine("{0} - {1} - {2}", Produto.Id, Produto.Nome, Produto.Categoria.Descricao)
        'Next
        'Console.WriteLine("Listagem de categorias")
        'Dim listaDeCategorias = appCategoria.Listar()
        'For Each categoria In listaDeCategorias
        '    Console.WriteLine("{0} - {1}", categoria.Id, categoria.Descricao)
        'Next

        '''''''''AULA 03'''''''''''
        'Dim appLista As New ListaDeProdutoAplicacao
        'Dim appProduto As New ProdutoAplicacao

        'Dim lista01 = appLista.Listar().LastOrDefault()  'Where(Function(x) x.Id = 1).FirstOrDefault()  'As New ListaDeProduto()
        'lista01.Descricao = "Cesta Basica de Rico"
        'lista01.Produtos = appProduto.Listar().ToList() '.Where(Function(x) x.Categoria.Id = 2).ToList()

        ''appLista.Salvar(lista01)
        ''appLista.Alterar(lista01)
        'appLista.Excluir(lista01.Id)

        'Dim listas = appLista.Listar()

        'For Each lista In listas
        '    Console.WriteLine("{0} - {1}", lista.Id, lista.Descricao)
        '    For Each Produto In lista.Produtos
        '        Console.WriteLine("     {0} - {1}", Produto.Id, Produto.Nome)
        '    Next
        'Next

        '''''''''AULA 04'''''''''''
        Dim appCategoria As New CategoriaAplicacao()
        'Dim objCategoria As New Categoria() With {.Descricao = "Enlatados"}
        'appCategoria.Salvar(objCategoria)
        'Dim listaDeCategorias = appCategoria.Listar()
        'For Each listaDeCategoria In listaDeCategorias
        '    Console.WriteLine("{0}", listaDeCategoria.Descricao)
        'Next

        'Produto
        Dim appProduto As New ProdutoAplicacao()
        'Dim objProduto As New Produto() With {.Nome = "Sardinha",
        '                                      .Categoria = appCategoria.Listar().FirstOrDefault()}
        'appProduto.Salvar(objProduto)
        'Dim listaDeProdutos = appProduto.Listar()
        'For Each ListaDeProduto In listaDeProdutos
        '    Console.WriteLine("{0} - {1}",
        '                      ListaDeProduto.Nome,
        '                      ListaDeProduto.Categoria.Descricao)
        'Next

        'Lista de produtos
        Dim appLista As New ListaDeProdutoAplicacao()
        Dim objListaProdutos As New ListaDeProduto() With {.Descricao = "Lista de Compras do Cleyton"}
        Dim produto1 = appProduto.Listar().FirstOrDefault()
        objListaProdutos.Produtos = New List(Of Produto)
        objListaProdutos.Produtos.Add(produto1)
        appLista.Salvar(objListaProdutos)
        Dim listas = appLista.Listar()
        For Each listaDeProduto In listas
            Console.WriteLine("{0}", listaDeProduto.Descricao)
            For Each produto In listaDeProduto.Produtos
                Console.WriteLine("     {0} - {1}", produto.Nome, produto.Categoria.Descricao)
            Next
        Next
        Console.ReadKey()

    End Sub

End Module
