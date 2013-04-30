Imports Demo.Operacao
Module Inicio

    Sub Main()

        ''Classe''
        'Dim mm As New MinhaClasse()
        'Telefone.Discar("9975-0504")

        ''Composição''
        'Dim r1 As New Roda()
        'r1.cor = "Azul"
        'r1.aro = "22"
        'Dim r2 As New Roda()
        'r2.aro = 22
        'r2.cor = "Vermelho"
        'Dim minhaMoto As New Moto("Azul", r1, r2)

        ''Encapsulamento''
        'Dim cp As New Cripto()
        'cp.setValor("aeiou")
        'System.Console.WriteLine(cp.getValor())

        ''Herança''
        'Dim eu As New Homem()
        'eu.Idade = 30
        'eu.Nome = "Cleyton Ferrari"
        'eu.tamanhoBarba = 0
        'Dim mi As New Mulher()
        'mi.TamanhoDoBusto = 80
        'mi.Nome = "Miele Casarin"
        'mi.Idade = 28

        ''Polimorfismo''
        'Dim m1 As New Leao()
        'Dim m1 As New Gorila()
        'm1.Andar()
        'Dim op As New Subtracao()
        'Dim op As New Soma()
        'Dim n1 As Double = 5, n2 = 5
        'Dim c As New Calcular()
        'c.MostrarResultado(op, n1, n2)

        ''Sobreposição''
        Dim p1 As New Poupanca
        p1.Saque("88888-8", "1234-5", 100)

        Dim c1 As New Corrente
        c1.Saque("77777-7", "5432-1", 100)

        Console.ReadKey()

    End Sub

End Module
