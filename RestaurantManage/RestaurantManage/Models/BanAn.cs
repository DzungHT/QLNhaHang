using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManage.Models
{
    public class BanAn :INotifyPropertyChanged
    {
        int _BanAnID;
        string _TenBan;
        int _KhuVucID;
        int _TrangThaiID;
        string _TenTrangThai;
        string _TenKhuVuc;

        public int BanAnID
        {
            get
            {
                return _BanAnID;
            }

            set
            {
                if (!value.Equals(_BanAnID))
                {
                    _BanAnID = value;
                    OnPropertyChanged("BanAnID");
                }
            }
        }

        public string TenBan
        {
            get
            {
                return _TenBan;
            }

            set
            {
                if (!value.Equals(_TenBan))
                {
                    _TenBan = value;
                    OnPropertyChanged("TenBan");
                }
            }
        }

        public int KhuVucID
        {
            get
            {
                return _KhuVucID;
            }

            set
            {
                if (!value.Equals(_KhuVucID))
                {
                    _KhuVucID = value;
                    OnPropertyChanged("KhuVucID");
                }
            }
        }

        public int TrangThaiID
        {
            get
            {
                return _TrangThaiID;
            }

            set
            {
                if (!value.Equals(_TrangThaiID))
                {
                    _TrangThaiID = value;
                    OnPropertyChanged("TrangThaiID");
                }
            }
        }

        public string TenTrangThai
        {
            get
            {
                return _TenTrangThai;
            }

            set
            {
                if (!value.Equals(_TenTrangThai))
                {
                    _TenTrangThai = value;
                    OnPropertyChanged("TenTrangThai");
                }
            }
        }

        public string TenKhuVuc
        {
            get
            {
                return _TenKhuVuc;
            }

            set
            {
                if (!value.Equals(_TenKhuVuc))
                {
                    _TenKhuVuc = value;
                    OnPropertyChanged("TenKhuVuc");
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
                this._BanAnID = dr.Table.Columns.Contains("BanAnID") ? dr.Field<int>("BanAnID") : -1;
                this._KhuVucID = dr.Table.Columns.Contains("KhuVucID") ? dr.Field<int>("KhuVucID") : -1;
                this._TrangThaiID = dr.Table.Columns.Contains("TrangThaiID") ? dr.Field<int>("TrangThaiID") : -1;
                this._TenBan = dr.Table.Columns.Contains("TenBan") ? dr.Field<string>("TenBan") : null;
                this._TenKhuVuc = dr.Table.Columns.Contains("TenKhuVuc") ? dr.Field<string>("TenKhuVuc") : null;
                this._TenTrangThai = dr.Table.Columns.Contains("TenTrangThai") ? dr.Field<string>("TenTrangThai") : null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public BanAn() { }
        public BanAn(DataRow dr)
        {
            this.SetValues(dr);
        }
    }
}
