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
    public partial class SelectOrganizator : Form
    {
        CompetitionDB db = new CompetitionDB();
        public SelectOrganizator()
        {
            InitializeComponent();

            List<CompetitionOrganizator> organizators = db.Organizators.ToList();
            dbCombo.DataSource = organizators;
            dbCombo.DisplayMember = "LastName" + "FirstName" + "MiddleName";
            dbCombo.ValueMember = "OrganizatorId";

            dbCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            dbList.DisplayMember = "LastName" + "FirstName" + "MiddleName";
            dbList.ValueMember = "OrganizatorId";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompetitionOrganizator competitionOrganizator = (CompetitionOrganizator)dbCombo.SelectedItem;

            dbList.Items.Add(competitionOrganizator);
        }
        private void OkButton_Click(object sender, EventArgs e)
        {

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
