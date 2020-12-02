namespace sushi_site_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kmk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Cost", c => c.Int(nullable: false));
        }
    }
}
