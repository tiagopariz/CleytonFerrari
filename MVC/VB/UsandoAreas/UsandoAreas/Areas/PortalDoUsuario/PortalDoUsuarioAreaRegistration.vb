Namespace Areas.PortalDoUsuario
    Public Class PortalDoUsuarioAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "PortalDoUsuario"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As System.Web.Mvc.AreaRegistrationContext)
            context.MapRoute( _
                "PortalDoUsuario_default", _
               "PortalDoUsuario/{controller}/{action}/{id}", _
                New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}, _
                namespaces:=New String() {"UsandoAreas.Areas.PortalDoUsuario.Controller"}
            )
        End Sub
    End Class
End Namespace

