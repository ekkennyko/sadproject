using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionProject
{
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

        public Report Reports { get; set;}

        public ICollection<CompetitionResult> CompetitionResults { get; set; }
        public Competition()
        {
            CompetitionResults = new List<CompetitionResult>();
        }
    }  
}


