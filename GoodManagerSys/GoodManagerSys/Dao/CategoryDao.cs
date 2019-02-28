using GoodManagerSys.Entities;
using GoodManagerSys.Enums;
using GoodManagerSys.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GoodManagerSys.Dao {
    class CategoryDao {
        public static List<EtCategory> QueryAll() {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM category";
            MySqlDataReader dr = helper.RunQuerySQL(sql);
            return GetListByDataReader(dr);
        }

        public static List<EtCategory> QueryByCategoryID(int categoryID) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM category WHERE categoryID = @categoryID";
            MySqlParameter[] prams = { new MySqlParameter("@categoryID", categoryID) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtCategory> QueryByCategoryName(string categoryName) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM category WHERE categoryName = @categoryName";
            MySqlParameter[] prams = { new MySqlParameter("@categoryName", categoryName) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtCategory> QueryByParentCategoryID(ECategory cate) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM category WHERE parentCategoryID = @parentCategoryID";
            MySqlParameter[] prams = { new MySqlParameter("@parentCategoryID", cate) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static List<EtCategory> QueryByIsValid(EValid eValid) {
            DBHelper helper = new DBHelper();
            string sql = "SELECT * FROM category WHERE isValid = @isValid;";
            MySqlParameter[] prams = { new MySqlParameter("@isValid", eValid) };
            MySqlDataReader dr = helper.RunQuerySQL(sql, prams);
            return GetListByDataReader(dr);
        }

        public static int InsertCategory(EtCategory category) {
            List<EtCategory> categories = QueryByCategoryID(category.CategoryID);
            if (categories.Count > 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "INSERT INTO " +
                "category(categoryName,parentCategoryID,parentCategoryName,unit,color,firm,minStock,maxStock,expirationDate,isValid) " +
                "VALUE(@categoryName,@parentCategoryID,@parentCategoryName,@unit,@color,@firm,@minStock,@maxStock,@expirationDate,@isValid)";
            MySqlParameter[] prams = {
                 new MySqlParameter("@categoryName",category.CategoryName??(object)DBNull.Value),
                 new MySqlParameter("@parentCategoryID",category.ParentCategoryID),
                 new MySqlParameter("@parentCategoryName",category.ParentCategoryName??(object)DBNull.Value),
                 new MySqlParameter("@unit",category.Unit??(object)DBNull.Value),
                 new MySqlParameter("@color",category.Color??(object)DBNull.Value),
                 new MySqlParameter("@firm",category.Firm??(object)DBNull.Value),
                 new MySqlParameter("@minStock",category.MinStock),
                 new MySqlParameter("@maxStock",category.MaxStock),
                 new MySqlParameter("@expirationDate",category.ExpirationDate),
                 new MySqlParameter("@isValid",category.IsValid)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }

        public static int DeleteByCategoryID(int categoryID) {
            List<EtCategory> categories = QueryByCategoryID(categoryID);
            //未查到
            if (categories.Count == 0) return -1;
            //之前已经删除了
            if (categories[0].IsValid == EValid.eDeleted) return -2;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE category SET isValid = @isValid WHERE categoryID = @categoryID;";
            MySqlParameter[] prams ={
                new MySqlParameter("@isValid",EValid.eDeleted),
                new MySqlParameter("@categoryID",categoryID),
            };
            return helper.RunNonQuerySQL(sql, prams);
        }

        public static int UpdateCategory(EtCategory category) {
            List<EtCategory> categories = QueryByCategoryID(category.CategoryID);
            if (categories.Count == 0) return -1;
            DBHelper helper = new DBHelper();
            string sql = "UPDATE category SET categoryName = @categoryName," +
                "parentCategoryID = @parentCategoryID," +
                "parentCategoryName = @parentCategoryName," +
                "unit = @unit, color = @color, firm = @firm," +
                "minStock = @minStock, maxStock = @maxStock, " +
                "expirationDate = @expirationDate, isValid = @isValid " +
                "WHERE categoryID = @categoryID;";
            MySqlParameter[] prams = {
                 new MySqlParameter("@categoryName",category.CategoryName??(object)DBNull.Value),
                 new MySqlParameter("@parentCategoryID",category.ParentCategoryID),
                 new MySqlParameter("@parentCategoryName",category.ParentCategoryName??(object)DBNull.Value),
                 new MySqlParameter("@unit",category.Unit??(object)DBNull.Value),
                 new MySqlParameter("@color",category.Color??(object)DBNull.Value),
                 new MySqlParameter("@firm",category.Firm??(object)DBNull.Value),
                 new MySqlParameter("@minStock",category.MinStock),
                 new MySqlParameter("@maxStock",category.MaxStock),
                 new MySqlParameter("@expirationDate",category.ExpirationDate),
                 new MySqlParameter("@isValid",category.IsValid),
                 new MySqlParameter("@categoryID",category.CategoryID)
            };
            return helper.RunNonQuerySQL(sql, prams);
        }

        private static List<EtCategory> GetListByDataReader(MySqlDataReader dr) {
            List<EtCategory> categories = new List<EtCategory>();
            while (dr.Read()) {
                EtCategory category = new EtCategory {
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
                };
                categories.Add(category);
            }
            return categories;
        }

    }
}
