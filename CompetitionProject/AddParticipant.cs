using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompetitionClasses;
using DataBaseArch;

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

        private void button1_Click(object sender, EventArgs e)
        {
            CompetitionDB addParticipant = new CompetitionDB();
            Participant newParticipant = new Participant()
            {
                LastName = textBox1.Text,
                FirstName = textBox2.Text,
                MiddleName = textBox4.Text,
                Birthday = dateTimePicker1.Value,
                Gender = comboBox1.Text,
                Region = textBox6.Text,
                SportClub = textBox7.Text,
                Rank = textBox8.Text,
                Weight = int.Parse(textBox9.Text),
                Email = textBox10.Text
            };
            addParticipant.Participants.Add(newParticipant);
            addParticipant.SaveChanges();
            MessageBox.Show("Новый участник добавлен");
            this.Close();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
