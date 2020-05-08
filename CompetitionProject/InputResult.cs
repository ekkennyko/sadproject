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
using CompetitionProject.Competition;

namespace CompetitionProject
{
    public partial class inputResult : Form
    {
        public static CompetitionClasses.Participant participant;
        public static CompetitionDB db = new CompetitionDB();
        public inputResult()
        {
            InitializeComponent();
        }

        private void selectParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            {
                bool res = false;
                //int count = 0;
                CompetitionClasses.CompetitionResult competitionResult = new CompetitionClasses.CompetitionResult()
                {
                    Participant = selectParticipant.Text,
                    Position = Position.Text,
                };
                try
                {
                    var tempCompetition = db.Competitions.ToList();
                    if (res == false)
                    {
                        //db.Competitions.Add(competi);
                        db.SaveChanges();
                       // toList(competition);
                        MessageBox.Show("Результат добавлен");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении:\n" + ex);
                }
            }
        }

        private void Position_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
