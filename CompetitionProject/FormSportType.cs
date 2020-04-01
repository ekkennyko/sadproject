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
    public partial class FormSportType : Form
    {
        CompetitionDB db;
        public FormSportType()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddSportType addSportType = new AddSportType();
            addSportType.ShowDialog();
        }

        private void ToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                SportType sportType = db.SportTypes.Find(id);
                db.SportTypes.Remove(sportType);
                db.SaveChanges();
                MessageBox.Show("Вид спорта удален");

            }
            else
            {
                MessageBox.Show("Для начала выберите вид спорта");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                SportType sportType = db.SportTypes.Find(id);
                EditSportType editSportType = new EditSportType();
                editSportType.textBox1.Text = sportType.Name;
                editSportType.textBox2.Text = sportType.Type;

                editSportType.ShowDialog();
                if (editSportType.result == true)
                {
                    sportType.Name = editSportType.textBox1.Text;
                    sportType.Type = editSportType.textBox2.Text;

                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Информация о виде спорта обновлена");
                }
                else
                {
                    MessageBox.Show("Для начала выберите вид спорта");
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                SportType sportType = db.SportTypes.Find(id);
                InfoSportType infoSportType = new InfoSportType();
                infoSportType.label3.Text = sportType.Name;
                infoSportType.label4.Text = sportType.Type;
                infoSportType.ShowDialog();
            }
            else
            {
                MessageBox.Show("Для начала выберите вид спорта");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            db = new CompetitionDB();
            db.SportTypes.Load();

            var result = from sportType in db.SportTypes
                         select new
                         {
                             Код = sportType.SportTypeId,
                             Название = sportType.Name,
                             Тип = sportType.Type,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void FormSportType_Load(object sender, EventArgs e)
        {

        }
    }
}
