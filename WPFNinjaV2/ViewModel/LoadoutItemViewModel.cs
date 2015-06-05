using WPFNinjaV2.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace WPFNinjaV2.ViewModel
{
    public class LoadoutItemViewModel : INotifyPropertyChanged
    {
        private LoadoutItem _item;
        public event PropertyChangedEventHandler PropertyChanged;

        public string name
        {
            get { return _item.name; }
            set { _item.name = value; OnPropertyChanged(); }
        }

        public EquipmentItem head
        {
            get { return _item.head; }
            set { _item.head = value; OnPropertyChanged(); }
        }

        public EquipmentItem shoulders
        {
            get { return _item.shoulders; }
            set { _item.head = value; OnPropertyChanged(); }
        }

        public EquipmentItem chest
        {
            get { return _item.chest; }
            set { _item.head = value; OnPropertyChanged(); }
        }

        public EquipmentItem belt
        {
            get { return _item.belt; }
            set { _item.head = value; OnPropertyChanged(); }
        }

        public EquipmentItem legs
        {
            get { return _item.legs; }
            set { _item.head = value; OnPropertyChanged(); }
        }

        public EquipmentItem boots
        {
            get { return _item.boots; }
            set { _item.head = value; OnPropertyChanged(); }
        }

        public LoadoutItemViewModel(LoadoutItem item)
        {
            this._item = item;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
