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
        bool? _GioiTinh;

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

        public bool? GioiTinh
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
                this._NhanVienID = dr.Table.Columns.Contains("NhanVienID") ? dr.Field<int>("NhanVienID") : -1;
                this._HoTen = dr.Table.Columns.Contains("HoTen")? dr.Field<string>("HoTen"): null;
                this._SDT = dr.Table.Columns.Contains("SDT") ? dr.Field<string>("SDT") : null;
                this._DiaChi = dr.Table.Columns.Contains("DiaChi") ? dr.Field<string>("DiaChi") : null;
                this._Email = dr.Table.Columns.Contains("Email") ? dr.Field<string>("Email") : null;
                this._GioiTinh = dr.Table.Columns.Contains("GioiTinh") ? dr.Field<bool?>("GioiTinh") : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
