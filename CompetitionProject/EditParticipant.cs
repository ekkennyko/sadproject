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
    public partial class EditParticipant : Form
    {
        CompetitionDB db;
        public bool result = false;
        public EditParticipant()
        { 
            InitializeComponent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}
