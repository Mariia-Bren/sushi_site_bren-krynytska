namespace sushi_site_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            AddColumn("dbo.Products", "SubCategory_Id", c => c.Int());
            AddColumn("dbo.Products", "SubCategory_Id1", c => c.Int());
            CreateIndex("dbo.Products", "SubCategory_Id");
            CreateIndex("dbo.Products", "SubCategory_Id1");
            AddForeignKey("dbo.Products", "SubCategory_Id", "dbo.SubCategories", "Id");
            AddForeignKey("dbo.Products", "SubCategory_Id1", "dbo.SubCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SubCategory_Id1", "dbo.SubCategories");
            DropForeignKey("dbo.Products", "SubCategory_Id", "dbo.SubCategories");
            DropIndex("dbo.Products", new[] { "SubCategory_Id1" });
            DropIndex("dbo.Products", new[] { "SubCategory_Id" });
            DropColumn("dbo.Products", "SubCategory_Id1");
            DropColumn("dbo.Products", "SubCategory_Id");
            AddForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories", "Id", cascadeDelete: true);
        }
    }
}
