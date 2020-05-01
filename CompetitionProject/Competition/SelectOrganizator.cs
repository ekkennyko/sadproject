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

namespace CompetitionProject.Competition
{
    public partial class SelectOrganizator : Form
    {
        public SelectOrganizator()
        {
            InitializeComponent();
            loadToList();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void loadToList()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Organizators.Load();
                var result = from organizator in db.Organizators
                             select new
                             {
                                 Код = organizator.OrganizatorId,
                                 Фамилия = organizator.Organizator.LastName,
                                 Имя = organizator.Organizator.FirstName,
                                 Отчество = organizator.Organizator.MiddleName,
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }
    }
}
