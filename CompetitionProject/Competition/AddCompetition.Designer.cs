namespace CompetitionProject
{
    partial class AddCompetition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompetition));
            this.ExitButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BriefInfo = new System.Windows.Forms.TextBox();
            this.PlaceLocation = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.CheckCat = new System.Windows.Forms.CheckBox();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckSport = new System.Windows.Forms.CheckBox();
            this.SportButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(352, 248);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 27);
            this.ExitButton.TabIndex = 44;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 70);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 21);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // BriefInfo
            // 
            this.BriefInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BriefInfo.Location = new System.Drawing.Point(197, 190);
            this.BriefInfo.Multiline = true;
            this.BriefInfo.Name = "BriefInfo";
            this.BriefInfo.Size = new System.Drawing.Size(242, 52);
            this.BriefInfo.TabIndex = 41;
            // 
            // PlaceLocation
            // 
            this.PlaceLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceLocation.Location = new System.Drawing.Point(262, 38);
            this.PlaceLocation.Name = "PlaceLocation";
            this.PlaceLocation.Size = new System.Drawing.Size(177, 21);
            this.PlaceLocation.TabIndex = 36;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(262, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(177, 21);
            this.Title.TabIndex = 35;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Краткая информация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Дата проведения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Место проведения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Название:";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(262, 248);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(87, 27);
            this.OkButton.TabIndex = 24;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(14, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "Статус:";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Не начат",
            "Начат",
            "Закончён"});
            this.statusBox.Location = new System.Drawing.Point(262, 100);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(177, 23);
            this.statusBox.TabIndex = 56;
            // 
            // CheckCat
            // 
            this.CheckCat.AutoSize = true;
            this.CheckCat.Enabled = false;
            this.CheckCat.Location = new System.Drawing.Point(240, 135);
            this.CheckCat.Name = "CheckCat";
            this.CheckCat.Size = new System.Drawing.Size(15, 14);
            this.CheckCat.TabIndex = 86;
            this.CheckCat.UseVisualStyleBackColor = true;
            // 
            // CategoryButton
            // 
            this.CategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryButton.Location = new System.Drawing.Point(261, 130);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(177, 24);
            this.CategoryButton.TabIndex = 85;
            this.CategoryButton.Text = "Добавить";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 82;
            this.label7.Text = "Категория:";
            // 
            // CheckSport
            // 
            this.CheckSport.AutoCheck = false;
            this.CheckSport.AutoSize = true;
            this.CheckSport.Location = new System.Drawing.Point(240, 165);
            this.CheckSport.Name = "CheckSport";
            this.CheckSport.Size = new System.Drawing.Size(15, 14);
            this.CheckSport.TabIndex = 90;
            this.CheckSport.UseVisualStyleBackColor = true;
            // 
            // SportButton
            // 
            this.SportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SportButton.Location = new System.Drawing.Point(261, 160);
            this.SportButton.Name = "SportButton";
            this.SportButton.Size = new System.Drawing.Size(177, 24);
            this.SportButton.TabIndex = 89;
            this.SportButton.Text = "Добавить";
            this.SportButton.UseVisualStyleBackColor = true;
            this.SportButton.Click += new System.EventHandler(this.SportButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 88;
            this.label6.Text = "Вид спорта:";
            // 
            // AddCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 290);
            this.Controls.Add(this.CheckSport);
            this.Controls.Add(this.SportButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckCat);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BriefInfo);
            this.Controls.Add(this.PlaceLocation);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCompetition";
            this.Text = "Добавление соревнования";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox BriefInfo;
        private System.Windows.Forms.TextBox PlaceLocation;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox statusBox;
        protected internal System.Windows.Forms.CheckBox CheckCat;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.CheckBox CheckSport;
        private System.Windows.Forms.Button SportButton;
        private System.Windows.Forms.Label label6;
    }
}