namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthSad33 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participants", "Passport", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Participants", "Passport");
        }
    }
}
