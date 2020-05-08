namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seventhsad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Competitions", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Competitions", "Status");
        }
    }
}
