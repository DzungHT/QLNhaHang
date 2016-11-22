using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantServices.Business
{
    public class NhanVienDAO
    {
        private static string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }
        
        public static DataTable GetAllNhanVien()
        {
            string cmdText = "SELECT * FROM NhanVien";
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.TableName = "dt";
            if(dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }

        }
        public static void Insert(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            return;
        }
        public static void Update(int NhanVienID, string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            return;
        }
        public static void Delete(int NhanVienID)
        {
            return;
        }
        
    }
}