namespace InputCsvDisplayChartForms
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbNseEquityAll = new System.Windows.Forms.ComboBox();
            this.cmbNseFno = new System.Windows.Forms.ComboBox();
            this.cmbNsePortfolio = new System.Windows.Forms.ComboBox();
            this.chtEquity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtEquity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNseEquityAll
            // 
            this.cmbNseEquityAll.FormattingEnabled = true;
            this.cmbNseEquityAll.Location = new System.Drawing.Point(178, 35);
            this.cmbNseEquityAll.Name = "cmbNseEquityAll";
            this.cmbNseEquityAll.Size = new System.Drawing.Size(121, 21);
            this.cmbNseEquityAll.TabIndex = 1;
            this.cmbNseEquityAll.SelectedIndexChanged += new System.EventHandler(this.cmbNseEquityAll_SelectedIndexChanged);
            // 
            // cmbNseFno
            // 
            this.cmbNseFno.FormattingEnabled = true;
            this.cmbNseFno.Location = new System.Drawing.Point(382, 35);
            this.cmbNseFno.Name = "cmbNseFno";
            this.cmbNseFno.Size = new System.Drawing.Size(121, 21);
            this.cmbNseFno.TabIndex = 2;
            this.cmbNseFno.SelectedIndexChanged += new System.EventHandler(this.cmbNseFno_SelectedIndexChanged);
            // 
            // cmbNsePortfolio
            // 
            this.cmbNsePortfolio.FormattingEnabled = true;
            this.cmbNsePortfolio.Location = new System.Drawing.Point(579, 35);
            this.cmbNsePortfolio.Name = "cmbNsePortfolio";
            this.cmbNsePortfolio.Size = new System.Drawing.Size(121, 21);
            this.cmbNsePortfolio.TabIndex = 3;
            this.cmbNsePortfolio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chtEquity
            // 
            chartArea1.Name = "ChartArea1";
            this.chtEquity.ChartAreas.Add(chartArea1);
            this.chtEquity.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chtEquity.Legends.Add(legend1);
            this.chtEquity.Location = new System.Drawing.Point(0, 269);
            this.chtEquity.Name = "chtEquity";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtEquity.Series.Add(series1);
            this.chtEquity.Size = new System.Drawing.Size(1184, 392);
            this.chtEquity.TabIndex = 1;
            this.chtEquity.Text = "chart1";
            this.chtEquity.Click += new System.EventHandler(this.chart1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chtEquity);
            this.Controls.Add(this.cmbNseEquityAll);
            this.Controls.Add(this.cmbNseFno);
            this.Controls.Add(this.cmbNsePortfolio);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtEquity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbNseEquityAll;
        private System.Windows.Forms.ComboBox cmbNseFno;
        private System.Windows.Forms.ComboBox cmbNsePortfolio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtEquity;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}