﻿using System;
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
        CompetitionDB autho = new CompetitionDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Employee employee = new Employee()
            //{
            //    Login = "Dvorakovskii",
            //    Password = "123456",
            //    FirstName = "Александр",
            //    LastName = "Двораковский",
            //    MiddleName = "Олегович",
            //    Job = "Организатор",
            //    Email = "dhrhrhjdjfh@gmail.com"
            //};
            //autho.Employees.Add(employee);
            //autho.SaveChanges();
            var employee = autho.Employees;
            foreach (Employee au in employee)
            {
                if (textBox1.Text == au.Login && textBox2.Text == au.Password)
                {
                    MainMenu menu = new MainMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
