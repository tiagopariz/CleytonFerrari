@ModelType IEnumerable(Of RotasMVC.Noticia)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Rotas em ASP.NET MVC</h2>

<div>
    <ul>
        @For Each item In ViewBag.Categorias
            @<li>
                @Html.ActionLink(item, "MostraCategoria", "Home", New With {.categoria = item}, Nothing)
            </li>
        Next
    </ul>
</div>

<div>
    <ul>
        @For Each item In Model
            @<li>
                @Html.ActionLink(item.Titulo, "MostraNoticia", "Home", New With
                                                                       {
                                                                           .noticiaid = item.NoticiaID,
                                                                           .categoria = item.Categoria.ToLower(),
                                                                           .titulo = item.Titulo.ToLower()
                                                                       }, Nothing)
                <em>@Html.DisplayFor(Function(ModelItem) item.Categoria)</em>
                <b>@Html.DisplayFor(Function(ModelItem) item.Data)</b>
            </li>
        Next
    </ul>
    <div>
        @Html.ActionLink("Todas as Notícias", "RetornaTodasAsNoticias", "Home")
    </div>
</div>
