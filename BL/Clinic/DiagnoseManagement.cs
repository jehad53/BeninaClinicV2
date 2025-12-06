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
  public class DiagnoseManagement
    {
        // Insert Diagnose
        public void InsertDepartment(string DepartmentName, string DepartmentManger)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[2];
                pr[0] = new SqlParameter("@DiagnosisName", SqlDbType.NVarChar, 150);
                pr[0].Value = DepartmentName;
                pr[1] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[1].Value = DepartmentManger;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertDiagnose", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertDiagnose  --> {ex.Message}");
            }

        }


        // Get All Diagnoses
        public DataTable GetAllDiagnoses()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllDiagnoses", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllDiagnoses -->  { ex.Message }");
            }
        }

        // Edit Diagnose 
        public void EditDiagnose(int Diagnose_Id, string DiagnosetName, string Description)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[3];
                pr[0] = new SqlParameter("@Diagnosis_Id", SqlDbType.Int);
                pr[0].Value = Diagnose_Id;
                pr[1] = new SqlParameter("@DiagnosisName", SqlDbType.NVarChar, 150);
                pr[1].Value = DiagnosetName;
                pr[2] = new SqlParameter("@Description", SqlDbType.NVarChar);
                pr[2].Value = Description;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditDiagnose", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditDiagnose  --> {ex.Message}");
            }

        }

        public void DeleteDiagnose(int Department_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Diagnosis_Id", SqlDbType.Int);
                pr[0].Value = Department_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteDiagnose", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteDiagnose  --> {ex.Message}");
            }
        }

        // Function for Search Diagnose
        public DataTable SearchDiagnose(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchDiagnose", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchDiagnose  --> {ex.Message}");
            }
        }
    }
}
