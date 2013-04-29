Public Class MinhaClasse

    Public Sub New()

        Dim meuTelefone As New Telefone("Preto", "WP7")
        meuTelefone.Ligar("99750504")
        meuTelefone.Ligar("069", "99750504")
    End Sub

End Class

Class Telefone

    Dim Cor As String
    Dim SO As String

    'Construtor
    Public Sub New(_cor As String, _so As String)
        Cor = _cor
        SO = _so
    End Sub

    'Método
    Public Sub Ligar(numeroDiscar As String)
        'System.Console.WriteLine("Telefone {0} como o Sistema Operacional {1}", Cor, SO)
        Dim texto As String = BemVindo()
        System.Console.WriteLine(texto)
        System.Console.WriteLine("Ligando para {0}", numeroDiscar)
    End Sub

    'Método sobrecarregado
    Public Sub Ligar(ddd As String, numeroDiscar As String)
        'System.Console.WriteLine("Telefone {0} como o Sistema Operacional {1}", Cor, SO)
        Dim texto As String = BemVindo()
        System.Console.WriteLine(texto)
        System.Console.WriteLine("Ligando para {0} - {1}", ddd, numeroDiscar)
    End Sub

    Private Function BemVindo() As String

        Dim texto As String = "Telefone " & Cor & " com sistema operacional " & SO

        Return texto

    End Function

    'Método estático
    Public Shared Sub Discar(numeroDiscar As String)

        System.Console.WriteLine("Ligando para {0}", numeroDiscar)

    End Sub

    'Destrutor
    Protected Overrides Sub Finalize()

        System.Console.WriteLine("Telefone sendo liberado da memória")

    End Sub

End Class