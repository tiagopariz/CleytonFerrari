@ModelType RotasMVC.Noticia

@Code
    ViewData("Title") = Model.Titulo 
End Code

<h2>@Model.Titulo </h2>
<em>
    @Model.Data - @Html.ActionLink(Model.Categoria, "MostraCategoria", "Home", New With {.categoria = Model.Categoria}, Nothing)
</em>
<div>
    @Model.Conteudo
</div>
