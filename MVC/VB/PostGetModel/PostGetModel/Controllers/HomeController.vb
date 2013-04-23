Namespace PostGetModel
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Home
        <HttpGet> _
        Function Index() As ActionResult
            Dim pessoa As New Pessoa
            With pessoa
                .PessoaID = 1
                .Nome = "Tiago Pariz"
                .Twitter = "@tiagopariz"
            End With

            'ViewData("PessoaID") = pessoa.PessoaID
            'ViewData("Nome") = pessoa.Nome
            'ViewData("Twitter") = pessoa.Twitter

            'ViewBag.PessoaID = pessoa.PessoaID
            'ViewBag.NomeDaPessoa = pessoa.Nome
            'ViewBag.Twitter = pessoa.Twitter

            Return View(pessoa)
        End Function

        '<HttpGet> _
        'Function Lista(PessoaID As Int32, Nome As String, Twitter As String) As ActionResult
        'Function Lista(form As FormCollection) As ActionResult
        <HttpPost> _
        Function Lista(pessoa As Pessoa) As ActionResult

            'ViewData("PessoaID") = PessoaID
            'ViewData("Nome") = Nome
            'ViewData("Twitter") = Twitter

            'ViewData("PessoaID") = form("PessoaID")
            'ViewData("Nome") = form("Nome")
            'ViewData("Twitter") = form("Twitter")

            'ViewData("PessoaID") = pessoa.PessoaID
            'ViewData("Nome") = pessoa.Nome
            'ViewData("Twitter") = pessoa.Twitter

            Return View(pessoa)
        End Function

    End Class
End Namespace