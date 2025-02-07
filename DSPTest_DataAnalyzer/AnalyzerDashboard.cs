using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSPTest_DataAnalyzer
{
    public partial class AnalyzerDashboard : Form
    {
        public AnalyzerDashboard()
        {
            InitializeComponent();


            picBxCloseBtn.Cursor = Cursors.Hand;
            btnAnalyzer.Cursor = Cursors.Hand;

            picBxCloseBtn.MouseEnter += new EventHandler(btnDashClose_MouseEnter);
            picBxCloseBtn.MouseLeave += new EventHandler(btnDashClose_MouseLeave);


            btnAnalyzer.MouseEnter += new EventHandler(btnAnalyzer_MouseEnter);
            btnAnalyzer.MouseLeave += new EventHandler(btnAnalyzer_MouseLeave);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashClose_MouseEnter(object sender, EventArgs e)
        {
            picBxCloseBtn.Size = new Size(picBxCloseBtn.Width + 2, picBxCloseBtn.Height + 2);
            picBxCloseBtn.Location = new Point(picBxCloseBtn.Location.X - 1, picBxCloseBtn.Location.Y - 1);
        }

        private void btnDashClose_MouseLeave(object sender, EventArgs e)
        {
            picBxCloseBtn.Size = new Size(picBxCloseBtn.Width - 2, picBxCloseBtn.Height - 2);
            picBxCloseBtn.Location = new Point(picBxCloseBtn.Location.X + 1, picBxCloseBtn.Location.Y + 1);
        }

        private void btnAnalyzer_MouseEnter(object sender, EventArgs e)
        {
            int grow = 8;
            btnAnalyzer.ForeColor = Color.White;
            btnAnalyzer.Size = new Size(btnAnalyzer.Width + grow, btnAnalyzer.Height + grow);
            btnAnalyzer.Location = new Point(btnAnalyzer.Location.X - grow / 2, btnAnalyzer.Location.Y - grow / 2);
        }

        private void btnAnalyzer_MouseLeave(object sender, EventArgs e)
        {
            int shrink = 8;
            btnAnalyzer.ForeColor = Color.Black;
            btnAnalyzer.Size = new Size(btnAnalyzer.Width - shrink, btnAnalyzer.Height - shrink);
            btnAnalyzer.Location = new Point(btnAnalyzer.Location.X + shrink / 2, btnAnalyzer.Location.Y + shrink / 2);
        }

        private void btnAnalyzer_Click(object sender, EventArgs e)
        {
            frmAnalyzer frmAnalyzer = new frmAnalyzer();    
            frmAnalyzer.Show();
            this.Hide();
        }
    }
}
