using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using GoodManagerSys.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Dao {
    class GoodDao {
        public static List<EtGood> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByGoodID(int goodID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE goodID = @goodID";
            MySqlParameter[] prams = { new MySqlParameter("@goodID", goodID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByCategoryID(int categoryID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE categoryID = @categoryID";
            MySqlParameter[] prams = { new MySqlParameter("@categoryID", categoryID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByPurchaseDate(string purchaseDate) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE purchaseDate = @purchaseDate";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseDate", purchaseDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByState(EState State) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE state = @State";
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
                new MySqlParameter("@categoryID",good.CategoryID),
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
            if (goods[0].State == EState.ePrePutaway) return -2;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE good SET state = @state WHERE goodID = @goodID;";
            MySqlParameter[] prams = {
                new MySqlParameter("@state",EState.ePrePutaway),
                new MySqlParameter("@goodID",goodID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        public static int UpdateGood(EtGood good)
        {
            List<EtGood> goods = QueryByGoodID(good.GoodID);
            if (goods.Count == 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE good SET categoryID = @CategoryID, " +
                "productionDate = @ProductionDate, purchaseDate = @PurchaseDate, cost = @Cost, " +
                "price = @price, state = @state WHERE goodID = @goodID";
            MySqlParameter[] prams = {
                new MySqlParameter("@categoryID",good.CategoryID),
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
            while (dr.Read()) {
                EtGood good = new EtGood {
                    GoodID = dr.GetInt32("goodID"),
                    CategoryID = dr.GetInt32("categoryID"),
                    ProductionDate = dr["productionDate"] is DBNull ? null : dr.GetString("productionDate"),
                    PurchaseDate = dr["purchaseDate"] is DBNull ? null : dr.GetString("purchaseDate"),
                    Cost = dr["cost"] is DBNull ? 0 : dr.GetDouble("cost"),
                    Price = dr["price"] is DBNull ? 0 : dr.GetDouble("price"),
                    State = (EState)(dr["state"] is DBNull ? 0 : dr.GetInt32("state"))
                };
                goods.Add(good);
            }
            return goods;
        }
    }
}