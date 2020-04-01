namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthSad : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "SportType_SportTypeId", "dbo.SportTypes");
            DropForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionResults", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionJudges", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionOrganizators", "CompetitionId", "dbo.Competitions");
            DropIndex("dbo.Categories", new[] { "CompetitionId" });
            DropIndex("dbo.Categories", new[] { "SportType_SportTypeId" });
            DropIndex("dbo.CompetitionResults", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionJudges", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionOrganizators", new[] { "CompetitionId" });
            AddColumn("dbo.SportTypes", "CompetitionId", c => c.Int());
            AlterColumn("dbo.Categories", "CompetitionId", c => c.Int());
            AlterColumn("dbo.CompetitionResults", "CompetitionId", c => c.Int());
            AlterColumn("dbo.CompetitionJudges", "CompetitionId", c => c.Int());
            AlterColumn("dbo.CompetitionOrganizators", "CompetitionId", c => c.Int());
            CreateIndex("dbo.Categories", "CompetitionId");
            CreateIndex("dbo.CompetitionResults", "CompetitionId");
            CreateIndex("dbo.CompetitionJudges", "CompetitionId");
            CreateIndex("dbo.CompetitionOrganizators", "CompetitionId");
            AddForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions", "CompetitionId");
            AddForeignKey("dbo.CompetitionResults", "CompetitionId", "dbo.Competitions", "CompetitionId");
            AddForeignKey("dbo.CompetitionJudges", "CompetitionId", "dbo.Competitions", "CompetitionId");
            AddForeignKey("dbo.CompetitionOrganizators", "CompetitionId", "dbo.Competitions", "CompetitionId");
            DropColumn("dbo.Categories", "SportType_SportTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "SportType_SportTypeId", c => c.Int());
            DropForeignKey("dbo.CompetitionOrganizators", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionJudges", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionResults", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions");
            DropIndex("dbo.CompetitionOrganizators", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionJudges", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionResults", new[] { "CompetitionId" });
            DropIndex("dbo.Categories", new[] { "CompetitionId" });
            AlterColumn("dbo.CompetitionOrganizators", "CompetitionId", c => c.Int(nullable: false));
            AlterColumn("dbo.CompetitionJudges", "CompetitionId", c => c.Int(nullable: false));
            AlterColumn("dbo.CompetitionResults", "CompetitionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "CompetitionId", c => c.Int(nullable: false));
            DropColumn("dbo.SportTypes", "CompetitionId");
            CreateIndex("dbo.CompetitionOrganizators", "CompetitionId");
            CreateIndex("dbo.CompetitionJudges", "CompetitionId");
            CreateIndex("dbo.CompetitionResults", "CompetitionId");
            CreateIndex("dbo.Categories", "SportType_SportTypeId");
            CreateIndex("dbo.Categories", "CompetitionId");
            AddForeignKey("dbo.CompetitionOrganizators", "CompetitionId", "dbo.Competitions", "CompetitionId", cascadeDelete: true);
            AddForeignKey("dbo.CompetitionJudges", "CompetitionId", "dbo.Competitions", "CompetitionId", cascadeDelete: true);
            AddForeignKey("dbo.CompetitionResults", "CompetitionId", "dbo.Competitions", "CompetitionId", cascadeDelete: true);
            AddForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions", "CompetitionId", cascadeDelete: true);
            AddForeignKey("dbo.Categories", "SportType_SportTypeId", "dbo.SportTypes", "SportTypeId");
        }
    }
}
