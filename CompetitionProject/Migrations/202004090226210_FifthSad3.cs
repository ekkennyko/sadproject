namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthSad3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Age", c => c.String());
            AlterColumn("dbo.Categories", "Weight", c => c.String());
            AlterColumn("dbo.Categories", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Gender", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Categories", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Categories", "Age", c => c.Int(nullable: false));
        }
    }
}
