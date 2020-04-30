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
        CompetitionDB db = new CompetitionDB();

        CompetitionJudge judge = new CompetitionJudge();
        CompetitionOrganizator organizator = new CompetitionOrganizator();
        Employee newEmployee = new Employee();

        public AddEmployeeAdmin()
        {
            InitializeComponent();
        }

        private void toList()
        {
            if (checkJudge.Checked == true)
            {
                judge.JudgeId = newEmployee.PersonId;
                db.Judges.Add(judge);
                db.SaveChanges();
            }
            else if (checkOrg.Checked == true)
            {
                organizator.OrganizatorId = newEmployee.PersonId;
                db.Organizators.Add(organizator);
                db.SaveChanges();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            newEmployee.LastName = LastName.Text;
            newEmployee.FirstName = FirstName.Text;
            newEmployee.MiddleName = MiddleName.Text;
            newEmployee.Job = Job.Text;
            newEmployee.Email = Email.Text;
            newEmployee.Login = Login.Text;
            newEmployee.Password = Password.Text;

            try
            {

                bool res = false;
                var employee = db.Employees;
                foreach (CompetitionClasses.Employee el in employee)
                {
                    if (Email.Text != el.Email && Email.Text != el.Job)
                    {
                        db.Employees.Add(newEmployee);
                        db.SaveChanges();
                        toList();
                        MessageBox.Show("Новый сотрудник добавлен");
                        res = true;
                        this.Close();
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
                    toList();
                    MessageBox.Show("Новый сотрудник добавлен");
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении:\n" + ex);
            }



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
