using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using RestaurantServices.Business;
using System.Configuration;
using System.Data.SqlClient;

namespace RestaurantServices
{
    /// <summary>
    /// Summary description for RestaurantServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RestaurantServices : System.Web.Services.WebService
    {
        private string ConnectionString { get { return ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString; } }
        #region HuyNQ
        [WebMethod]
        public DataTable Login(String username, String password)
        {
            AccountDAO acc = new AccountDAO();
            return acc.Login(username, password);
        }
        [WebMethod]
        public DataTable GetAllNhanVien()
        {
            return NhanVienDAO.GetAllNhanVien();
        }
        [WebMethod]
        public int InsertNhanVien(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            return NhanVienDAO.Insert(HoTen, SDT, DiaChi, Email, GioiTinh);
        }
        [WebMethod]
        public int UpdateNhanVien(int NhanVienID, string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            return NhanVienDAO.Update(NhanVienID, HoTen, SDT, DiaChi, Email, GioiTinh);
        }
        [WebMethod]
        public int DeleteNhanVien(int NhanVienID)
        {
            return NhanVienDAO.Delete(NhanVienID);
        }
        [WebMethod]
        public DataTable GetAllKhachHang()
        {
            return KhachHangDAO.GetAllKhachHang();
        }
        [WebMethod]
        public int InsertKhachHang(string HoTen, string SDT, string DiaChi)
        {
            return KhachHangDAO.Insert(HoTen, SDT, DiaChi);
        }
        [WebMethod]
        public int UpdateKhachHang(int KhachHangID, string HoTen, string SDT, string DiaChi)
        {
            return KhachHangDAO.Update(KhachHangID, HoTen, SDT, DiaChi);
        }
        [WebMethod]
        public int DeleteKhachHang(int KhachHangID)
        {
            return KhachHangDAO.Delete(KhachHangID);
        }
        [WebMethod]
        public DataTable GetAllAccount()
        {
            return AccountDAO.GetAllAccount();
        }
        [WebMethod]
        public int InsertAccount(string username, string password, int NhanVienID)
        {
            return AccountDAO.Insert(username, password, NhanVienID);
        }
        [WebMethod]
        public int ChangePassword(string username, string password, int NhanVienID)
        {
            return AccountDAO.ChangePassword(username, password, NhanVienID);
        }
        [WebMethod]
        public int DeleteAccount(string username)
        {
            return AccountDAO.Delete(username);
        }
        #endregion
        #region DoanVD
        LoaiMonAnDAO _LoaiMonAnDAO = new LoaiMonAnDAO();
        MonAnDAO _MonAnDAO = new MonAnDAO();
        KhuVucDAO _KhuVucDAO = new KhuVucDAO();
        BanAnDAO _BanAnDAO = new BanAnDAO();
        // Lọai món an
        [WebMethod]
        public DataTable DS_LoaiMonAN(String st, String sc, bool iss)
        {
            return _LoaiMonAnDAO.DS_LoaiMonAn(st, sc, iss);
        }
        [WebMethod]
        public DataTable LoaiMonAn_Chitiet(int loaimonanid)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "Select * from LoaiMonAn where LoaiMonAnID=" + loaimonanid.ToString();
            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "LoaiMonAn";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        [WebMethod]
        public bool LoaiMonAn_Insert(string ten, string mota)
        {
            return _LoaiMonAnDAO.Insert(ten, mota);
        }
        [WebMethod]
        public bool LoaiMonAn_Update(int id, string ten, string mota)
        {
            return _LoaiMonAnDAO.Update(id, ten, mota);
        }
        [WebMethod]
        public bool LoaiMonAn_Delete(int id)
        {
            return _LoaiMonAnDAO.Delete(id);
        }
        // Món an
        [WebMethod]
        public DataTable DS_MonAn(string searchtype, string searchcontent, bool isSearch)
        {
            return _MonAnDAO.DS_MonAn(searchtype, searchcontent, isSearch);
        }
        [WebMethod]
        public DataTable MonAn_Chitiet(int monanid)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "SELECT m.*, l.TenLoaiMonAn FROM MonAn m INNER JOIN LoaiMonAn l ON m.LoaiMonAnID = l.LoaiMonAnID where MonAnID=" + monanid.ToString();
            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "MonAn";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        [WebMethod]
        public bool MonAn_Insert(string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu)
        {
            return _MonAnDAO.Insert(ten, donvi, dongia, loaiid, soluongton, toithieu);
        }
        [WebMethod]
        public bool MonAn_Update(int id, string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu)
        {
            return _MonAnDAO.Update(id, ten, donvi, dongia, loaiid, soluongton, toithieu);
        }
        [WebMethod]
        public bool MonAn_Delete(int id)
        {
            return _MonAnDAO.Delete(id);
        }
        // Khu v?c
        [WebMethod]
        public DataTable DS_KhuVuc(string searchtype, string searchcontent, bool isSearch)
        {
            return _KhuVucDAO.DS_KhuVuc(searchtype, searchcontent, isSearch);
        }
        [WebMethod]
        public DataTable KhuVuc_Chitiet(int khuvucid)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "Select * from KhuVuc where KhuVucID=" + khuvucid.ToString();
            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "KhuVuc";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        [WebMethod]
        public bool KhuVuc_Insert(string ten, string mota)
        {
            return _KhuVucDAO.Insert(ten, mota);
        }
        [WebMethod]
        public bool KhuVuc_Update(int id, string ten, string mota)
        {
            return _KhuVucDAO.Update(id, ten, mota);
        }
        [WebMethod]
        public bool KhuVuc_Delete(int id)
        {
            return _KhuVucDAO.Delete(id);
        }
        // Bàn an
        [WebMethod]
        public DataTable DS_BanAn(string searchtype, string searchcontent, bool isSearch)
        {
            return _BanAnDAO.DS_BanAn(searchtype, searchcontent, isSearch);
        }
        [WebMethod]
        public DataTable BanAn_Chitiet(int bananid)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "SELECT b.*, k.TenKhuVuc FROM BanAn b INNER JOIN KhuVuc k ON b.KhuVucID = k.KhuVucID where BanAnID=" + bananid.ToString();
            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "BanAn";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        [WebMethod]
        public bool BanAn_Insert(string ten, int khuvucid, int trangthai, int songuoi)
        {
            return _BanAnDAO.Insert(ten, khuvucid, trangthai, songuoi);
        }
        [WebMethod]
        public bool BanAn_Update(int id, string ten, int khuvucid, int trangthai, int songuoi)
        {
            return _BanAnDAO.Update(id, ten, khuvucid, trangthai, songuoi);
        }
        [WebMethod]
        public bool BanAn_Delete(int id)
        {
            return _BanAnDAO.Delete(id);
        }
        #endregion
        #region DzungHT
        [WebMethod]
        public DataTable Lay_BanAn(int khuVucBanAnID, int trangThaiID)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = @"SELECT ba.*, kv.TenKhuVuc, tt.TenTrangThai FROM BanAn ba INNER JOIN KhuVuc kv ON kv.KhuVucID = ba.KhuVucID INNER JOIN TrangThaiBanAn tt ON tt.TrangThaiID = ba.TrangThaiID ";
            if (khuVucBanAnID != -1 && trangThaiID != -1)
            {
                sql += string.Format("WHERE ba.KhuVucID = {0} AND ba.TrangThaiID = {1}", khuVucBanAnID, trangThaiID);
            }
            else if (khuVucBanAnID != -1)
            {
                sql += string.Format("WHERE ba.KhuVucID = {0}", khuVucBanAnID);
            }
            else if (trangThaiID != -1)
            {
                sql += string.Format("WHERE ba.TrangThaiID = {0}", trangThaiID);
            }

            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "BanAn";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }

        }

        [WebMethod]
        public DataTable Lay_KhuVuc()
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "SELECT -1 AS KhuVucID, N'Tất cả' AS TenKhuVuc UNION ALL SELECT * FROM KhuVuc";

            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "KhuVuc";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        public DataTable Lay_TrangThaiBanAn()
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "SELECT -1 AS TrangThaiID, N'Tất cả' AS TenTrangThai UNION ALL SELECT * FROM TrangThaiBanAn";

            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "TrangThai";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        public DataTable Lay_LoaiMonAn()
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "SELECT -1 AS LoaiMonAnID, N'Tất cả' AS TenLoaiMonAn UNION ALL SELECT * FROM LoaiMonAn";

            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "LoaiMonAn";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        public DataTable Lay_MonAn(int LoaiMonAnID)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "SELECT m.MonanID, m.TenMonAn, m.DonViTinh, m.DonGia*1000 as DonGia,m.LoaiMonAnID, l.TenLoaiMonAn FROM MonAn m INNER JOIN LoaiMonAn l ON m.LoaiMonAnID = l.LoaiMonAnID";
            if (LoaiMonAnID != -1)
            {
                sql += " WHERE m.LoaiMonAnID = " + LoaiMonAnID.ToString();
            }
            cmd.CommandText = sql;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "MonAn";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        public DataSet Lay_DanhSachDatBan(int BanID)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string sql = "SELECT * FROM DatBan db WHERE db.BanAnID = {0} AND db.NgayDatBan = (SELECT MAX(db2.NgayDatBan) FROM DatBan db2 WHERE db2.BanAnID = {0}) SELECT ct.DatBanID, ct.MonAnID, ct.SoLuong, ma.TenMonAn, ma.DonGia FROM ChiTietDatBan ct INNER JOIN MonAn ma ON ma.MonanID = ct.MonAnID WHERE ct.DatBanID = (SELECT db.DatBanID FROM DatBan db WHERE db.BanAnID = {0} AND db.NgayDatBan = (SELECT MAX(db2.NgayDatBan) FROM DatBan db2 WHERE db2.BanAnID = {0}))";

            cmd.CommandText = string.Format(sql, BanID);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds);
                ds.Tables[0].TableName = "DatBan";
                ds.Tables[1].TableName = "ChiTietDatBan";
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        [WebMethod]
        public DataTable GoiMon(int BanAnID, int MonAnID, int SoLuong)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "sp_GoiMon";
            cmd.Parameters.Add(new SqlParameter("BanAnID", BanAnID));
            cmd.Parameters.Add(new SqlParameter("MonAnID", MonAnID));
            cmd.Parameters.Add(new SqlParameter("SoLuong", SoLuong));
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "KetQua";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        [WebMethod]
        public DataTable ThanhToan(int DatBanID, int NhanVienID, int? KhachHangID = null)
        {
            SqlConnection con = new SqlConnection(this.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "sp_ThanhToan";
            cmd.Parameters.Add(new SqlParameter("DatBanID", DatBanID));
            cmd.Parameters.Add(new SqlParameter("NhanVienID", NhanVienID));
            cmd.Parameters.Add(new SqlParameter("KhachHangID", KhachHangID));
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                dt.TableName = "KetQua";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
