Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class AdicionadoListaDeProdutos
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.ListaDeProdutoes",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Descricao = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.ListaDeProdutoProdutoes",
                Function(c) New With
                    {
                        .ListaDeProduto_Id = c.Int(nullable := False),
                        .Produto_Id = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.ListaDeProduto_Id, t.Produto_Id }) _
                .ForeignKey("dbo.ListaDeProdutoes", Function(t) t.ListaDeProduto_Id, cascadeDelete := True) _
                .ForeignKey("dbo.Produtoes", Function(t) t.Produto_Id, cascadeDelete := True) _
                .Index(Function(t) t.ListaDeProduto_Id) _
                .Index(Function(t) t.Produto_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.ListaDeProdutoProdutoes", New String() { "Produto_Id" })
            DropIndex("dbo.ListaDeProdutoProdutoes", New String() { "ListaDeProduto_Id" })
            DropForeignKey("dbo.ListaDeProdutoProdutoes", "Produto_Id", "dbo.Produtoes")
            DropForeignKey("dbo.ListaDeProdutoProdutoes", "ListaDeProduto_Id", "dbo.ListaDeProdutoes")
            DropTable("dbo.ListaDeProdutoProdutoes")
            DropTable("dbo.ListaDeProdutoes")
        End Sub
    End Class
End Namespace
