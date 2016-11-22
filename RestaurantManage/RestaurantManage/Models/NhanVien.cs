using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace RestaurantManage.Models
{

    public class NhanVien : INotifyPropertyChanged
    {
        public NhanVien()
        {
        }
        int _NhanVienID;
        string _HoTen;
        string _SDT;
        string _DiaChi;
        string _Email;
        bool _GioiTinh;

        public int NhanVienID
        {
            get
            {
                return _NhanVienID;
            }

            set
            {
                if (!value.Equals(_NhanVienID))
                {
                    _NhanVienID = value;
                    OnPropertyChanged("NhanVienID");
                }
            }
        }

        public string HoTen
        {
            get
            {
                return _HoTen;
            }

            set
            {
                if (!value.Equals(_HoTen))
                {
                    _HoTen = value;
                    OnPropertyChanged("HoTen");
                }
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                if (!value.Equals(_SDT))
                {
                    _SDT = value;
                    OnPropertyChanged("SDT");
                }
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                if (!value.Equals(_DiaChi))
                {
                    _DiaChi = value;
                    OnPropertyChanged("DiaChi");
                }
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                if (!value.Equals(_Email))
                {
                    _Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public bool GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                if (!value.Equals(_GioiTinh))
                {
                    _GioiTinh = value;
                    OnPropertyChanged("GioiTinh");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }



        public void SetValues(DataRow dr)
        {
            try
            {
                this._NhanVienID = dr["NhanVienID"] != null ? (int)dr["NhanVienID"] : 0;
                this._HoTen = dr["NhanVienID"] != null ? dr["NhanVienID"].ToString() : null;
                this._SDT = dr["SDT"] != null ? dr["SDT"].ToString() : null;
                this._DiaChi = dr["DiaChi"] != null ? dr["DiaChi"].ToString() : null;
                this._Email = dr["Email"] != null ? dr["Email"].ToString() : null;
                this._GioiTinh = dr["GioiTinh"] != null ? (bool)dr["GioiTinh"] : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
