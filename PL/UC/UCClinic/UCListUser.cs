using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeninaClinic.PL.UC.UCClinic
{
    public partial class UCListUser : UserControl
    {
        public UCListUser()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            try
            {
              //  JobManagement jobmanagement = new JobManagement();
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Cairo", 14, FontStyle.Bold);
             //   dgvUsers.DataSource = jobmanagement.GetAllJobs();
            }
            catch
            {
                MessageBox.Show("يوجد خطأ في تحميل البيانات", " تحميل الوظائف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }


}