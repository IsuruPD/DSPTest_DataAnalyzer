namespace DSPTest_DataAnalyzer
{
    partial class AnalyzerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzerDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAnalyzer = new System.Windows.Forms.Button();
            this.picBxCloseBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picBxCloseBtn);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 700);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(332, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consumer Data Analyzer";
            // 
            // btnAnalyzer
            // 
            this.btnAnalyzer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnalyzer.BackgroundImage")));
            this.btnAnalyzer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnalyzer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyzer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnalyzer.Location = new System.Drawing.Point(842, -16);
            this.btnAnalyzer.Name = "btnAnalyzer";
            this.btnAnalyzer.Size = new System.Drawing.Size(757, 717);
            this.btnAnalyzer.TabIndex = 1;
            this.btnAnalyzer.Text = "View Records";
            this.btnAnalyzer.UseVisualStyleBackColor = true;
            this.btnAnalyzer.Click += new System.EventHandler(this.btnAnalyzer_Click);
            // 
            // picBxCloseBtn
            // 
            this.picBxCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.picBxCloseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBxCloseBtn.BackgroundImage")));
            this.picBxCloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxCloseBtn.Location = new System.Drawing.Point(18, 14);
            this.picBxCloseBtn.Name = "picBxCloseBtn";
            this.picBxCloseBtn.Size = new System.Drawing.Size(34, 33);
            this.picBxCloseBtn.TabIndex = 1;
            this.picBxCloseBtn.TabStop = false;
            this.picBxCloseBtn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AnalyzerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 688);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnalyzer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalyzerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyzerDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picBxCloseBtn;
        private System.Windows.Forms.Button btnAnalyzer;
    }
}