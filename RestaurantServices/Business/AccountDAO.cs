using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CybertronFramework.Helper;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace RestaurantServices.Business
{
    public class AccountDAO
    {
        private static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }

        /// <summary>
        /// Trả về dữ liệu của nhân viên và account tương ứng
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        public DataTable Login(string username, string password)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_Account_Login";
            cmd.Parameters.Add(new SqlParameter("Username", username));
            cmd.Parameters.Add(new SqlParameter("Password", password.ToMD5()));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                dt.TableName = "Login";
                return dt;
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllAccount()
        {
            string cmdText = "SELECT * FROM Account";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(cmdText, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.TableName = "dt";
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }

        }
        public static int Insert(string username, string password, int NhanVienID)
        {
            string cmdText = "INSERT INTO Account VALUES("
                          + "N'" + username + "', "
                          + "'" + password.ToMD5() + "', "
                          + "" + NhanVienID + " "
                         + ")";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public static int ChangePassword(string username, string password, int NhanVienID)
        {
            return 0;
        }
        public static int Delete(string username)
        {
            string cmdText = "DELETE FROM Account "
             + "WHERE Username = " + username;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
    }
}