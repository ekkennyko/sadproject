using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CompetitionProject
{
    public class CompetitionContext : DbContext
    {
        public CompetitionContext() : base("CompetitionContext") { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
