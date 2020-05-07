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
    public partial class FormCompetition : Form
    {
        public FormCompetition()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCompetition addCompetition = new AddCompetition();
            addCompetition.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Competition competition = db.Competitions.Find(id);
                    db.Competitions.Remove(competition);
                    db.SaveChanges();
                    MessageBox.Show("Соревнование удалено");

                }
                else
                {
                    MessageBox.Show("Выберите соревнование");
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Competitions.Load();
                var result = from competition in db.Competitions
                             select new
                             {
                                 Название = competition.Title,
                                 Дата = competition.DateCompetition,
                                 Место_проведения = competition.Location,
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Competition competition = db.Competitions.Find(id);
                    EditCompetition editCompetition = new EditCompetition();
                    editCompetition.TitleBox.Text = competition.Title;
                    editCompetition.LocationBox.Text = competition.Location;
                    editCompetition.dateTimePicker1.Value = competition.DateCompetition;

                    editCompetition.ShowDialog();
                    if (editCompetition.result == true)
                    {
                        competition.Title = editCompetition.TitleBox.Text;
                        competition.Location = editCompetition.LocationBox.Text;
                        competition.DateCompetition = editCompetition.dateTimePicker1.Value;

                        db.SaveChanges();
                        dataGridView1.Refresh();
                        MessageBox.Show("Информация о соревновании обновлена");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите соревнование");
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Competition competition = db.Competitions.Find(id);
                    InfoCompetition infoCompetition = new InfoCompetition();
                    infoCompetition.Title.Text = competition.Title;
                    infoCompetition.PlaceLocation.Text = competition.Location;
                    infoCompetition.TimeDate.Text = competition.DateCompetition.ToString();
                    //
                    infoCompetition.BriefInfo.Text = competition.BriefInformation;

                    infoCompetition.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите соревнование");
                }
            }
        }

        private void FormCompetition_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshButton_Click_1(object sender, EventArgs e)
        {

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            FormResult formResult = new FormResult();
            formResult.ShowDialog();
        }
    }
}
