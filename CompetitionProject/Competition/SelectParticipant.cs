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
using CompetitionProject.Migrations;

namespace CompetitionProject.Competition
{
    public partial class SelectParticipant : Form
    {
        public SelectParticipant()
        {
            InitializeComponent();
            loadToList();
            loadToList2();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    int index = dataGridView2.Rows[i].Index;
                    bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    EditCompetition.participant = EditCompetition.db.Participants.FirstOrDefault(temp => temp.PersonId == id);
                    EditCompetition.toParticipant();
                }
            }
            else
            {
                MessageBox.Show("Добавьте участника");
            }
        }

        private void loadToList()
        {
            EditCompetition.db.Participants.Load();
            var result = from participant in EditCompetition.db.Participants
                         select new
                         {
                             Код = participant.PersonId,
                             Фамилия = participant.LastName,
                             Имя = participant.FirstName,
                             Отчество = participant.MiddleName,
                             Ранг = participant.Rank,
                             Регион = participant.Region
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int index = dataGridView2.Rows.Add(r.Clone() as DataGridViewRow);

                foreach (DataGridViewCell o in r.Cells)
                {
                    dataGridView2.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                {
                    bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    EditCompetition.participant = EditCompetition.db.Participants.FirstOrDefault(temp => temp.PersonId == id);
                    EditCompetition.offParticipant();
                }
                dataGridView2.Rows.RemoveAt(index);
            }
            dataGridView2.Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadToList2()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                CompetitionClasses.Competition competition = db.Competitions.Include(t => t.Participants).Where(t => t.CompetitionId == FormCompetition.id).FirstOrDefault();
                if (competition.Participants != null)
                {
                    foreach (CompetitionClasses.Participant pc in competition.Participants)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                        row.Cells[0].Value = pc.PersonId;
                        row.Cells[1].Value = pc.LastName;
                        row.Cells[2].Value = pc.FirstName;
                        row.Cells[3].Value = pc.MiddleName;
                        row.Cells[4].Value = pc.Rank;
                        row.Cells[5].Value = pc.Region;
                        dataGridView2.Rows.Add(row);
                    }
                }
            }
        }
    }
}