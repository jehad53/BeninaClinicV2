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
    public class MedicineReportManagement
    {
        //Insert Medicine
        public void InsertReportMedical(DateTime ReportDate, string ReportContent, int Visit_Id, int Patient_Id, string PatientName, string Gender, DateTime DateofBirth, int Age, string DoctorName, string ClinicName)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[10];
                pr[0] = new SqlParameter("@ReportDate", SqlDbType.Date);
                pr[0].Value = ReportDate;
                pr[1] = new SqlParameter("@ReportContent", SqlDbType.NVarChar);
                pr[1].Value = ReportContent;
                pr[2] = new SqlParameter("@Visit_Id", SqlDbType.Int);
                pr[2].Value = Visit_Id;
                pr[3] = new SqlParameter("@Patient_Id", SqlDbType.Int);
                pr[3].Value = Patient_Id;
                pr[4] = new SqlParameter("@PatientName", SqlDbType.NVarChar, 150);
                pr[4].Value = PatientName;
                pr[5] = new SqlParameter("@Gender", SqlDbType.NVarChar, 50);
                pr[5].Value = Gender;
                pr[6] = new SqlParameter("@DateofBirth", SqlDbType.Date);
                pr[6].Value = DateofBirth;
                pr[7] = new SqlParameter("@Age", SqlDbType.Int);
                pr[7].Value = Age;
                pr[8] = new SqlParameter("@DoctorName", SqlDbType.NVarChar, 150);
                pr[8].Value = DoctorName;
                pr[9] = new SqlParameter("@ClinicName", SqlDbType.NVarChar, 150);
                pr[9].Value = ClinicName;

                using (Db db = new Db())
                {
                    db.ExecuteCommand("InsertReportMedical", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertReportMedical  --> {ex.Message}");
            }
        }
    }
}