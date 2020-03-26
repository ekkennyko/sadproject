namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthSad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participants", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "Gender", c => c.Boolean(nullable: false));
        }
    }
}
