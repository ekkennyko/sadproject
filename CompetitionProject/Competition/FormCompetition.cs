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
using CompetitionClasses;
using CompetitionProject.Migrations;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CompetitionProject
{
    public partial class FormCompetition : Form
    {
        public FormCompetition()
        {
            InitializeComponent();
            RefreshButton_Click_1(null, null);
        }

        DataGridView DGV = new DataGridView();

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCompetition addCompetition = new AddCompetition();
            addCompetition.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Competition competition = db.Competitions.Find(id);
                    db.Competitions.Remove(competition);
                    db.SaveChanges();
                    MessageBox.Show("Соревнование удалено");

                }
                else
                {
                    MessageBox.Show("Выберите соревнование");
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Competition competition = db.Competitions.Find(id);
                    EditCompetition editCompetition = new EditCompetition();
                    editCompetition.TitleBox.Text = competition.Title;
                    editCompetition.LocationBox.Text = competition.Location;
                    editCompetition.dateTimePicker1.Value = competition.DateCompetition;

                    editCompetition.ShowDialog();
                    if (editCompetition.result == true)
                    {
                        competition.Title = editCompetition.TitleBox.Text;
                        competition.Location = editCompetition.LocationBox.Text;
                        competition.DateCompetition = editCompetition.dateTimePicker1.Value;

                        db.SaveChanges();
                        dataGridView1.Refresh();
                        MessageBox.Show("Информация о соревновании обновлена");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите соревнование");
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    CompetitionClasses.Competition competition = db.Competitions.Find(id);
                    InfoCompetition infoCompetition = new InfoCompetition();
                    infoCompetition.Title.Text = competition.Title;
                    infoCompetition.PlaceLocation.Text = competition.Location;
                    infoCompetition.TimeDate.Text = competition.DateCompetition.ToString();
                    
                    infoCompetition.BriefInfo.Text = competition.BriefInformation;

                    infoCompetition.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите соревнование");
                }
            }
        }

        private void FormCompetition_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshButton_Click_1(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                db.Competitions.Load();
                var result = from competition in db.Competitions
                             select new
                             {
                                 Название = competition.Title,
                                 Дата = competition.DateCompetition,
                                 Место_проведения = competition.Location,
                             };
                dataGridView1.DataSource = result.ToList();
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            FormResult formResult = new FormResult();
            formResult.ShowDialog();
        }

        private void SaveInPDF_Click(object sender, EventArgs e)
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
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
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
    }
}
