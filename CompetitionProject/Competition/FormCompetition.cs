﻿using System;
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
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CompetitionProject
{
    public partial class FormCompetition : Form
    {
        public CompetitionDB db = new CompetitionDB();
        public FormCompetition()
        {
            InitializeComponent();
            RefreshButton_Click_1(null, null);
        }

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
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
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

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
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

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                List<InfoParticipant> participants = new List<InfoParticipant>();
                List<CompetitionJudge> judges = new List<CompetitionJudge>();
                List<CompetitionOrganizator> orgs = new List<CompetitionOrganizator>();
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false)
                    return;
                CompetitionClasses.Competition competition = db.Competitions.Find(id);
                InfoCompetition infoCompetition = new InfoCompetition();
                infoCompetition.Title.Text = competition.Title;
                infoCompetition.PlaceLocation.Text = competition.Location;
                infoCompetition.TimeDate.Text = competition.DateCompetition.ToString();
                infoCompetition.BriefInfo.Text = competition.BriefInformation;
                infoCompetition.TypeSport.Text = db.SportTypes.FirstOrDefault(temp => temp.Id == competition.SportTypeId).Name;
                infoCompetition.Category.Text = db.Categories.FirstOrDefault(temp => temp.CategoryId == competition.CategoryId).Name;

               
                foreach (CompetitionClasses.Competition ct in db.Competitions.Include(ct => ct.Participants))
                {
                    foreach (Participant pc in ct.Participants)
                    {
                        infoCompetition.participantBox.Text = pc.LastName + " " + pc.FirstName + " " + pc.MiddleName + "\n";
                        
                    }
                }

                foreach (CompetitionClasses.Competition ct in db.Competitions.Include(ct => ct.Judges))
                {
                    foreach (CompetitionJudge pc in ct.Judges)
                    {
                        infoCompetition.judgeBox.Text = pc.Judge.LastName + " " + pc.Judge.FirstName + " " + pc.Judge.MiddleName + "\n";

                    }
                }

                foreach (CompetitionClasses.Competition ct in db.Competitions.Include(ct => ct.Organizators))
                {
                    foreach (CompetitionOrganizator pc in ct.Organizators)
                    {
                        infoCompetition.orgBox.Text = pc.Organizator.LastName + " " + pc.Organizator.FirstName + " " + pc.Organizator.MiddleName + "\n";

                    }
                }

                //infoCompetition.JudgeList.DataSource = judges;
                //infoCompetition.JudgeList.DisplayMember = "FirstName";

                //infoCompetition.OrgList.DataSource = orgs;
                //infoCompetition.OrgList.DisplayMember = "FirstName";

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

        private void RefreshButton_Click_1(object sender, EventArgs e)
        {
            db.Competitions.Load();
            var result = from competition in db.Competitions
                         select new
                         {
                             Код = competition.CompetitionId,
                             Название = competition.Title,
                             Дата = competition.DateCompetition,
                             Место_проведения = competition.Location,
                             Статус = competition.Status,
                             Вид_спорта = competition.SportType.Name,
                             Категория = competition.Category.Name
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            FormResult formResult = new FormResult();
            formResult.ShowDialog();
        }
    }
}