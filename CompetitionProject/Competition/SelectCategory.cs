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
    public partial class SelectCategory : Form
    {
        public SelectCategory()
        {
            InitializeComponent();
        }
        public static void SelectDataGridViewCell(DataGridView dataGridView, int rowIndex, int cellIndex)
        {
            DataGridViewCell cell = dataGridView.Rows[rowIndex].Cells[0];
            dataGridView.CurrentCell = cell;
            dataGridView.CurrentCell.Selected = true;
        }

        public static void SelectDataGridViewRow(DataGridView dataGridView, int rowNum)
        {
            SelectDataGridViewCell(dataGridView, rowNum, 0);
        }

        public static int CalculateNewSelRowIndex(int oldRowCount, int newRowCount, int oldRowIndex)
        {
            int newRowIndex = 0;

            if (newRowCount >= oldRowCount)
            {
                newRowIndex = oldRowIndex;
            }
            else if (newRowCount > 1)
            {
                newRowIndex = newRowCount - 1;
            }

            return newRowIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
