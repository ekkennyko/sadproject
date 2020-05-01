using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseArch;
using CompetitionClasses;
using System.Data.Entity;

namespace CompetitionProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //using(CompetitionDB db = new CompetitionDB())
            //{
            //    SportType newSportType = new SportType()
            //    {
            //        Name = "Плавание",
            //        Type = "Водный",
            //    };
            //    db.SportTypes.Add(newSportType);
            //    db.SaveChanges();
            //}
            Application.Run(new Form1());          
        }
    }
}