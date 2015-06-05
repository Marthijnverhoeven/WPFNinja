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

        public String name
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
            set { _item.shoulders = value; OnPropertyChanged(); }
        }

        public EquipmentItem chest
        {
            get { return _item.chest; }
            set { _item.chest = value; OnPropertyChanged(); }
        }

        public EquipmentItem belt
        {
            get { return _item.belt; }
            set { _item.belt = value; OnPropertyChanged(); }
        }

        public EquipmentItem legs
        {
            get { return _item.legs; }
            set { _item.legs = value; OnPropertyChanged(); }
        }

        public EquipmentItem boots
        {
            get { return _item.boots; }
            set { _item.boots = value; OnPropertyChanged(); }
        }

        public int agility
        {
            get { return _item.belt.agility + _item.boots.agility + _item.chest.agility + _item.head.agility + _item.legs.agility + _item.shoulders.agility; }
        }

        public int strength
        {
            get { return _item.belt.strength + _item.boots.strength + _item.chest.strength + _item.head.strength + _item.legs.strength + _item.shoulders.strength; }
        }

        public int intelligence
        {
            get { return _item.belt.intelligence + _item.boots.intelligence + _item.chest.intelligence + _item.head.intelligence + _item.legs.intelligence + _item.shoulders.intelligence; }
        }

        public int value
        {
            get { return _item.belt.price + _item.boots.price + _item.chest.price + _item.head.price + _item.legs.price + _item.shoulders.price; }
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
                PropertyChanged(this, new PropertyChangedEventArgs("agility"));
                PropertyChanged(this, new PropertyChangedEventArgs("strength"));
                PropertyChanged(this, new PropertyChangedEventArgs("intelligence"));
                PropertyChanged(this, new PropertyChangedEventArgs("value"));
                /*PropertyChanged(this, new PropertyChangedEventArgs("head"));
                PropertyChanged(this, new PropertyChangedEventArgs("chest"));
                PropertyChanged(this, new PropertyChangedEventArgs("shoulders"));
                PropertyChanged(this, new PropertyChangedEventArgs("belt"));
                PropertyChanged(this, new PropertyChangedEventArgs("legs"));
                PropertyChanged(this, new PropertyChangedEventArgs("boots"));*/
            }
        }
    }
}
