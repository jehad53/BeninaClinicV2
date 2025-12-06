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
    public class DoseManagement
    {
        // Insert Dose
        public void InsertDose(string DoseName)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@DoseName", SqlDbType.NVarChar, 200);
                pr[0].Value = DoseName;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertDose", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertDose  --> {ex.Message}");
            }
        }


        // Get All Dose
        public DataTable GetAllDoses()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllDoses", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllDoses -->  { ex.Message }");
            }
        }

        // Edit Dose 
        public void EditDose(int Diagnose_Id, string DiagnosetName)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@Dose_Id", SqlDbType.Int);
                pr[0].Value = Diagnose_Id;
                pr[1] = new SqlParameter("@DoseName", SqlDbType.NVarChar, 200);
                pr[1].Value = DiagnosetName;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditDose", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditDose  --> {ex.Message}");
            }
        }

        // Delete Dose
        public void DeleteDose(int Department_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Dose_Id", SqlDbType.Int);
                pr[0].Value = Department_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteDose", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteDose  --> {ex.Message}");
            }
        }

        // Function for Search Dose
        public DataTable SearchDose(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchDose", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchDose  --> {ex.Message}");
            }
        }
    }
}
