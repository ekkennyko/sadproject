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
    public partial class SelectOrganizator : Form
    {
        public SelectOrganizator()
        {
            InitializeComponent();
            loadToList();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    MessageBox.Show(dataGridView2.Rows.Count.ToString() + " " + i.ToString());
                    int index = dataGridView2.Rows[i].Index;
                    bool converted = Int32.TryParse(dataGridView2[i, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    EditCompetition.organizator = EditCompetition.db.Organizators.Include(temp => temp.Organizator).FirstOrDefault(temp => temp.Id == id);
                    EditCompetition.toOrganizator();
                }
            }
            else
            {
                MessageBox.Show("Добавьте организатора");
            }
        }

        private void loadToList()
        {
            EditCompetition.db.Organizators.Load();
            var result = from organizator in EditCompetition.db.Organizators
                         select new
                         {
                             Код = organizator.Id,
                             Фамилия = organizator.Organizator.LastName,
                             Имя = organizator.Organizator.FirstName,
                             Отчество = organizator.Organizator.MiddleName,
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
    }
}