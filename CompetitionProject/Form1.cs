using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompetitionClasses;
using DataBaseArch;

namespace CompetitionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CompetitionDB test = new CompetitionDB();
            //Employee employee = new Employee
            //{
            //    Login = "Dvorakovskii", Password = "16081999", FirstName = "Александр", LastName = "Двораковский", MiddleName = "Олегович", Email = "dhrhrhjdjfh@gmail.com", PersonId = 1
            //};
            //test.Employees.Add(employee);
            //test.SaveChanges();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
