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
        public static CompetitionClasses.CompetitionResult result;
        public static CompetitionDB db = new CompetitionDB();
        public inputResult()
        {
            InitializeComponent();
           
        }

        
        private void inputResult_Load(object sender, EventArgs e)
        {
            List<Participant> participants = (from participant in db.Participants
                                        select participant).Take(4).ToList();
            participants.Insert(0, new Participant
            {
                PersonId = 0,
                FirstName = "Please select"
            });
            selectParticipant.DataSource = participants;
            selectParticipant.DisplayMember = "FirstName";
            selectParticipant.ValueMember = "PersonId";
        }
        private void selectParticipant_SelectedIndexChanged(object sender, EventArgs e)
            {
                
            }
        private void okButton_Click(object sender, EventArgs e)
        {
            {
                bool res = false;
                int count = 0;
                CompetitionClasses.CompetitionResult newResult = new CompetitionClasses.CompetitionResult()
                {
                    Participant = selectParticipant.Text,
                    Position = Position.Text,
                };
                try
                {
                    var Result = db.CompetitionsResults.ToList();
                    foreach (CompetitionClasses.CompetitionResult el in Result)
                    {
                        int max= 3;
                        if (count == max - 1)
                        {
                            {
                                db.CompetitionsResults.Add(newResult);
                                db.SaveChanges();
                                MessageBox.Show(newResult.CompResId.ToString());
                                MessageBox.Show("Результат добавлен");
                                res = true;
                                this.Close();
                            }
                            count++;

                        }
                        else
                        {
                            res = true;
                            MessageBox.Show("Такой результат уже существует");
                        }
                    }
                    if (res == false)
                    {
                        db.CompetitionsResults.Add(newResult);
                        db.SaveChanges();
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
