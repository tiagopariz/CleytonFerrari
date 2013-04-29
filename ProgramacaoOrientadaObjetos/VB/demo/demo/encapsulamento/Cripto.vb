Public Class Cripto

    Dim valor As String

    Public Sub setValor(texto As String)

        valor = texto.Replace("a", "1")

    End Sub

    Public Function getValor()

        Return valor

    End Function


End Class
