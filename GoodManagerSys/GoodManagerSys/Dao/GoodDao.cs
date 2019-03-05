using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GoodManagerSys.Dao {
    class GoodDao {
        public static List<EtGood> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good LEFT JOIN category " +
                "ON good.categoryID = category.categoryID";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByGoodID(int goodID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good LEFT JOIN category " +
                "ON good.categoryID = category.categoryID WHERE goodID = @goodID";
            MySqlParameter[] prams = { new MySqlParameter("@goodID", goodID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByCategoryID(int categoryID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good LEFT JOIN category " +
                "ON good.categoryID = category.categoryID " +
                "WHERE good.categoryID = @categoryID";
            MySqlParameter[] prams = { new MySqlParameter("@categoryID", categoryID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByPurchaseDate(string purchaseDate) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good LEFT JOIN category " +
                "ON good.categoryID = category.categoryID WHERE purchaseDate = @purchaseDate";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseDate", purchaseDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByState(EState State) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good LEFT JOIN category " +
                "ON good.categoryID = category.categoryID WHERE state = @State";
            MySqlParameter[] prams = { new MySqlParameter("@State", State) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static int InsertGood(EtGood good) {
            List<EtGood> goods = QueryByGoodID(good.GoodID);
            if (goods.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "good(categoryID,productionDate,purchaseDate,cost,price,state) " +
                "VALUE(@categoryID,@productionDate,@purchaseDate,@cost,@price,@state)";
            MySqlParameter[] prams = {
                new MySqlParameter("@categoryID",good.Category.CategoryID),
                new MySqlParameter("@productionDate",good.ProductionDate??(object)DBNull.Value),
                new MySqlParameter("@purchaseDate",good.PurchaseDate??(object)DBNull.Value),
                new MySqlParameter("@cost",good.Cost),
                new MySqlParameter("@price",good.Price),
                new MySqlParameter("@state",good.State)
            };
            return helper.RunNonQuerySQL(sql, prams); ;
        }
        public static int DeleteByGoodID(int goodID) {
            List<EtGood> goods = QueryByGoodID(goodID);
            if (goods.Count == 0) return -1;
            if (goods[0].State == EState.未上架) return -2;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE good SET state = @state WHERE goodID = @goodID;";
            MySqlParameter[] prams = {
                new MySqlParameter("@state",EState.未上架),
                new MySqlParameter("@goodID",goodID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        public static int UpdateGood(EtGood good) {
            List<EtGood> goods = QueryByGoodID(good.GoodID);
            if (goods.Count == 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE good SET categoryID = @CategoryID, " +
                "productionDate = @ProductionDate, purchaseDate = @PurchaseDate, cost = @Cost, " +
                "price = @price, state = @state WHERE goodID = @goodID";
            MySqlParameter[] prams = {
                new MySqlParameter("@categoryID",good.Category.CategoryID),
                new MySqlParameter("@productionDate",good.ProductionDate??(object)DBNull.Value),
                new MySqlParameter("@purchaseDate",good.PurchaseDate??(object)DBNull.Value),
                new MySqlParameter("@cost",good.Cost),
                new MySqlParameter("@price",good.Price),
                new MySqlParameter("@state",good.State),
                new MySqlParameter("@goodID",good.GoodID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        private static List<EtGood> GetListByDataReader(MySqlDataReader dr) {
            List<EtGood> goods = new List<EtGood>();
            try {
                while (dr.Read()) {
                    EtGood good = new EtGood {
                        GoodID = dr.GetInt32("goodID"),
                        Category = new EtCategory {
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
                    };
                    goods.Add(good);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return goods;
        }
    }
}