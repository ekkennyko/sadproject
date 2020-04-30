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
    public partial class SelectJudge : Form
    {
        CompetitionDB db = new CompetitionDB();
        public SelectJudge()
        {
            InitializeComponent();

            List<CompetitionJudge> judges = db.Judges.ToList();
            dbCombo.DataSource = judges;
            dbCombo.DisplayMember = "LastName" + "FirstName" + "MiddleName";
            dbCombo.ValueMember = "JudgeId";

            dbCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            dbList.DisplayMember = "LastName" + "FirstName" + "MiddleName";
            dbList.ValueMember = "JudgeId";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompetitionJudge competitionJudge = (CompetitionJudge)dbCombo.SelectedItem;

            dbList.Items.Add(competitionJudge);
        }
        private void OkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
