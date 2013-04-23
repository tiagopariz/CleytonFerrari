Namespace RotasMVC
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        Public Sub New()

            todasAsNoticiasValue =
                New Noticia().TodasAsNoticias.OrderByDescending(Function(x) x.Data)

        End Sub

        Dim todasAsNoticiasValue As IEnumerable(Of Noticia)
        ReadOnly Property todasAsNoticias As IEnumerable(Of Noticia)
            Get
                Return todasAsNoticiasValue
            End Get
        End Property

        Function Index() As ActionResult
            Dim ultimasNoticias = todasAsNoticias.Take(3)
            Dim todasAsCategorias = todasAsNoticias.Select(Function(x) x.Categoria).Distinct().ToList()

            ViewBag.Categorias = todasAsCategorias

            Return View(ultimasNoticias)
        End Function

        Function RetornaTodasAsNoticias() As ActionResult
            Return View(todasAsNoticias)
        End Function

        Function MostraNoticia(noticiaid As Int32, titulo As String, categoria As String) As ActionResult
            Return View(todasAsNoticias.FirstOrDefault(Function(x) x.NoticiaID = noticiaid))
        End Function

        Function MostraCategoria(categoria As String) As ActionResult

            Dim categoriaEspecifica = todasAsNoticias.Where(Function(x) x.Categoria.ToLower() = categoria.ToLower()).ToList()
            ViewBag.Categoria = categoria
            Return View(categoriaEspecifica)

        End Function

    End Class
End Namespace