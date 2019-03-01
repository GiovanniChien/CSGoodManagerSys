using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Dao {
    class StaffDao {
        public static List<EtStaff> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM staff";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }

        public static List<EtStaff> QueryByStaffID(int staffID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM staff WHERE staffID = @staffID";
            MySqlParameter[] prams = { new MySqlParameter("@staffID", staffID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtStaff> QueryByStaffName(string staffName) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM staff WHERE staffName = @staffName";
            MySqlParameter[] prams = { new MySqlParameter("@staffName", staffName) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtStaff> QueryByRole(int role) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM staff WHERE role = @role";
            MySqlParameter[] prams = { new MySqlParameter("@role", role) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static int InsertStaff(EtStaff staff) {
            List<EtStaff> staffs = QueryByStaffID(staff.StaffID);
            if (staffs.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "staff(staffName,pwd,staffPhone,role) " +
                "VALUE(@staffName,@pwd,@staffPhone,@role)";
            MySqlParameter[] prams = {
                new MySqlParameter("@staffName",staff.StaffName??(object)DBNull.Value),
                new MySqlParameter("@pwd",staff.Pwd??(object)DBNull.Value),
                new MySqlParameter("@staffPhone",staff.StaffPhone??(object)DBNull.Value),
                new MySqlParameter("@role",staff.Role)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        public static int UpdateStaff(EtStaff staff) {
            List<EtStaff> staffs = QueryByStaffID(staff.StaffID);
            if (staffs.Count == 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE category SET staffName = @staffName," +
                "pwd = @pwd,staffPhone = @staffPhone," +
                "role = @role";
            MySqlParameter[] prams = {
                new MySqlParameter("@staffName",staff.StaffName),
                new MySqlParameter("@pwd",staff.Pwd),
                new MySqlParameter("@staffPhone",staff.StaffPhone),
                new MySqlParameter("@role",staff.Role)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        private static List<EtStaff> GetListByDataReader(MySqlDataReader dr) {
            List<EtStaff> staffs = new List<EtStaff>();
            while (dr.Read()) {
                EtStaff staff = new EtStaff {
                    StaffID = dr.GetInt32("staffID"),
                    StaffName = dr["staffName"] is DBNull ? null : dr.GetString("staffName"),
                    Pwd = dr["pwd"] is DBNull ? null : dr.GetString("pwd"),
                    StaffPhone = dr["staffPhone"] is DBNull ? null : dr.GetString("staffPhone"),
                    Role = dr["role"] is DBNull ? 0 : dr.GetInt32("role")
                };
                staffs.Add(staff);
            }
            return staffs;
        }
    }
}
