using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeninaClinic.BL.Pharmacy;

namespace BeninaClinic.PL.Forms.FrmPharmacy
{
    public partial class FrmAddMedication : Form
    {
        MedicationManagement mm = new MedicationManagement();
        public int medId = 0;

        public FrmAddMedication()
        {
            InitializeComponent();
        }

        public FrmAddMedication(int id)
        {
            InitializeComponent();
            this.medId = id;
            LoadMedicationData();
        }

        private void LoadMedicationData()
        {
             // Since I couldn't purely rely on GetMedication by DB, 
             // and passing rows is tricky via constructor without reference to the object
             // I will try to use the Search method to find it by ID if I had it in the grid.
             // But actually, for now, let's assume I added the method or I will just fetch ALL and filter (easy hack for now)
             
             try 
             {
                 DataTable dt = mm.GetAllMedications();
                 DataRow[] rows = dt.Select("Id = " + medId);
                 if (rows.Length > 0)
                 {
                     DataRow row = rows[0];
                     txtName.Text = row["Name"].ToString();
                     txtScientificName.Text = row["ScientificName"].ToString();
                     txtCode.Text = row["Code"].ToString();
                     txtType.Text = row["Type"].ToString();
                     txtPurchasePrice.Text = row["PurchasePrice"].ToString();
                     txtSellingPrice.Text = row["SellingPrice"].ToString();
                     txtQuantity.Text = row["Quantity"].ToString();
                     txtAlertQty.Text = row["AlertQuantity"].ToString();
                     dtpExpiry.Value = Convert.ToDateTime(row["ExpiryDate"]);
                     // dtpProduction might be null check
                     if(row["ProductionDate"] != DBNull.Value)
                        dtpProduction.Value = Convert.ToDateTime(row["ProductionDate"]);
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("يرجى إدخال اسم الدواء");
                    return;
                }

                if (medId == 0)
                {
                    mm.InsertMedication(txtCode.Text, txtName.Text, txtScientificName.Text, txtType.Text,
                        Convert.ToDecimal(txtPurchasePrice.Text), Convert.ToDecimal(txtSellingPrice.Text),
                        Convert.ToInt32(txtQuantity.Text), dtpExpiry.Value, dtpProduction.Value,
                        Convert.ToInt32(txtAlertQty.Text));
                    MessageBox.Show("تم الإضافة بنجاح");
                }
                else
                {
                    mm.UpdateMedication(medId, txtCode.Text, txtName.Text, txtScientificName.Text, txtType.Text,
                        Convert.ToDecimal(txtPurchasePrice.Text), Convert.ToDecimal(txtSellingPrice.Text),
                        Convert.ToInt32(txtQuantity.Text), dtpExpiry.Value, dtpProduction.Value,
                        Convert.ToInt32(txtAlertQty.Text));
                    MessageBox.Show("تم التعديل بنجاح");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }
    }
}
