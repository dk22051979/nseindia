using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InputCsvDisplayChartForms
{
    public partial class ChartForm : Form
    {
        private const float CZoomScale = 4f;
        private int FZoomLevel = 0;
        public ChartForm()
        {
            InitializeComponent();
            chtEquity.MouseWheel += chtEquity_MouseWheel;
        }

        private void chtEquity_Click(object sender, EventArgs e)
        {

        }

        private void chtEquity_MouseEnter(object sender, EventArgs e)
        {
            if (!chtEquity.Focused)
                chtEquity.Focus();
        }

        private void chtEquity_MouseLeave(object sender, EventArgs e)
        {
            if (chtEquity.Focused)
                chtEquity.Parent.Focus();
        }

        private void chtEquity_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                Axis xAxis = chtEquity.ChartAreas[0].AxisX;
                double xMin = xAxis.ScaleView.ViewMinimum;
                double xMax = xAxis.ScaleView.ViewMaximum;
                double xPixelPos = xAxis.PixelPositionToValue(e.Location.X);

                if (e.Delta < 0 && FZoomLevel > 0)
                {
                    // Scrolled down, meaning zoom out
                    if (--FZoomLevel <= 0)
                    {
                        FZoomLevel = 0;
                        xAxis.ScaleView.ZoomReset();
                    }
                    else
                    {
                        double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) * CZoomScale, 0);
                        double xEndPos = Math.Min(xStartPos + (xMax - xMin) * CZoomScale, xAxis.Maximum);
                        xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    }
                }
                else if (e.Delta > 0)
                {
                    // Scrolled up, meaning zoom in
                    double xStartPos = Math.Max(xPixelPos - (xPixelPos - xMin) / CZoomScale, 0);
                    double xEndPos = Math.Min(xStartPos + (xMax - xMin) / CZoomScale, xAxis.Maximum);
                    xAxis.ScaleView.Zoom(xStartPos, xEndPos);
                    FZoomLevel++;
                }
            }
            catch { }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PopulateChartFromDB(string table)
        {
            chtEquity.Series.Clear();


            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=nse1920q4eq;Integrated Security=true;");

            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("Select tradedate, dayhigh, daylow, dayopen, dayclose, dayprevclose, volume from eq" + table, con);
            adapt.Fill(ds);
            chtEquity.DataSource = ds;



            string seriesName1 = table;
            Series ser1 = chtEquity.Series.Add(seriesName1);

            ser1.ChartArea = chtEquity.ChartAreas[0].Name;
            chtEquity.ChartAreas[0].AxisX.LabelStyle.Angle = 90;

            ChartArea CA = chtEquity.ChartAreas[0];

            CA.AxisX.ScaleView.Zoomable = true;
            CA.AxisY.ScaleView.Zoomable = true;
            CA.CursorX.AutoScroll = true;
            CA.CursorX.IsUserSelectionEnabled = true;

            ser1.Name = seriesName1;
            //ser1.ChartType = SeriesChartType.Stock;

            ser1.ChartType = SeriesChartType.Candlestick;

            ser1.BorderWidth = 3;
            ser1.XValueMember = "tradedate";
            ser1.YValueMembers = "dayhigh,daylow,dayopen,dayclose";
            ser1.SetCustomProperty("PriceUpColor", "Green");
            ser1.SetCustomProperty("PriceDownColor", "Red");
            ser1.ToolTip = "H #VALY1, L #VALY2, O #VALY3, C #VALY4, #VALX";
            //ser1.Points.AddXY(1, 44, 11, 34, 37);  
            //ser1.Points.AddXY(2, 33, 11, 22, 33);

            /*
            string seriesName2 = "line";
            Series ser2 = chtEquity.Series.Add(seriesName2);
            ser2.ChartArea = chtEquity.ChartAreas[0].Name;
            ser2.Name = seriesName2;
            ser2.ChartType = SeriesChartType.Line;
            ser2.Points.AddXY(1, 44);
            ser2.Points.AddXY(2, 33);*/

        }
        private void cmbNseEquityAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            chtEquity.Series.Clear();
            PopulateChartFromDB(cmbNseEquityAll.SelectedItem.ToString());
            System.Diagnostics.Process.Start("https://www1.nseindia.com/companytracker/cmtracker.jsp?cName=cmtracker_nsedef.css&symbol=" + cmbNseEquityAll.SelectedItem.ToString().ToUpper());
        }

        private void cmbNseFno_SelectedIndexChanged(object sender, EventArgs e)
        {
            chtEquity.Series.Clear();
            PopulateChartFromDB(cmbNseFno.SelectedItem.ToString());
            System.Diagnostics.Process.Start("https://www1.nseindia.com/companytracker/cmtracker.jsp?cName=cmtracker_nsedef.css&symbol=" + cmbNseFno.SelectedItem.ToString().ToUpper());
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=nse1920q4eq;Integrated Security=true;");

            SqlCommand cmd, cmd2, cmd3;
            SqlDataReader dr, dr2, dr3;
            con.Open();
            cmd = new SqlCommand("SELECT sobjects.name FROM sysobjects sobjects WHERE sobjects.xtype = 'U' ORDER BY sobjects.name", con);


            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tableName = dr[0].ToString();
                cmbNseEquityAll.Items.Add(tableName.Substring(2));
            }
            dr.Close();

            cmd2 = new SqlCommand("SELECT scrip FROM fundamental WHERE derivative='N' OR derivative='E' OR derivative='Y' ORDER BY scrip", con);


            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string tableName = dr2[0].ToString();
                cmbNseFno.Items.Add(tableName.Substring(2));
                comboBox1.Items.Add(tableName.Substring(2));
            }
            dr2.Close();
            cmd3 = new SqlCommand("SELECT scrip,in_portfolio,price FROM fundamental WHERE in_portfolio=1 ORDER BY scrip", con);


            dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                string tableName = dr3[0].ToString();
                cmbNsePortfolio.Items.Add(tableName.Substring(2));
            }
            dr3.Close();
            con.Close();
        }

        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chtEquity.Series.Clear();
            PopulateChartFromDB(cmbNsePortfolio.SelectedItem.ToString());
            System.Diagnostics.Process.Start("https://www1.nseindia.com/companytracker/cmtracker.jsp?cName=cmtracker_nsedef.css&symbol=" + cmbNsePortfolio.SelectedItem.ToString().ToUpper());
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            chtEquity.Series.Clear();
            PopulateChartFromDB(comboBox1.SelectedItem.ToString());
        }
    }
}
