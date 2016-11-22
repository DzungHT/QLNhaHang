using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantServices.Business
{
    public class KhuVucDAO
    {
        private string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }
        public DataTable DS_KhuVuc(string searchtype, string searchcontent, bool isSearch)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_KhuVuc_Search";
            if (!isSearch || searchtype.Contains("Tất cả"))
            {
                searchtype = searchcontent = "";
            }
            else
            {
                switch (searchtype)
                {
                    case "Tên khu vực":
                        searchtype = "TenKhuVuc";
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
            if (dt.Rows.Count == 1)
            {
                dt.TableName = "DS_KhuVuc";
                return dt;
            }
            else
            {
                return null;
            }
        }
        public bool Insert(string ten, string mota)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_KhuVuc_Insert";
            cmd.Parameters.Add(new SqlParameter("tenkhuvuc", ten));
            cmd.Parameters.Add(new SqlParameter("mota", mota));
            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(int id, string ten, string mota)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_KhuVuc_Update";
            cmd.Parameters.Add(new SqlParameter("khuvucid", id));
            cmd.Parameters.Add(new SqlParameter("tenkhuvuc", ten));
            cmd.Parameters.Add(new SqlParameter("mota", mota));
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
            cmd.CommandText = "sp_KhuVuc_Delete";
            cmd.Parameters.Add(new SqlParameter("khuvucid", id));
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