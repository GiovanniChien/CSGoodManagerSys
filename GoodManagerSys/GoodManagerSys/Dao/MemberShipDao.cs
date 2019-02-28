using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Dao {
    class MemberShipDao {
        public static List<EtMembership> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM membership";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        public static List<EtMembership> QueryByMsID(int msID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM membership WHERE msID=@msID";
            MySqlParameter[] prams = { new MySqlParameter("@msID", msID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtMembership> QueryByMsName(string msName) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM membership WHERE msName=@msName";
            MySqlParameter[] prams = { new MySqlParameter("@msName", msName) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtMembership> QueryByIsValid(EValid isValid) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM membership WHERE isValid=@isValid";
            MySqlParameter[] prams = { new MySqlParameter("@isValid", isValid) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static int InsertMemberShip(EtMembership membership) {
            List<EtMembership> memberships = QueryByMsID(membership.MsID);
            if (memberships.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "membership(msName,msPhone,msPoint,isValid) " +
                "VALUE(@msName,@msPhone,@msPoint,@isValid)";
            MySqlParameter[] prams = {
                new MySqlParameter("@msName",membership.MsName),
                new MySqlParameter("@msPhone",membership.MsPhone),
                new MySqlParameter("@msPoint",membership.MsPoint),
                new MySqlParameter("@isValid",membership.IsValid)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        private static List<EtMembership> GetListByDataReader(MySqlDataReader dr) {
            List<EtMembership> memberships = new List<EtMembership>();
            while (dr.Read()) {
                EtMembership membership = new EtMembership {
                    MsID = dr.GetInt32("msID"),
                    MsName = dr["msName"] is DBNull ? null : dr.GetString("msName"),
                    MsPhone = dr["msPhone"] is DBNull ? null : dr.GetString("msPhone"),
                    MsPoint = dr["msPoint"] is DBNull ? 0 : dr.GetInt32("msPoint"),
                    IsValid = dr["isValid"] is DBNull ? 0 : dr.GetInt32("isValid")
                };
                memberships.Add(membership);
            }
            return memberships;
        }
    }
}