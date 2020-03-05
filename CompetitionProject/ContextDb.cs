using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CompetitionClasses;


namespace DataBaseArch
{
    public class CompetitionDB : DbContext
    {
        public CompetitionDB() : base("CompetitionDB") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<CompetitionResult> CompetitionsResults { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
