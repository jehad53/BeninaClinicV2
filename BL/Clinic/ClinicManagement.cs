using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeninaClinic.DAL;
using System.Data;
using System.Data.SqlClient;
namespace BeninaClinic.BL.Clinic
{
    public class ClinicManagement
    {

        //public int GetMaxID(string tblname, string fieldname)
        //{
        //    SqlParameter[] prm = new SqlParameter[2];
        //    prm[0] = new SqlParameter("@tblName", SqlDbType.VarChar,50);
        //    prm[0].Value = tblname;
        //    prm[1] = new SqlParameter("@fieldName", SqlDbType.VarChar, 50);
        //    prm[1].Value = fieldname;
        //    try
        //    {
        //        using (Db db = new Db())
        //        {
        //            int Num = db.MaxID("GetMaxID", prm);
        //            return Num;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException("Error in GETMAXID ", ex.Message);
        //    }
        //}

        public void InsertClinic(string ClinicName , string ClinicManager , string ClinicPhone)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@ClinicName", SqlDbType.NVarChar,100);
            prm[0].Value = ClinicName;
            prm[1] = new SqlParameter("@ClincManager", SqlDbType.NVarChar, 100);
            prm[1].Value = ClinicManager;
            prm[2] = new SqlParameter("@ClinicPhone", SqlDbType.VarChar, 100);
            prm[2].Value = ClinicPhone;

            try
           { 
            using (Db db = new Db())
            {
                db.ExecuteCommand("InsertClinic", prm);
            }
           }

            catch (Exception ex)
            {
                throw new ArgumentException("Error in InsertClinic ", ex.Message);
            }
        }


        // GET ALL CLINICS 
        public DataTable GetAllClinics()
        {
          try
            {
                using (Db db = new Db())
                {

                    return db.ReadData("GetAllClinics", null);  
                }
            }

            catch (Exception ex)
            {
                throw new ArgumentException("Error in GetAllClinics ", ex.Message);
            }
        }

        // Edit Data CLINIC
        public void EditClinics(int Clinic_Id, string ClinicName, string ClinicManager, string ClinicPhone)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@Clinic_Id", SqlDbType.Int);
            prm[0].Value = Clinic_Id;
            prm[1] = new SqlParameter("@ClinicName", SqlDbType.NVarChar, 100);
            prm[1].Value = ClinicName;
            prm[2] = new SqlParameter("@ClinicManager", SqlDbType.VarChar, 100);
            prm[2].Value = ClinicManager;
            prm[3] = new SqlParameter("@ClinicPhone", SqlDbType.VarChar, 100);
            prm[3].Value = ClinicPhone;

            try
            {
                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditClinics", prm);
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Error in EditClinics ", ex);
            }
        }

        // Delete CLINIC + New Method to Send Data 
        public void DeleteClinics(int Clinic_Id)
        {
            try
            {
                //New Method to Send Data
                SqlParameter[] pr = new SqlParameter[]
                {
                new SqlParameter ("@Clinic_Id" ,SqlDbType.Int) { Value = Clinic_Id }
                };

                using(Db db = new Db())
                {
                    db.ExecuteCommand("DeleteClinics", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in DeleteClinics", ex);
            }
        }
    }
}
