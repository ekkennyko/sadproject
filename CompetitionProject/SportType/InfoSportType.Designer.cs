namespace CompetitionProject.SportType
{
    partial class InfoSportType
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
            this.Name = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.NameST = new System.Windows.Forms.Label();
            this.TypeST = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.Location = new System.Drawing.Point(17, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(79, 18);
            this.Name.TabIndex = 0;
            this.Name.Text = "Название:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.Location = new System.Drawing.Point(17, 58);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(37, 18);
            this.Type.TabIndex = 1;
            this.Type.Text = "Тип:";
            // 
            // NameST
            // 
            this.NameST.AutoSize = true;
            this.NameST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameST.Location = new System.Drawing.Point(102, 22);
            this.NameST.Name = "NameST";
            this.NameST.Size = new System.Drawing.Size(48, 18);
            this.NameST.TabIndex = 2;
            this.NameST.Text = "Name";
            // 
            // TypeST
            // 
            this.TypeST.AutoSize = true;
            this.TypeST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeST.Location = new System.Drawing.Point(60, 58);
            this.TypeST.Name = "TypeST";
            this.TypeST.Size = new System.Drawing.Size(40, 18);
            this.TypeST.TabIndex = 3;
            this.TypeST.Text = "Type";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(339, 91);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InfoSportType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 126);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.TypeST);
            this.Controls.Add(this.NameST);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Name);
            this.Name = "InfoSportType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Type;
        protected internal System.Windows.Forms.Label NameST;
        protected internal System.Windows.Forms.Label TypeST;
        private System.Windows.Forms.Button okButton;
    }
}