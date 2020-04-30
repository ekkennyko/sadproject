namespace CompetitionProject
{
    partial class SelectSportType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSportType));
            this.dbList = new System.Windows.Forms.ListBox();
            this.dbCombo = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbList
            // 
            this.dbList.FormattingEnabled = true;
            this.dbList.Location = new System.Drawing.Point(16, 54);
            this.dbList.Margin = new System.Windows.Forms.Padding(2);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(190, 56);
            this.dbList.TabIndex = 15;
            // 
            // dbCombo
            // 
            this.dbCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbCombo.FormattingEnabled = true;
            this.dbCombo.Location = new System.Drawing.Point(16, 18);
            this.dbCombo.Margin = new System.Windows.Forms.Padding(2);
            this.dbCombo.Name = "dbCombo";
            this.dbCombo.Size = new System.Drawing.Size(191, 23);
            this.dbCombo.TabIndex = 14;
            this.dbCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(124, 127);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 28);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(16, 127);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(82, 28);
            this.OkButton.TabIndex = 12;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SelectSportType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 173);
            this.Controls.Add(this.dbList);
            this.Controls.Add(this.dbCombo);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectSportType";
            this.Text = "SelectSportType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dbList;
        private System.Windows.Forms.ComboBox dbCombo;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}