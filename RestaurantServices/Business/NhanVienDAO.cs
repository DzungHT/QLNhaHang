﻿using System;
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
            SqlDataAdapter da = new SqlDataAdapter(cmdText,con);
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
        public static int Insert(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            string cmdText = "INSERT INTO NhanVien VALUES("
                          +"N'"+HoTen+"', "
                          +"N'" +SDT+"', "
                          +"N'" + DiaChi + "', "
                          +"'" + Email + "', "
                          + "'" + GioiTinh + "'"
                         + ")";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public static int Update(int NhanVienID, string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            string cmdText = "UPDATE NhanVien SET "
                          +"HoTen = " + "N'" + HoTen + "', "
                          +"SDT = " + "N'" + SDT + "', "
                          +"DiaChi = " + "N'" + DiaChi + "', "
                          +"Email = " + "'" + Email + "', "
                          +"GioiTinh = " + "'" + GioiTinh + "' "
                          +"WHERE NhanVienID = "+NhanVienID;
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.CommandType = CommandType.Text;
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public static int Delete(int NhanVienID)
        {
            string cmdText = "DELETE FROM NhanVien "
                         + "WHERE NhanVienID = " + NhanVienID;
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