using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CompetitionProject
{
    public class Person
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int? ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<Person> Persons { get; set; }
        public Employee()
        {
            Persons = new List<Person>();
        }
    }

    public class Participant
    {
        public int Id { get; set; }
        public string Birthday { get; set; }
        public bool Gender { get; set; }
        public double Weight { get; set; }
        public string Region { get; set; }
        public string SportClub { get; set; }
        public string Rank { get; set; }
        private string PassportSerial { get; set; }
        private string PassportNumber { get; set; }

        public ICollection<Person> Persons { get; set; }
        public Participant()
        {
            Persons = new List<Person>();
        }
    }

    public class UserContext : DbContext
    {
        public UserContext() : base("UserContext") { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
