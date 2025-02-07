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
            FetchData();
        }


        private void FetchData()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=DSPTest;Integrated Security=True;";
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
                MessageBox.Show("Select a customer first");
            }
            else
            {
                //TestPlotter();
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
