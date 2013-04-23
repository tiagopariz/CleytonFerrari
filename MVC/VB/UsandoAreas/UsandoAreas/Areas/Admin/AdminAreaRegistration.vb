Namespace Areas.Admin
    Public Class AdminAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "Admin"
            End Get
        End Property

        Public Overrides Sub RegisterArea(ByVal context As System.Web.Mvc.AreaRegistrationContext)
            context.MapRoute( _
                "Admin_default", _
               "Admin/{controller}/{action}/{id}", _
                New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}, _
                namespaces:=New String() {"UsandoAreas.Areas.Admin.Controller"}
            )
        End Sub
    End Class
End Namespace

