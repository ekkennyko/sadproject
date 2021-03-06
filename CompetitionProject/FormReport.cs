﻿using System;
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
using Microsoft.Office.Interop.Excel;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace CompetitionProject
{
    public partial class FormReport : Form
    {
        string a, b;
        public CompetitionDB DB { get; set; }
        public FormReport()
        {
            InitializeComponent();
        }
        DataGridView DGV = new DataGridView();

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
                    Document pdfdoc = new Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf";
            saveFileDialog1.Title = "Save an PDF File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                dgvtopdf(dataGridView1, saveFileDialog1.FileName);
                fs.Close();
            }
        }

        private void ExcelButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelExport = new Microsoft.Office.Interop.Excel.Application();
                excelExport.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excelExport.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count + 1; j++)
                    {
                        excelExport.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelExport.Columns.AutoFit();
                excelExport.Visible = true;
            }
        }

        private void Jpgtopdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "C:\\Users";
            dlg.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PdfSharp.Pdf.PdfDocument doc = new PdfSharp.Pdf.PdfDocument();
                doc.Info.Title = "made by Pechal' Project";

                foreach (string fileSpec in dlg.FileNames)
                {
                    PdfSharp.Pdf.PdfPage page = doc.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
                    XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
                    a = Convert.ToString(comboBox1.SelectedValue);
                    b = Convert.ToString(comboBox1.SelectedItem);

                    gfx.DrawString("Награждается", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                    gfx.DrawString(a, font, XBrushes.Black, new XRect(0, 25, page.Width, page.Height), XStringFormats.Center);
                    gfx.DrawString("Занявший", font, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), XStringFormats.Center);
                    gfx.DrawString(b, font, XBrushes.Black, new XRect(0, 75, page.Width, page.Height), XStringFormats.Center);
                    gfx.DrawString("место", font, XBrushes.Black, new XRect(0, 100, page.Width, page.Height), XStringFormats.Center);

                }
                
                if (doc.PageCount > 0)
                {
                    doc.Save(@"C:\Users\User\Downloads\Result.pdf");
                }
            }
        }

        public void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            var part = from Participant in DB.Participants select Participant;
            comboBox1.DataSource = part.ToList();
            comboBox1.ValueMember = "PersonId";
            comboBox1.DisplayMember = "FirstName";
        }
    }
}
