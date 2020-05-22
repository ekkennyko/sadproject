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
using System.Data.Entity;
using CompetitionProject.Migrations;

namespace CompetitionProject.Competition
{
    public partial class SelectJudge : Form
    {
        public SelectJudge()
        {
            InitializeComponent();
            loadToList();
            loadToList2();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    MessageBox.Show(dataGridView2.Rows.Count.ToString() + i);
                    int index = dataGridView2.Rows[i].Index;
                    bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    MessageBox.Show(id.ToString());
                    EditCompetition.judge = EditCompetition.db.Judges.Include(temp => temp.Judge).FirstOrDefault(temp => temp.Id == id);
                    EditCompetition.toJudge();
                }
            }
            else
            {
                MessageBox.Show("Добавьте судью");
            }
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    EditCompetition.judge = EditCompetition.db.Judges.Include(temp => temp.Judge).FirstOrDefault(temp => temp.Id == id);
                    EditCompetition.offJudge();
                }
                dataGridView2.Rows.RemoveAt(index);
            }
            dataGridView2.Refresh();
        }

        private void loadToList()
        {
            EditCompetition.db.Judges.Load();
            var result = from judge in EditCompetition.db.Judges
                         select new
                         {
                             Код = judge.Id,
                             Фамилия = judge.Judge.LastName,
                             Имя = judge.Judge.FirstName,
                             Отчество = judge.Judge.MiddleName,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void loadToList2()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                CompetitionClasses.Competition competition = db.Competitions.Include(t => t.Judges.Select(c => c.Judge)).Where(t => t.CompetitionId == FormCompetition.id).FirstOrDefault();
                if (competition.Judges != null)
                {
                    foreach (CompetitionClasses.CompetitionJudge pc in competition.Judges)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                        row.Cells[0].Value = pc.Id;
                        row.Cells[1].Value = pc.Judge.LastName;
                        row.Cells[2].Value = pc.Judge.FirstName;
                        row.Cells[3].Value = pc.Judge.MiddleName;
                        dataGridView2.Rows.Add(row);
                    }
                }
            }
        }
    }
}