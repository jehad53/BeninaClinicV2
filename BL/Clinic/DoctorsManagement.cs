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
   public class DoctorsManagement
    {

        // Insert Doctor 
        public void InsertDoctor(string DoctorName, string NationalNum, string Gender,string Phone,string Address, string ContractType, string SocialStatus, string Specialty, int Clinic_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[9];
                pr[0] = new SqlParameter("@DoctorName", SqlDbType.NVarChar,100);
                pr[0].Value = DoctorName;
                pr[1] = new SqlParameter("@NationalNum", SqlDbType.VarChar, 50);
                pr[1].Value = NationalNum;
                pr[2] = new SqlParameter("@Gender", SqlDbType.NVarChar, 50);
                pr[2].Value = Gender;
                pr[3] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                pr[3].Value = Phone;
                pr[4] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                pr[4].Value = Address;
                pr[5] = new SqlParameter("@ContractType", SqlDbType.NVarChar, 50);
                pr[5].Value = ContractType;
                pr[6] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 50);
                pr[6].Value = SocialStatus;
                pr[7] = new SqlParameter("@Specialty", SqlDbType.NVarChar, 50);
                pr[7].Value = Specialty;
                pr[8] = new SqlParameter("@Clinic_Id", SqlDbType.Int);
                pr[8].Value = Clinic_Id;

                using (Db db = new Db() )
                {
                    db.ExecuteCommand("InsertDoctor", pr);
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error in InsertDoctor  --> {ex.Message}");
            }
        }

        // Get All Doctors
        public DataTable GetAllDoctors()
        {
            try
            {
                using (Db db = new Db())
                {

                    return db.ReadData("GetAllDoctors", null);
                }
            }

            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllDoctors -->  { ex.Message }");
            }
        }

        public void EditDoctor(int Doctor_Id , string DoctorName , string NationalNum , string Gender , string Phone, string Address, string ContractType, string SocialStatus, string Specialty, int Clinic_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[10];
                pr[0] = new SqlParameter("@DoctorName", SqlDbType.NVarChar, 100);
                pr[0].Value = DoctorName;
                pr[1] = new SqlParameter("@NationalNum", SqlDbType.VarChar, 50);
                pr[1].Value = NationalNum;
                pr[2] = new SqlParameter("@Gender", SqlDbType.NVarChar, 50);
                pr[2].Value = Gender;
                pr[3] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                pr[3].Value = Phone;
                pr[4] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                pr[4].Value = Address;
                pr[5] = new SqlParameter("@ContractType", SqlDbType.NVarChar, 50);
                pr[5].Value = ContractType;
                pr[6] = new SqlParameter("@SocialStatus", SqlDbType.NVarChar, 50);
                pr[6].Value = SocialStatus;
                pr[7] = new SqlParameter("@Specialty", SqlDbType.NVarChar, 50);
                pr[7].Value = Specialty;
                pr[8] = new SqlParameter("@Clinic_Id", SqlDbType.Int);
                pr[8].Value = Clinic_Id;
                pr[9] = new SqlParameter("@Doctor_Id", SqlDbType.Int);
                pr[9].Value = Doctor_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditDoctor", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditDoctor  --> {ex.Message}");
            }
        }
        

        // Method for Delete Doctor
         public void DeleteDoctor(int Doctor_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Doctor_Id", SqlDbType.Int) { Value = Doctor_Id } };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeleteDoctor", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteDoctor  --> {ex.Message}");
            }
        }

        // Function for Search Doctor
        public DataTable SearchDoctorByNameOrNatNum(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar,100) { Value = Word } };
            using (Db db = new Db())
            {
              return  db.ReadData("SearchDoctorByNameOrNatNum", pr);
            }


        }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeleteDoctor  --> {ex.Message}");
             }
           }

        // Function Get Doctors By Clinic

        public DataTable GetDoctorsByClinic(int Dep_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Clinic_Id", SqlDbType.Int);
                pr[0].Value = Dep_Id;
                using (Db db = new Db())
                {

                    return db.ReadData("GetDoctorsByClinic", pr);
                }
            }

            catch (Exception ex)
            {
                throw new Exception($"Error in GetDoctorsByClinic -->  { ex.Message }");
            }
        }

    }
}
