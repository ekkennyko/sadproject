namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthSad3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "SportTypeId", "dbo.SportTypes");
            DropIndex("dbo.Categories", new[] { "SportTypeId" });
            RenameColumn(table: "dbo.Categories", name: "SportTypeId", newName: "SportType_SportTypeId");
            AddColumn("dbo.Categories", "CompetitionId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "SportType_SportTypeId", c => c.Int());
            CreateIndex("dbo.Categories", "CompetitionId");
            CreateIndex("dbo.Categories", "SportType_SportTypeId");
            AddForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions", "CompetitionId", cascadeDelete: true);
            AddForeignKey("dbo.Categories", "SportType_SportTypeId", "dbo.SportTypes", "SportTypeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "SportType_SportTypeId", "dbo.SportTypes");
            DropForeignKey("dbo.Categories", "CompetitionId", "dbo.Competitions");
            DropIndex("dbo.Categories", new[] { "SportType_SportTypeId" });
            DropIndex("dbo.Categories", new[] { "CompetitionId" });
            AlterColumn("dbo.Categories", "SportType_SportTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.Categories", "CompetitionId");
            RenameColumn(table: "dbo.Categories", name: "SportType_SportTypeId", newName: "SportTypeId");
            CreateIndex("dbo.Categories", "SportTypeId");
            AddForeignKey("dbo.Categories", "SportTypeId", "dbo.SportTypes", "SportTypeId", cascadeDelete: true);
        }
    }
}
