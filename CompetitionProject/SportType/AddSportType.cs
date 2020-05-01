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
        public AddSportType()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            using (CompetitionDB db = new CompetitionDB())
            {
                bool res = false;
                int count = 0;
                SportType newSportType = new SportType()
                {
                    Name = NameSport.Text,
                    Type = Type.Text,
                };
                try
                {
                    var sportype = db.SportTypes.ToList();
                    foreach (SportType st in sportype)
                    {
                        if (NameSport.Text != st.Name && Type.Text != st.Type)
                        {
                            if (count == sportype.Count - 1)
                            {
                                db.SportTypes.Add(newSportType);
                                db.SaveChanges();
                                res = true;
                                MessageBox.Show("Новый вид спорта добавлен");
                                this.Close();
                            }
                            count++;
                        }
                        else
                        {
                            res = true;
                            MessageBox.Show("Такой вид спорта уже сущесвует");
                        }
                    }
                    if (res == false)
                    {
                        db.SportTypes.Add(newSportType);
                        db.SaveChanges();
                        MessageBox.Show("Новый вид спорта добавлен");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении:\n" + ex);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
