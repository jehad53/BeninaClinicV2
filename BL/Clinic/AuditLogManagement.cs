using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BeninaClinic.DAL;
using System.Management;

namespace BeninaClinic.BL.Clinic
{
    public class AuditLogManagement
    {
        // Add Log
        public void AddLog(string actionType, string tableName, string recordId, int userId, string oldValue, string newValue, string MachineName)
        {
            try
            {
                SqlParameter[] pr = new SqlParameter[7];
                pr[0] = new SqlParameter("@ActionType", SqlDbType.NVarChar, 50) { Value = actionType };
                pr[1] = new SqlParameter("@TableName", SqlDbType.NVarChar, 100) { Value = tableName };
                pr[2] = new SqlParameter("@RecordId", SqlDbType.NVarChar, 50) { Value = recordId ?? (object)DBNull.Value };
                pr[3] = new SqlParameter("@UserId", SqlDbType.Int) { Value = userId };
                pr[4] = new SqlParameter("@OldValue", SqlDbType.NVarChar) { Value = oldValue ?? (object)DBNull.Value };
                pr[5] = new SqlParameter("@NewValue", SqlDbType.NVarChar) { Value = newValue ?? (object)DBNull.Value };
                pr[6] = new SqlParameter("@MachineName", SqlDbType.NVarChar, 100) { Value = GetDeviceSerialNumber() ?? (object)DBNull.Value };

                using (Db db = new Db())
                {
                    db.ExecuteCommand("Audit_InsertLog", pr);
                }
            }
            catch
            {
                // In production, we might log this to a file, but here we swallow or throw. 
                // Swallowing is safer to avoid breaking the main flow if logging fails.
                // However, detailed requirements ask for "System Activity Tracking", so maybe we should throw.
                // But usually logging failure shouldn't stop business logic.
                // I will throw for now to help debugging, or I can catch.
                // ex.Message
            }

        }

            public string GetDeviceSerialNumber()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_BIOS");

                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["SerialNumber"]?.ToString()?.Trim();
                }
            }
            catch
            {
                // ضع هنا Log أو رسالة خطأ لو تبي
            }

            return "Unknown";
        }

        // Get Logs
        public DataTable GetLogs()
        {
            try
            {
                using (Db db = new Db())
                {
                    return db.ReadData("Audit_GetLogs", null);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Audit_GetLogs", ex);
            }
        }
    }
    }

