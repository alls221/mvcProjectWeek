namespace MvcProjectWeek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accesories", "Photo", c => c.String());
            AddColumn("dbo.Bottoms", "Photo", c => c.String());
            AddColumn("dbo.Shoes", "Photo", c => c.String());
            AddColumn("dbo.Tops", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tops", "Photo");
            DropColumn("dbo.Shoes", "Photo");
            DropColumn("dbo.Bottoms", "Photo");
            DropColumn("dbo.Accesories", "Photo");
        }
    }
}
