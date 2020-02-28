using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CompetitionProject;


namespace DataBaseArch
{
    public class CompetitionDB : DbContext
    {
        public CompetitionDB() : base("CompetitionProject") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<CompetitionResult> CompetitionsResults { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
