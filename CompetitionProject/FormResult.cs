using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetitionProject
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void inputResult_Click(object sender, EventArgs e)
        {
            InputResult inputResult = new InputResult();
            inputResult.ShowDialog();
        }
    }
}
