namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthSad34 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.CompetitionResults", "CompResId");
            AddForeignKey("dbo.CompetitionResults", "CompResId", "dbo.Reports", "ReportId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompetitionResults", "CompResId", "dbo.Reports");
            DropIndex("dbo.CompetitionResults", new[] { "CompResId" });
        }
    }
}
