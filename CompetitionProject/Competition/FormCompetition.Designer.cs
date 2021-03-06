﻿namespace CompetitionProject
{
    partial class FormCompetition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompetition));
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(645, 13);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 31);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(645, 65);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(183, 31);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(645, 117);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(183, 31);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoButton.Location = new System.Drawing.Point(645, 169);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(183, 31);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "Информация";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 396);
            this.dataGridView1.TabIndex = 4;
            // 
            // MenuButton
            // 
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.Location = new System.Drawing.Point(645, 378);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(183, 31);
            this.MenuButton.TabIndex = 10;
            this.MenuButton.Text = "Главное меню";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(645, 273);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(183, 31);
            this.RefreshButton.TabIndex = 11;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click_1);
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(645, 221);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(183, 31);
            this.ResultButton.TabIndex = 14;
            this.ResultButton.Text = "Результаты";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // FormCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 420);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCompetition";
            this.Text = "Соревнования";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ResultButton;
    }
}