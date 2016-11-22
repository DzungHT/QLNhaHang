using CybertronFramework.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantServices.Business
{
    public class LoaiMonAnDAO
    {
        private string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }
        public DataTable DS_LoaiMonAn(string searchtype,string searchcontent,bool isSearch)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_LoaiMonAn_Search";
            if (searchtype == null) searchtype = "-1";
            if (searchcontent == null) searchcontent = "";
            if (!isSearch || searchtype.Contains("Tất cả"))
            {
                searchtype = "-1";
                
            }
            else
            {
                switch (searchtype)
                {
                    case "Tên loại món ăn":
                        searchtype = "TenLoaiMonAn";
                        break;
                    case "Mô tả":
                        searchtype = "Mota";
                        break;
                } 
            }
            cmd.Parameters.Add(new SqlParameter("searchtype", searchtype));
            cmd.Parameters.Add(new SqlParameter("searchcontent", searchcontent));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >0)
            {
                dt.TableName = "DS_LoaiMonAn";
                return dt;
            }
            else
            {
                return null;
            }
        }
        public bool Insert(string ten,string mota)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_LoaiMonAn_Insert";
            cmd.Parameters.Add(new SqlParameter("tenloaimonan", ten));
            cmd.Parameters.Add(new SqlParameter("mota", mota));
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();            
        }
        public bool Update(int id,string ten, string mota)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_LoaiMonAn_Update";
            cmd.Parameters.Add(new SqlParameter("loaimonanid", id));
            cmd.Parameters.Add(new SqlParameter("tenloaimonan", ten));
            cmd.Parameters.Add(new SqlParameter("mota", mota));
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();
        }
        public bool Delete(int id)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_LoaiMonAn_Delete";
            cmd.Parameters.Add(new SqlParameter("loaimonanid", id));
            con.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();
        }
    }
}