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
    public partial class frmAnalyzer : Form
    {
        public frmAnalyzer()
        {
            InitializeComponent();
            chartUsagePeaks.Parent = pnlChartSec;
            btnPcBxBack.Cursor = Cursors.Hand;
            FetchData();


            btnPcBxBack.MouseEnter += new EventHandler(btnPcBxBack_MouseEnter);
            btnPcBxBack.MouseLeave += new EventHandler(btnPcBxBack_MouseLeave);
        }


        private void FetchData()
        {
            string connectionString = "Server=DESKTOP-D81M7DI;Database=DSPTest;Integrated Security=True;";
            string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbl_customer_usage' AND COLUMN_NAME <> 'Time'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cmbBxCustomers.Items.Clear();

                        while (reader.Read())
                        {
                            cmbBxCustomers.Items.Add(reader["COLUMN_NAME"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCnsSearch_Click(object sender, EventArgs e)
        {
            if (cmbBxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Select a customer first", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Plot grpah
            string selectedCustomer = cmbBxCustomers.SelectedItem.ToString();
            PlotCustomerData(selectedCustomer);

            // Count peaks 
            int peakCount = CountLoadPeaks(selectedCustomer);
            lblLoadPeaksCount.Text = $"{peakCount}";
            // Get the highest peak
            double maxPeak = GetHighestLoadPeak(selectedCustomer);
            lblMaximumPeak.Text = $"{maxPeak} kWh";
            // Tabulate hourly consumption
            DisplayHourlyPowerConsumption(selectedCustomer);
        }

        private void PlotCustomerData(string customerName)
        {
            string connectionString = "Server=DESKTOP-D81M7DI;Database=DSPTest;Integrated Security=True;";
            string query = $"SELECT Time, [{customerName}] FROM tbl_customer_usage ORDER BY Time";

            try
            {
                chartUsagePeaks.Series.Clear(); 

                var series = new Series
                {
                    Name = customerName,
                    ChartType = SeriesChartType.Line,
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

                chartUsagePeaks.Series.Add(series);
                chartUsagePeaks.ChartAreas[0].AxisX.Title = "Time (Minutes)";
                chartUsagePeaks.ChartAreas[0].AxisY.Title = "Demand";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Data Fetch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CountLoadPeaks(string customerName)
        {
            string connectionString = "Server=DESKTOP-D81M7DI;Database=DSPTest;Integrated Security=True;";
            string query = $"SELECT Time, [{customerName}] FROM tbl_customer_usage ORDER BY Time";

            List<double> dataPoints = new List<double>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(1))
                            {
                                dataPoints.Add(Convert.ToDouble(reader[1]));
                            }
                        }
                    }
                }

                return CalculatePeaks(dataPoints);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Peak Count Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private int CalculatePeaks(List<double> data)
        {
            int peakCount = 0;

            for (int i = 1; i < data.Count-1; i++)
            {
                if (data[i] > data[i - 1] && data[i] > data[i + 1])
                {
                    peakCount++;
                }
            }

            return peakCount;
        }

        private double GetHighestLoadPeak(string customerName)
        {
            string connectionString = "Server=DESKTOP-D81M7DI;Database=DSPTest;Integrated Security=True;";
            string query = $"SELECT Time, [{customerName}] FROM tbl_customer_usage ORDER BY Time";

            List<double> dataPoints = new List<double>();
            double maxPeak = double.MinValue;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(1))
                            {
                                dataPoints.Add(Convert.ToDouble(reader[1]));
                            }
                        }
                    }
                }

                // Find the maximum peak value
                for (int i = 1; i < dataPoints.Count - 1; i++)
                {
                    if (dataPoints[i] > dataPoints[i - 1] && dataPoints[i] > dataPoints[i + 1])
                    {
                        maxPeak = Math.Max(maxPeak, dataPoints[i]);
                    }
                }

                return maxPeak == double.MinValue ? 0 : maxPeak;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Max Peak Calculation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /*private void DisplayHourlyPowerConsumption(string customerName)
        {
            string connectionString = "Server=DESKTOP-D81M7DI;Database=DSPTest;Integrated Security=True;";

            string query = $@"SELECT Time,[{customerName}] AS Energy FROM tbl_customer_usage ORDER BY Time";

            try
            {
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

                DataTable resultTable = new DataTable();
                resultTable.Columns.Add("Hour", typeof(int));
                resultTable.Columns.Add("Power Consumption (kWh)", typeof(double));

                foreach (var hp in hourlyPower)
                {
                    resultTable.Rows.Add(hp.Key, hp.Value);
                }

                dgvConsumptionSummary.DataSource = resultTable;
                dgvConsumptionSummary.Columns["Hour"].HeaderText = "Hour";
                dgvConsumptionSummary.Columns["Power Consumption (kWh)"].HeaderText = "Power Consumption (kWh)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to fetch hourly data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnalyzerDashboard dashboard = new AnalyzerDashboard();
            dashboard.Show();
            this.Close();
        }

        private void lblLoadPeaksCount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbBxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Select a customer first", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCustomer = cmbBxCustomers.SelectedItem.ToString();
            TableGraphicsForm tableGraphics = new TableGraphicsForm(selectedCustomer);
            tableGraphics.Show();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAnalyzer_Load(object sender, EventArgs e)
        {

        }


        private void DisplayHourlyPowerConsumption(string customerName)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DSPTest;Integrated Security=True;";

            string query = $@"SELECT Time,[{customerName}] AS Energy FROM tbl_customer_usage ORDER BY Time";

            try
            {
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

                DataTable resultTable = new DataTable();
                resultTable.Columns.Add("Hour", typeof(int));
                resultTable.Columns.Add("Power Consumption (kWh)", typeof(double));

                foreach (var kvp in hourlyPower)
                {
                    resultTable.Rows.Add(kvp.Key, kvp.Value);
                }

                dgvConsumptionSummary.DataSource = resultTable;
                dgvConsumptionSummary.Columns["Hour"].HeaderText = "Hour";
                dgvConsumptionSummary.Columns["Power Consumption (kWh)"].HeaderText = "Power Consumption (kWh)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to fetch hourly data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
        private void TestPlotter()
        {
            try
            {
                chartUsagePeaks.Series.Clear();

                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "TestData",
                    IsVisibleInLegend = true,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                };

                series.Points.AddXY("08:00", 10);
                series.Points.AddXY("09:00", 15);
                series.Points.AddXY("10:00", 7);
                series.Points.AddXY("11:00", 12);
                series.Points.AddXY("12:00", 20);
                series.Points.AddXY("13:00", 8);

                chartUsagePeaks.Series.Add(series);

                chartUsagePeaks.ChartAreas[0].AxisX.Title = "Time (Hours)";
                chartUsagePeaks.ChartAreas[0].AxisY.Title = "Power Consumption (kWh)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Failed to plot test data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
