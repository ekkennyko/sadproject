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
        CompetitionDB db;
        public FormParticipant()
        {
            InitializeComponent();
            Refresh_Click(null, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddParticipant addParticipant = new AddParticipant();
            addParticipant.ShowDialog();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Participant participant = db.Participants.Find(id);
                db.Participants.Remove(participant);
                db.SaveChanges();
                MessageBox.Show("Участник удален");

            }
            else
            {
                MessageBox.Show("Для начала выберите участника");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Participant participant = db.Participants.Find(id);
                EditParticipant editParticipant = new EditParticipant();
                editParticipant.label4.Text = participant.LastName;
                editParticipant.label5.Text = participant.FirstName;
                editParticipant.label10.Text = participant.MiddleName;
                editParticipant.textBox6.Text = participant.Region;
                editParticipant.textBox7.Text = participant.SportClub;
                editParticipant.textBox8.Text = participant.Rank;
                editParticipant.textBox9.Text = participant.Weight.ToString();

                editParticipant.ShowDialog();
                if (editParticipant.result == true)
                {
                    participant.Region = editParticipant.textBox6.Text;
                    participant.SportClub = editParticipant.textBox7.Text;
                    participant.Rank = editParticipant.textBox8.Text;
                    participant.Weight = double.Parse(editParticipant.textBox9.Text);

                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Информация о участнике обновлена");
                }
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Participant participant = db.Participants.Find(id);
                InfoParticipant infoParticipant = new InfoParticipant();
                infoParticipant.label11.Text = participant.LastName;
                infoParticipant.label12.Text = participant.FirstName;
                infoParticipant.label13.Text = participant.MiddleName;
                infoParticipant.label14.Text = participant.Birthday.ToShortDateString();
                infoParticipant.label15.Text = participant.Gender;
                infoParticipant.label16.Text = participant.Region;
                infoParticipant.label17.Text = participant.SportClub;
                infoParticipant.label18.Text = participant.Rank;
                infoParticipant.label19.Text = participant.Weight.ToString();
                infoParticipant.label20.Text = participant.Email;

                infoParticipant.ShowDialog();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            db = new CompetitionDB();
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
