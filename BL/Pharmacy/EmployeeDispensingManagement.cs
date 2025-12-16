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
    public class EmployeeDispensingManagement
    {
        // Insert Dispensation Header
        public int InsertDispensation(int userId, int employeeId, string employeeName, decimal totalCost, string note)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[6];
                pr[0] = new SqlParameter("@UserId", SqlDbType.Int) { Value = userId };
                pr[1] = new SqlParameter("@EmployeeId", SqlDbType.Int) { Value = employeeId };
                pr[2] = new SqlParameter("@EmployeeName", SqlDbType.NVarChar, 150) { Value = employeeName };
                pr[3] = new SqlParameter("@TotalCost", SqlDbType.Decimal) { Value = totalCost };
                pr[4] = new SqlParameter("@Note", SqlDbType.NVarChar) { Value = note ?? (object)DBNull.Value };
                
                pr[5] = new SqlParameter("@NewId", SqlDbType.Int);
                pr[5].Direction = ParameterDirection.Output;

                using (Db db = new Db())
                {
                    return db.ExecuteCommandReturnID("Pharmacy_InsertEmployeeDispensation", pr, "@NewId");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertDispensation --> {ex.Message}");
            }
        }

        // Insert Dispensation Details
        public void InsertDispensationDetail(int dispensationId, int medicationId, int quantity, decimal cost)
        {
             try
            {
                SqlParameter[] pr = new SqlParameter[4];
                pr[0] = new SqlParameter("@DispensationId", SqlDbType.Int) { Value = dispensationId };
                pr[1] = new SqlParameter("@MedicationId", SqlDbType.Int) { Value = medicationId };
                pr[2] = new SqlParameter("@Quantity", SqlDbType.Int) { Value = quantity };
                pr[3] = new SqlParameter("@Cost", SqlDbType.Decimal) { Value = cost };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("Pharmacy_InsertEmployeeDispensationDetail", pr);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in InsertDispensationDetail --> {ex.Message}");
            }
        }
    }
}
