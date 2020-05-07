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

        private void toList(Employee newEmployee)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                CompetitionJudge judge = new CompetitionJudge();
                CompetitionOrganizator organizator = new CompetitionOrganizator();

                if (checkJudge.Checked == true)
                {
                    judge.JudgeId = newEmployee.PersonId;
                    db.Judges.Add(judge);
                }
                else if (checkOrg.Checked == true)
                {
                    organizator.OrganizatorId = newEmployee.PersonId;
                    db.Organizators.Add(organizator);
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                bool res = false;
                int count = 0;
                Employee newEmployee = new Employee
                {
                    LastName = LastName.Text,
                    FirstName = FirstName.Text,
                    MiddleName = MiddleName.Text,
                    Job = Job.Text,
                    Email = Email.Text,
                    Login = Login.Text,
                    Password = Password.Text
                };
                try
                { 
                    var employee = db.Employees.ToList();
                    foreach (CompetitionClasses.Employee el in employee)
                    {
                        if (Email.Text != el.Email && Email.Text != el.Job)
                        {
                            if (count == employee.Count - 1)
                            {
                                db.Employees.Add(newEmployee);
                                db.SaveChanges();
                                toList(newEmployee);
                                res = true;
                                MessageBox.Show("Новый сотрудник добавлен");
                                this.Close();
                            }
                            count++;
                        }
                        else
                        {
                            res = true;
                            MessageBox.Show("Такой сотрудник уже существует");
                        }
                    }
                    if (res == false)
                    {
                        db.Employees.Add(newEmployee);
                        db.SaveChanges();
                        toList(newEmployee);
                        MessageBox.Show("Новый сотрудник добавлен");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении:\n" + ex);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
