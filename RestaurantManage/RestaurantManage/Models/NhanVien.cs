using System;
using System.Collections.Generic;
using System.ComponentModel;

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string PropertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
