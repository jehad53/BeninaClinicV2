using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BeninaClinic.PL.Forms.FrmClinic
{
    public partial class Frm_List_Viewer : Form
    {
        public FrmAppointment frmApp;

        private static Frm_List_Viewer instance;

        public static Frm_List_Viewer GetInstance(FrmAppointment frm)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Frm_List_Viewer(frm);
            }
            else
            {
                instance.frmApp = frm;
            }

            return instance;
        }

        public Frm_List_Viewer(FrmAppointment frm)
        {
            InitializeComponent();
            frmApp = frm;
        }

        public void LoadData(DataTable dt)
        {
            dgvList.DataSource = dt;
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count > 0 && dgvList.CurrentRow != null)
                {
                    frmApp.txtPatientID.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
                    frmApp.txtPatientName.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
                    frmApp.txtNatNum.Text = dgvList.CurrentRow.Cells[2].Value.ToString();

                    Frm_List_Viewer.instance.Dispose(); // إغلاق الفورم بعد الاختيار مباشرة
                }
            }
            catch
            {
                return;
            }
        }
    }
}