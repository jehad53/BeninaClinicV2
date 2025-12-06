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
        // متغير يستقبل الفورم الاصلي
        public FrmAppointment frmApp;

        public Frm_List_Viewer(FrmAppointment frm) // هنا نتسقبل الفورم الاصلي
        {
            InitializeComponent();
            frmApp = frm;
        }

        // Method for Fill DataGridView
        public void LoadData(DataTable dt) // Some Parameters
        {
            dgvList.DataSource = dt;
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(dgvList.CurrentRow != null)
                { 
                frmApp.txtPatientID.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
                frmApp.txtPatientName.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
                frmApp.txtNatNum.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
                frmApp.txtBoD.Text = dgvList.CurrentRow.Cells[3].Value.ToString();
                frmApp.txtGender.Text = dgvList.CurrentRow.Cells[4].Value.ToString();
                frmApp.txtPhone.Text = dgvList.CurrentRow.Cells[5].Value.ToString();
                frmApp.txtAddress.Text = dgvList.CurrentRow.Cells[6].Value.ToString();
                frmApp.txtPatientNote.Text = dgvList.CurrentRow.Cells[7].Value.ToString();
                }
                this.Close();
            }
            catch
            {
                return;
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
