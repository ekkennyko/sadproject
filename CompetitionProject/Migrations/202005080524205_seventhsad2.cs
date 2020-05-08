namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventhsad2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes");
            DropIndex("dbo.Categories", new[] { "CompetitionId" });
            DropIndex("dbo.Competitions", new[] { "SportTypeId" });
            AddColumn("dbo.Competitions", "CategoryId", c => c.Int());
            AlterColumn("dbo.Competitions", "SportTypeId", c => c.Int());
            CreateIndex("dbo.Competitions", "SportTypeId");
            CreateIndex("dbo.Competitions", "CategoryId");
            AddForeignKey("dbo.Competitions", "CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes", "Id");
            DropColumn("dbo.Categories", "CompetitionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CompetitionId", c => c.Int());
            DropForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes");
            DropForeignKey("dbo.Competitions", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Competitions", new[] { "CategoryId" });
            DropIndex("dbo.Competitions", new[] { "SportTypeId" });
            AlterColumn("dbo.Competitions", "SportTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.Competitions", "CategoryId");
            CreateIndex("dbo.Competitions", "SportTypeId");
            CreateIndex("dbo.Categories", "CompetitionId");
            AddForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions", "CompetitionId");
        }
    }
}
