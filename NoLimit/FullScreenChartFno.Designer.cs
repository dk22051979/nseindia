﻿namespace InputCsvDisplayChartForms
{
    partial class FullScreenChartFno
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbOpt = new System.Windows.Forms.ComboBox();
            this.cmbFut = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbStrike = new System.Windows.Forms.ComboBox();
            this.cmbOptype = new System.Windows.Forms.ComboBox();
            this.cmbExpiry = new System.Windows.Forms.ComboBox();
            this.txtStrike = new System.Windows.Forms.TextBox();
            this.txtOptype = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGet = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOpt
            // 
            this.cmbOpt.FormattingEnabled = true;
            this.cmbOpt.Location = new System.Drawing.Point(3, 388);
            this.cmbOpt.Name = "cmbOpt";
            this.cmbOpt.Size = new System.Drawing.Size(404, 21);
            this.cmbOpt.TabIndex = 0;
            this.cmbOpt.SelectedIndexChanged += new System.EventHandler(this.cmbOpt_SelectedIndexChanged);
            // 
            // cmbFut
            // 
            this.cmbFut.FormattingEnabled = true;
            this.cmbFut.Location = new System.Drawing.Point(3, 364);
            this.cmbFut.Name = "cmbFut";
            this.cmbFut.Size = new System.Drawing.Size(404, 21);
            this.cmbFut.TabIndex = 1;
            this.cmbFut.SelectedIndexChanged += new System.EventHandler(this.cmbFut_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea5.AlignWithChartArea = "ChartArea1";
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(422, 355);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // cmbStrike
            // 
            this.cmbStrike.FormattingEnabled = true;
            this.cmbStrike.Location = new System.Drawing.Point(2, 435);
            this.cmbStrike.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStrike.Name = "cmbStrike";
            this.cmbStrike.Size = new System.Drawing.Size(406, 21);
            this.cmbStrike.TabIndex = 3;
            this.cmbStrike.SelectedIndexChanged += new System.EventHandler(this.cmbStrike_SelectedIndexChanged);
            // 
            // cmbOptype
            // 
            this.cmbOptype.FormattingEnabled = true;
            this.cmbOptype.Location = new System.Drawing.Point(2, 459);
            this.cmbOptype.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOptype.Name = "cmbOptype";
            this.cmbOptype.Size = new System.Drawing.Size(406, 21);
            this.cmbOptype.TabIndex = 4;
            this.cmbOptype.SelectedIndexChanged += new System.EventHandler(this.cmbOptype_SelectedIndexChanged);
            // 
            // cmbExpiry
            // 
            this.cmbExpiry.FormattingEnabled = true;
            this.cmbExpiry.Location = new System.Drawing.Point(2, 411);
            this.cmbExpiry.Margin = new System.Windows.Forms.Padding(2);
            this.cmbExpiry.Name = "cmbExpiry";
            this.cmbExpiry.Size = new System.Drawing.Size(406, 21);
            this.cmbExpiry.TabIndex = 5;
            this.cmbExpiry.SelectedIndexChanged += new System.EventHandler(this.cmbExpiry_SelectedIndexChanged);
            // 
            // txtStrike
            // 
            this.txtStrike.Location = new System.Drawing.Point(430, 435);
            this.txtStrike.Margin = new System.Windows.Forms.Padding(2);
            this.txtStrike.Name = "txtStrike";
            this.txtStrike.Size = new System.Drawing.Size(402, 20);
            this.txtStrike.TabIndex = 6;
            this.txtStrike.Text = "0.00";
            this.txtStrike.TextChanged += new System.EventHandler(this.txtStrike_TextChanged);
            // 
            // txtOptype
            // 
            this.txtOptype.Location = new System.Drawing.Point(430, 459);
            this.txtOptype.Margin = new System.Windows.Forms.Padding(2);
            this.txtOptype.Name = "txtOptype";
            this.txtOptype.Size = new System.Drawing.Size(402, 20);
            this.txtOptype.TabIndex = 7;
            this.txtOptype.Text = "XX";
            this.txtOptype.TextChanged += new System.EventHandler(this.txtOptype_TextChanged);
            // 
            // txtExpiry
            // 
            this.txtExpiry.Location = new System.Drawing.Point(430, 411);
            this.txtExpiry.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(402, 20);
            this.txtExpiry.TabIndex = 8;
            this.txtExpiry.Text = "30-Apr-2020";
            this.txtExpiry.TextChanged += new System.EventHandler(this.txtExpiry_TextChanged);
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(431, 364);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(403, 20);
            this.txtTable.TabIndex = 9;
            this.txtTable.TextChanged += new System.EventHandler(this.txtTable_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbFut, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbOpt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbExpiry, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtExpiry, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbStrike, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtStrike, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbOptype, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtOptype, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 502);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(431, 388);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 18);
            this.btnGet.TabIndex = 11;
            this.btnGet.Text = "CHART";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(431, 3);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(423, 355);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // FullScreenChartFno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FullScreenChartFno";
            this.Text = "FullScreenChartFno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FullScreenChartFno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpt;
        private System.Windows.Forms.ComboBox cmbFut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbStrike;
        private System.Windows.Forms.ComboBox cmbOptype;
        private System.Windows.Forms.ComboBox cmbExpiry;
        private System.Windows.Forms.TextBox txtStrike;
        private System.Windows.Forms.TextBox txtOptype;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}