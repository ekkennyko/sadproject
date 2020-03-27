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
    public partial class AddSportType : Form
    {
        public AddSportType()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CompetitionDB addsportType = new CompetitionDB();
            SportType newsportType = new SportType()
            {
                Name = textBox1.Text,
                Type = textBox2.Text,
            };
            addsportType.SportTypes.Add(newsportType);
            addsportType.SaveChanges();
            MessageBox.Show("Новый вид спорта добавлен");
            this.Close();
        }
    }
}
