using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManage.Models
{
    class SearchItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public SearchItem() { }
        string _SearchType;
        string _SearchContent;
        public string SearchType
        {
            get
            {
                return _SearchType;
            }

            set
            {
                if (!value.Equals(_SearchType))
                {
                    _SearchType = value;
                    OnPropertyChanged("SearchType");
                }
            }
        }
        public string SearchContent
        {
            get
            {
                return _SearchContent;
            }

            set
            {
                if (!value.Equals(_SearchContent))
                {
                    _SearchContent = value;
                    OnPropertyChanged("SearchContent");
                }
            }
        }
        protected virtual void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
