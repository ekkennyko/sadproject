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

namespace CompetitionProject
{
    public partial class SelectCategory : Form
    {
        CompetitionDB db = new CompetitionDB();
        AddCompetition competitionForm = new AddCompetition();
        public SelectCategory()
        {
            InitializeComponent();

            loadToList();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void loadToList()
        {
            db.Categories.Load();

            var result = from category in db.Categories
                         select new
                         {
                             Код = category.CategoryId,
                             Название = category.Name,
                             Вес = category.Weight
                         };
            dataGridView1.DataSource = result.ToList();
        }
    }
}
