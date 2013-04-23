@Code
    ViewData("Title") = "Index"
End Code

<h1>Página inicial</h1>

<div class="row-fluid">
    <div class="hero-unit">
        <h1>ASP.NET MVC</h1>
        <p>
            Esta é uma série de vídeos sobre asp.net mvc, usando os novos recursos do mvc 4
        </p>
        <p>
            <a class="btn btn-primary btn-large">Saiba mais</a>
        </p>
    </div>
</div>

@section rodape
    
    <p>Veja mais em @Html.ActionLink("Sobre","Index","Sobre")</p>

End Section