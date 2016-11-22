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
        private string ConnectionString { get { return ConfigurationManager.ConnectionStrings[0].ConnectionString; } }

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
            cmd.CommandText = string.Format("", username, password.ToMD5());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
    }
}