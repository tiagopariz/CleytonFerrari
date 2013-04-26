Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class AdicionadoCategoria
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Produtoes", "Categoria", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Produtoes", "Categoria")
        End Sub
    End Class
End Namespace
