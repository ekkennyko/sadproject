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
    public partial class AddParticipant : Form
    {
        public AddParticipant()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                bool res = false;
                int count = 0;
                CompetitionClasses.Participant newParticipant = new CompetitionClasses.Participant()
                {
                    LastName = LastName.Text,
                    FirstName = FirstName.Text,
                    MiddleName = MiddleName.Text,
                    Birthday = TimeDate.Value,
                    Gender = Gender.Text,
                    Region = CrntRegion.Text,
                    SportClub = SportClub.Text,
                    Rank = Rank.Text,
                    Weight = double.Parse(Weight.Text),
                    Email = Email.Text,
                    Passport = Passport.Text
                };
                try
                { 
                    var participant = db.Participants.ToList();
                    foreach (CompetitionClasses.Participant pt in participant)
                    {
                        if (Passport.Text != pt.Passport)
                        {
                            if (count == participant.Count - 1)
                            {
                                db.Participants.Add(newParticipant);
                                db.SaveChanges();
                                MessageBox.Show("Новый участник добавлен");
                                res = true;
                                this.Close();
                            }
                            count++;
                        }
                        else
                        {
                            res = true;
                            MessageBox.Show("Такой участник уже существует");
                        }
                    }
                    if (res == false)
                    {
                        db.Participants.Add(newParticipant);
                        db.SaveChanges();
                        MessageBox.Show("Новый участник добавлен");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении:\n" + ex);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
