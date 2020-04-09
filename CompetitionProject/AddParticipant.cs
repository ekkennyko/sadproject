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
            CompetitionDB addParticipant = new CompetitionDB();
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
                var participant = addParticipant.Participants;
                foreach (CompetitionClasses.Participant pt in participant)
                {
                    if (Passport.Text != pt.Passport)
                    {
                        addParticipant.Participants.Add(newParticipant);
                        addParticipant.SaveChanges();
                        MessageBox.Show("Новый участник добавлен");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Такой участник уже существует");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении");
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
