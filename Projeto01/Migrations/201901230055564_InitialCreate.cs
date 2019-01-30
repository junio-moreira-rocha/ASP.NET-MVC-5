namespace Projeto01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Fabricantes",
                c => new
                    {
                        FabricanteId = c.Long(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.FabricanteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fabricantes");
            DropTable("dbo.Categorias");
        }
    }
}
