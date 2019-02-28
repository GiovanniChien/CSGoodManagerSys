using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Dao {
    class SaleDao {
        public static List<EtSale> QueryAll()
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        private static List<EtSale> GetListByDataReader(MySqlDataReader dr)
        {
            List<EtSale> sales = new List<EtSale>();
            while (dr.Read())
            {
                EtSale sale = new EtSale
                {
                    SaleID = dr.GetInt32("saleID"),
                    GoodID = dr.GetInt32("goodID"),
                    SaleDate = dr["saleDate"] is DBNull ? null : dr.GetString("saleDate"),
                    Profit = dr["profit"] is DBNull ? 0 : dr.GetDouble("profit"),
                    StaffID = dr.GetInt32("staffID")
                };
                sales.Add(sale);
            }
            return sales;
        }

        public static List<EtSale> QueryBySaleID(int saleID)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE saleID=@saleID";
            MySqlParameter[] prams = { new MySqlParameter("@saleID", saleID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql,prams);
            return GetListByDataReader(dr);
        }

        public static List<EtSale> QueryByGoodID(int goodID)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE goodID=@goodID";
            MySqlParameter[] prams = { new MySqlParameter("@goodID", goodID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtSale> QueryBySaleDate(string saleDate)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE saleDate=@saleDate";
            MySqlParameter[] prams = { new MySqlParameter("@saleDate", saleDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtSale> QueryByStaffID(int staffID)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE staffID=@staffID";
            MySqlParameter[] prams = { new MySqlParameter("@staffID", staffID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
    }
}
