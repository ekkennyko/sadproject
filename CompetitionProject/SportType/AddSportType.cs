using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompetitionClasses;
using DataBaseArch;

namespace CompetitionProject
{
    public partial class AddSportType : Form
    {
        CompetitionDB addSportType = new CompetitionDB();
        public AddSportType()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CompetitionClasses.SportType newSportType = new CompetitionClasses.SportType()
            {
                Name = NameSport.Text,
                Type = Type.Text,
            };
            try
            {
                bool res = false;
                var sportype = addSportType.SportTypes;
                foreach (CompetitionClasses.SportType st in sportype)
                {
                    if (NameSport.Text != st.Name && Type.Text != st.Type)
                    {
                        addSportType.SportTypes.Add(newSportType);
                        addSportType.SaveChanges();
                        MessageBox.Show("Новый вид спорта добавлен");
                        res = true;
                        this.Close();
                    }
                    else
                    {
                        res = true;
                        MessageBox.Show("Такой вид спорта уже сущесвует");
                    }
                }
                if (res == false)
                {
                    addSportType.SportTypes.Add(newSportType);
                    addSportType.SaveChanges();
                    MessageBox.Show("Новый вид спорта добавлен");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении:\n" + ex);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
