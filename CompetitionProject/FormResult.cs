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
using CompetitionClasses;
using CompetitionProject.Migrations;

namespace CompetitionProject
{
    public partial class FormResult : Form
    {
        public CompetitionDB db = new CompetitionDB();
        public FormResult()
        {
            InitializeComponent();
        }

        private void inputResult_Click(object sender, EventArgs e)
        {
            inputResult inputResult = new inputResult();
            inputResult.ShowDialog();
        }

        private void outReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void participantBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
