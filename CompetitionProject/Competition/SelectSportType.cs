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
using System.Data.Entity;

namespace CompetitionProject.Competition
{
    public partial class SelectSportType : Form
    {
        public SelectSportType()
        {
            InitializeComponent();
            loadToList();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadToList()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.SportTypes.Load();
                var result = from sportType in db.SportTypes
                             select new
                             {
                                 Код = sportType.Id,
                                 Название = sportType.Name,
                                 Тип = sportType.Type
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }
    }
}
