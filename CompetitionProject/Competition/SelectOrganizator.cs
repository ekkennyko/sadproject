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
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    int index = dataGridView2.Rows[0].Index;
                    bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    AddCompetition.organizator = db.Organizators.Find(id);
                }
                else
                {
                    MessageBox.Show("Добавьте категорию");
                }
            }
        }

        private void loadToList()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Organizators.Load();
                var result = from organizator in db.Organizators
                             select new
                             {
                                 Код = organizator.OrganizatorId,
                                 Фамилия = organizator.Organizator.LastName,
                                 Имя = organizator.Organizator.FirstName,
                                 Отчество = organizator.Organizator.MiddleName,
                             };
                dataGridView1.DataSource = result.ToList();
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
