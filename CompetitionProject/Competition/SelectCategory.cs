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
using CompetitionClasses;
using System.Data.Entity;
using CompetitionProject.Competition;

namespace CompetitionProject
{
    public partial class SelectCategory : Form
    {
        public SelectCategory()
        {
            InitializeComponent();

            loadToList();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                int index = dataGridView2.Rows[0].Index;
                bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out int id);
                if (converted == false)
                    return;
                AddCompetition.category = AddCompetition.db.Categories.FirstOrDefault(temp => temp.CategoryId == id);
            }
            else
            {
                MessageBox.Show("Добавьте категорию");
            }
        }

        private void loadToList()
        {
            AddCompetition.db.Categories.Load();

            var result = from category in AddCompetition.db.Categories
                         select new
                         {
                             Код = category.CategoryId,
                             Название = category.Name,
                             Вес = category.Weight
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