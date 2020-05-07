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
using CompetitionProject.Admin;

namespace CompetitionProject
{
    public partial class FormEmployeeAdmin : Form
    {
        public FormEmployeeAdmin()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Employees.Load();
                var result = from employee in db.Employees
                             select new
                             {
                                 Код = employee.PersonId,
                                 Фамилия = employee.LastName,
                                 Имя = employee.FirstName,
                                 Отчество = employee.MiddleName,
                                 Почта = employee.Email,
                                 Должность = employee.Job,
                             };
                dataGridView1.DataSource = result.ToList();
            }
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Employee employee = db.Employees.Find(id);
                    EditEmployeeAdmin editEmployee = new EditEmployeeAdmin();
                    editEmployee.LastName.Text = employee.LastName;
                    editEmployee.FirstName.Text = employee.FirstName;
                    editEmployee.MiddleName.Text = employee.MiddleName;
                    editEmployee.Job.Text = employee.Job;
                    editEmployee.Login.Text = employee.Login;
                    editEmployee.Password.Text = employee.Password;
                    editEmployee.Email.Text = employee.Email;

                    editEmployee.ShowDialog();
                    if (editEmployee.result == true)
                    {
                        try
                        {
                            employee.Password = editEmployee.Password.Text;
                            employee.Email = editEmployee.Email.Text;

                            db.SaveChanges();
                            dataGridView1.Refresh();
                            MessageBox.Show("Информация о сотруднике обновлена");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка:\n" + ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите сотрудника");
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Employee employee = db.Employees.Find(id);
                    try
                    {
                        db.Employees.Remove(employee);
                        db.SaveChanges();
                        MessageBox.Show("Сотрудник удален");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка:\n" + ex);
                    }

                }
                else
                {
                    MessageBox.Show("Выберите сотрудника");
                }
            }
        }
    }
}
