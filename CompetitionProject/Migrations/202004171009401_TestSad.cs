namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestSad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CompetitionResults", "Position", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CompetitionResults", "Position", c => c.Int(nullable: false));
        }
    }
}
