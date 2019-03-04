using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodManagerSys.Utils {
    class DBHelper {

        //！！！！！！！
        /**
         * @database:数据库名
         * @user:用户名,一般root
         * @password:密码
         */
        private static string ConnStr = "server=localhost;port=3306;database=goodmanagesys;user=root;password=root;SslMode=none;";
        private MySqlConnection conn = null;

        public DBHelper() {
            conn = new MySqlConnection(ConnStr);
            conn.Open();
        }

        //无参查找
        public MySqlDataReader RunQuerySQL(string sql) {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = null;
            try {
                dr = cmd.ExecuteReader();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return dr;
        }

        //有参查找，详见demo.cs
        public MySqlDataReader RunQuerySQL(string sql, MySqlParameter[] prams) {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = null;
            try {
                foreach (MySqlParameter pram in prams) {
                    cmd.Parameters.Add(pram);
                }
                dr = cmd.ExecuteReader();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            return dr;
        }

        //无参增删改
        public int RunNonQuerySQL(string sql) {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int res = 0;
            MySqlTransaction transaction = conn.BeginTransaction();
            try {
                res = cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
                transaction.Rollback();
            }
            return res;
        }

        //有参增删改
        public int RunNonQuerySQL(string sql, MySqlParameter[] prams) {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int res = 0;
            MySqlTransaction transaction = conn.BeginTransaction();
            try {
                foreach (MySqlParameter pram in prams) {
                    cmd.Parameters.Add(pram);
                }
                res = cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
                transaction.Rollback();
            }
            return res;
        }

        ~DBHelper() {
            conn.Close();
        }

    }
}
