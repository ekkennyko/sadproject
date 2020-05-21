using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

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
            /*CompetitionDB db;
            try
            {
               db = new CompetitionDB();
                Employee empl = new Employee();
                empl.LastName = "Канаев";
                empl.FirstName = "Александр";
                empl.MiddleName = "Васильевич";
                empl.Job = "Студент";
                empl.Email = "blabla@mail.ru";
                empl.Login = "abc";
                empl.Password = "123";
                db.Employees.Add(empl);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
            */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());        
        }
    }
}