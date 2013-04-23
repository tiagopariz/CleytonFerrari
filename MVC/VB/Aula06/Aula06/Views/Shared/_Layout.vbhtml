<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/bootstrap")

    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")

</head>
<body>
    <div class="container">
        @RenderPage("~/Views/Shared/_Topo.vbhtml")
        <div class="row">
            @Html.Partial("_MenuLateral")
            <div class="span9">
                @RenderBody()
            </div>
        </div>
        <div class="row">
            <hr />
            <footer class="pull-right">
                @If IsSectionDefined("rodape") Then
                    @RenderSection("rodape")
                Else
                    @Html.Partial("_Rodape")
                End If
            </footer>
        </div>
    </div>
</body>
</html>
