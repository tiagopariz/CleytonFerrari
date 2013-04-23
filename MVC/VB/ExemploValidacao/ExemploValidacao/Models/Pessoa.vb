Imports System.ComponentModel.DataAnnotations

Public Class Pessoa

    <Required(ErrorMessage:="O nome deve ser preenchido")> _
    Property Nome As String

    <StringLength(50, MinimumLength:=5, ErrorMessage:="A observação deve ter entre 5 e 50 caracteres")> _
    <Required(ErrorMessage:="Preencha a observação")>
    Property Observacao As String

    <Range(18, 50, ErrorMessage:="A idade da pessoa deve ser entre 18 e 50 anos")> _
    <Required(ErrorMessage:="Informe uma idade")> _
    Property Idade As Int32

    <RegularExpression("\b[a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}\b", ErrorMessage:="O email informado não é válido :-@")> _
    Property Email As String

    <RegularExpression("[a-zA-Z]{5,15}", ErrorMessage:="O login deve possuir somente letras e deve ter de 5 a 15 caracteres")> _
    <Required(ErrorMessage:="O login deve ser preenchido")> _
    <Remote("LoginUnico", "Pessoa", ErrorMessage:="Este nome de login já existe")> _
    Property Login As String

    <Required(ErrorMessage:="A senha deve ser informada")> _
    Property Senha As String

    <Compare("Senha", ErrorMessage:="As senhas não conferem")> _
    Property ConfirmarSenha As String

End Class
