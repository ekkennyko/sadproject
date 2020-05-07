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
using CompetitionProject.Competition;

namespace CompetitionProject
{
    public partial class AddCompetition : Form
    {
        public static Category category;
        public static SportType sportType;
        public static CompetitionJudge judge;
        public static CompetitionOrganizator organizator;
        public static CompetitionClasses.Participant participant;
        public CompetitionClasses.Competition competition = new CompetitionClasses.Competition();
        protected internal bool resComp;
        public AddCompetition()
        {
            InitializeComponent();
        }

        private void ParticipantButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB()) {
                SelectParticipant selectParticipant = new SelectParticipant();
                selectParticipant.ShowDialog();
                if(selectParticipant.DialogResult == DialogResult.OK)
                {
                    competition.Participants.Add(participant);
                    CheckPart.Checked = true;
                }
                else
                {
                    CheckPart.Checked = false;
                }
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                SelectCategory selectCategory = new SelectCategory();
                selectCategory.ShowDialog();
                if (selectCategory.DialogResult == DialogResult.OK)
                {
                    competition.Categories.Add(category);
                    CheckCat.Checked = true;
                }
                else
                {
                    CheckCat.Checked = false;
                }
            }
        }

        private void AddCompetition_Load(object sender, EventArgs e)
        {

        }

        private void SportButton_Click(object sender, EventArgs e)
        {    
            using (CompetitionDB db = new CompetitionDB())
            {
                SelectSportType selectSportType = new SelectSportType();
                selectSportType.ShowDialog();
                if (selectSportType.DialogResult == DialogResult.OK)
                {
                    competition.SportType = sportType;
                    CheckSport.Checked = true;
                }
                else
                {
                    CheckSport.Checked = false;
                }
            }
        }

        private void JudgeButton_Click(object sender, EventArgs e)
        {      
            using (CompetitionDB db = new CompetitionDB())
            {
                SelectJudge selectJudge = new SelectJudge();
                selectJudge.ShowDialog();
                if (selectJudge.DialogResult == DialogResult.OK)
                {
                    competition.Judges.Add(judge);
                    CheckJudge.Checked = true;
                }
                else
                {
                    CheckJudge.Checked = false;
                }
            }
        }

        private void OrgButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                SelectOrganizator selectOrganizator = new SelectOrganizator();
                selectOrganizator.ShowDialog();
                if(selectOrganizator.DialogResult == DialogResult.OK)
                {
                    competition.Organizators.Add(organizator);
                    CheckOrg.Checked = true;
                }
                else
                {
                    CheckOrg.Checked = false;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                bool res = false;
                int count = 0;
                competition.Title = Title.Text;
                competition.Location = PlaceLocation.Text;
                competition.DateCompetition = dateTimePicker1.Value;
                competition.BriefInformation = BriefInfo.Text;
                try
                {
                    var tempCompetition = db.Competitions.ToList();
                    foreach (CompetitionClasses.Competition comp in tempCompetition)
                    {
                        if (Title.Text != comp.Title && PlaceLocation.Text != comp.Location)
                        {
                            if (count == tempCompetition.Count - 1)
                            {
                                db.Competitions.Add(competition);
                                db.SaveChanges();
                                res = true;
                                MessageBox.Show("Новое соревнование добавлено");
                                this.Close();
                            }
                            count++;
                        }
                        else
                        {
                            res = true;
                            MessageBox.Show("Такое соревнование уже существует");
                        }
                    }
                    if( res == false)
                    {
                        db.Competitions.Add(competition);
                        db.SaveChanges();
                        MessageBox.Show("Новое соревнование добавлено");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении:\n" + ex);
                }
            }
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}