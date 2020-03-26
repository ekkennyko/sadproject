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
            db = new CompetitionDB();
            db.Participants.Load();

            var result = from participant in db.Participants
                         select new
                         {
                             Код = participant.PersonId,
                             Фамилия = participant.LastName,
                             Имя = participant.FirstName,
                             Отчество = participant.MiddleName,
                             Возраст = DateTime.Today.Year - participant.Birthday.Year         //Докончить
                         };
            dataGridView1.DataSource = result.ToList();
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
                MessageBox.Show("Объект удален из списка");

            }
            else
            {
                MessageBox.Show("Выберите объект  для удаления");
            }
        }
    }
}
