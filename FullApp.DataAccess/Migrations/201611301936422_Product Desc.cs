namespace FullApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductDesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Desc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Desc");
        }
    }
}
