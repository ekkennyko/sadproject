using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseArch;
using CompetitionClasses;

namespace CompetitionProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                Employee employee1 = new Employee { PersonId = 1, LastName = "Двораковский", FirstName = "Александр", MiddleName = "Олегович", Email = "qweqwuioeqwu@gmail.com", Login = "raqowski", Password = "123456" };

                db.Employees.Add(employee1);
                db.SaveChanges();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}