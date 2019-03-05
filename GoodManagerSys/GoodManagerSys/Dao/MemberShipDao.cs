using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GoodManagerSys.Dao {
    class MembershipDao {
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
        public static int UpdateMembership(EtMembership membership)
        {
            List<EtMembership> memberships = QueryByMsID(membership.MsID);
            if (memberships.Count == 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE membership SET msName = @MsName, msPhone = @MsPhone," +
                "msPoint = @MsPoint, isValid = @IsValid " +
                "WHERE msID = @MsID;";
            MySqlParameter[] prams ={
                new MySqlParameter("@MsName",membership.MsName??(object)DBNull.Value),
                new MySqlParameter("@MsPhone",membership.MsPhone??(object)DBNull.Value),
                new MySqlParameter("@MsPoint",membership.MsPoint),
                new MySqlParameter("@IsValid",membership.IsValid),
                new MySqlParameter("@MsID",membership.MsID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        public static int InsertMembership(EtMembership membership) {
            List<EtMembership> memberships = QueryByMsID(membership.MsID);
            if (memberships.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "membership(msName,msPhone,msPoint,isValid) " +
                "VALUE(@msName,@msPhone,@msPoint,@isValid)";
            MySqlParameter[] prams = {
                new MySqlParameter("@MsName",membership.MsName??(object)DBNull.Value),
                new MySqlParameter("@MsPhone",membership.MsPhone??(object)DBNull.Value),
                new MySqlParameter("@msPoint",membership.MsPoint),
                new MySqlParameter("@isValid",membership.IsValid)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        public static int DeleteByMsID(int msID) {
            List<EtMembership> memberships = QueryByMsID(msID);
            if (memberships.Count == 0) return 0;
            if (memberships[0].IsValid == EValid.已删除) return -2;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE membership SET isValid = @isValid WHERE msID = @msID;";
            MySqlParameter[] prams = {
                new MySqlParameter("@isValid",EValid.已删除),
                new MySqlParameter("@msID",msID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        private static List<EtMembership> GetListByDataReader(MySqlDataReader dr) {
            List<EtMembership> memberships = new List<EtMembership>();
            try
            {
                while (dr.Read())
                {
                    EtMembership membership = new EtMembership
                    {
                        MsID = dr.GetInt32("msID"),
                        MsName = dr["msName"] is DBNull ? null : dr.GetString("msName"),
                        MsPhone = dr["msPhone"] is DBNull ? null : dr.GetString("msPhone"),
                        MsPoint = dr["msPoint"] is DBNull ? 0 : dr.GetInt32("msPoint"),
                        IsValid = (EValid)(dr["isValid"] is DBNull ? 0 : dr.GetInt32("isValid"))
                    };
                    memberships.Add(membership);
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());
            }
            return memberships;
        }
    }
}