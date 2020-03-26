using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionClasses
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
    }

    public class Employee : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<CompetitionJudge> CompetitionsJ { get; set; }
        public ICollection<CompetitionOrganizator> CompetitionsO { get; set; }
    }

    public class CompetitionJudge 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int JudgeId { get; set; }
        [ForeignKey("JudgeId")]
        public Employee Judge{get;set;}

        public int CompetitionId { get; set; }
        [ForeignKey("CompetitionId")]
        public virtual Competition Competition { get; set; }
    }

    public class CompetitionOrganizator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int OrganizatorId { get; set; }
        [ForeignKey("OrganizatorId")]
        public Employee Organizator { get; set; }

        public int CompetitionId { get; set; }
        [ForeignKey("CompetitionId")]
        public virtual Competition Competition { get; set; }
    }

    public class Participant : Person
    {
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public string Region { get; set; }
        public string SportClub { get; set; }
        public string Rank { get; set; }
        private string PassportSerial { get; set; }
        private string PassportNumber { get; set; }

        public int? CompetitionId { get; set; }
        public virtual Competition Competition { get; set; }
    }

    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool Gender { get; set; }

        public int SportTypeId { get; set; }
        public virtual SportType Sport { get; set; }
    }

    public class SportType
    {
        [Key]
        [ForeignKey("Competition")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SportTypeId { get; set; }
        public string Name { get; set; }
        public bool Water { get; set; }
        public bool Logic { get; set; }
        public bool Motor { get; set; }
        public bool Power { get; set; }

        //[ForeignKey("CategoryId")]
        public ICollection<Category> Categories { get; set; }
        public SportType()
        {
            Categories = new List<Category>();
        }

        public virtual Competition Competition { get; set; }
    }

    public class Report
    {
        [Key]
        [ForeignKey("Competition")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }
        public string BestAthlete { get; set; }
        public string Winner { get; set; }


        public virtual Competition Competition { get; set; }
    }

    public class CompetitionResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompResId { get; set; }
        public int Position { get; set; }
        public string Participant { get; set; }

        public int CompetitionId { get; set; }
        public virtual CompetitionResult Result { get; set; }
    }

    public class Competition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompetitionId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime DateCompetition { get; set; }

        //public int ReportId { get; set; }
       // [ForeignKey("ReportId")]
        public virtual Report Report { get; set; }

        public virtual SportType Sport { get; set; }
        public ICollection<CompetitionResult> CompetitionResults { get; set; }
        public ICollection<CompetitionJudge> Judges { get; set; }
        public ICollection<CompetitionOrganizator> Organizators { get; set; }
        public ICollection<Participant> Participants { get; set; }
        public Competition()
        {
            CompetitionResults = new List<CompetitionResult>();
            Judges = new List<CompetitionJudge>();        
            Organizators = new List<CompetitionOrganizator>();
            Participants = new List<Participant>();
        }
    }
}