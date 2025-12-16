using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;
using BeninaClinic.PL.Forms;

namespace BeninaClinic.BL.Clinic
{
   public class PatientManagement
    {
        // Insert Patient
        public void InsertPatient(string PatientName, string Gender , DateTime BoD ,int Age , string Note, string Phone , string NatNum  , string Address ,string BooldType)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[9];
                pr[0] = new SqlParameter("@PatientName", SqlDbType.NVarChar, 150);
                pr[0].Value = PatientName;
                pr[1] = new SqlParameter("@Gender", SqlDbType.NVarChar , 50);
                pr[1].Value = Gender;
                pr[2] = new SqlParameter("@BoD", SqlDbType.Date);
                pr[2].Value = BoD;
                pr[3] = new SqlParameter("@Age", SqlDbType.Int);
                pr[3].Value = Age;
                pr[4] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[4].Value = Note;
                pr[5] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
                pr[5].Value = Phone;
                pr[6] = new SqlParameter("@NatNum", SqlDbType.NVarChar, 150);
                pr[6].Value = NatNum;
                pr[7] = new SqlParameter("@Address", SqlDbType.NVarChar, 150);
                pr[7].Value = Address;
                pr[8] = new SqlParameter("@BooldType", SqlDbType.NVarChar, 10);
                pr[8].Value = BooldType;
                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertPatient", pr);
                }
                AuditLogManagement log = new AuditLogManagement();
                string newValue = $"Name: {PatientName}, Gender: {Gender}, BoD: {BoD}, Phone: {Phone}, NatNum: {NatNum}";
                log.AddLog("Insert", "Patients", NatNum, Frm_Login.UserID, null, newValue, null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertPatient  --> {ex.Message}");
            }
        }


        // Get All Patient
        public DataTable GetAllPatients()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GelAllPatients", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GelAllPatients -->  { ex.Message }");
            }
        }

        public DataTable GelPatientByNatNum(string NatNum)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@NatNum", SqlDbType.NVarChar,50);
                pr[0].Value = NatNum;
                using (Db db = new Db())
                {
                    return db.ReadData("GelPatientByNatNum", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GelPatientByNatNum -->  { ex.Message }");
            }
        }


        // Edit Patient 
        public void EditPatient(int Patient_Id, string PatientName, string Gender, DateTime BoD, int Age, string Note , string Phone, string NatNum, string Address ,string BooldType)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[10];
                pr[0] = new SqlParameter("@Patient_Id", SqlDbType.Int);
                pr[0].Value = Patient_Id;
                pr[1] = new SqlParameter("@PatientName", SqlDbType.NVarChar, 150);
                pr[1].Value = PatientName;
                pr[2] = new SqlParameter("@Gender", SqlDbType.NVarChar, 50);
                pr[2].Value = Gender;
                pr[3] = new SqlParameter("@BoD", SqlDbType.Date);
                pr[3].Value = BoD;
                pr[4] = new SqlParameter("@Age", SqlDbType.Int);
                pr[4].Value = Age;
                pr[5] = new SqlParameter("@Note", SqlDbType.NVarChar);
                pr[5].Value = Note;
                pr[6] = new SqlParameter("@Phone", SqlDbType.NVarChar ,50);
                pr[6].Value = Phone;
                pr[7] = new SqlParameter("@NatNum", SqlDbType.NVarChar , 150);
                pr[7].Value = NatNum;
                pr[8] = new SqlParameter("@Address", SqlDbType.NVarChar , 150);
                pr[8].Value = Address;
                pr[9] = new SqlParameter("@BooldType", SqlDbType.VarChar, 10);
                pr[9].Value = BooldType;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("EditPatient", pr);
                }
                AuditLogManagement log = new AuditLogManagement();
                string newValue = $"Id: {Patient_Id}, Name: {PatientName}, Phone: {Phone}, NatNum: {NatNum}, Address: {Address}";
                log.AddLog("Update", "Patients", Patient_Id.ToString(), Frm_Login.UserID, "See Record", newValue, null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in EditPatient  --> {ex.Message}");
            }
        }

        // Delete Patient
        public void DeletePatient(int Department_Id)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@Patient_Id", SqlDbType.Int);
                pr[0].Value = Department_Id;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("DeletePatient", pr);
                }
                AuditLogManagement log = new AuditLogManagement();
                log.AddLog("Delete", "Patients", Department_Id.ToString(), Frm_Login.UserID, $"Deleted ID: {Department_Id}", "Deleted", null);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DeletePatient  --> {ex.Message}");
            }
        }

        // Function for Search Patient
        public DataTable SearchPatient(string Word)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[] { new SqlParameter("@Word", SqlDbType.NVarChar, 100) { Value = Word } };
                using (Db db = new Db())
                {
                    return db.ReadData("SearchPatient", pr);
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"Error in SearchPatient  --> {ex.Message}");
            }
        }



    }
}
