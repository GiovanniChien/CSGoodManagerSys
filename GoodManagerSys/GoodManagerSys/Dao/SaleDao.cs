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
    class SaleDao {
        public static List<EtSale> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryBySaleID(int saleID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE saleID = @saleID";
            MySqlParameter[] prams = { new MySqlParameter("@saleID", saleID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryByGoodID(int goodID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE goodID = @goodID";
            MySqlParameter[] prams = { new MySqlParameter("@goodID", goodID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryBySaleDate(string saleDate) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE saleDate = @saleDate";
            MySqlParameter[] prams = { new MySqlParameter("@saleDate", saleDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryByStaffID(int staffID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale WHERE staffID = @staffID";
            MySqlParameter[] prams = { new MySqlParameter("@staffID", staffID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static int InsertSale(EtSale sale) {
            List<EtSale> sales = QueryBySaleID(sale.SaleID);
            if (sales.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "sale(saleID,goodID,saleDate,profit,staffID) " +
                "VALUE(@saleID,@goodID,@saleDate,@profit,@staffID)";
            MySqlParameter[] prams = {
                new MySqlParameter("@saleID",sale.SaleID),
                new MySqlParameter("@goodID",sale.Good.GoodID),
                new MySqlParameter("@saleDate",sale.SaleDate??(object)DBNull.Value),
                new MySqlParameter("@profit",sale.Profit),
                new MySqlParameter("@staffID",sale.StaffID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        private static List<EtSale> GetListByDataReader(MySqlDataReader dr) {
            List<EtSale> sales = new List<EtSale>();
            while (dr.Read()) {
                EtSale sale = new EtSale {
                    SaleID = dr.GetInt32("saleID"),
                    Good = new EtGood
                    {
                        GoodID = dr.GetInt32("goodID"),
                        CategoryID = dr.GetInt32("categoryID"),
                        ProductionDate = dr["productionDate"] is DBNull ? null : dr.GetString("productionDate"),
                        PurchaseDate = dr["purchaseDate"] is DBNull ? null : dr.GetString("purchaseDate"),
                        Cost = dr["cost"] is DBNull ? 0 : dr.GetDouble("cost"),
                        Price = dr["price"] is DBNull ? 0 : dr.GetDouble("price"),
                        State = (EState)(dr["state"] is DBNull ? 0 : dr.GetInt32("state"))
                    },
                    SaleDate = dr["saleDate"] is DBNull ? null : dr.GetString("saleDate"),
                    Profit = dr["profit"] is DBNull ? 0 : dr.GetDouble("profit"),
                    StaffID = dr.GetInt32("staffID")
                };
                sales.Add(sale);
            }
            return sales;
        }

    }
}
