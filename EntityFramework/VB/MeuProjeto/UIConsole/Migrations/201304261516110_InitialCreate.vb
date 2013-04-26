Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Produtoes",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Nome = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Produtoes")
        End Sub
    End Class
End Namespace
