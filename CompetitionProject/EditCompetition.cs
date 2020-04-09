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

namespace CompetitionProject.Migrations
{
    public partial class EditCompetition : Form
    {
        protected internal bool result = false;
        public EditCompetition()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }

        private void EditCompetition_Load(object sender, EventArgs e)
        {

        }
    }
}
