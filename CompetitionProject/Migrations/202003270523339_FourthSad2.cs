namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthSad2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SportTypes", "Type", c => c.String());
            DropColumn("dbo.SportTypes", "Water");
            DropColumn("dbo.SportTypes", "Logic");
            DropColumn("dbo.SportTypes", "Motor");
            DropColumn("dbo.SportTypes", "Power");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SportTypes", "Power", c => c.Boolean(nullable: false));
            AddColumn("dbo.SportTypes", "Motor", c => c.Boolean(nullable: false));
            AddColumn("dbo.SportTypes", "Logic", c => c.Boolean(nullable: false));
            AddColumn("dbo.SportTypes", "Water", c => c.Boolean(nullable: false));
            DropColumn("dbo.SportTypes", "Type");
        }
    }
}
