<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <h1>Meusite.com.br</h1>
    @Html.ActionLink("Home", "Index", "Home")
    @Html.ActionLink("Veja o sobre", "Sobre", "Home") 

    @RenderBody()

    @Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required:=False)

    <footer>
        <p>
            Meusite.com.br todos os direitos reservados
        </p>
    </footer>

</body>
</html>
