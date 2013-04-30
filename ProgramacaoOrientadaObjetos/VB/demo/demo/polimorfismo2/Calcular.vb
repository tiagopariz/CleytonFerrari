Public Class Calcular
    Public Sub MostrarResultado(operacao As Operacao, n1 As Double, n2 As Double)

        Dim resultado As Double = operacao.Calcular(n1, n2)
        System.Console.WriteLine("Resultado: {0}", resultado)
    End Sub
End Class
