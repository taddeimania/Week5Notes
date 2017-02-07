namespace Day2MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BlogPostId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogPosts", t => t.BlogPostId, cascadeDelete: true)
                .Index(t => t.BlogPostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "BlogPostId", "dbo.BlogPosts");
            DropIndex("dbo.Tags", new[] { "BlogPostId" });
            DropTable("dbo.Tags");
        }
    }
}
