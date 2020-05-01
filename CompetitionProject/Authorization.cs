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

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                try
                {
                    var employee = db.Employees;
                    foreach (Employee au in employee)
                    {
                        if (Login.Text == au.Login && Password.Text == au.Password)
                        {
                            MainMenu menu = new MainMenu();
                            menu.LastName.Text = au.LastName;
                            menu.FirstName.Text = au.FirstName;
                            menu.MiddleName.Text = au.MiddleName;
                            menu.Job.Text = au.Job;
                            menu.Email.Text = au.Email;
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Такого пользователя не существует:\n" + ex);
                }
            }
        }
    }
}
