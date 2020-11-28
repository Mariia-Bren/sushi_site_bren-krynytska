namespace sushi_site_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ar : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropColumn("dbo.SubCategories", "CategoryId");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SubCategories", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.SubCategories", "CategoryId");
            AddForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
