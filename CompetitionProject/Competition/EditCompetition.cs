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
                CheckPart.Checked = true;
            }
            else
            {
                CheckPart.Checked = false;
            }
        }

        public static void toJudge()
        {
            MessageBox.Show(judge.Judge.LastName + judge.CompetitionId + " " + competition.CompetitionId);
            if (judge.CompetitionId == null || judge.CompetitionId != competition.CompetitionId)
            {
                judge.CompetitionId = competition.CompetitionId;
                MessageBox.Show("2 " + judge.CompetitionId);
            }
        }

        public static void toOrganizator()
        {
            if (organizator.CompetitionId == null || organizator.CompetitionId != competition.CompetitionId)
            {
                organizator.CompetitionId = competition.CompetitionId;          
            }
        }

        public static void toParticipant()
        {
            if (participant.CompetitionId == null || participant.CompetitionId != competition.CompetitionId)
            {
                participant.CompetitionId = competition.CompetitionId;           
            }
        }

        public static void offJudge()
        {
            judge.CompetitionId = null;
        }

        public static void offOrganizator()
        {
            organizator.CompetitionId = null;
        }

        public static void offParticipant()
        {
            participant.CompetitionId = null;
        }

        private void JudgeButton_Click(object sender, EventArgs e)
        {
            SelectJudge selectJudge = new SelectJudge();
            selectJudge.ShowDialog();
            if (selectJudge.DialogResult == DialogResult.OK)
            {
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
                CheckOrg.Checked = true;
            }
            else
            {
                CheckOrg.Checked = false;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            competition.Location = PlaceLocation.Text;
            competition.DateCompetition = dateTimePicker1.Value;
            db.SaveChanges();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}