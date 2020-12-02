namespace sushi_site_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asfghn : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "SubCategory_Id", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Products", name: "SubCategory_Id1", newName: "SubCategory_Id");
            RenameColumn(table: "dbo.Products", name: "__mig_tmp__0", newName: "SubCategory_Id1");
            RenameIndex(table: "dbo.Products", name: "IX_SubCategory_Id1", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.Products", name: "IX_SubCategory_Id", newName: "IX_SubCategory_Id1");
            RenameIndex(table: "dbo.Products", name: "__mig_tmp__0", newName: "IX_SubCategory_Id");
            DropColumn("dbo.Orders", "City");
            DropColumn("dbo.Orders", "State");
            DropColumn("dbo.Orders", "PostalCode");
            DropColumn("dbo.Orders", "Country");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Country", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Orders", "State", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "City", c => c.String(nullable: false, maxLength: 40));
            RenameIndex(table: "dbo.Products", name: "IX_SubCategory_Id", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.Products", name: "IX_SubCategory_Id1", newName: "IX_SubCategory_Id");
            RenameIndex(table: "dbo.Products", name: "__mig_tmp__0", newName: "IX_SubCategory_Id1");
            RenameColumn(table: "dbo.Products", name: "SubCategory_Id1", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.Products", name: "SubCategory_Id", newName: "SubCategory_Id1");
            RenameColumn(table: "dbo.Products", name: "__mig_tmp__0", newName: "SubCategory_Id");
        }
    }
}
