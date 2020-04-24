using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseArch;
using CompetitionClasses;
using System.Data.Entity;

namespace CompetitionProject
{
    public partial class AddEmployeeAdmin : Form
    {

        public AddEmployeeAdmin()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CompetitionDB db = new CompetitionDB();
            Employee newEmployee = new Employee()
            {
                LastName = LastName.Text,
                FirstName = FirstName.Text,
                MiddleName = MiddleName.Text,
                Job = Job.Text,
                Email = Email.Text,
                Login = Login.Text,
                Password = Password.Text,
            };
            try
            {
                var employee = db.Employees;
                foreach (CompetitionClasses.Employee el in employee)
                {
                    //if (employee != null)
                    //{
                        if (Email.Text != el.Email && Email.Text != el.Job)
                        {
                            db.Employees.Add(newEmployee);
                            db.SaveChanges();
                            MessageBox.Show("Новый сотрудник добавлен");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Такой сотрудник уже существует");
                        }
                    //}
                    //else
                    //{
                    //    db.Employees.Add(newEmployee);
                    //    db.SaveChanges();
                    //    MessageBox.Show("Новый сотрудник добавлен");
                    //    this.Close();
                    //}
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
