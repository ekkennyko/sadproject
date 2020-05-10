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
    public partial class SelectSportType : Form
    {
        public CompetitionDB db = new CompetitionDB();
        public SelectSportType()
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
                AddCompetition.sportType = AddCompetition.db.SportTypes.FirstOrDefault(temp => temp.Id == id);
            }
            else
            {
                MessageBox.Show("Добавьте вид спорта");
            }
        }

        private void loadToList()
        {
            AddCompetition.db.SportTypes.Load();
            var result = from sportType in AddCompetition.db.SportTypes
                         select new
                         {
                             Код = sportType.Id,
                             Название = sportType.Name,
                             Тип = sportType.Type
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

        }
    }
}