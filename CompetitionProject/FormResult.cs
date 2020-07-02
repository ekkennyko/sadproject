using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataBaseArch;
using CompetitionClasses;
using CompetitionProject.Migrations;

namespace CompetitionProject
{
    public partial class FormResult : Form
    {
        public CompetitionDB DB { get; set; }
        public FormResult()
        {
            InitializeComponent();
        }

        private void inputResult_Click(object sender, EventArgs e)
        {
            inputResult inputResult = new inputResult();
            inputResult.DB = this.DB;
            inputResult.ShowDialog();
            dataResults.DataSource = DB.CompetitionsResults.ToList();
        }

        private void outReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void participantBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormResult_Load(object sender, EventArgs e)
        {
            DB = new CompetitionDB();
            dataResults.DataSource = DB.CompetitionsResults.ToList();
            dataResults.Columns[0].Visible = false;
            dataResults.Columns[1].HeaderText = "id";
            dataResults.Columns[2].HeaderText = "Позиция";
            dataResults.Columns[3].HeaderText = "Участник";
            dataResults.Columns[4].Visible = false;
            dataResults.Columns[5].Visible = false;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DB = new CompetitionDB();
            DB.CompetitionsResults.Load();
            var result = from competition in DB.CompetitionsResults
                         select new
                         {
                             id = competition.CompetitionId,
                             Позиция = competition.Position,
                             Участник = competition.Participant,
                         };
            dataResults.DataSource = result.ToList();
        }
    }
}
