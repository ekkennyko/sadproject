﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseArch;
using CompetitionClasses;

namespace CompetitionProject
{
    public partial class SelectSportType : Form
    {
        CompetitionDB db;
        public bool result = false;
        public SelectSportType()
        {
            InitializeComponent();
            //comboBox1.DataSource = ;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "SportTypeId";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "SportTypeId";
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Organizators organizator = (Organizators)comboBox1.SelectedItem;
            //listBox1.Items.Add(organizator);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }
    }
}