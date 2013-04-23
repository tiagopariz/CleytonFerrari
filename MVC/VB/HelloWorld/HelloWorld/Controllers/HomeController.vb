Namespace HelloWorld
    Public Class HomeController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Home

        Function Index() As ActionResult
            Return View()
        End Function

        Function Sobre() As ActionResult
            Return View()
        End Function

        'Function Sobre() As String
        '    Return "O Sobre do meu site"
        'End Function

    End Class
End Namespace