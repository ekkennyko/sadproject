namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthSad2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Competitions", "BriefInformation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Competitions", "BriefInformation");
        }
    }
}
