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
        public static int id;
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
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
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
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Competition competition = db.Competitions.Find(id);
                    EditCompetition.competition = db.Competitions.Find(id);

                    EditCompetition editCompetition = new EditCompetition();
                    editCompetition.TitleLabel.Text = competition.Title;
                    editCompetition.PlaceLocation.Text = competition.Location;
                    editCompetition.dateTimePicker1.Value = competition.DateCompetition;
                    editCompetition.statusBox.Text = competition.Status;


                    editCompetition.ShowDialog();

                    if (editCompetition.DialogResult == DialogResult.OK)
                    {
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

                    competition = db.Competitions.Include(t => t.Participants).Where(t => t.CompetitionId == id).FirstOrDefault();
                    if (competition.Participants != null)
                    {
                        foreach (Participant pc in competition.Participants)
                        {
                            infoCompetition.participantBox.Text += pc.LastName + " ";
                            infoCompetition.participantBox.Text += pc.FirstName + " ";
                            infoCompetition.participantBox.Text += pc.MiddleName + '\n';
                        }
                    }
                    competition = db.Competitions.Include(t => t.Judges.Select(c => c.Judge)).Where(t => t.CompetitionId == id).FirstOrDefault();
                    if (competition.Judges != null)
                    {
                        foreach (CompetitionJudge pc in competition.Judges)
                        {
                            infoCompetition.judgeBox.Text += pc.Judge.LastName + " ";
                            infoCompetition.judgeBox.Text += pc.Judge.FirstName + " ";
                            infoCompetition.judgeBox.Text += pc.Judge.MiddleName + '\n';
                        }
                    }
                    competition = db.Competitions.Include(t => t.Organizators.Select(c => c.Organizator)).Where(t => t.CompetitionId == id).FirstOrDefault();
                    if (competition.Organizators != null)
                    {
                        foreach (CompetitionOrganizator pc in competition.Organizators)
                        {
                            infoCompetition.orgBox.Text += pc.Organizator.LastName + " ";
                            infoCompetition.orgBox.Text += pc.Organizator.FirstName + " ";
                            infoCompetition.orgBox.Text += pc.Organizator.MiddleName + '\n';
                        }
                    }

                    infoCompetition.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите соревнование");
                }
            }
        }

        private void RefreshButton_Click_1(object sender, EventArgs e)
        {
            CompetitionDB db = new CompetitionDB();
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