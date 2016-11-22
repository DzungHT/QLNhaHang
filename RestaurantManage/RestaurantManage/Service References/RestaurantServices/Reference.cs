﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManage.RestaurantServices {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RestaurantServices.RestaurantServicesSoap")]
    public interface RestaurantServicesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllNhanVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetAllNhanVien();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllNhanVien", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetAllNhanVienAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNhanVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void InsertNhanVien(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNhanVien", ReplyAction="*")]
        System.Threading.Tasks.Task InsertNhanVienAsync(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateNhanVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateNhanVien(int NhanVienID, string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateNhanVien", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateNhanVienAsync(int NhanVienID, string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteNhanVien", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteNhanVien(int NhanVienID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteNhanVien", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteNhanVienAsync(int NhanVienID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllAccount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetAllAccount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllAccount", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetAllAccountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertAccount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void InsertAccount(string username, string password, int NhanVienID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertAccount", ReplyAction="*")]
        System.Threading.Tasks.Task InsertAccountAsync(string username, string password, int NhanVienID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangePassword", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ChangePassword(string username, string password, int NhanVienID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChangePassword", ReplyAction="*")]
        System.Threading.Tasks.Task ChangePasswordAsync(string username, string password, int NhanVienID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteAccount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteAccount(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteAccount", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteAccountAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_LoaiMonAN", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DS_LoaiMonAN(string st, string sc, bool iss);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_LoaiMonAN", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DS_LoaiMonANAsync(string st, string sc, bool iss);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoaiMonAn_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool LoaiMonAn_Insert(string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoaiMonAn_Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> LoaiMonAn_InsertAsync(string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoaiMonAn_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool LoaiMonAn_Update(int id, string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoaiMonAn_Update", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> LoaiMonAn_UpdateAsync(int id, string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoaiMonAn_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool LoaiMonAn_Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoaiMonAn_Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> LoaiMonAn_DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_MonAn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DS_MonAn(string searchtype, string searchcontent, bool isSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_MonAn", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DS_MonAnAsync(string searchtype, string searchcontent, bool isSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonAn_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool MonAn_Insert(string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonAn_Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> MonAn_InsertAsync(string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonAn_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool MonAn_Update(int id, string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonAn_Update", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> MonAn_UpdateAsync(int id, string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonAn_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool MonAn_Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MonAn_Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> MonAn_DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_KhuVuc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DS_KhuVuc(string searchtype, string searchcontent, bool isSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_KhuVuc", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DS_KhuVucAsync(string searchtype, string searchcontent, bool isSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KhuVuc_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool KhuVuc_Insert(string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KhuVuc_Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> KhuVuc_InsertAsync(string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KhuVuc_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool KhuVuc_Update(int id, string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KhuVuc_Update", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> KhuVuc_UpdateAsync(int id, string ten, string mota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KhuVuc_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool KhuVuc_Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KhuVuc_Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> KhuVuc_DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_BanAn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable DS_BanAn(string searchtype, string searchcontent, bool isSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DS_BanAn", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> DS_BanAnAsync(string searchtype, string searchcontent, bool isSearch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BanAn_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool BanAn_Insert(string ten, int khuvucid, int trangthai, int songuoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BanAn_Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> BanAn_InsertAsync(string ten, int khuvucid, int trangthai, int songuoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BanAn_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool BanAn_Update(int id, string ten, int khuvucid, int trangthai, int songuoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BanAn_Update", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> BanAn_UpdateAsync(int id, string ten, int khuvucid, int trangthai, int songuoi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BanAn_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool BanAn_Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BanAn_Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> BanAn_DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_BanAn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Lay_BanAn(int khuVucBanAnID, int trangThaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_BanAn", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> Lay_BanAnAsync(int khuVucBanAnID, int trangThaiID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_KhuVuc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Lay_KhuVuc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_KhuVuc", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> Lay_KhuVucAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_TrangThaiBanAn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Lay_TrangThaiBanAn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_TrangThaiBanAn", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> Lay_TrangThaiBanAnAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_LoaiMonAn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Lay_LoaiMonAn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_LoaiMonAn", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> Lay_LoaiMonAnAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_MonAn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable Lay_MonAn(int LoaiMonAnID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Lay_MonAn", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> Lay_MonAnAsync(int LoaiMonAnID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RestaurantServicesSoapChannel : RestaurantManage.RestaurantServices.RestaurantServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RestaurantServicesSoapClient : System.ServiceModel.ClientBase<RestaurantManage.RestaurantServices.RestaurantServicesSoap>, RestaurantManage.RestaurantServices.RestaurantServicesSoap {
        
        public RestaurantServicesSoapClient() {
        }
        
        public RestaurantServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RestaurantServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestaurantServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public System.Data.DataTable GetAllNhanVien() {
            return base.Channel.GetAllNhanVien();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetAllNhanVienAsync() {
            return base.Channel.GetAllNhanVienAsync();
        }
        
        public void InsertNhanVien(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh) {
            base.Channel.InsertNhanVien(HoTen, SDT, DiaChi, Email, GioiTinh);
        }
        
        public System.Threading.Tasks.Task InsertNhanVienAsync(string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh) {
            return base.Channel.InsertNhanVienAsync(HoTen, SDT, DiaChi, Email, GioiTinh);
        }
        
        public void UpdateNhanVien(int NhanVienID, string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh) {
            base.Channel.UpdateNhanVien(NhanVienID, HoTen, SDT, DiaChi, Email, GioiTinh);
        }
        
        public System.Threading.Tasks.Task UpdateNhanVienAsync(int NhanVienID, string HoTen, string SDT, string DiaChi, string Email, bool GioiTinh) {
            return base.Channel.UpdateNhanVienAsync(NhanVienID, HoTen, SDT, DiaChi, Email, GioiTinh);
        }
        
        public void DeleteNhanVien(int NhanVienID) {
            base.Channel.DeleteNhanVien(NhanVienID);
        }
        
        public System.Threading.Tasks.Task DeleteNhanVienAsync(int NhanVienID) {
            return base.Channel.DeleteNhanVienAsync(NhanVienID);
        }
        
        public System.Data.DataTable GetAllAccount() {
            return base.Channel.GetAllAccount();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetAllAccountAsync() {
            return base.Channel.GetAllAccountAsync();
        }
        
        public void InsertAccount(string username, string password, int NhanVienID) {
            base.Channel.InsertAccount(username, password, NhanVienID);
        }
        
        public System.Threading.Tasks.Task InsertAccountAsync(string username, string password, int NhanVienID) {
            return base.Channel.InsertAccountAsync(username, password, NhanVienID);
        }
        
        public void ChangePassword(string username, string password, int NhanVienID) {
            base.Channel.ChangePassword(username, password, NhanVienID);
        }
        
        public System.Threading.Tasks.Task ChangePasswordAsync(string username, string password, int NhanVienID) {
            return base.Channel.ChangePasswordAsync(username, password, NhanVienID);
        }
        
        public void DeleteAccount(string username) {
            base.Channel.DeleteAccount(username);
        }
        
        public System.Threading.Tasks.Task DeleteAccountAsync(string username) {
            return base.Channel.DeleteAccountAsync(username);
        }
        
        public System.Data.DataTable DS_LoaiMonAN(string st, string sc, bool iss) {
            return base.Channel.DS_LoaiMonAN(st, sc, iss);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DS_LoaiMonANAsync(string st, string sc, bool iss) {
            return base.Channel.DS_LoaiMonANAsync(st, sc, iss);
        }
        
        public bool LoaiMonAn_Insert(string ten, string mota) {
            return base.Channel.LoaiMonAn_Insert(ten, mota);
        }
        
        public System.Threading.Tasks.Task<bool> LoaiMonAn_InsertAsync(string ten, string mota) {
            return base.Channel.LoaiMonAn_InsertAsync(ten, mota);
        }
        
        public bool LoaiMonAn_Update(int id, string ten, string mota) {
            return base.Channel.LoaiMonAn_Update(id, ten, mota);
        }
        
        public System.Threading.Tasks.Task<bool> LoaiMonAn_UpdateAsync(int id, string ten, string mota) {
            return base.Channel.LoaiMonAn_UpdateAsync(id, ten, mota);
        }
        
        public bool LoaiMonAn_Delete(int id) {
            return base.Channel.LoaiMonAn_Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> LoaiMonAn_DeleteAsync(int id) {
            return base.Channel.LoaiMonAn_DeleteAsync(id);
        }
        
        public System.Data.DataTable DS_MonAn(string searchtype, string searchcontent, bool isSearch) {
            return base.Channel.DS_MonAn(searchtype, searchcontent, isSearch);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DS_MonAnAsync(string searchtype, string searchcontent, bool isSearch) {
            return base.Channel.DS_MonAnAsync(searchtype, searchcontent, isSearch);
        }
        
        public bool MonAn_Insert(string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu) {
            return base.Channel.MonAn_Insert(ten, donvi, dongia, loaiid, soluongton, toithieu);
        }
        
        public System.Threading.Tasks.Task<bool> MonAn_InsertAsync(string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu) {
            return base.Channel.MonAn_InsertAsync(ten, donvi, dongia, loaiid, soluongton, toithieu);
        }
        
        public bool MonAn_Update(int id, string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu) {
            return base.Channel.MonAn_Update(id, ten, donvi, dongia, loaiid, soluongton, toithieu);
        }
        
        public System.Threading.Tasks.Task<bool> MonAn_UpdateAsync(int id, string ten, string donvi, int dongia, int loaiid, int soluongton, string toithieu) {
            return base.Channel.MonAn_UpdateAsync(id, ten, donvi, dongia, loaiid, soluongton, toithieu);
        }
        
        public bool MonAn_Delete(int id) {
            return base.Channel.MonAn_Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> MonAn_DeleteAsync(int id) {
            return base.Channel.MonAn_DeleteAsync(id);
        }
        
        public System.Data.DataTable DS_KhuVuc(string searchtype, string searchcontent, bool isSearch) {
            return base.Channel.DS_KhuVuc(searchtype, searchcontent, isSearch);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DS_KhuVucAsync(string searchtype, string searchcontent, bool isSearch) {
            return base.Channel.DS_KhuVucAsync(searchtype, searchcontent, isSearch);
        }
        
        public bool KhuVuc_Insert(string ten, string mota) {
            return base.Channel.KhuVuc_Insert(ten, mota);
        }
        
        public System.Threading.Tasks.Task<bool> KhuVuc_InsertAsync(string ten, string mota) {
            return base.Channel.KhuVuc_InsertAsync(ten, mota);
        }
        
        public bool KhuVuc_Update(int id, string ten, string mota) {
            return base.Channel.KhuVuc_Update(id, ten, mota);
        }
        
        public System.Threading.Tasks.Task<bool> KhuVuc_UpdateAsync(int id, string ten, string mota) {
            return base.Channel.KhuVuc_UpdateAsync(id, ten, mota);
        }
        
        public bool KhuVuc_Delete(int id) {
            return base.Channel.KhuVuc_Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> KhuVuc_DeleteAsync(int id) {
            return base.Channel.KhuVuc_DeleteAsync(id);
        }
        
        public System.Data.DataTable DS_BanAn(string searchtype, string searchcontent, bool isSearch) {
            return base.Channel.DS_BanAn(searchtype, searchcontent, isSearch);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> DS_BanAnAsync(string searchtype, string searchcontent, bool isSearch) {
            return base.Channel.DS_BanAnAsync(searchtype, searchcontent, isSearch);
        }
        
        public bool BanAn_Insert(string ten, int khuvucid, int trangthai, int songuoi) {
            return base.Channel.BanAn_Insert(ten, khuvucid, trangthai, songuoi);
        }
        
        public System.Threading.Tasks.Task<bool> BanAn_InsertAsync(string ten, int khuvucid, int trangthai, int songuoi) {
            return base.Channel.BanAn_InsertAsync(ten, khuvucid, trangthai, songuoi);
        }
        
        public bool BanAn_Update(int id, string ten, int khuvucid, int trangthai, int songuoi) {
            return base.Channel.BanAn_Update(id, ten, khuvucid, trangthai, songuoi);
        }
        
        public System.Threading.Tasks.Task<bool> BanAn_UpdateAsync(int id, string ten, int khuvucid, int trangthai, int songuoi) {
            return base.Channel.BanAn_UpdateAsync(id, ten, khuvucid, trangthai, songuoi);
        }
        
        public bool BanAn_Delete(int id) {
            return base.Channel.BanAn_Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> BanAn_DeleteAsync(int id) {
            return base.Channel.BanAn_DeleteAsync(id);
        }
        
        public System.Data.DataTable Lay_BanAn(int khuVucBanAnID, int trangThaiID) {
            return base.Channel.Lay_BanAn(khuVucBanAnID, trangThaiID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Lay_BanAnAsync(int khuVucBanAnID, int trangThaiID) {
            return base.Channel.Lay_BanAnAsync(khuVucBanAnID, trangThaiID);
        }
        
        public System.Data.DataTable Lay_KhuVuc() {
            return base.Channel.Lay_KhuVuc();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Lay_KhuVucAsync() {
            return base.Channel.Lay_KhuVucAsync();
        }
        
        public System.Data.DataTable Lay_TrangThaiBanAn() {
            return base.Channel.Lay_TrangThaiBanAn();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Lay_TrangThaiBanAnAsync() {
            return base.Channel.Lay_TrangThaiBanAnAsync();
        }
        
        public System.Data.DataTable Lay_LoaiMonAn() {
            return base.Channel.Lay_LoaiMonAn();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Lay_LoaiMonAnAsync() {
            return base.Channel.Lay_LoaiMonAnAsync();
        }
        
        public System.Data.DataTable Lay_MonAn(int LoaiMonAnID) {
            return base.Channel.Lay_MonAn(LoaiMonAnID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Lay_MonAnAsync(int LoaiMonAnID) {
            return base.Channel.Lay_MonAnAsync(LoaiMonAnID);
        }
    }
}
