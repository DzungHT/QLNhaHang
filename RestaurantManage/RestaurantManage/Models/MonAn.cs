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
        public MonAn(DataRow dr) { this.SetValues(dr); }
        int _MonAnID;
        string _TenMonAn;
        string _DonViTinh;
        int _DonGia;
        int _LoaiMonAnID;
        int _SoLuongTon;
        string _TonToiThieu;
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
        public string TonToiThieu
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
                this._MonAnID = dr.Table.Columns.Contains("MonAnID") ? dr.Field<int>("MonAnID") : -1;
                this._DonGia = dr.Table.Columns.Contains("DonGia") ? dr.Field<int>("DonGia") : -1;
                this._LoaiMonAnID = dr.Table.Columns.Contains("LoaiMonAnID") ? dr.Field<int>("LoaiMonAnID") : -1;
                this._SoLuongTon = dr.Table.Columns.Contains("SoLuongTon") ? dr.Field<int>("SoLuongTon") : -1;
                this._TonToiThieu = dr.Table.Columns.Contains("TonToiThieu") ? dr.Field<string>("TonToiThieu") : null;
                this._TenMonAn = dr.Table.Columns.Contains("TenMonAn") ? dr.Field<string>("TenMonAn") : null;
                this._DonViTinh = dr.Table.Columns.Contains("DonViTinh") ? dr.Field<string>("DonViTinh") : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
