namespace CompetitionProject
{
    partial class SelectCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCategory));
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.dbCombo = new System.Windows.Forms.ComboBox();
            this.dbList = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(140, 149);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 32);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(14, 149);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(96, 32);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // dbCombo
            // 
            this.dbCombo.FormattingEnabled = true;
            this.dbCombo.Location = new System.Drawing.Point(14, 14);
            this.dbCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dbCombo.Name = "dbCombo";
            this.dbCombo.Size = new System.Drawing.Size(222, 23);
            this.dbCombo.TabIndex = 10;
            // 
            // dbList
            // 
            this.dbList.FormattingEnabled = true;
            this.dbList.ItemHeight = 15;
            this.dbList.Location = new System.Drawing.Point(14, 50);
            this.dbList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(222, 79);
            this.dbList.TabIndex = 11;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(241, 50);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(96, 32);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Убрать";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SelectCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 200);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.dbList);
            this.Controls.Add(this.dbCombo);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelectCategory";
            this.Text = "SelectCategory";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox dbCombo;
        private System.Windows.Forms.ListBox dbList;
        private System.Windows.Forms.Button RemoveButton;
    }
}