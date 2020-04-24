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
    public partial class EditResult : Form
    {
        protected internal bool result = false;
        public EditResult()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}
