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
    public partial class SelectSportType : Form
    {
        CompetitionDB db = new CompetitionDB();
        public SelectSportType()
        {
            InitializeComponent();

            List<SportType> sportTypes = db.SportTypes.ToList();
            dbCombo.DataSource = sportTypes;
            dbCombo.DisplayMember = "Name";
            dbCombo.ValueMember = "Id";

            dbCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            dbList.DisplayMember = "Name";
            dbList.ValueMember = "Id";
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SportType sportType = (SportType)dbCombo.SelectedItem;

            dbList.Items.Add(sportType);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
