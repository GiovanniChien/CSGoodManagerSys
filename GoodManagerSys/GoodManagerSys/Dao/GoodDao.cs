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
        public static List<EtGood> QueryByIsState(EState isState) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE isState = @isState";
            MySqlParameter[] prams = { new MySqlParameter("@isState", isState) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static int InsertGood(EtGood good) {
            List<EtGood> goods = QueryByGoodID(good.GoodID);
            if (goods.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "good(categoryID,productionDate,purchaseDate,cost,price,isState) " +
                "VALUE(@categoryID,@productionDate,@purchaseDate,@cost,@price,@isState)";
            MySqlParameter[] prams = {
                new MySqlParameter("@categoryID",good.CategoryID),
                new MySqlParameter("@productionDate",good.ProductionDate),
                new MySqlParameter("@purchaseDate",good.PurchaseDate),
                new MySqlParameter("@cost",good.Cost),
                new MySqlParameter("@price",good.Price),
                new MySqlParameter("@isState",good.IsState)
            };
            return helper.RunNonQuerySQL(sql, prams); ;
        }
        public static int DeleteByGoodID(int goodID) {
            List<EtGood> goods = QueryByGoodID(goodID);
            if (goods.Count == 0) return -1;
            if (goods[0].IsState == EState.ePrePutaway) return -2;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE good SET isState = @isState WHERE goodID = @goodID;";
            MySqlParameter[] prams = {
                new MySqlParameter("@isState",EState.ePrePutaway),
                new MySqlParameter("@goodID",goodID)
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
                    IsState = (EState)(dr["isState"] is DBNull ? 0 : dr.GetInt32("isState"))
                };
                goods.Add(good);
            }
            return goods;
        }
    }
}