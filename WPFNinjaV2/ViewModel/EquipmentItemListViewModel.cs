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
        }

        private void AddEquipmentItem()
        {
            var eivm = new EquipmentItemViewModel();

            eivm.id = SelectedItem.id;
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
            if (SelectedItem == null)
                return false;

            if (SelectedItem.id <= 0)
                return false;

            if (String.IsNullOrEmpty(SelectedItem.name) || SelectedItem.type < 0 || SelectedItem.type > 5)
                return false;

            return true;
        }
    }
}
