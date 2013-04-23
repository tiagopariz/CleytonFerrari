Imports System.Collections.ObjectModel

Namespace ExemploValidacao
    Public Class PessoaController
        Inherits System.Web.Mvc.Controller

        Function Index() As ActionResult
            Dim pessoa As New Pessoa()
            Return View(pessoa)
        End Function

        <HttpPost> _
        Function Index(pessoa As Pessoa) As ActionResult

            'Validando o campo nome
            'If String.IsNullOrEmpty(pessoa.Nome) Then
            '    ModelState.AddModelError("Nome", "O campo Nome é obrigatório ¬¬")
            'End If
            'Validando o modelo
            'If pessoa.Senha <> pessoa.ConfirmarSenha Then
            '    ModelState.AddModelError("", "As senhas não conferem :-O")
            'End If

            If ModelState.IsValid Then
                Return View("Resultado", pessoa)
            End If

            Return View(pessoa)

        End Function

        Function Resultado(pessoa As Pessoa) As ActionResult
            Return View(pessoa)
        End Function

        Function LoginUnico(login As String) As ActionResult

            Dim bancoDeNomesDeExemplo = New Collection(Of String) From {
                "Cleyton",
                "Anderson",
                "Tiago"}

            Return Json(bancoDeNomesDeExemplo.All(Function(x) x.ToLower() <> login.ToLower()), JsonRequestBehavior.AllowGet)

        End Function

        'string login = "";
        'var banco = new Collection<string>
        '    {
        '        "Cleyton"
        '    };
        'return Json(banco.All(x => x.ToLower() != loginToLower()));

    End Class
End Namespace