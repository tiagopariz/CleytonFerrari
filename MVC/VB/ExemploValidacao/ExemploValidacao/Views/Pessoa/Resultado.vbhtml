@ModelType ExemploValidacao.Pessoa 

@Code
    ViewData("Title") = "Lista dados da pessoa válida"
End Code

<h2>Lista dados da pessoa válida</h2>
<fieldset>
    <legend>Pessoa</legend>
    <div class="display-label">
        @Html.DisplayNameFor(Function(m) m.Nome)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(m) m.Nome)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(m) m.Observacao)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(m) m.Observacao)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(m) m.Idade)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(m) m.Idade)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(m) m.Email)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(m) m.Email)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(m) m.Login)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(m) m.Login)
    </div>

    <p>
        @Html.ActionLink("Voltar", "Index")
    </p>
</fieldset>