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
        public CompetitionDB db = new CompetitionDB();
        public SelectParticipant()
        {
            InitializeComponent();
            loadToList();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                int index = dataGridView2.Rows[0].Index;
                bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out int id);
                if (converted == false)
                    return;
                EditCompetition.participant = EditCompetition.db.Participants.FirstOrDefault(temp => temp.PersonId == id);
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
                dataGridView2.Rows.RemoveAt(index);
            }
            dataGridView2.Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}