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
        AddCompetition competitionForm = new AddCompetition();
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
            ////Category category = (Category)dbList.SelectedItem;
            //if (dbList.Items.Count > 0)
            //{
            //    for (int i = 0; i < dbList.Items.Count; i++)
            //    {
            //        DataRowView D1 = dbList.Selec as DataRowView;

            //        int id = (int)D1[1];
              
            //        Category category = db.Categories.Find(id);
            //        try
            //        {

            //            competitionForm.newCompetition.Categories.Add(category);
            //        }
            //        catch
            //        {

            //        }
            //    }
            //}

            competitionForm.resComp = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            competitionForm.resComp = false;
            this.Close();
        }
    }
}
