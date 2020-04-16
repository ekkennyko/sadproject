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
    public partial class EditCategory : Form
    {
        protected internal bool result = false;
        public EditCategory()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}
