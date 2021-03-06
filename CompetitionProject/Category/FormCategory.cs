﻿using System;
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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            RefreshButton_Click(null, null);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Category category = db.Categories.Find(id);
                    try
                    {
                        db.Categories.Remove(category);
                        db.SaveChanges();
                        MessageBox.Show("Категория удалена");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка");
                    }

                }
                else
                {
                    MessageBox.Show("Выберите категорию");
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Categories.Load();

                var result = from category in db.Categories
                             select new
                             {
                                 Код = category.CategoryId,
                                 Название = category.Name,
                                 Пол = category.Gender,
                                 Возраст = category.Age,
                                 Вес_кг = category.Weight,
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Category category = db.Categories.Find(id);
                    EditCategory editCategory = new EditCategory();
                    editCategory.NameBox.Text = category.Name;
                    editCategory.AgeBox.Text = category.Age;
                    editCategory.WeightBox.Text = category.Weight;
                    editCategory.GenderBox.Text = category.Gender;

                    editCategory.ShowDialog();
                    if (editCategory.result == true)
                    {
                        try
                        {
                            category.Name = editCategory.NameBox.Text;
                            category.Age = editCategory.AgeBox.Text;
                            category.Weight = editCategory.WeightBox.Text;

                            db.SaveChanges();
                            dataGridView1.Refresh();
                            MessageBox.Show("Информация о категории обновлена");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберите категорию");
                }
            }
        }

    }
}
