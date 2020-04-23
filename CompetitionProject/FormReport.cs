using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DataBaseArch;
using System.IO;
using iTextSharp;
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
        DataGridView DGV = new DataGridView();

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

        public void dgvtopdf(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgv.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                pdftable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog()==DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName,FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            dgvtopdf(dataGridView1, "Отчет");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
