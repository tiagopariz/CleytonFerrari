Public Class Conta

    'Overridable = virtual do C# e Sub = void do C#
    Public Overridable Sub Saque(agencia As String, conta As String, valor As Double)
        System.Console.WriteLine("Saque, Ag.: {0} C/C.: {1} Valor R$ {2:00}", agencia, conta, valor)
    End Sub

End Class
