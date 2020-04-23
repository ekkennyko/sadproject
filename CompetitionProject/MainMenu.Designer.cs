namespace CompetitionProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.competitionButton = new System.Windows.Forms.Button();
            this.participantButton = new System.Windows.Forms.Button();
            this.typeSportButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // competitionButton
            // 
            this.competitionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.competitionButton.Location = new System.Drawing.Point(360, 14);
            this.competitionButton.Name = "competitionButton";
            this.competitionButton.Size = new System.Drawing.Size(118, 27);
            this.competitionButton.TabIndex = 0;
            this.competitionButton.Text = "Соревнования";
            this.competitionButton.UseVisualStyleBackColor = true;
            this.competitionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // participantButton
            // 
            this.participantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.participantButton.Location = new System.Drawing.Point(360, 47);
            this.participantButton.Name = "participantButton";
            this.participantButton.Size = new System.Drawing.Size(118, 27);
            this.participantButton.TabIndex = 1;
            this.participantButton.Text = "Участники";
            this.participantButton.UseVisualStyleBackColor = true;
            this.participantButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // typeSportButton
            // 
            this.typeSportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeSportButton.Location = new System.Drawing.Point(360, 80);
            this.typeSportButton.Name = "typeSportButton";
            this.typeSportButton.Size = new System.Drawing.Size(118, 27);
            this.typeSportButton.TabIndex = 2;
            this.typeSportButton.Text = "Виды спорта";
            this.typeSportButton.UseVisualStyleBackColor = true;
            this.typeSportButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton.Location = new System.Drawing.Point(360, 146);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(118, 27);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Отчёт";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(360, 179);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 27);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Должность:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(91, 14);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(76, 18);
            this.LastName.TabIndex = 9;
            this.LastName.Text = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(58, 47);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(48, 18);
            this.FirstName.TabIndex = 10;
            this.FirstName.Text = "Name";
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleName.Location = new System.Drawing.Point(87, 81);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(91, 18);
            this.MiddleName.TabIndex = 11;
            this.MiddleName.Text = "MiddleName";
            // 
            // Job
            // 
            this.Job.AutoSize = true;
            this.Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Job.Location = new System.Drawing.Point(100, 114);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(33, 18);
            this.Job.TabIndex = 12;
            this.Job.Text = "Job";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Эл. почта:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(97, 148);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(45, 18);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email";
            // 
            // CategoryButton
            // 
            this.CategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryButton.Location = new System.Drawing.Point(360, 113);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(118, 27);
            this.CategoryButton.TabIndex = 15;
            this.CategoryButton.Text = "Категории";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.Crimson;
            this.EmployeeButton.Location = new System.Drawing.Point(250, 14);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(104, 27);
            this.EmployeeButton.TabIndex = 16;
            this.EmployeeButton.Text = "Сотрудники";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.OrgButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 216);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.CategoryButton);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Job);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.typeSportButton);
            this.Controls.Add(this.participantButton);
            this.Controls.Add(this.competitionButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button competitionButton;
        private System.Windows.Forms.Button participantButton;
        private System.Windows.Forms.Button typeSportButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label LastName;
        protected internal System.Windows.Forms.Label FirstName;
        protected internal System.Windows.Forms.Label MiddleName;
        protected internal System.Windows.Forms.Label Job;
        private System.Windows.Forms.Label label9;
        protected internal System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button EmployeeButton;
    }
}