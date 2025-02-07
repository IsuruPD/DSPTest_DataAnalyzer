namespace DSPTest_DataAnalyzer
{
    partial class frmAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyzer));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnCnsSearch = new System.Windows.Forms.Button();
            this.btnPcBxBack = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxCustomers = new System.Windows.Forms.ComboBox();
            this.chartUsagePeaks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlChartSec = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaximumPeak = new System.Windows.Forms.Label();
            this.lblLoadPeaksCount = new System.Windows.Forms.Label();
            this.lblLoadPeaks = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvConsumptionSummary = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPcBxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsagePeaks)).BeginInit();
            this.pnlChartSec.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumptionSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuText;
            this.pnlTop.Controls.Add(this.btnCnsSearch);
            this.pnlTop.Controls.Add(this.btnPcBxBack);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cmbBxCustomers);
            this.pnlTop.Location = new System.Drawing.Point(-2, -1);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1416, 158);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // btnCnsSearch
            // 
            this.btnCnsSearch.Location = new System.Drawing.Point(553, 109);
            this.btnCnsSearch.Name = "btnCnsSearch";
            this.btnCnsSearch.Size = new System.Drawing.Size(115, 24);
            this.btnCnsSearch.TabIndex = 2;
            this.btnCnsSearch.Text = "Search";
            this.btnCnsSearch.UseVisualStyleBackColor = true;
            this.btnCnsSearch.Click += new System.EventHandler(this.btnCnsSearch_Click);
            // 
            // btnPcBxBack
            // 
            this.btnPcBxBack.BackColor = System.Drawing.Color.Transparent;
            this.btnPcBxBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPcBxBack.BackgroundImage")));
            this.btnPcBxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPcBxBack.Location = new System.Drawing.Point(18, 15);
            this.btnPcBxBack.Name = "btnPcBxBack";
            this.btnPcBxBack.Size = new System.Drawing.Size(28, 28);
            this.btnPcBxBack.TabIndex = 0;
            this.btnPcBxBack.TabStop = false;
            this.btnPcBxBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(105, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(611, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Consumption";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBxCustomers
            // 
            this.cmbBxCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBxCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBxCustomers.FormattingEnabled = true;
            this.cmbBxCustomers.Location = new System.Drawing.Point(215, 109);
            this.cmbBxCustomers.Name = "cmbBxCustomers";
            this.cmbBxCustomers.Size = new System.Drawing.Size(311, 24);
            this.cmbBxCustomers.TabIndex = 0;
            // 
            // chartUsagePeaks
            // 
            chartArea2.Name = "ChartArea1";
            this.chartUsagePeaks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartUsagePeaks.Legends.Add(legend2);
            this.chartUsagePeaks.Location = new System.Drawing.Point(3, 3);
            this.chartUsagePeaks.Name = "chartUsagePeaks";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartUsagePeaks.Series.Add(series2);
            this.chartUsagePeaks.Size = new System.Drawing.Size(729, 516);
            this.chartUsagePeaks.TabIndex = 1;
            this.chartUsagePeaks.Text = "chart1";
            // 
            // pnlChartSec
            // 
            this.pnlChartSec.Controls.Add(this.chartUsagePeaks);
            this.pnlChartSec.Location = new System.Drawing.Point(12, 175);
            this.pnlChartSec.Name = "pnlChartSec";
            this.pnlChartSec.Size = new System.Drawing.Size(735, 522);
            this.pnlChartSec.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMaximumPeak);
            this.panel1.Controls.Add(this.lblLoadPeaksCount);
            this.panel1.Controls.Add(this.lblLoadPeaks);
            this.panel1.Location = new System.Drawing.Point(769, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 100);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Maximum Peak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = ":";
            // 
            // lblMaximumPeak
            // 
            this.lblMaximumPeak.AutoSize = true;
            this.lblMaximumPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumPeak.Location = new System.Drawing.Point(173, 55);
            this.lblMaximumPeak.Name = "lblMaximumPeak";
            this.lblMaximumPeak.Size = new System.Drawing.Size(30, 16);
            this.lblMaximumPeak.TabIndex = 0;
            this.lblMaximumPeak.Text = "N/A";
            // 
            // lblLoadPeaksCount
            // 
            this.lblLoadPeaksCount.AutoSize = true;
            this.lblLoadPeaksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadPeaksCount.Location = new System.Drawing.Point(173, 19);
            this.lblLoadPeaksCount.Name = "lblLoadPeaksCount";
            this.lblLoadPeaksCount.Size = new System.Drawing.Size(30, 16);
            this.lblLoadPeaksCount.TabIndex = 0;
            this.lblLoadPeaksCount.Text = "N/A";
            this.lblLoadPeaksCount.Click += new System.EventHandler(this.lblLoadPeaksCount_Click);
            // 
            // lblLoadPeaks
            // 
            this.lblLoadPeaks.AutoSize = true;
            this.lblLoadPeaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadPeaks.Location = new System.Drawing.Point(13, 19);
            this.lblLoadPeaks.Name = "lblLoadPeaks";
            this.lblLoadPeaks.Size = new System.Drawing.Size(90, 16);
            this.lblLoadPeaks.TabIndex = 0;
            this.lblLoadPeaks.Text = "Load Peaks";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvConsumptionSummary);
            this.panel2.Location = new System.Drawing.Point(769, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 357);
            this.panel2.TabIndex = 4;
            // 
            // dgvConsumptionSummary
            // 
            this.dgvConsumptionSummary.AllowUserToAddRows = false;
            this.dgvConsumptionSummary.AllowUserToDeleteRows = false;
            this.dgvConsumptionSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumptionSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsumptionSummary.Location = new System.Drawing.Point(0, 0);
            this.dgvConsumptionSummary.Name = "dgvConsumptionSummary";
            this.dgvConsumptionSummary.ReadOnly = true;
            this.dgvConsumptionSummary.RowHeadersWidth = 51;
            this.dgvConsumptionSummary.RowTemplate.Height = 24;
            this.dgvConsumptionSummary.Size = new System.Drawing.Size(632, 357);
            this.dgvConsumptionSummary.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(1185, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Graphics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 709);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChartSec);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAnalyzer_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPcBxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsagePeaks)).EndInit();
            this.pnlChartSec.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumptionSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxCustomers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsagePeaks;
        private System.Windows.Forms.PictureBox btnPcBxBack;
        private System.Windows.Forms.Panel pnlChartSec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLoadPeaksCount;
        private System.Windows.Forms.Label lblLoadPeaks;
        private System.Windows.Forms.Label lblMaximumPeak;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCnsSearch;
        private System.Windows.Forms.DataGridView dgvConsumptionSummary;
    }
}

