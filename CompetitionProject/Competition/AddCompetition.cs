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

namespace CompetitionProject
{
    public partial class AddCompetition : Form
    {
        protected internal bool res = false;
        public AddCompetition()
        {
            InitializeComponent();
        }

        private void ParticipantButton_Click(object sender, EventArgs e)
        {
            SelectParticipant selectParticipant = new SelectParticipant();
            selectParticipant.ShowDialog();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            SelectCategory selectCategory = new SelectCategory();
            selectCategory.ShowDialog();
            if (res == true)
            {
                CheckCat.Checked = true;
            }
            else
            {
                CheckCat.Checked = false;
            }
        }

        private void AddCompetition_Load(object sender, EventArgs e)
        {

        }

        private void SportButton_Click(object sender, EventArgs e)
        {
            SelectSportType selectSportType = new SelectSportType();
            selectSportType.ShowDialog();
            CheckCat.Checked = true;
        }

        private void JudgeButton_Click(object sender, EventArgs e)
        {
            SelectJudge selectJudge = new SelectJudge();
            selectJudge.ShowDialog();
        }

        private void OrgButton_Click(object sender, EventArgs e)
        {
            SelectOrganizator selectOrganizator = new SelectOrganizator();
            selectOrganizator.ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            {
                CompetitionDB addCompetition = new CompetitionDB();
                CompetitionClasses.Competition newCompetition = new CompetitionClasses.Competition()
                {
                    Title = Title.Text,
                    Location = PlaceLocation.Text,
                    DateCompetition = dateTimePicker1.Value,
                    //Organizators = OrgButton.String,




                    BriefInformation=BriefInfo.Text,
                };
                try
                {
                    var competition = addCompetition.Competitions;
                    foreach (Competition comp in competition)
                    {
                        if (Title.Text != comp.Title && PlaceLocation.Text != comp.Location)
                        {
                            addCompetition.Competitions.Add(newCompetition);
                            addCompetition.SaveChanges();
                            MessageBox.Show("Новое соревнование добавлено");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Такое соревнование уже существует");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка при добавлении");
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
