namespace CompetitionProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstSd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        SportTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.SportTypes", t => t.SportTypeId, cascadeDelete: true)
                .Index(t => t.SportTypeId);
            
            CreateTable(
                "dbo.SportTypes",
                c => new
                    {
                        SportTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        Water = c.Boolean(nullable: false),
                        Logic = c.Boolean(nullable: false),
                        Motor = c.Boolean(nullable: false),
                        Power = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SportTypeId)
                .ForeignKey("dbo.Competitions", t => t.SportTypeId)
                .Index(t => t.SportTypeId);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        CompetitionId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Location = c.String(),
                        DateCompetition = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompetitionId);
            
            CreateTable(
                "dbo.CompetitionResults",
                c => new
                    {
                        CompResId = c.Int(nullable: false, identity: true),
                        Position = c.Int(nullable: false),
                        Participant = c.String(),
                        CompetitionId = c.Int(nullable: false),
                        Result_CompResId = c.Int(),
                    })
                .PrimaryKey(t => t.CompResId)
                .ForeignKey("dbo.CompetitionResults", t => t.Result_CompResId)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .Index(t => t.CompetitionId)
                .Index(t => t.Result_CompResId);
            
            CreateTable(
                "dbo.CompetitionJudges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JudgeId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.JudgeId, cascadeDelete: true)
                .Index(t => t.JudgeId)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.CompetitionOrganizators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizatorId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.OrganizatorId, cascadeDelete: true)
                .Index(t => t.OrganizatorId)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Birthday = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Weight = c.Double(nullable: false),
                        Region = c.String(),
                        SportClub = c.String(),
                        Rank = c.String(),
                        CompetitionId = c.Int(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportId = c.Int(nullable: false),
                        BestAthlete = c.String(),
                        Winner = c.String(),
                    })
                .PrimaryKey(t => t.ReportId)
                .ForeignKey("dbo.Competitions", t => t.ReportId)
                .Index(t => t.ReportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SportTypes", "SportTypeId", "dbo.Competitions");
            DropForeignKey("dbo.Reports", "ReportId", "dbo.Competitions");
            DropForeignKey("dbo.Participants", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionOrganizators", "OrganizatorId", "dbo.Employees");
            DropForeignKey("dbo.CompetitionOrganizators", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionJudges", "JudgeId", "dbo.Employees");
            DropForeignKey("dbo.CompetitionJudges", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionResults", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.CompetitionResults", "Result_CompResId", "dbo.CompetitionResults");
            DropForeignKey("dbo.Categories", "SportTypeId", "dbo.SportTypes");
            DropIndex("dbo.Reports", new[] { "ReportId" });
            DropIndex("dbo.Participants", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionOrganizators", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionOrganizators", new[] { "OrganizatorId" });
            DropIndex("dbo.CompetitionJudges", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionJudges", new[] { "JudgeId" });
            DropIndex("dbo.CompetitionResults", new[] { "Result_CompResId" });
            DropIndex("dbo.CompetitionResults", new[] { "CompetitionId" });
            DropIndex("dbo.SportTypes", new[] { "SportTypeId" });
            DropIndex("dbo.Categories", new[] { "SportTypeId" });
            DropTable("dbo.Reports");
            DropTable("dbo.Participants");
            DropTable("dbo.CompetitionOrganizators");
            DropTable("dbo.Employees");
            DropTable("dbo.CompetitionJudges");
            DropTable("dbo.CompetitionResults");
            DropTable("dbo.Competitions");
            DropTable("dbo.SportTypes");
            DropTable("dbo.Categories");
        }
    }
}
