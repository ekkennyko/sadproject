﻿namespace CompetitionProject
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
            this.dataResults = new System.Windows.Forms.DataGridView();
            this.inputResult = new System.Windows.Forms.Button();
            this.outReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResults
            // 
            this.dataResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResults.Location = new System.Drawing.Point(24, 59);
            this.dataResults.Name = "dataResults";
            this.dataResults.RowTemplate.Height = 24;
            this.dataResults.Size = new System.Drawing.Size(443, 228);
            this.dataResults.TabIndex = 0;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название соревнования";
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
            this.Name = "FormResult";
            this.Text = "Результаты";
            ((System.ComponentModel.ISupportInitialize)(this.dataResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResults;
        private System.Windows.Forms.Button inputResult;
        private System.Windows.Forms.Button outReport;
        private System.Windows.Forms.Label label1;
    }
}