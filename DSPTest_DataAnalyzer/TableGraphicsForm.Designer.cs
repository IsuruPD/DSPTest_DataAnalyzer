namespace DSPTest_DataAnalyzer
{
    partial class TableGraphicsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableGraphicsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTitleHrlyConsumption = new System.Windows.Forms.Label();
            this.btnPcBxBack = new System.Windows.Forms.PictureBox();
            this.chrtHrlyConsumption = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTitleHrlyConsumption = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnPcBxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHrlyConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleHrlyConsumption
            // 
            this.lblTitleHrlyConsumption.AutoSize = true;
            this.lblTitleHrlyConsumption.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHrlyConsumption.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Italic);
            this.lblTitleHrlyConsumption.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitleHrlyConsumption.Location = new System.Drawing.Point(303, 39);
            this.lblTitleHrlyConsumption.Name = "lblTitleHrlyConsumption";
            this.lblTitleHrlyConsumption.Size = new System.Drawing.Size(283, 32);
            this.lblTitleHrlyConsumption.TabIndex = 2;
            this.lblTitleHrlyConsumption.Text = "Hourly Consumption";
            this.lblTitleHrlyConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPcBxBack
            // 
            this.btnPcBxBack.BackColor = System.Drawing.Color.Transparent;
            this.btnPcBxBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPcBxBack.BackgroundImage")));
            this.btnPcBxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPcBxBack.Location = new System.Drawing.Point(14, 13);
            this.btnPcBxBack.Name = "btnPcBxBack";
            this.btnPcBxBack.Size = new System.Drawing.Size(28, 28);
            this.btnPcBxBack.TabIndex = 3;
            this.btnPcBxBack.TabStop = false;
            this.btnPcBxBack.Click += new System.EventHandler(this.btnPcBxBack_Click);
            // 
            // chrtHrlyConsumption
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtHrlyConsumption.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtHrlyConsumption.Legends.Add(legend2);
            this.chrtHrlyConsumption.Location = new System.Drawing.Point(48, 115);
            this.chrtHrlyConsumption.Name = "chrtHrlyConsumption";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtHrlyConsumption.Series.Add(series2);
            this.chrtHrlyConsumption.Size = new System.Drawing.Size(746, 417);
            this.chrtHrlyConsumption.TabIndex = 4;
            this.chrtHrlyConsumption.Text = "chart1";
            // 
            // pnlTitleHrlyConsumption
            // 
            this.pnlTitleHrlyConsumption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTitleHrlyConsumption.Location = new System.Drawing.Point(-5, -5);
            this.pnlTitleHrlyConsumption.Name = "pnlTitleHrlyConsumption";
            this.pnlTitleHrlyConsumption.Size = new System.Drawing.Size(864, 107);
            this.pnlTitleHrlyConsumption.TabIndex = 5;
            // 
            // TableGraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 581);
            this.Controls.Add(this.btnPcBxBack);
            this.Controls.Add(this.lblTitleHrlyConsumption);
            this.Controls.Add(this.chrtHrlyConsumption);
            this.Controls.Add(this.pnlTitleHrlyConsumption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableGraphicsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableGraphicsForm";
            this.Load += new System.EventHandler(this.TableGraphicsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPcBxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHrlyConsumption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleHrlyConsumption;
        private System.Windows.Forms.PictureBox btnPcBxBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHrlyConsumption;
        private System.Windows.Forms.Panel pnlTitleHrlyConsumption;
    }
}