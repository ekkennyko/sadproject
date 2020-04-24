namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SixthSad1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes");
            DropPrimaryKey("dbo.SportTypes");
            AddColumn("dbo.SportTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SportTypes", "Id");
            AddForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.SportTypes", "SportTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SportTypes", "SportTypeId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes");
            DropPrimaryKey("dbo.SportTypes");
            DropColumn("dbo.SportTypes", "Id");
            AddPrimaryKey("dbo.SportTypes", "SportTypeId");
            AddForeignKey("dbo.Competitions", "SportTypeId", "dbo.SportTypes", "SportTypeId", cascadeDelete: true);
        }
    }
}
