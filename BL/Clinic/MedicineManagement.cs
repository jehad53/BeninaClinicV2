using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;

namespace BeninaClinic.BL.Clinic
{
   public class MedicineManagement
    {
        //Insert Medicine
        public void InsertMedicine(string MedicineName, string ScinceName , int Qty)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[3];
                pr[0] = new SqlParameter("@MedicineName", SqlDbType.NVarChar, 150);
                pr[0].Value = MedicineName;
                pr[1] = new SqlParameter("@ScienceName", SqlDbType.NVarChar, 150);
                pr[1].Value = ScinceName;
                pr[2] = new SqlParameter("@Qty", SqlDbType.Int);
                pr[2].Value = Qty;
                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertMedicine", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertMedicine  --> {ex.Message}");
            }

        }


        // Get All Medicines
        public DataTable GetAllMedicines()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllMedicine", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllMedicine -->  { ex.Message }");
            }
        }

        // Edit Medicine 
        public void EditMedicine(int Medicine_Id, string MedicineName, string ScienceName, int Qty)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[4];
                pr[0] = new SqlParameter("@Medicine_Id", SqlDbType.Int);
                pr[0].Value = Medicine_Id;
                pr[1] = new SqlParameter("@MedicineName", SqlDbType.NVarChar, 150);
                pr[1].Value = MedicineName;
                pr[2] = new SqlParameter("@ScienceName", SqlDbType.NVarChar, 150);
                pr[2].Value = ScienceName;
                pr[3] = new SqlParameter("@Qty", SqlDbType.Int);
                pr[3].Value = Qty;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditMedicine", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditMedicine  --> {ex.Message}");
            }

        }

        public void DeleteMedicine(int Medicine_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Medicine_Id", SqlDbType.Int);
                pr[0].Value = Medicine_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteMedicine", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteMedicine  --> {ex.Message}");
            }
        }

        public DataTable SearchMedicine(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchMedicine", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchMedicine  --> {ex.Message}");
            }
        }
    }
}
