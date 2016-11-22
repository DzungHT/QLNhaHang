using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManage.Models
{
    class MonAn: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public MonAn() { }
        int _MonAnID;
        string _TenMonAn;
        string _DonViTinh;
        int _DonGia;
        int _LoaiMonAnID;
        int _SoLuongTon;
        int _TonToiThieu;
        public int MonAnID
        {
            get
            {
                return _MonAnID;
            }

            set
            {
                if (!value.Equals(_MonAnID))
                {
                    _MonAnID = value;
                    OnPropertyChanged("MonAnID");
                }
            }
        }
        public string TenMonAn
        {
            get
            {
                return _TenMonAn;
            }

            set
            {
                if (!value.Equals(_TenMonAn))
                {
                    _TenMonAn = value;
                    OnPropertyChanged("TenMonAn");
                }
            }
        }
        public string DonViTinh
        {
            get
            {
                return _DonViTinh;
            }

            set
            {
                if (!value.Equals(_DonViTinh))
                {
                    _DonViTinh = value;
                    OnPropertyChanged("DonViTinh");
                }
            }
        }
        public int DonGia
        {
            get
            {
                return _DonGia;
            }

            set
            {
                if (!value.Equals(_DonGia))
                {
                    _DonGia = value;
                    OnPropertyChanged("DonGia");
                }
            }
        }
        public int LoaiMonAnID
        {
            get
            {
                return _LoaiMonAnID;
            }

            set
            {
                if (!value.Equals(_LoaiMonAnID))
                {
                    _LoaiMonAnID = value;
                    OnPropertyChanged("LoaiMonAnID");
                }
            }
        }
        public int SoLuongTon
        {
            get
            {
                return _SoLuongTon;
            }

            set
            {
                if (!value.Equals(_SoLuongTon))
                {
                    _SoLuongTon = value;
                    OnPropertyChanged("SoLuongTon");
                }
            }
        }
        public int TonToiThieu
        {
            get
            {
                return _TonToiThieu;
            }

            set
            {
                if (!value.Equals(_TonToiThieu))
                {
                    _TonToiThieu = value;
                    OnPropertyChanged("TonToiThieu");
                }
            }
        }

        public void SetValues(DataRow dr)
        {
            try
            {
                this._MonAnID = dr["MonAnID"] != null ? (int)dr["MonAnID"] : 0;
                this._DonGia = dr["DonGia"] != null ? (int)dr["DonGia"] : 0;
                this._LoaiMonAnID = dr["LoaiMonAnID"] != null ? (int)dr["LoaiMonAnID"] : 0;
                this._SoLuongTon = dr["SoLuongTon"] != null ? (int)dr["SoLuongTon"] : 0;
                this._TonToiThieu = dr["TonToiThieu"] != null ? (int)dr["TonToiThieu"] : 0;
                this._TenMonAn = dr["TenMonAn"] != null ? dr["TenMonAn"].ToString() : null;
                this._DonViTinh = dr["DonViTinh"] != null ? dr["DonViTinh"].ToString() : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
