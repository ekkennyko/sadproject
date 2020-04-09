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
    public partial class MainMenu : Form
    {
        CompetitionDB db;
        public MainMenu()
        {
            InitializeComponent();

            db = new CompetitionDB();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSportType sportType = new FormSportType();
            sportType.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCompetition competition = new FormCompetition();
            competition.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormParticipant formParticipant= new FormParticipant();
            formParticipant.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.Show();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.Show();
        }
    }
}
