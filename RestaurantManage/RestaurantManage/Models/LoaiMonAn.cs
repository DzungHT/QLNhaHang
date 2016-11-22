using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManage.Models
{
    class LoaiMonAn : INotifyPropertyChanged
    {
        public LoaiMonAn() { }
        public LoaiMonAn(DataRow dr) { this.SetValues(dr); }
        int _LoaiMonAnID;
        string _TenLoaiMonAn;
        string _MoTa;
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
        public string TenLoaiMonAN
        {
            get
            {
                return _TenLoaiMonAn;
            }

            set
            {
                if (!value.Equals(_TenLoaiMonAn))
                {
                    _TenLoaiMonAn = value;
                    OnPropertyChanged("TenLoaiMonAN");
                }
            }
        }
        public string MoTa
        {
            get
            {
                return _MoTa;
            }

            set
            {
                if (!value.Equals(_MoTa))
                {
                    _MoTa = value;
                    OnPropertyChanged("MoTa");
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
                this._LoaiMonAnID = dr.Table.Columns.Contains("LoaiMonAnID") ? dr.Field<int>("LoaiMonAnID") : -1;
                this._TenLoaiMonAn = dr.Table.Columns.Contains("TenLoaiMonAn") ? dr.Field<string>("TenLoaiMonAn") : null;
                this._MoTa = dr.Table.Columns.Contains("MoTa") ? dr.Field<string>("MoTa") : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
