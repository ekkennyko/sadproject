namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthSad1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "CompetitionId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "CompetitionId");
        }
    }
}
