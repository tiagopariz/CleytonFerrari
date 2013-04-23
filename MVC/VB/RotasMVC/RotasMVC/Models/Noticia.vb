Imports System.ComponentModel.DataAnnotations
Imports System.Collections.ObjectModel

Public Class Noticia

    Property NoticiaID As Int32

    Property Titulo As String

    Property Conteudo As String

    Property Categoria As String

    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}")> _
    Property Data As DateTime

    Public Function TodasAsNoticias() As IEnumerable(Of Noticia)

        Dim retorno = New Collection(Of Noticia)() From {
            New Noticia() With {
                .NoticiaID = 1,
                .Categoria = "Esportes",
                .Titulo = "Felipe Massa Ganha F1",
                .Conteudo = "Numa tarde de chuva Felipe Massa ganha F1 no Brasil...",
                .Data = New DateTime(2012, 7, 5)},
            New Noticia() With {
                .NoticiaID = 2,
                .Categoria = "Política",
                .Titulo = "Presidente Assina convênios",
                .Conteudo = "Durante reunião o presidente Ismael Freitas assinou os convênios...",
                .Data = New DateTime(2012, 7, 3)},
            New Noticia() With {
                .NoticiaID = 3,
                .Categoria = "Política",
                .Titulo = "Vereador é eleito pela 4ª vez",
                .Conteudo = "Vereador Fábio Pratt é eleito pela 4ª vez...",
                .Data = New DateTime(2012, 7, 20)},
            New Noticia() With {
                .NoticiaID = 4,
                .Categoria = "Esportes",
                .Titulo = "O tão sonhado título chegou",
                .Conteudo = "Em um jogo que levou os torcedores ao delírio...",
                .Data = New DateTime(2012, 7, 18)},
            New Noticia() With {
                .NoticiaID = 5,
                .Categoria = "Humor",
                .Titulo = "O comediante Anderson Reanto fará show hoje",
                .Conteudo = "O comediante mais engraçado dos comentários do youtube fará um show hoje...",
                .Data = New DateTime(2012, 7, 14)},
            New Noticia() With {
                .NoticiaID = 6,
                .Categoria = "Policial",
                .Titulo = "Tenente coronel Lucas Farias Santos assume o controle",
                .Conteudo = "Durante a retomada do morro o tenente coronel disse...",
                .Data = New DateTime(2012, 7, 19)},
            New Noticia() With {
                .NoticiaID = 7,
                .Categoria = "Esportes",
                .Titulo = "Atacante do barcelona faz 4 gols",
                .Conteudo = "O atacante Lucas Farias Santos Messi, fez 4 gols e decidiu o jogo...",
                .Data = New DateTime(2012, 7, 8)}
        }

        Return retorno

    End Function

End Class
