using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeninaClinic.PL.Forms.FrmPharmacy
{
    public partial class FrmPharmacyMain : Form
    {
        public FrmPharmacyMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FrmMedicationList frm = new FrmMedicationList();
            frm.ShowDialog();
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
           FrmDispense frm = new FrmDispense();
           frm.ShowDialog();
        }
    }
}
