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
    public partial class SelectParticipant : Form
    {
        CompetitionDB db = new CompetitionDB();
        public SelectParticipant()
        {
            InitializeComponent();

            List<CompetitionClasses.Participant> participants = db.Participants.ToList();
            dbCombo.DataSource = participants;
            dbCombo.DisplayMember = "LastName" //+ "FirstName " + "MiddleName"
                ;
            dbCombo.ValueMember = "PersonId";

            dbCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            dbList.DisplayMember = "LastName" //+ "FirstName " + "MiddleName"
                ;
            dbList.ValueMember = "PersonId";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Participant participant = (Participant)dbCombo.SelectedItem;

            dbList.Items.Add(participant);
        }
        private void OkButton_Click(object sender, EventArgs e)
        {

        }

        private void dbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
