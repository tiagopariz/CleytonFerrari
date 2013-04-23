@ModelType PostGetModel.Pessoa

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

@*<p>@ViewData("PessoaID")</p>
<p>@ViewData("Nome")</p>
<p>@ViewData("Twitter")</p>*@

@*<p>@ViewBag.PessoaID</p>
<p>@ViewBag.NomeDaPessoa</p>
<p>@ViewBag.Twitter</p>*@

@*<p>@Model.PessoaID</p>
<p>@Model.Nome</p>
<p>@Model.Twitter</p>*@

@*<form action="Home/Lista" method="get">*@
@*<form action="Home/Lista" method="post">*@
@Using (Html.BeginForm("Lista", "Home", FormMethod.Post))
    @<fieldset>
        <legend>Pessoa</legend>
        <div>  
            @*<label for="PessoaID">Código</label>*@
            @Html.LabelFor(Function(m) m.PessoaID)
        </div>
        <div>
            @*<input type="number" value="@Model.PessoaID" id="PessoaID" name="PessoaID" />*@
            @Html.EditorFor(Function(m) m.PessoaID)
        </div>
        <div>
            @*<label for="Nome">Nome</label>*@
            @Html.LabelFor(Function(m) m.Nome)
        </div>
        <div>
            @*<input type="text" value="@Model.Nome" id="Nome" name="Nome" />*@
            @Html.EditorFor(Function(m) m.Nome)
        </div>
        <div>
            @*<label for="Twitter">Twitter</label>*@
            @Html.LabelFor(Function(m) m.Twitter)
        </div>
        <div>
            @*<input type="text" value="@Model.Twitter" id="Twitter" name="Twitter" />*@
            @Html.EditorFor(Function(m) m.Twitter)
        </div>
        <p>
            <input type="submit" value="Enviar" />
        </p>
    </fieldset>
    
End Using

@*</form>*@