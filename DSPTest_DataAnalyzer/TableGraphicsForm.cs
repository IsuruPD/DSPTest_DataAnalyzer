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
            chrtHrlyConsumption.ChartAreas[0].AxisX.Minimum = 0;
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
            string connectionString = "Server=DESKTOP-D81M7DI;Database=DSPTest;Integrated Security=True;";

            string query = $@"SELECT Time,[{customerName}] AS Energy FROM tbl_customer_usage ORDER BY Time";

            try
            {

                chrtHrlyConsumption.Series.Clear();

                var series = new Series
                {
                    Name = customerName,
                    ChartType = SeriesChartType.Column,
                    IsVisibleInLegend = true
                };


                DataTable dataTable = new DataTable();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }

                Dictionary<int, double> hourlyPower = new Dictionary<int, double>();

                for (int i = 0; i < dataTable.Rows.Count - 1; i++)
                {
                    DateTime time1 = Convert.ToDateTime(dataTable.Rows[i]["Time"]);
                    DateTime time2 = Convert.ToDateTime(dataTable.Rows[i + 1]["Time"]);
                    double energy1 = Convert.ToDouble(dataTable.Rows[i]["Energy"]);
                    double energy2 = Convert.ToDouble(dataTable.Rows[i + 1]["Energy"]);

                    double timeDif = (time2 - time1).TotalMinutes / 60.0;

                    double power = ((energy1 + energy2) / 2) * timeDif;

                    int hour = time1.Hour;

                    if (!hourlyPower.ContainsKey(hour))
                        hourlyPower[hour] = 0;

                    hourlyPower[hour] += power;
                }

                foreach (var hp in hourlyPower)
                {
                    series.Points.AddXY(hp.Key, hp.Value);
                }

                chrtHrlyConsumption.Series.Add(series);
                chrtHrlyConsumption.ChartAreas[0].AxisX.Title = "Time (Hours)";
                chrtHrlyConsumption.ChartAreas[0].AxisY.Title = "Cumulative Power Consumption (kWh)";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to fetch hourly data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TableGraphicsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
