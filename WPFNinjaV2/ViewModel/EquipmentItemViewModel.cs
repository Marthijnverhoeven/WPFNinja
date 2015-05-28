using WPFNinjaV2.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFNinjaV2.ViewModel
{
    public class EquipmentItemViewModel : INotifyPropertyChanged
    {
        private EquipmentItem _item;
        public event PropertyChangedEventHandler PropertyChanged;

        public int type
        {
            get { return _item.type; }
            set { _item.type = value; OnPropertyChanged(); }
        }

        public int id
        {
            get { return _item.id; }
            set { _item.id = value; OnPropertyChanged(); }
        }

        public int intelligence
        {
            get { return _item.intelligence; }
            set { _item.intelligence = value; OnPropertyChanged(); }
        }

        public int strength
        {
            get { return _item.strength; }
            set { _item.strength = value; OnPropertyChanged(); }
        }

        public int agility
        {
            get { return _item.agility; }
            set { _item.agility = value; OnPropertyChanged(); }
        }

        public int price
        {
            get { return _item.price; }
            set { _item.price = value; OnPropertyChanged(); }
        }

        public string name
        {
            get { return "dummy"; } //_item.name; }
            set {  OnPropertyChanged(); }
        }


        public EquipmentItemViewModel()
        {
            this._item = new EquipmentItem();
        }

        public EquipmentItemViewModel(EquipmentItem item)
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
