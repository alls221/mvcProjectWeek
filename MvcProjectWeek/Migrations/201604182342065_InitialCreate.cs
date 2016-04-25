namespace MvcProjectWeek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesories",
                c => new
                    {
                        AccesoriesId = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.AccesoriesId);
            
            CreateTable(
                "dbo.Bottoms",
                c => new
                    {
                        BottomsId = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.BottomsId);
            
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        ShoesId = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.ShoesId);
            
            CreateTable(
                "dbo.Tops",
                c => new
                    {
                        TopsId = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.TopsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tops");
            DropTable("dbo.Shoes");
            DropTable("dbo.Bottoms");
            DropTable("dbo.Accesories");
        }
    }
}
