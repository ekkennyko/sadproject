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
        public static CompetitionDB db = new CompetitionDB();
        public AddCompetition()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toList(CompetitionClasses.Competition competition)
        {
            competition.SportType = sportType;
            competition.Category = category;

            //MessageBox.Show(judge.CompetitionId.ToString() + " " + judge.Judge.FirstName.ToString() + " = " + competition.CompetitionId.ToString());
            //MessageBox.Show(organizator.CompetitionId.ToString() + " " + organizator.Organizator.FirstName.ToString() + " = " + competition.CompetitionId.ToString());
            //MessageBox.Show(participant.CompetitionId.ToString() + " " + participant.LastName.ToString() + " = " + competition.CompetitionId.ToString());
            //MessageBox.Show(competition.SportTypeId.ToString() + " " + competition.Title.ToString() + " = " + sportType.Id.ToString() + " " + sportType.Name.ToString());
            //MessageBox.Show(competition.CategoryId.ToString() + " " + competition.Title.ToString() + " = " + category.CategoryId.ToString() + " " + category.Name.ToString());

            db.SaveChanges();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            bool res = false;
            int count = 0;
            CompetitionClasses.Competition competition = new CompetitionClasses.Competition()
            {
                Title = Title.Text,
                Location = PlaceLocation.Text,
                DateCompetition = dateTimePicker1.Value,
                BriefInformation = BriefInfo.Text,
                Status = statusBox.Text,
            };
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
                            toList(competition);
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
                if (res == false)
                {
                    db.Competitions.Add(competition);
                    toList(competition);
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
        
        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            SelectCategory selectCategory = new SelectCategory();
            selectCategory.ShowDialog();
            if (selectCategory.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(category.Name);
                CheckCat.Checked = true;
            }
            else
            {
                CheckCat.Checked = false;
            }
        }
        private void SportButton_Click(object sender, EventArgs e)
        {
            SelectSportType selectSportType = new SelectSportType();
            selectSportType.ShowDialog();
            if (selectSportType.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(sportType.Name);
                CheckSport.Checked = true;
            }
            else
            {
                CheckSport.Checked = false;
            }
        }
    }
}