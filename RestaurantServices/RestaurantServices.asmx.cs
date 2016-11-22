using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using RestaurantServices.Business;
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
        #region HuyNQ
        [WebMethod]
        public DataTable GetAllNhanVien()
        {
            return NhanVienDAO.GetAllNhanVien();
        }
        [WebMethod]
        public void InsertNhanVien(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            NhanVienDAO.Insert(HoTen,SDT,DiaChi,Email,GioiTinh);
        }
        [WebMethod]
        public void UpdateNhanVien(int NhanVienID,string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh)
        {
            NhanVienDAO.Update(NhanVienID, HoTen, SDT, DiaChi, Email, GioiTinh);
        }
        [WebMethod]
        public void DeleteNhanVien(int NhanVienID)
        {
            NhanVienDAO.Delete(NhanVienID);
        }
        [WebMethod]
        public DataTable GetAllAccount()
        {
            return AccountDAO.GetAllAccount();
        }
        [WebMethod]
        public void InsertAccount(string username, string password, int NhanVienID)
        {
            AccountDAO.Insert(username,password,NhanVienID);
        }
        [WebMethod]
        public void ChangePassword(string username, string password, int NhanVienID)
        {
            AccountDAO.ChangePassword(username,password,NhanVienID);
        }
        [WebMethod]
        public void DeleteAccount(string username)
        {
            AccountDAO.Delete(username);
        }
        #endregion
        #region  DoanVD
        LoaiMonAnDAO _LoaiMonAnDAO = new LoaiMonAnDAO();
        MonAnDAO _MonAnDAO = new MonAnDAO();
        KhuVucDAO _KhuVucDAO = new KhuVucDAO();
        BanAnDAO _BanAnDAO = new BanAnDAO();
        // Lo?i món an
        [WebMethod]
        public DataTable DS_LoaiMonAN(String st, String sc, bool iss)
        {
            return _LoaiMonAnDAO.DS_LoaiMonAn(st, sc, iss);
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
        public DataTable Login(String username, String password)
        {
            AccountDAO acc = new AccountDAO();
            return acc.Login(username, password);
        }
        #endregion
    }
}
