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
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    CompetitionClasses.SportType sportType = db.SportTypes.Find(id);
                    try
                    {
                        db.SportTypes.Remove(sportType);
                        db.SaveChanges();
                        MessageBox.Show("Вид спорта удален");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка:\n" + ex);
                    }

                }
                else
                {
                    MessageBox.Show("Сначала выберите вид спорта");
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    CompetitionClasses.SportType sportType = db.SportTypes.Find(id);
                    EditSportType editSportType = new EditSportType();
                    editSportType.NameSport.Text = sportType.Name;
                    editSportType.Type.Text = sportType.Type;

                    editSportType.ShowDialog();
                    if (editSportType.result == true)
                    {
                        try
                        {
                            sportType.Name = editSportType.NameSport.Text;
                            sportType.Type = editSportType.Type.Text;

                            db.SaveChanges();
                            dataGridView1.Refresh();
                            MessageBox.Show("Информация о виде спорта обновлена");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Сначала выберите вид спорта");
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.SportTypes.Load();

                var result = from sportType in db.SportTypes
                             select new
                             {
                                 Код = sportType.Id,
                                 Название = sportType.Name,
                                 Тип = sportType.Type,
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }

        private void FormSportType_Load(object sender, EventArgs e)
        {

        }
    }
}
