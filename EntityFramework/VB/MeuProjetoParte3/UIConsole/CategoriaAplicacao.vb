Public Class CategoriaAplicacao

    Public Property banco As DBProduto

    Public Sub New()

        banco = New DBProduto()

    End Sub

    Public Sub Salvar(categoria As Categoria)

        banco.Categorias.Add(categoria)
        banco.SaveChanges()

    End Sub

    Public Function Listar() As IEnumerable(Of Categoria)

        Return banco.Categorias.ToList()

    End Function

    Public Sub Alterar(categoria As Categoria)

        Dim categoriaSalvar As Categoria = banco.Categorias.Where(Function(x) x.Id = categoria.Id).First()
        categoriaSalvar.Descricao = categoria.Descricao
        banco.SaveChanges()

    End Sub

    Public Sub Excluir(Id As Int32)

        Dim categoriExcluir As Categoria = banco.Categorias.Where(Function(x) x.Id = Id).First()
        banco.Set(Of Categoria).Remove(categoriExcluir)
        banco.SaveChanges()

    End Sub

End Class
