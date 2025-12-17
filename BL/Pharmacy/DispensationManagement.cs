using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;

namespace BeninaClinic.BL.Pharmacy
{
    public class DispensationManagement
    {
        // Insert Dispensation Header
        public int InsertDispensation(int UserId, int PatientId, string PatientName, decimal TotalCost, string Note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[6];
                pr[0] = new SqlParameter("@UserId", SqlDbType.Int) { Value = UserId };
                pr[1] = new SqlParameter("@PatientId", SqlDbType.Int) { Value = PatientId }; // Can be 0 or null logic handled by SP if needed, but int usually defaults to 0
                pr[2] = new SqlParameter("@PatientName", SqlDbType.NVarChar, 150) { Value = PatientName };
                pr[3] = new SqlParameter("@TotalCost", SqlDbType.Decimal) { Value = TotalCost };
                pr[4] = new SqlParameter("@Note", SqlDbType.NVarChar) { Value = Note };
                pr[5] = new SqlParameter("@NewId", SqlDbType.Int) { Direction = ParameterDirection.Output };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("Pharmacy_InsertDispensation", pr);
                    return Convert.ToInt32(pr[5].Value);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertDispensation --> {ex.Message}");
            }
        }

        // Insert Dispensation Detail
        public void InsertDispensationDetail(int DispensationId, int MedicationId, int Quantity, decimal Cost)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[4];
                pr[0] = new SqlParameter("@DispensationId", SqlDbType.Int) { Value = DispensationId };
                pr[1] = new SqlParameter("@MedicationId", SqlDbType.Int) { Value = MedicationId };
                pr[2] = new SqlParameter("@Quantity", SqlDbType.Int) { Value = Quantity };
                pr[3] = new SqlParameter("@Cost", SqlDbType.Decimal) { Value = Cost };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("Pharmacy_InsertDispensationDetail", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertDispensationDetail --> {ex.Message}");
            }
        }

        // Get Doctor Notifications (Pending Prescriptions)
        public DataTable GetDoctorNotifications()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("Pharmacy_GetDoctorNotifications", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetDoctorNotifications --> {ex.Message}");
            }
        }

        // Get All Dispensation 
        public DataTable GetAllDispensation()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("GetAllDispenations", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetAllDispenations --> {ex.Message}");
            }
        }

        // Get Dispensation Between 2 Dates
        public DataTable GetDispensationBetweenDates(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (Db db = new Db())
                {
                    SqlParameter[] param = new SqlParameter[2];

                    param[0] = new SqlParameter("@FromDate", SqlDbType.Date);
                    param[0].Value = fromDate.Date;

                    param[1] = new SqlParameter("@ToDate", SqlDbType.Date);
                    param[1].Value = toDate.Date;

                    return db.ReadData("GetDispensationBetweenDates", param);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetDispensationBetweenDates --> {ex.Message}");
            }
        }

       // GetDispensationByName
        public DataTable GetDispensationByName(string Name)
        {
            try
            {
                using (Db db = new Db())
                {
                    SqlParameter[] param = new SqlParameter[1];

                    param[0] = new SqlParameter("@PatientName", SqlDbType.NVarChar ,100);
                    param[0].Value = Name;


                    return db.ReadData("GetDispensationByName", param);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GetDispensationByName --> {ex.Message}");
            }
        }
    }
}
