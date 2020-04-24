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
            CompetitionDB addCategory = new CompetitionDB();
            CompetitionClasses.Category newCategory = new CompetitionClasses.Category()
            {
                Name = NameBox.Text,
                Age = AgeBox.Text,
                Weight = WeightBox.Text,
                Gender = GenderBox.Text
            };
            try
            {
                bool res = false;
                var category = addCategory.Categories;
                foreach (Category cat in category)
                {
                    if (NameBox.Text != cat.Name && GenderBox.Text != cat.Gender)
                    {
                        addCategory.Categories.Add(newCategory);
                        addCategory.SaveChanges();
                        MessageBox.Show("Новая категория добавлена");
                        res = true;
                        this.Close();
                    }
                    else
                    {
                        res = true;
                        MessageBox.Show("Такая категория уже существует");
                    }
                }
                if (res == false)
                {
                    addCategory.Categories.Add(newCategory);
                    addCategory.SaveChanges();
                    MessageBox.Show("Новая категория добавлена");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }
        }
    }
}
