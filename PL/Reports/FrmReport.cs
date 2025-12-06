using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeninaClinic.PL.Reports
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            crystalReportViewer1.Zoom(1);
        }
    }
}
