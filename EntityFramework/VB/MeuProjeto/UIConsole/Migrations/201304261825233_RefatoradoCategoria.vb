Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class RefatoradoCategoria
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Categorias",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Descricao = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Produtoes", "Categoria_Id", Function(c) c.Int())
            AddForeignKey("dbo.Produtoes", "Categoria_Id", "dbo.Categorias", "Id")
            CreateIndex("dbo.Produtoes", "Categoria_Id")
            DropColumn("dbo.Produtoes", "Categoria")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Produtoes", "Categoria", Function(c) c.String())
            DropIndex("dbo.Produtoes", New String() { "Categoria_Id" })
            DropForeignKey("dbo.Produtoes", "Categoria_Id", "dbo.Categorias")
            DropColumn("dbo.Produtoes", "Categoria_Id")
            DropTable("dbo.Categorias")
        End Sub
    End Class
End Namespace
