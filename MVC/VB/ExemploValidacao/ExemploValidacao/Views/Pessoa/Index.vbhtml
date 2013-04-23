@ModelType ExemploValidacao.Pessoa 

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

@Using (Html.BeginForm())
    
    @Html.ValidationSummary(True)
    @<fieldset>
        <legend>Dados da Pessoa</legend>
        <div class="editor-label">
            @Html.LabelFor(Function(m) m.Nome)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(m) m.Nome)
            @Html.ValidationMessageFor(Function(m) m.Nome)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(m) m.Observacao)
        </div>
        <div class="editor-field">
            @Html.TextAreaFor(Function(m) m.Observacao)
            @Html.ValidationMessageFor(Function(m) m.Observacao)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(m) m.Idade)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(m) m.Idade)
            @Html.ValidationMessageFor(Function(m) m.Idade)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(m) m.Email)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(m) m.Email)
            @Html.ValidationMessageFor(Function(m) m.Email)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(m) m.Login)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(m) m.Login)
            @Html.ValidationMessageFor(Function(m) m.Login)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(m) m.Senha)
        </div>
        <div class="editor-field">
            @Html.PasswordFor(Function(m) m.Senha)
            @Html.ValidationMessageFor(Function(m) m.Senha)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(m) m.ConfirmarSenha)
        </div>
        <div class="editor-field">
            @Html.PasswordFor(Function(m) m.ConfirmarSenha)
            @Html.ValidationMessageFor(Function(m) m.ConfirmarSenha)
        </div>

        <p>
            <input type="submit" value="Cadastrar" />
        </p>

     </fieldset>

End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section