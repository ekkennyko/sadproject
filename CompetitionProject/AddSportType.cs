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
        CompetitionDB addSportType = new CompetitionDB();
        public AddSportType()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SportType newSportType = new SportType()
            {
                Name = NameSport.Text,
                Type = Type.Text,
            };
            addSportType.SportTypes.Add(newSportType);
            addSportType.SaveChanges();
            MessageBox.Show("Новый вид спорта добавлен");
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
