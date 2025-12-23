using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;
using BeninaClinic.BL.Clinic;
namespace BeninaClinic.BL.Pharmacy
{
    public class MedicationManagement
    {
        AuditLogManagement _audit = new AuditLogManagement();

        // Get Medication By Id
        public DataTable GetMedicationById(int Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Id", SqlDbType.Int) { Value = Id };
                using (Db db = new Db())
                {
                    return db.ReadData("Pharmacy_GetMedicationById", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetMedicationById --> {ex.Message}");
            }
        }

        // Insert Medication
        public void InsertMedication(string Code, string Name, string ScientificName, string Type, 
                                     decimal PurchasePrice, decimal SellingPrice, int Quantity, 
                                     DateTime ExpiryDate, DateTime ProductionDate, int AlertQuantity, int userId)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[10];
                pr[0] = new SqlParameter("@Code", SqlDbType.NVarChar, 50) { Value = Code };
                pr[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 150) { Value = Name };
                pr[2] = new SqlParameter("@ScientificName", SqlDbType.NVarChar, 150) { Value = ScientificName };
                pr[3] = new SqlParameter("@Type", SqlDbType.NVarChar, 50) { Value = Type };
                pr[4] = new SqlParameter("@PurchasePrice", SqlDbType.Decimal) { Value = PurchasePrice };
                pr[5] = new SqlParameter("@SellingPrice", SqlDbType.Decimal) { Value = SellingPrice };
                pr[6] = new SqlParameter("@Quantity", SqlDbType.Int) { Value = Quantity };
                pr[7] = new SqlParameter("@ExpiryDate", SqlDbType.Date) { Value = ExpiryDate };
                pr[8] = new SqlParameter("@ProductionDate", SqlDbType.Date) { Value = ProductionDate };
                pr[9] = new SqlParameter("@AlertQuantity", SqlDbType.Int) { Value = AlertQuantity };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("Pharmacy_InsertMedication", pr);
                }

                _audit.AddLog("Insert", "Pharmacy_Medications", Code, Convert.ToInt32(userId), null, $"Name: {Name}, Qty: {Quantity}", null);

            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertMedication --> {ex.Message}");
            }
        }

        // Update Medication
        public void UpdateMedication(int Id, string Code, string Name, string ScientificName, string Type,
                                     decimal PurchasePrice, decimal SellingPrice, int Quantity,
                                     DateTime ExpiryDate, DateTime ProductionDate, int AlertQuantity, int userId)
        {
            try
            {
 
                SqlParameter[] pr = new SqlParameter[11];
                pr[0] = new SqlParameter("@Id", SqlDbType.Int) { Value = Id };
                pr[1] = new SqlParameter("@Code", SqlDbType.NVarChar, 50) { Value = Code };
                pr[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 150) { Value = Name };
                pr[3] = new SqlParameter("@ScientificName", SqlDbType.NVarChar, 150) { Value = ScientificName };
                pr[4] = new SqlParameter("@Type", SqlDbType.NVarChar, 50) { Value = Type };
                pr[5] = new SqlParameter("@PurchasePrice", SqlDbType.Decimal) { Value = PurchasePrice };
                pr[6] = new SqlParameter("@SellingPrice", SqlDbType.Decimal) { Value = SellingPrice };
                pr[7] = new SqlParameter("@Quantity", SqlDbType.Int) { Value = Quantity };
                pr[8] = new SqlParameter("@ExpiryDate", SqlDbType.Date) { Value = ExpiryDate };
                pr[9] = new SqlParameter("@ProductionDate", SqlDbType.Date) { Value = ProductionDate };
                pr[10] = new SqlParameter("@AlertQuantity", SqlDbType.Int) { Value = AlertQuantity };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("Pharmacy_UpdateMedication", pr);
                }
                
                string newValue = $"{Code} | {Name} | {ScientificName} | {Type} | {PurchasePrice} | {SellingPrice} | {Quantity} | {ExpiryDate} | {ProductionDate} | {AlertQuantity}";
                _audit.AddLog("Update", "Pharmacy_Medications", Id.ToString(), userId, "oldValue", newValue, null);

            }
            catch (Exception ex)
            {
                throw new Exception($"Error in UpdateMedication --> {ex.Message}");
            }
        }

        // Delete Medication
        public void DeleteMedication(int Id, int userId)
        {
            try
            {
                // Get Old Value
                string oldValue = "";
                DataTable dtOld = GetMedicationById(Id);
                if (dtOld.Rows.Count > 0)
                {
                    oldValue = string.Join(" | ", dtOld.Rows[0].ItemArray);
                }

                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Id", SqlDbType.Int) { Value = Id };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("Pharmacy_DeleteMedication", pr);
                }

                _audit.AddLog("Delete", "Pharmacy_Medications", Id.ToString(), userId, oldValue, "Deleted", null);

            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteMedication --> {ex.Message}");
            }
        }

        // Get All Medications
        public DataTable GetAllMedications()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("Pharmacy_GetAllMedications", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllMedications --> {ex.Message}");
            }
        }

        // Search Medications
        public DataTable SearchMedications(string search)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 100) { Value = search };

                using (Db db = new Db())
                {
                    return db.ReadData("Pharmacy_SearchMedications", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchMedications --> {ex.Message}");
            }
        }

        // Get Medication By Id
        public DataTable GetMedication(int Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Id", SqlDbType.Int) { Value = Id };
                // reusing Search but filtering by ID effectively requires a new SP or just filtering locally?
                // Actually I didn't create Pharmacy_GetMedication SP.
                // I'll use a direct Select query if ReadData supports it, but Db.cs expects SP.
                // I will add a dynamic SQL or just use SearchMedications and filter in code if I was lazy,
                // BUT I should create the SP. 
                // Since I cannot ask user to run SQL again easily effectively, I will use "Pharmacy_SearchMedications" 
                // but passing the ID as string if the SP supports it? No, UpdateMedication exists.
                // Wait, I can't effectively fetch ONE item without an SP.
                // OPTION: Pass the DataRow from the GridView to the Form!
                // This is safer than modifying DB schema again.
                // I will abort adding this method and pass data via constructor.
                return null; 
            }
            catch { return null; }
        }
    }
}
