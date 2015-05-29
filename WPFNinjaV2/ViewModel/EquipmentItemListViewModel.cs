using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPFNinjaV2.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace WPFNinjaV2.ViewModel
{
    public class EquipmentItemListViewModel : ViewModelBase
    {
        IEquipmentItemRepository itemRepository;


        public ObservableCollection<EquipmentItemViewModel> items { get; set; }

        private EquipmentItemViewModel _selectedItem;

        //public ObservableObject _selectedItem { get; set; }

        public EquipmentItemViewModel SelectedItem
        {
            get 
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddEquipmentItemCommand { get; set; }

        public ICommand ComboValueChangedCommand { get; set; }

        public ICommand ClearItemCommand { get; set; }

        //public ICommand RemoveEquipmentItemCommand { get; set; }

        public EquipmentItemListViewModel()
        {
            itemRepository = new DummyEquipmentItemRepository();
            var itemList = itemRepository.ToList().Select(s => new EquipmentItemViewModel(s));

            AddEquipmentItemCommand = new RelayCommand(AddEquipmentItem, CanAddNewItem);
            ClearItemCommand = new RelayCommand(ClearItem);

            items = new ObservableCollection<EquipmentItemViewModel>(itemList);
            SelectedItem = items.First();
        }
        
        private void ClearItem()
        {
            this.SelectedItem = new EquipmentItemViewModel();
            
            int id = 0;

            foreach (EquipmentItemViewModel item in items)
            {
                if (item.id > id)
                {
                    id = item.id;
                }
            }

            this.SelectedItem.id = id;
            this.SelectedItem.type = EquipmentItem.HEAD;
        }

        private void AddEquipmentItem()
        {
            int id = 0;

            foreach (EquipmentItemViewModel item in items)
            {
                if (item.id > id)
                {
                    id = item.id;
                }
            }

            var eivm = new EquipmentItemViewModel();

            eivm.id = id + 1;
            eivm.type = SelectedItem.type;
            eivm.intelligence = SelectedItem.intelligence;
            eivm.strength = SelectedItem.strength;
            eivm.agility = SelectedItem.agility;
            eivm.price = SelectedItem.price;
            eivm.name = SelectedItem.name;

            items.Add(eivm);
        }

        private bool CanAddNewItem()
        {
            if(items.Contains(SelectedItem))
            {
                return false;
            }

            if (SelectedItem == null)
                return false;

            if (SelectedItem.id <= 0)
                return false;

            return true;
        }
    }
}
