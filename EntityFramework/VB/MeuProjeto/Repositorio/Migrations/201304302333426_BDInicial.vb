Imports System
Imports System.Data.Entity.Migrations

Namespace Migrations
    Public Partial Class BDInicial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Produtoes",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Nome = c.String(),
                        .Categoria_Id = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.Categorias", Function(t) t.Categoria_Id) _
                .Index(Function(t) t.Categoria_Id)
            
            CreateTable(
                "dbo.Categorias",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Descricao = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
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
            DropIndex("dbo.Produtoes", New String() { "Categoria_Id" })
            DropForeignKey("dbo.ListaDeProdutoProdutoes", "Produto_Id", "dbo.Produtoes")
            DropForeignKey("dbo.ListaDeProdutoProdutoes", "ListaDeProduto_Id", "dbo.ListaDeProdutoes")
            DropForeignKey("dbo.Produtoes", "Categoria_Id", "dbo.Categorias")
            DropTable("dbo.ListaDeProdutoProdutoes")
            DropTable("dbo.ListaDeProdutoes")
            DropTable("dbo.Categorias")
            DropTable("dbo.Produtoes")
        End Sub
    End Class
End Namespace
