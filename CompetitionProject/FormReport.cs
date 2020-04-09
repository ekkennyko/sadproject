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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CompetitionProject
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        CompetitionDB db;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                CompetitionClasses.CompetitionResult competitionResult = db.CompetitionsResults.Find(id);
                ResultEdit resultEdit = new ResultEdit();
                resultEdit.textBox1.Text = competitionResult.Position;


                resultEdit.ShowDialog();
                if (resultEdit.result == true)
                {
                    competitionResult.Position = resultEdit.textBox1.Text;

                    db.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Информация о результатах обновлена");
                }
            }
            else
            {
                MessageBox.Show("Выберите участника");
            }
        }
    }
}
