using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeninaClinic
{
    public partial class FrmStartApp : Form
    {
        public FrmStartApp()
        {
            InitializeComponent();
        }

        private void FrmStartApp_Load(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value = 30;
            lblValue.Text = guna2ProgressBar1.Value.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 1;
                lblValue.Text = guna2ProgressBar1.Value.ToString();
                return;
            }
                timer1.Stop();
                FrmMainClinic frmMain = new FrmMainClinic();
                frmMain.Show();
                this.Hide();
        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }
    }
}
