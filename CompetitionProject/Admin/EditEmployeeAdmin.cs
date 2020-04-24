using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CompetitionProject.Admin
{
    public partial class EditEmployeeAdmin : Form
    {
        protected internal bool result = false;
        public EditEmployeeAdmin()
        {
            InitializeComponent();
        }

        private void EditEmployeeAdmin_Load(object sender, EventArgs e)
        {

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
    }
}
