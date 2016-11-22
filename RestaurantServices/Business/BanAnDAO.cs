using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestaurantServices.Business
{
    public class BanAnDAO
    {
        private string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }
        public DataTable DS_BanAn(string searchtype, string searchcontent, bool isSearch)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_BanAn_Search";
            if (searchtype == null) searchtype = "-1";
            if (searchcontent == null) searchcontent = "";
            if (!isSearch || searchtype.Contains("Tất cả"))
            {
                searchtype ="-1";
            }
            else
            {
                switch (searchtype)
                {
                    case "Tên khu vực":
                        searchtype = "KhuVucID";
                        break;
                    case "Tên bàn":
                        searchtype = "TenBan";
                        break;
                    case "Trạng thái":
                        searchtype = "TrangThai";
                        break;
                    case "Số người":
                        searchtype = "SoNguoi";
                        break;
                }
            }
            cmd.Parameters.Add(new SqlParameter("searchtype", searchtype));
            cmd.Parameters.Add(new SqlParameter("searchcontent", searchcontent));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                dt.TableName = "DS_BanAn";
                return dt;
            }
            else
            {
                return null;
            }
        }
        public bool Insert(string ten, int khuvucid,int trangthai,int songuoi)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_BanAn_Insert";
            cmd.Parameters.Add(new SqlParameter("tenbanan", ten));
            cmd.Parameters.Add(new SqlParameter("khuvucid", khuvucid));
            cmd.Parameters.Add(new SqlParameter("trangthai", trangthai));
            cmd.Parameters.Add(new SqlParameter("songuoi", songuoi));
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
        public bool Update(int id,string ten, int khuvucid, int trangthai, int songuoi)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_BanAn_Update";
            cmd.Parameters.Add(new SqlParameter("bananid", id));
            cmd.Parameters.Add(new SqlParameter("tenbanan", ten));
            cmd.Parameters.Add(new SqlParameter("khuvucid", khuvucid));
            cmd.Parameters.Add(new SqlParameter("trangthai", trangthai));
            cmd.Parameters.Add(new SqlParameter("songuoi", songuoi));
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
            cmd.CommandText = "sp_BanAn_Delete";
            cmd.Parameters.Add(new SqlParameter("bananid", id));
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