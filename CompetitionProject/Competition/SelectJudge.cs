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
    public partial class SelectJudge : Form
    {
        public SelectJudge()
        {
            InitializeComponent();
            loadToList();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadToList()
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Judges.Load();
                var result = from judge in db.Judges
                             select new
                             {
                                 Код = judge.JudgeId,
                                 Фамилия = judge.Judge.LastName,
                                 Имя = judge.Judge.FirstName,
                                 Отчество = judge.Judge.MiddleName,
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }
    }
}
