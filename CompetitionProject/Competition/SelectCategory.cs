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

namespace CompetitionProject
{
    public partial class SelectCategory : Form
    {
        CompetitionDB db = new CompetitionDB();
        AddCompetition competition = new AddCompetition();
        public SelectCategory()
        {
            InitializeComponent();

            List<Category> categories = db.Categories.ToList();
            dbCombo.DataSource = categories;
            dbCombo.DisplayMember = "Name";
            dbCombo.ValueMember = "CategoryId";

            dbCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            dbList.DisplayMember = "Name";
            dbList.ValueMember = "CategoryId";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category)dbCombo.SelectedItem;
            dbList.Items.Add(category);
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            competition.res = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            competition.res = false;
            this.Close();
        }
    }
}
