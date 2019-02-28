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
        public static List<EtGood> QueryAll()
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByGoodID(int goodID)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE goodID=@goodID";
            MySqlParameter[] prams = { new MySqlParameter("@goodID", goodID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByCategoryID(int categoryID)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE categoryID=@categoryID";
            MySqlParameter[] prams = { new MySqlParameter("@categoryID", categoryID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByPurchaseDate(string purchaseDate)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE purchaseDate=@purchaseDate";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseDate", purchaseDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtGood> QueryByIsValid(EValid isValid)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM good WHERE isValid=@isValid";
            MySqlParameter[] prams = { new MySqlParameter("@isValid", isValid) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        private static List<EtGood> GetListByDataReader(MySqlDataReader dr)
        {
            List<EtGood> goods = new List<EtGood>();
            while (dr.Read())
            {
                EtGood good = new EtGood
                {
                    GoodID = dr.GetInt32("goodID"),
                    CategoryID = dr.GetInt32("categoryID"),
                    ProductionDate = dr["productionDate"] is DBNull ? null : dr.GetString("productionDate"),
                    PurchaseDate = dr["purchaseDate"] is DBNull ? null : dr.GetString("purchaseDate"),
                    Cost = dr["cost"] is DBNull ? 0 : dr.GetDouble("cost"),
                    Price = dr["price"] is DBNull ? 0 : dr.GetDouble("price"),
                    IsValid =(EState)(dr["isValid"] is DBNull ? 0 : dr.GetInt32("isValid"))
                };
                goods.Add(good);
            }
            return goods;
        }
    }
}