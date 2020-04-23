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
            SportType newSportType = new SportType()
            {
                SportTypeId = 1,
                Name = NameSport.Text,
                Type = Type.Text,
            };
            try
            {
                //var sportype = addSportType.SportTypes;
                //foreach (SportType st in sportype)
                //{
                  //  if (NameSport.Text != st.Name && Type.Text != st.Type)
                    //{
                        addSportType.SportTypes.Add(newSportType);
                        addSportType.SaveChanges();
                        MessageBox.Show("Новый вид спорта добавлен");
                        this.Close();
                    //}
                    //else
                    //{
                     //   MessageBox.Show("Такой вид спорта уже сущесвует");
                    //}
                //}
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                string s = "";
                foreach (var et in ex.EntityValidationErrors)
                {
                    foreach (var er in et.ValidationErrors)
                    {
                        s += er.PropertyName + ". Message: " + er.ErrorMessage;
                    }
                }
                MessageBox.Show(s);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
