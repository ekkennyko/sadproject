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
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count - 1 > 0)
            {
                int index = dataGridView2.Rows[0].Index;
                bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out int id);
                if (converted == false)
                    return;
                EditCompetition.judge = EditCompetition.db.Judges.Include(temp => temp.Judge).FirstOrDefault(temp => temp.Id == id);
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
                dataGridView2.Rows.RemoveAt(index);
            }
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
