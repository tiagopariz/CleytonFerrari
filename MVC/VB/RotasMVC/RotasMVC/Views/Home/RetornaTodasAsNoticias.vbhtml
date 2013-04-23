@ModelType IEnumerable(Of RotasMVC.Noticia)

@Code
    ViewData("Title") = "Todas As Noticias"
End Code

<h2>Todas As Noticias</h2>
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
</div>
