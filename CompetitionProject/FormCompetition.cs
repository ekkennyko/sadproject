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
        CompetitionDB db;
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCompetition addCompetition = new AddCompetition();
            addCompetition.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                CompetitionClasses.Participant participant = db.Participants.Find(id);
                db.Participants.Remove(participant);
                db.SaveChanges();
                MessageBox.Show("Соревнование удалено");

            }
            else
            {
                MessageBox.Show("Выберите соревнование");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            db = new CompetitionDB();
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

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                CompetitionClasses.Competition category = db.Competitions.Find(id);
                EditCompetition editCompetition = new EditCompetition();
                editCompetition.TitleBox.Text = category.Title;
                editCompetition.LocationBox.Text = category.Location;
                editCompetition.dateTimePicker1.Date = category.DateCompetition;
                
                editCompetition.ShowDialog();
                if (editCompetition.result == true)
                {
                    competition.Title = editCompetition.TitleBox.Text;
                    competition.Location = editCompetition.LocationBox.Text;
                    competition.Date = editCompetition.DateTimePicker1.Date;

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

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                CompetitionClasses.Competition competition = db.Competitions.Find(id);
                Competition infoCompetition = new Competition();
                infoCompetition.Title.Text = competition.Title;
                infoCompetition.Location.Text = competition.Location;
                infoCompetition.TimeDate.Date = competition.TimeDate;
                infoCompetition.TypeSport.Text = competition.TypeSport;
                infoCompetition.BriefInformation.Text = competition.BriefInformation;

                infoCompetition.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите соревнование");
            }
        }

        private void FormCompetition_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
