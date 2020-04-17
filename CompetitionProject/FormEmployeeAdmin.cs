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
using System.Data.Entity;

namespace CompetitionProject
{
    public partial class FormEmployeeAdmin : Form
    {
        CompetitionDB db;
        public FormEmployeeAdmin()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            db = new CompetitionDB();
            db.Employees.Load();

            var result = from employee in db.Employees
                         select new
                         {
                             Фамилия = employee.LastName,
                             Имя = employee.FirstName,
                             Отчество = employee.MiddleName,
                             Почта = employee.Email,
                             Должность = employee.Job,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeAdmin addEmployee = new AddEmployeeAdmin();
            addEmployee.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
