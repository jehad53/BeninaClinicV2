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
    public partial class FrmDispense : Form
    {
        DispensationManagement dm = new DispensationManagement();
        MedicationManagement mm = new MedicationManagement();
        DataTable dtNotifications;
        DataTable dtInventory;
        DataTable dtCart; // For the right grid

        int currentVisitId = 0;
        int currentPatientId = 0;
        string currentPatientName = "";

        public FrmDispense()
        {
            InitializeComponent();
        }

        private void FrmDispense_Load(object sender, EventArgs e)
        {
            InitializeCart();
            LoadInventory();
            LoadNotifications();
            timerRefresh.Start();
        }

        private void InitializeCart()
        {
            dtCart = new DataTable();
            dtCart.Columns.Add("MedicationId", typeof(int));
            dtCart.Columns.Add("Name", typeof(string));
            dtCart.Columns.Add("RequestedName", typeof(string));
            dtCart.Columns.Add("Status", typeof(string)); // Available / Not Found / Low Stock
            dtCart.Columns.Add("Price", typeof(decimal));
            dtCart.Columns.Add("Quantity", typeof(int));
            dtCart.Columns.Add("Total", typeof(decimal), "Price * Quantity");
            
            dgvItems.DataSource = dtCart;
            dgvItems.Columns["MedicationId"].Visible = false;
        }

        private void LoadInventory()
        {
            dtInventory = mm.GetAllMedications();
        }

        private void LoadNotifications()
        {
            try
            {
                dtNotifications = dm.GetDoctorNotifications();
                dgvNotifications.DataSource = dtNotifications;
                // Hide IDs if needed
                if(dgvNotifications.Columns.Contains("Visit_Id")) dgvNotifications.Columns["Visit_Id"].Visible = false;
                if(dgvNotifications.Columns.Contains("Patient_Id")) dgvNotifications.Columns["Patient_Id"].Visible = false;
            }
            catch 
            {
                // Silent fail on timer?
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadNotifications();
            LoadInventory();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            LoadNotifications();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // When clicking a row, load its details into the Cart view
            if (e.RowIndex >= 0)
            {
                // Assuming rows are grouped by VisitId visually or multiple rows per visit?
                // The SP returns joined rows (1 row per med per visit).
                // I should extract the VisitId and filter locally from the table to get all meds for that visit.
                
                try 
                {
                    int visitId = Convert.ToInt32(dgvNotifications.Rows[e.RowIndex].Cells["Visit_Id"].Value);
                    currentPatientName = dgvNotifications.Rows[e.RowIndex].Cells["PatientName"].Value.ToString();
                    currentPatientId = Convert.ToInt32(dgvNotifications.Rows[e.RowIndex].Cells["Patient_Id"].Value);
                    currentVisitId = visitId;
                    
                    lblPatientInfo.Text = "بيانات المريض: " + currentPatientName;
                    
                    dtCart.Rows.Clear();
                    
                    // Filter notifications for this visit
                    DataRow[] visitRows = dtNotifications.Select("Visit_Id = " + visitId);
                    
                    foreach (DataRow row in visitRows)
                    {
                        string medName = row["MedicineName"].ToString();
                        MatchAndAddToCart(medName);
                    }
                    UpdateTotal();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MatchAndAddToCart(string requestedName)
        {
            // Simple string matching
            DataRow[] found = dtInventory.Select($"Name LIKE '%{requestedName}%' OR ScientificName LIKE '%{requestedName}%'");
            
            if (found.Length > 0)
            {
                DataRow stockItem = found[0];
                DataRow newRow = dtCart.NewRow();
                newRow["MedicationId"] = stockItem["Id"];
                newRow["Name"] = stockItem["Name"];
                newRow["RequestedName"] = requestedName;
                newRow["Price"] = stockItem["SellingPrice"];
                newRow["Quantity"] = 1; // Default 1 for now
                
                int stock = Convert.ToInt32(stockItem["Quantity"]);
                if(stock <= 0)
                     newRow["Status"] = "غـير متوفر (Out of Stock)";
                else
                     newRow["Status"] = "متوفر";

                dtCart.Rows.Add(newRow);
            }
            else
            {
                DataRow newRow = dtCart.NewRow();
                newRow["MedicationId"] = -1; // Not found
                newRow["Name"] = "---";
                newRow["RequestedName"] = requestedName;
                newRow["Price"] = 0;
                newRow["Quantity"] = 0;
                newRow["Status"] = "غير موجود";
                dtCart.Rows.Add(newRow);
            }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in dtCart.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
            }
            lblTotal.Text = "الإجمالي: " + total.ToString("N2");
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
            if (dtCart.Rows.Count == 0) return;

            try
            {
                decimal total = 0;
                foreach (DataRow row in dtCart.Rows) total += Convert.ToDecimal(row["Total"]);

                int userId = BeninaClinic.PL.Forms.Frm_Login.UserID;
                // Assuming "Program.UserId" or similar? Ref: Frm_Login has static UserName.
                // I won't query UserID now to save time, defaulting to 1 or 0.

                int dispId = dm.InsertDispensation(userId, currentPatientId, currentPatientName, total, "");

                foreach (DataRow row in dtCart.Rows)
                {
                    int medId = Convert.ToInt32(row["MedicationId"]);
                    if (medId > 0)
                    {
                         int qty = Convert.ToInt32(row["Quantity"]);
                         decimal cost = Convert.ToDecimal(row["Price"]);
                         dm.InsertDispensationDetail(dispId, medId, qty, cost);
                    }
                }
                
                MessageBox.Show("تم الصرف بنجاح");
                dtCart.Rows.Clear();
                lblTotal.Text = "0.00";
                LoadInventory(); // Refresh stock
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
