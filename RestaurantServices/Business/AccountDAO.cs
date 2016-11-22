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
        private string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }

        /// <summary>
        /// Trả về dữ liệu của nhân viên và account tương ứng
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        public DataTable Login(string username, string password)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
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
            return new DataTable();
        }
        public static void Insert(string username, string password, int NhanVienID)
        {
            return;
        }
        public static void ChangePassword(string username, string password, int NhanVienID)
        {
            return;
        }
        public static void DeleteAccount(string username)
        {
            return;
        }
    }
}