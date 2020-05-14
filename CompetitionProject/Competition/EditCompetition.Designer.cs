using System;

namespace CompetitionProject.Migrations
{
    partial class EditCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCompetition));
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckJudge = new System.Windows.Forms.CheckBox();
            this.CheckOrg = new System.Windows.Forms.CheckBox();
            this.JudgeButton = new System.Windows.Forms.Button();
            this.OrgButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PlaceLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CheckPart = new System.Windows.Forms.CheckBox();
            this.ParticipantButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Не начат",
            "Начат",
            "Закончён"});
            this.statusBox.Location = new System.Drawing.Point(261, 190);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(177, 23);
            this.statusBox.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(14, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 82;
            this.label10.Text = "Статус:";
            // 
            // CheckJudge
            // 
            this.CheckJudge.AutoCheck = false;
            this.CheckJudge.AutoSize = true;
            this.CheckJudge.Location = new System.Drawing.Point(240, 135);
            this.CheckJudge.Name = "CheckJudge";
            this.CheckJudge.Size = new System.Drawing.Size(15, 14);
            this.CheckJudge.TabIndex = 78;
            this.CheckJudge.UseVisualStyleBackColor = true;
            // 
            // CheckOrg
            // 
            this.CheckOrg.AutoCheck = false;
            this.CheckOrg.AutoSize = true;
            this.CheckOrg.Location = new System.Drawing.Point(240, 105);
            this.CheckOrg.Name = "CheckOrg";
            this.CheckOrg.Size = new System.Drawing.Size(15, 14);
            this.CheckOrg.TabIndex = 77;
            this.CheckOrg.UseVisualStyleBackColor = true;
            // 
            // JudgeButton
            // 
            this.JudgeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JudgeButton.Location = new System.Drawing.Point(261, 130);
            this.JudgeButton.Name = "JudgeButton";
            this.JudgeButton.Size = new System.Drawing.Size(177, 24);
            this.JudgeButton.TabIndex = 73;
            this.JudgeButton.Text = "Добавить";
            this.JudgeButton.UseVisualStyleBackColor = true;
            this.JudgeButton.Click += new System.EventHandler(this.JudgeButton_Click);
            // 
            // OrgButton
            // 
            this.OrgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrgButton.Location = new System.Drawing.Point(261, 100);
            this.OrgButton.Name = "OrgButton";
            this.OrgButton.Size = new System.Drawing.Size(177, 24);
            this.OrgButton.TabIndex = 72;
            this.OrgButton.Text = "Добавить";
            this.OrgButton.UseVisualStyleBackColor = true;
            this.OrgButton.Click += new System.EventHandler(this.OrgButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(351, 219);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 27);
            this.ExitButton.TabIndex = 71;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(261, 70);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 21);
            this.dateTimePicker1.TabIndex = 70;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 1, 0, 0, 0, 0);
            // 
            // PlaceLocation
            // 
            this.PlaceLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceLocation.Location = new System.Drawing.Point(261, 38);
            this.PlaceLocation.Name = "PlaceLocation";
            this.PlaceLocation.Size = new System.Drawing.Size(177, 21);
            this.PlaceLocation.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "Судьи:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Организаторы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Дата проведения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Место проведения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Название:";
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.Location = new System.Drawing.Point(261, 219);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(87, 27);
            this.OkButton.TabIndex = 57;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(258, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 15);
            this.TitleLabel.TabIndex = 84;
            this.TitleLabel.Text = "Title";
            // 
            // CheckPart
            // 
            this.CheckPart.AutoCheck = false;
            this.CheckPart.AutoSize = true;
            this.CheckPart.Location = new System.Drawing.Point(240, 165);
            this.CheckPart.Name = "CheckPart";
            this.CheckPart.Size = new System.Drawing.Size(15, 14);
            this.CheckPart.TabIndex = 90;
            this.CheckPart.UseVisualStyleBackColor = true;
            // 
            // ParticipantButton
            // 
            this.ParticipantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParticipantButton.Location = new System.Drawing.Point(261, 160);
            this.ParticipantButton.Name = "ParticipantButton";
            this.ParticipantButton.Size = new System.Drawing.Size(177, 24);
            this.ParticipantButton.TabIndex = 89;
            this.ParticipantButton.Text = "Добавить";
            this.ParticipantButton.UseVisualStyleBackColor = true;
            this.ParticipantButton.Click += new System.EventHandler(this.ParticipantButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 88;
            this.label8.Text = "Участники:";
            // 
            // EditCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 259);
            this.Controls.Add(this.CheckPart);
            this.Controls.Add(this.ParticipantButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CheckJudge);
            this.Controls.Add(this.CheckOrg);
            this.Controls.Add(this.JudgeButton);
            this.Controls.Add(this.OrgButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PlaceLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditCompetition";
            this.Text = "Редактирование соревнований";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label10;
        protected internal System.Windows.Forms.CheckBox CheckJudge;
        protected internal System.Windows.Forms.CheckBox CheckOrg;
        private System.Windows.Forms.Button JudgeButton;
        private System.Windows.Forms.Button OrgButton;
        private System.Windows.Forms.Button ExitButton;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected internal System.Windows.Forms.TextBox PlaceLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkButton;
        protected internal System.Windows.Forms.Label TitleLabel;
        protected internal System.Windows.Forms.ComboBox statusBox;
        protected internal System.Windows.Forms.CheckBox CheckPart;
        private System.Windows.Forms.Button ParticipantButton;
        private System.Windows.Forms.Label label8;
    }
}