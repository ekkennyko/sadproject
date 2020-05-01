using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompetitionClasses;
using DataBaseArch;

namespace CompetitionProject
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                bool res = false;
                int count = 0;
                CompetitionClasses.Category newCategory = new CompetitionClasses.Category()
                {
                    Name = NameBox.Text,
                    Age = AgeBox.Text,
                    Weight = WeightBox.Text,
                    Gender = GenderBox.Text
                };
                try
                {
                    var category = db.Categories.ToList();
                    foreach (Category cat in category)
                    {
                        if (NameBox.Text != cat.Name && GenderBox.Text != cat.Gender)
                        {
                            if (count == category.Count - 1)
                            {
                                db.Categories.Add(newCategory);
                                db.SaveChanges();
                                res = true;
                                MessageBox.Show("Новая категория добавлена");
                                this.Close();
                            }
                            count++;
                        }
                        else
                        {
                            res = true;
                            MessageBox.Show("Данная категория уже существует");
                        }
                    }
                    if (res == false)
                    {
                        db.Categories.Add(newCategory);
                        db.SaveChanges();
                        MessageBox.Show("Новая категория добавлена");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении:\n" + ex);
                }
            }
        }
    }
}
