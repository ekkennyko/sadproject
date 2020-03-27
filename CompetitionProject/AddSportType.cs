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
            CompetitionDB addSportType = new CompetitionDB();
            SportType newSportType = new SportType()
            {
                SportTypeId = 1,
                Name = textBox1.Text,
                Type = comboBox1.Text,
            };
            addSportType.SportTypes.Add(newSportType);
            addSportType.SaveChanges();
            MessageBox.Show("Новый вид спорта добавлен");
            this.Close();
        }
    }
}
