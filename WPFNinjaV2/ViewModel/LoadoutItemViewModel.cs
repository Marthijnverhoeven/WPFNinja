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
            get 
            {
                int count = 0;

                if(_item.belt != null)
                {
                    count = count + belt.agility;
                }

                if(_item.boots != null)
                {
                    count = count + boots.agility;
                }

                if(_item.chest != null)
                {
                    count = count + chest.agility;
                }

                if(_item.head != null)
                {
                    count = count + head.agility;
                }

                if(_item.legs != null)
                {
                    count = count + legs.agility;
                }

                if(_item.shoulders != null)
                {
                    count = count + shoulders.agility;
                }

                return count;
            }
        }

        public int strength
        {
            get
            {
                int count = 0;

                if (_item.belt != null)
                {
                    count = count + belt.strength;
                }

                if (_item.boots != null)
                {
                    count = count + boots.strength;
                }

                if (_item.chest != null)
                {
                    count = count + chest.strength;
                }

                if (_item.head != null)
                {
                    count = count + head.strength;
                }

                if (_item.legs != null)
                {
                    count = count + legs.strength;
                }

                if (_item.shoulders != null)
                {
                    count = count + shoulders.strength;
                }

                return count;
            }
        }

        public int intelligence
        {
            get
            {
                int count = 0;

                if (_item.belt != null)
                {
                    count = count + belt.intelligence;
                }

                if (_item.boots != null)
                {
                    count = count + boots.intelligence;
                }

                if (_item.chest != null)
                {
                    count = count + chest.intelligence;
                }

                if (_item.head != null)
                {
                    count = count + head.intelligence;
                }

                if (_item.legs != null)
                {
                    count = count + legs.intelligence;
                }

                if (_item.shoulders != null)
                {
                    count = count + shoulders.intelligence;
                }

                return count;
            }
        }

        public int value
        {
            get
            {
                int count = 0;

                if (_item.belt != null)
                {
                    count = count + belt.price;
                }

                if (_item.boots != null)
                {
                    count = count + boots.price;
                }

                if (_item.chest != null)
                {
                    count = count + chest.price;
                }

                if (_item.head != null)
                {
                    count = count + head.price;
                }

                if (_item.legs != null)
                {
                    count = count + legs.price;
                }

                if (_item.shoulders != null)
                {
                    count = count + shoulders.price;
                }

                return count;
            }
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
