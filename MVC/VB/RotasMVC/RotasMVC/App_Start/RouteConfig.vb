Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Class RouteConfig
    Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        routes.MapRoute(
            name:="RetornaTodasAsNoticias",
            url:="noticias/",
            defaults:=New With {.controller = "Home", .action = "RetornaTodasAsNoticias"})

        routes.MapRoute(
            name:="CategoriaEspecifica",
            url:="noticias/{categoria}",
            defaults:=New With {.controller = "Home", .action = "MostraCategoria"})

        routes.MapRoute(
            name:="MostraNoticia",
            url:="noticias/{categoria}/{titulo}-{noticiaid}",
            defaults:=New With {.controller = "Home", .action = "MostraNoticia"}) ', .id = "\d+"})

        routes.MapRoute( _
            name:="Default", _
            url:="{controller}/{action}/{id}", _
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional} _
        )
    End Sub
End Class