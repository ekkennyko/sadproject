using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionProject
{
    public class Person
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
    }

    public class Employee: Person
    {
        public int EmployeeId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }
    }

    public class Participant : Person
    {
        public int ParticipantId { get; set; }
        public string Birthday { get; set; }
        public bool Gender { get; set; }
        public double Weight { get; set; }
        public string Region { get; set; }
        public string SportClub { get; set; }
        public string Rank { get; set; }
        private string PassportSerial { get; set; }
        private string PassportNumber { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }
    }

    public class Category
    {
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool Gender { get; set; }

        public SportType Sport { get; set; }
    }

    public class SportType
    {
        [Key]
        public int SportTypeId { get; set; }
        public string Name { get; set; }
        public bool Water { get; set; }
        public bool Logic { get; set; }
        public bool Motor { get; set; }
        public bool Power { get; set; }

        [Required]
        public Category Category { get; set; }

        public int CompetitionId { get; set; }
        public Competition Competition { get; set; }
    }
   
    public class Report
    {
        public string BestAthlete { get; set; }
        public string Winner { get; set; }

        public Competition Competition { get; set; }
    }

    public class CompetitionResult
    {
        public int Position { get; set; }
        public string Participant { get; set; }

        public int CompetitionId { get; set; }
        public CompetitionResult CompetitionResult { get; set; }
    }

    public class Competition
    {
        public int CompetitionId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string DateCompetition { get; set; }

        public Report Reports { get; set; }

        public ICollection<CompetitionResult> CompetitionResults { get; set; }
        public Competition()
        {
            CompetitionResults = new List<CompetitionResult>();
        }

        public SportType Sport { get; set; }

        public ICollection<Employee> Judge { get; set; }
        public ICollection<Employee> Organizator { get; set; }

        public ICollection<Participant> Participant { get; set; }
    }  
}