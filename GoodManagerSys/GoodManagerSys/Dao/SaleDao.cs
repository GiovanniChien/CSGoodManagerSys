using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GoodManagerSys.Dao {
    class SaleDao {
        public static List<EtSale> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale LEFT JOIN good ON sale.goodID = good.goodID " +
                "LEFT JOIN category ON good.categoryID = category.categoryID";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryBySaleID(int saleID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale LEFT JOIN good ON sale.goodID = good.goodID " +
                "LEFT JOIN category ON good.categoryID = category.categoryID " +
                "WHERE saleID = @saleID";
            MySqlParameter[] prams = { new MySqlParameter("@saleID", saleID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryByGoodID(int goodID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale LEFT JOIN good ON sale.goodID = good.goodID " +
                "LEFT JOIN category ON good.categoryID = category.categoryID " +
                "WHERE sale.goodID = @goodID";
            MySqlParameter[] prams = { new MySqlParameter("@goodID", goodID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryBySaleDate(string saleDate) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale LEFT JOIN good ON sale.goodID = good.goodID " +
                "LEFT JOIN category ON good.categoryID = category.categoryID " +
                "WHERE saleDate = @saleDate";
            MySqlParameter[] prams = { new MySqlParameter("@saleDate", saleDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryByStaffID(int staffID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale LEFT JOIN good ON sale.goodID = good.goodID " +
                "LEFT JOIN category ON good.categoryID = category.categoryID " +
                "WHERE staffID = @staffID";
            MySqlParameter[] prams = { new MySqlParameter("@staffID", staffID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtSale> QueryByPrimaryID(int saleID,int goodID)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM sale LEFT JOIN good ON sale.goodID = good.goodID " +
                "LEFT JOIN category ON good.categoryID = category.categoryID " +
                "WHERE saleID = @saleID and sale.goodID = @goodID";
            MySqlParameter[] prams = {
                new MySqlParameter("@saleID", saleID),
                new MySqlParameter("@goodID",goodID)
            };
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
            try
            {
                while (dr.Read())
                {
                    EtSale sale = new EtSale
                    {
                        SaleID = dr.GetInt32("saleID"),
                        Good = new EtGood
                        {
                            GoodID = dr.GetInt32("goodID"),
                            Category = new EtCategory
                            {
                                CategoryID = dr.GetInt32("categoryID"),
                                CategoryName = dr["categoryName"] is DBNull ? null : dr.GetString("categoryName"),
                                ParentCategoryID = dr["parentCategoryID"] is DBNull ? ECategory.未定义 : (ECategory)dr.GetInt16("parentCategoryID"),
                                ParentCategoryName = dr["parentCategoryName"] is DBNull ? null : dr.GetString("parentCategoryName"),
                                Unit = dr["unit"] is DBNull ? null : dr.GetString("unit"),
                                Color = dr["color"] is DBNull ? null : dr.GetString("color"),
                                Firm = dr["firm"] is DBNull ? null : dr.GetString("firm"),
                                MinStock = dr["minStock"] is DBNull ? 0 : dr.GetInt32("minStock"),
                                MaxStock = dr["maxStock"] is DBNull ? 0 : dr.GetInt32("maxStock"),
                                ExpirationDate = dr["expirationDate"] is DBNull ? 0 : dr.GetInt32("expirationDate"),
                                IsValid = dr["isValid"] is DBNull ? EValid.已删除 : (EValid)dr.GetInt16("isValid")
                            },
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
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return sales;
        }

    }
}
