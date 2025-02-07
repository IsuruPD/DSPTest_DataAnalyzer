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

namespace DSPTest_DataAnalyzer
{
    public partial class TableGraphicsForm : Form
    {
        public TableGraphicsForm(string selectedCustomer)
        {
            InitializeComponent();
            btnPcBxBack.Cursor = Cursors.Hand;
            PlotHourlyConsumption(selectedCustomer);
            btnPcBxBack.Parent = pnlTitleHrlyConsumption;
            btnPcBxBack.BackColor = Color.Transparent;
            lblTitleHrlyConsumption.Parent = pnlTitleHrlyConsumption;
            lblTitleHrlyConsumption.BackColor = Color.Transparent;

            btnPcBxBack.MouseEnter += new EventHandler(btnPcBxBack_MouseEnter);
            btnPcBxBack.MouseLeave += new EventHandler(btnPcBxBack_MouseLeave);
        }

        private void btnPcBxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPcBxBack_MouseEnter(object sender, EventArgs e)
        {
            btnPcBxBack.Size = new Size(btnPcBxBack.Width + 2, btnPcBxBack.Height + 2);
            btnPcBxBack.Location = new Point(btnPcBxBack.Location.X - 1, btnPcBxBack.Location.Y - 1);
        }

        private void btnPcBxBack_MouseLeave(object sender, EventArgs e)
        {
            btnPcBxBack.Size = new Size(btnPcBxBack.Width - 2, btnPcBxBack.Height - 2);
            btnPcBxBack.Location = new Point(btnPcBxBack.Location.X + 1, btnPcBxBack.Location.Y + 1);
        }

        private void PlotHourlyConsumption(string customerName)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DSPTest;Integrated Security=True;";

            string query = $@"
                            SELECT 
                            DATEPART(HOUR, Time) AS Hour, 
                            SUM([{customerName}]) AS TotalConsumption
                            FROM tbl_customer_usage
                            GROUP BY DATEPART(HOUR, Time)
                            ORDER BY Hour";

            try
            {
                chrtHrlyConsumption.Series.Clear();

                var series = new Series
                {
                    Name = customerName,
                    ChartType = SeriesChartType.Column,
                    IsVisibleInLegend = true
                };

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string timeValue = reader[0].ToString();
                            double powerConsumption = 0;

                            if (!reader.IsDBNull(1))
                            {
                                powerConsumption = Convert.ToDouble(reader[1]);
                            }

                            series.Points.AddXY(timeValue, powerConsumption);
                        }
                    }
                }

                chrtHrlyConsumption.Series.Add(series);
                chrtHrlyConsumption.ChartAreas[0].AxisX.Title = "Time (Hours)";
                chrtHrlyConsumption.ChartAreas[0].AxisY.Title = "Cumulative Power Consumption (kWh)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Data Fetch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TableGraphicsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
