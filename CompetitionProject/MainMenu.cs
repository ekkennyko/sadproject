﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetitionProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
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
        }
    }
}
