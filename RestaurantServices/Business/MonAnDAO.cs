using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantServices.Business
{
    public class MonAnDAO
    {
        private string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }
        public DataTable DS_MonAn(string searchtype, string searchcontent, bool isSearch)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_MonAn_Search";
            if (!isSearch || searchtype.Contains("Tất cả"))
            {
                searchtype = searchcontent = "";
            }
            else
            {
                switch (searchtype)
                {
                    case "Tên món ăn":
                        searchtype = "TenMonAn";
                        break;
                    case "Loại món ăn":
                        searchtype = "LoaiMonAnID";
                        break;
                }
            }
            cmd.Parameters.Add(new SqlParameter("searchtype", searchtype));
            cmd.Parameters.Add(new SqlParameter("searchcontent", searchcontent));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                dt.TableName = "DS_MonAn";
                return dt;
            }
            else
            {
                return null;
            }
        }
        public bool Insert(string ten,string donvi,int dongia,int loaiid,int soluongton,string toithieu)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_MonAn_Insert";
            cmd.Parameters.Add(new SqlParameter("tenmonan", ten));
            cmd.Parameters.Add(new SqlParameter("donvitinh", donvi));
            cmd.Parameters.Add(new SqlParameter("dongia", dongia));
            cmd.Parameters.Add(new SqlParameter("loaimonanid", loaiid));
            cmd.Parameters.Add(new SqlParameter("soluongton", soluongton));
            cmd.Parameters.Add(new SqlParameter("tontoithieu", toithieu));
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(int id,string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_MonAn_Insert";
            cmd.Parameters.Add(new SqlParameter("monanid", id));
            cmd.Parameters.Add(new SqlParameter("tenmonan", ten));
            cmd.Parameters.Add(new SqlParameter("donvitinh", donvi));
            cmd.Parameters.Add(new SqlParameter("dongia", dongia));
            cmd.Parameters.Add(new SqlParameter("loaimonanid", loaiid));
            cmd.Parameters.Add(new SqlParameter("soluongton", soluongton));
            cmd.Parameters.Add(new SqlParameter("tontoithieu", toithieu));
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_MonAn_Delete";
            cmd.Parameters.Add(new SqlParameter("monanid", id));
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}