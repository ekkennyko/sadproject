namespace CompetitionProject
{
    partial class FormResult
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResult));
            this.dataResults = new System.Windows.Forms.DataGridView();
            this.personIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputResult = new System.Windows.Forms.Button();
            this.outReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResults
            // 
            this.dataResults.AutoGenerateColumns = false;
            this.dataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.Place});
            this.dataResults.DataSource = this.participantBindingSource;
            this.dataResults.Location = new System.Drawing.Point(24, 59);
            this.dataResults.Name = "dataResults";
            this.dataResults.RowTemplate.Height = 24;
            this.dataResults.Size = new System.Drawing.Size(443, 228);
            this.dataResults.TabIndex = 0;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            this.personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            this.personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            this.personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            this.personIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // Place
            // 
            this.Place.HeaderText = "Место";
            this.Place.Name = "Place";
            // 
            // participantBindingSource
            // 
            this.participantBindingSource.DataSource = typeof(CompetitionClasses.Participant);
            this.participantBindingSource.CurrentChanged += new System.EventHandler(this.participantBindingSource_CurrentChanged);
            // 
            // inputResult
            // 
            this.inputResult.Location = new System.Drawing.Point(487, 59);
            this.inputResult.Name = "inputResult";
            this.inputResult.Size = new System.Drawing.Size(143, 45);
            this.inputResult.TabIndex = 1;
            this.inputResult.Text = "Внести результаты";
            this.inputResult.UseVisualStyleBackColor = true;
            this.inputResult.Click += new System.EventHandler(this.inputResult_Click);
            // 
            // outReport
            // 
            this.outReport.Location = new System.Drawing.Point(487, 140);
            this.outReport.Name = "outReport";
            this.outReport.Size = new System.Drawing.Size(143, 45);
            this.outReport.TabIndex = 2;
            this.outReport.Text = "Вывести отчет";
            this.outReport.UseVisualStyleBackColor = true;
            this.outReport.Click += new System.EventHandler(this.outReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название соревнования";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outReport);
            this.Controls.Add(this.inputResult);
            this.Controls.Add(this.dataResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResult";
            this.Text = "Результаты";
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResults;
        private System.Windows.Forms.Button inputResult;
        private System.Windows.Forms.Button outReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.BindingSource participantBindingSource;
    }
}