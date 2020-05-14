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
using CompetitionProject.Competition;
using CompetitionProject;

namespace CompetitionProject.Migrations
{
    public partial class EditCompetition : Form
    {
        public static CompetitionClasses.Competition competition;
        public static CompetitionJudge judge;
        public static CompetitionOrganizator organizator;
        public static CompetitionClasses.Participant participant;
        public static CompetitionDB db = new CompetitionDB();
        public EditCompetition()
        {
            InitializeComponent();
        }

        private void ParticipantButton_Click(object sender, EventArgs e)
        {
            SelectParticipant selectParticipant = new SelectParticipant();
            selectParticipant.ShowDialog();
            if (selectParticipant.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(participant.LastName);
                CheckPart.Checked = true;
            }
            else
            {
                CheckPart.Checked = false;
            }
        }

       

        private void AddCompetition_Load(object sender, EventArgs e)
        {

        }

        

        private void JudgeButton_Click(object sender, EventArgs e)
        {
            SelectJudge selectJudge = new SelectJudge();
            selectJudge.ShowDialog();
            if (selectJudge.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(judge.JudgeId.ToString());
                MessageBox.Show(judge.Judge.LastName);
                CheckJudge.Checked = true;
            }
            else
            {
                CheckJudge.Checked = false;
            }
        }

        private void OrgButton_Click(object sender, EventArgs e)
        {
            SelectOrganizator selectOrganizator = new SelectOrganizator();
            selectOrganizator.ShowDialog();
            if (selectOrganizator.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(organizator.OrganizatorId.ToString());
                MessageBox.Show(organizator.Organizator.LastName);
                CheckOrg.Checked = true;
            }
            else
            {
                CheckOrg.Checked = false;
            }
        }

        private void toList(CompetitionClasses.Competition competition)
        {
            judge.CompetitionId = competition.CompetitionId;
            organizator.CompetitionId = competition.CompetitionId;
            participant.CompetitionId = competition.CompetitionId;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            competition.Location = PlaceLocation.Text;
            competition.DateCompetition = dateTimePicker1.Value;
            toList(competition);
            db.SaveChanges();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
