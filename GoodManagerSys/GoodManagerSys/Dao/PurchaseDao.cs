using GoodManagerSys.Entities;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Dao {
    class PurchaseDao {
        public static List<EtPurchase> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }

        public static List<EtPurchase> QueryByPurchaseID(int purchaseID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase WHERE purchaseID = @purchaseID";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseID", purchaseID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtPurchase> QueryByCategoryID(int categoryID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase WHERE categoryID = @categoryID";
            MySqlParameter[] prams = { new MySqlParameter("@categoryID", categoryID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtPurchase> QueryByPurchaseDate(string purchaseDate) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase WHERE purchaseDate = @purchaseDate";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseDate", purchaseDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtPurchase> QueryByStaffID(int staffID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase WHERE staffID = @staffID";
            MySqlParameter[] prams = { new MySqlParameter("@staffID", staffID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static int InsertPurchase(EtPurchase purchase) {
            List<EtPurchase> purchases = QueryByPurchaseID(purchase.PurchaseID);
            if (purchases.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "purchase(categoryID,purchaseDate,quantity,cost,staffID) " +
                "VALUE(@categoryID,@purchaseDate,@quantity,@cost,@staffID)";
            MySqlParameter[] prams = {
                new MySqlParameter("@categoryID",purchase.CategoryID),
                new MySqlParameter("@purchaseDate",purchase.PurchaseDate??(object)DBNull.Value),
                new MySqlParameter("@quantity",purchase.Quantity),
                new MySqlParameter("@cost",purchase.Cost),
                new MySqlParameter("@staffID",purchase.StaffID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        private static List<EtPurchase> GetListByDataReader(MySqlDataReader dr) {
            List<EtPurchase> purchases = new List<EtPurchase>();
            while (dr.Read()) {
                EtPurchase purchase = new EtPurchase {
                    PurchaseID = dr.GetInt32("purchaseID"),
                    CategoryID = dr.GetInt32("categoryID"),
                    PurchaseDate = dr["purchaseDate"] is DBNull ? null : dr.GetString("purchaseDate"),
                    Quantity = dr["quantity"] is DBNull ? 0 : dr.GetInt32("quantity"),
                    Cost = dr["cost"] is DBNull ? 0 : dr.GetInt32("cost"),
                    StaffID = dr.GetInt32("staffID")
                };
                purchases.Add(purchase);
            }
            return purchases;
        }
    }
}
