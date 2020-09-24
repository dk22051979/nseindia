﻿namespace InputCsvDisplayChartForms
{
    partial class CSVFormMTN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button startAsyncButton;
        private System.Windows.Forms.Button cancelAsyncButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label resultLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.startAsyncButton = new System.Windows.Forms.Button();
            this.cancelAsyncButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvCsvFile = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvFile)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            91,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startAsyncButton
            // 
            this.startAsyncButton.Location = new System.Drawing.Point(16, 72);
            this.startAsyncButton.Name = "startAsyncButton";
            this.startAsyncButton.Size = new System.Drawing.Size(120, 23);
            this.startAsyncButton.TabIndex = 1;
            this.startAsyncButton.Text = "Start Async";
            this.startAsyncButton.Click += new System.EventHandler(this.startAsyncButton_Click);
            // 
            // cancelAsyncButton
            // 
            this.cancelAsyncButton.Enabled = false;
            this.cancelAsyncButton.Location = new System.Drawing.Point(153, 72);
            this.cancelAsyncButton.Name = "cancelAsyncButton";
            this.cancelAsyncButton.Size = new System.Drawing.Size(119, 23);
            this.cancelAsyncButton.TabIndex = 2;
            this.cancelAsyncButton.Text = "Cancel Async";
            this.cancelAsyncButton.Click += new System.EventHandler(this.cancelAsyncButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(112, 16);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(160, 23);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "(no result)";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 8);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // dgvCsvFile
            // 
            this.dgvCsvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCsvFile.Location = new System.Drawing.Point(95, 141);
            this.dgvCsvFile.Name = "dgvCsvFile";
            this.dgvCsvFile.Size = new System.Drawing.Size(240, 150);
            this.dgvCsvFile.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CSVFormMTN
            // 
            this.ClientSize = new System.Drawing.Size(504, 328);
            this.Controls.Add(this.dgvCsvFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.cancelAsyncButton);
            this.Controls.Add(this.startAsyncButton);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "CSVFormMTN";
            this.Text = "Fibonacci Calculator";
            this.Load += new System.EventHandler(this.CSVFormMTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsvFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCsvFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}