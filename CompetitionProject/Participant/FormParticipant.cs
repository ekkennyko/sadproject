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
using CompetitionClasses;
using DataBaseArch;

namespace CompetitionProject
{
    public partial class FormParticipant : Form
    {
        public FormParticipant()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddParticipant addParticipant = new AddParticipant();
            addParticipant.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    CompetitionClasses.Participant participant = db.Participants.Find(id);
                    try
                    {
                        db.Participants.Remove(participant);
                        db.SaveChanges();
                        MessageBox.Show("Участник удален");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка");
                    }

                }
                else
                {
                    MessageBox.Show("Выберите участника");
                }
            }
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
                    CompetitionClasses.Participant participant = db.Participants.Find(id);
                    EditParticipant editParticipant = new EditParticipant();
                    editParticipant.LastName.Text = participant.LastName;
                    editParticipant.FirstName.Text = participant.FirstName;
                    editParticipant.MiddleName.Text = participant.MiddleName;
                    editParticipant.CrntRegion.Text = participant.Region;
                    editParticipant.SportClub.Text = participant.SportClub;
                    editParticipant.Rank.Text = participant.Rank;
                    editParticipant.Weight.Text = participant.Weight.ToString();

                    editParticipant.ShowDialog();
                    if (editParticipant.result == true)
                    {
                        try
                        {
                            participant.Region = editParticipant.CrntRegion.Text;
                            participant.SportClub = editParticipant.SportClub.Text;
                            participant.Rank = editParticipant.Rank.Text;
                            participant.Weight = double.Parse(editParticipant.Weight.Text);

                            db.SaveChanges();
                            dataGridView1.Refresh();
                            MessageBox.Show("Информация о участнике обновлена");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка:\n" + ex);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите участника");
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
                    CompetitionClasses.Participant participant = db.Participants.Find(id);
                    Participant infoParticipant = new Participant();
                    infoParticipant.LastName.Text = participant.LastName;
                    infoParticipant.FirstName.Text = participant.FirstName;
                    infoParticipant.MiddleName.Text = participant.MiddleName;
                    infoParticipant.Birthday.Text = participant.Birthday.ToShortDateString();
                    infoParticipant.Gender.Text = participant.Gender;
                    infoParticipant.CrntRegion.Text = participant.Region;
                    infoParticipant.SportClub.Text = participant.SportClub;
                    infoParticipant.Rank.Text = participant.Rank;
                    infoParticipant.Weight.Text = participant.Weight.ToString();
                    infoParticipant.Email.Text = participant.Email;

                    infoParticipant.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите участника");
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Participants.Load();
                var result = from participant in db.Participants
                             select new
                             {
                                 Код = participant.PersonId,
                                 Фамилия = participant.LastName,
                                 Имя = participant.FirstName,
                                 Отчество = participant.MiddleName,
                                 Возраст = DateTime.Today.Year - participant.Birthday.Year,         //Докончить
                                 Вес = participant.Weight,
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }
    }
}
