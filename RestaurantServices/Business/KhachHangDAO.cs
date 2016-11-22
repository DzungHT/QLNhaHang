using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantServices.Business
{
    public class KhachHangDAO
    {
        private static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }
        public static DataTable GetAllKhachHang()
        {
            string cmdText = "SELECT * FROM KhachHang";
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
        public static int Insert(string HoTen, string SDT, string DiaChi)
        {
            string cmdText = "INSERT INTO KhachHang VALUES("
                          + "N'" + HoTen + "', "
                          + "N'" + SDT + "', "
                          + "N'" + DiaChi + "' "
                         + ")";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public static int Update(int KhachHangID, string HoTen, string SDT, string DiaChi)
        {
            string cmdText = "UPDATE KhachHang SET "
                          + "HoTen = " + "N'" + HoTen + "', "
                          + "SDT = " + "N'" + SDT + "', "
                          + "DiaChi = " + "N'" + DiaChi + "' "
                          + "WHERE KhachHangID = " + KhachHangID;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public static int Delete(int KhachHangID)
        {
            string cmdText = "DELETE FROM KhachHang "
                         + "WHERE KhachHangID = " + KhachHangID;
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