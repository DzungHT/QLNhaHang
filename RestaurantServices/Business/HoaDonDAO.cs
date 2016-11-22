using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantServices.Business
{
    public class HoaDonDAO
    {
        private static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }

        public static DataTable GetAllHoaDon()
        {
            string cmdText = "SELECT * FROM HoaDon";
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
        public static DataTable GetChiTietHoaDon(int HoaDonID)
        {
            string cmdText = "SELECT * FROM ChiTietHoaDon where HoaDonID = "+HoaDonID;
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
    }
}