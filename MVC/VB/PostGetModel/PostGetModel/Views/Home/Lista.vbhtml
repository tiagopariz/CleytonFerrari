@ModelType PostGetModel.Pessoa 

@Code
    ViewData("Title") = "Lista"
End Code

<h2>Lista</h2>
<div>
    @*<b>PessoaID</b>*@
    @Html.LabelFor(Function(m) m.PessoaID)
</div>
<div>
    @*@ViewData("PessoaID")*@
    @Model.PessoaID 
</div>
<div>
    @*<b>Nome</b>*@
    @Html.LabelFor(Function(m) m.Nome)
</div>
<div>
    @*@ViewData("Nome")*@
    @Model.Nome 
</div>
<div>
    @*<b>Twitter</b>*@
    @Html.LabelFor(Function(m) m.Twitter)
</div>
<div>
    @*@ViewData("Twitter")*@
    @Model.Twitter
</div>

@*<a href="~/" title="Voltar">Voltar</a>*@
@Html.ActionLink("Voltar", "Index", "Home")
