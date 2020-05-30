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
        public CompetitionDB DB { get; set; }
        public inputResult()
        {
            InitializeComponent();
           
        }
        
        private void inputResult_Load(object sender, EventArgs e)
        {
                selectParticipant.DataSource = DB.Participants.ToList();
                selectParticipant.ValueMember = "PersonId";
                selectParticipant.DisplayMember = "FirstName";
                
            }
        
        private void selectParticipant_SelectedIndexChanged(object sender, EventArgs e)
            {
                
            }
        private void okButton_Click(object sender, EventArgs e)
        {
            {
               CompetitionResult newResult = new CompetitionResult()
                {
                    Participant = selectParticipant.Text,
                    Position = Position.Text,
                };
                if (selectParticipant.SelectedValue != null)
                {
                    newResult.CompResId = Convert.ToInt32(selectParticipant.SelectedValue);
                }
                DB.CompetitionsResults.Add(newResult);
                try
                {
                    DB.SaveChanges();
                    MessageBox.Show(newResult.CompResId.ToString());
                    MessageBox.Show("Результат добавлен");
                    this.Close();
                }   
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
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
