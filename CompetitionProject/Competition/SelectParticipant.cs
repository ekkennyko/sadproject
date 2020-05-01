using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataBaseArch;

namespace CompetitionProject.Competition
{
    public partial class SelectParticipant : Form
    {
        public SelectParticipant()
        {
            InitializeComponent();
            loadToList();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void loadToList()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Participants.Load();
                var result = from participant in db.Participants
                             select new
                             {
                                 Код = participant.PersonId,
                                 Фамилия = participant.LastName,
                                 Имя = participant.FirstName,
                                 Отчество = participant.MiddleName,
                                 Ранг = participant.Rank,
                                 Регион = participant.Region
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }
    }
}
