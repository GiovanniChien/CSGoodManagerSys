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
    class PurchaseDao {
        public static List<EtPurchase> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase LEFT JOIN category ON purchase.categoryID = category.categoryID";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }
        public static List<EtPurchase> QueryByPurchaseID(int purchaseID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase LEFT JOIN category ON purchase.categoryID = category.categoryID WHERE purchaseID = @purchaseID";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseID", purchaseID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtPurchase> QueryByCategoryID(int categoryID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase LEFT JOIN category ON purchase.categoryID = category.categoryID WHERE purchase.categoryID = @categoryID";
            MySqlParameter[] prams = { new MySqlParameter("@categoryID", categoryID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtPurchase> QueryByPurchaseDate(string purchaseDate) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase LEFT JOIN category ON purchase.categoryID = category.categoryID WHERE purchaseDate = @purchaseDate";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseDate", purchaseDate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        public static List<EtPurchase> QueryByStaffID(int staffID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase LEFT JOIN category ON purchase.categoryID = category.categoryID WHERE staffID = @staffID";
            MySqlParameter[] prams = { new MySqlParameter("@staffID", staffID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }
        private static List<EtPurchase> QueryByPurchase(EtPurchase purchase)
        {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM purchase LEFT JOIN category ON purchase.categoryID = category.categoryID WHERE purchaseID = @purchaseID AND purchase.categoryID = @categoryID";
            MySqlParameter[] prams = { new MySqlParameter("@purchaseID", purchase.PurchaseID),new MySqlParameter("@categoryID",purchase.Category.CategoryID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static int InsertPurchase(EtPurchase purchase) {
            List<EtPurchase> purchases = QueryByPurchase(purchase);
            if (purchases.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "purchase(purchaseID,categoryID,purchaseDate,quantity,cost,staffID) " +
                "VALUE(@purchaseID,@categoryID,@purchaseDate,@quantity,@cost,@staffID)";
            MySqlParameter[] prams = {
                new MySqlParameter("@purchaseID",purchase.PurchaseID),
                new MySqlParameter("@categoryID",purchase.Category.CategoryID),
                new MySqlParameter("@purchaseDate",purchase.PurchaseDate??(object)DBNull.Value),
                new MySqlParameter("@quantity",purchase.Quantity),
                new MySqlParameter("@cost",purchase.Cost),
                new MySqlParameter("@staffID",purchase.StaffID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }
        private static List<EtPurchase> GetListByDataReader(MySqlDataReader dr) {
            List<EtPurchase> purchases = new List<EtPurchase>();
            try
            {
                while (dr.Read())
                {
                    EtPurchase purchase = new EtPurchase
                    {
                        PurchaseID = dr.GetInt32("purchaseID"),
                        Category=new EtCategory
                        {
                            CategoryID = dr.GetInt32("categoryID"),
                            CategoryName = dr["categoryName"] is DBNull ? null : dr.GetString("categoryName"),
                            ParentCategoryID = dr["parentCategoryID"] is DBNull ? ECategory.eUndefined : (ECategory)dr.GetInt16("parentCategoryID"),
                            ParentCategoryName = dr["parentCategoryName"] is DBNull ? null : dr.GetString("parentCategoryName"),
                            Unit = dr["unit"] is DBNull ? null : dr.GetString("unit"),
                            Color = dr["color"] is DBNull ? null : dr.GetString("color"),
                            Firm = dr["firm"] is DBNull ? null : dr.GetString("firm"),
                            MinStock = dr["minStock"] is DBNull ? 0 : dr.GetInt32("minStock"),
                            MaxStock = dr["maxStock"] is DBNull ? 0 : dr.GetInt32("maxStock"),
                            ExpirationDate = dr["expirationDate"] is DBNull ? 0 : dr.GetInt32("expirationDate"),
                            IsValid = dr["isValid"] is DBNull ? EValid.eDeleted : (EValid)dr.GetInt16("isValid")
                        },
                        PurchaseDate = dr["purchaseDate"] is DBNull ? null : dr.GetString("purchaseDate"),
                        Quantity = dr["quantity"] is DBNull ? 0 : dr.GetInt32("quantity"),
                        Cost = dr["cost"] is DBNull ? 0 : dr.GetInt32("cost"),
                        StaffID = dr.GetInt32("staffID")
                    };
                    purchases.Add(purchase);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return purchases;
        }
    }
}
