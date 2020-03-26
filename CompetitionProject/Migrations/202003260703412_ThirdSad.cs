namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdSad : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "SportTypeId", "dbo.SportTypes");
            DropIndex("dbo.SportTypes", new[] { "SportTypeId" });
            DropIndex("dbo.Reports", new[] { "ReportId" });
            DropPrimaryKey("dbo.SportTypes");
            DropPrimaryKey("dbo.Reports");
            AlterColumn("dbo.SportTypes", "SportTypeId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Reports", "ReportId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SportTypes", "SportTypeId");
            AddPrimaryKey("dbo.Reports", "ReportId");
            CreateIndex("dbo.SportTypes", "SportTypeId");
            CreateIndex("dbo.Reports", "ReportId");
            AddForeignKey("dbo.Categories", "SportTypeId", "dbo.SportTypes", "SportTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "SportTypeId", "dbo.SportTypes");
            DropIndex("dbo.Reports", new[] { "ReportId" });
            DropIndex("dbo.SportTypes", new[] { "SportTypeId" });
            DropPrimaryKey("dbo.Reports");
            DropPrimaryKey("dbo.SportTypes");
            AlterColumn("dbo.Reports", "ReportId", c => c.Int(nullable: false));
            AlterColumn("dbo.SportTypes", "SportTypeId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Reports", "ReportId");
            AddPrimaryKey("dbo.SportTypes", "SportTypeId");
            CreateIndex("dbo.Reports", "ReportId");
            CreateIndex("dbo.SportTypes", "SportTypeId");
            AddForeignKey("dbo.Categories", "SportTypeId", "dbo.SportTypes", "SportTypeId", cascadeDelete: true);
        }
    }
}
