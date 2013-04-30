Public Class Corrente
    'Inherits Conta = Corrente : Conta (C#)
    Inherits Conta

    'Overrides = sobrescrever
    Public Overrides Sub Saque(agencia As String, conta As String, valor As Double)
        valor = valor - (valor * 0.1)

        MyBase.Saque(agencia, conta, valor)

    End Sub

End Class
