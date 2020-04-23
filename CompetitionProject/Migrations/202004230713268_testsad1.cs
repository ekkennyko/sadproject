namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testsad1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SportTypes", "SportTypeId", "dbo.Competitions");
            DropIndex("dbo.SportTypes", new[] { "SportTypeId" });
            AddColumn("dbo.Competitions", "SportTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Competitions", "SportTypeId");
            AddForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes", "SportTypeId", cascadeDelete: true);
            DropColumn("dbo.SportTypes", "CompetitionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SportTypes", "CompetitionId", c => c.Int());
            DropForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes");
            DropIndex("dbo.Competitions", new[] { "SportTypeId" });
            DropColumn("dbo.Competitions", "SportTypeId");
            CreateIndex("dbo.SportTypes", "SportTypeId");
            AddForeignKey("dbo.SportTypes", "SportTypeId", "dbo.Competitions", "CompetitionId");
        }
    }
}
