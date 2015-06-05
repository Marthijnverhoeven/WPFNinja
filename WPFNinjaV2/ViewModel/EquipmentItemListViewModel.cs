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
        IInventory inventoryRepository;
<<<<<<< HEAD
        ILoadout loadoutRepository;
=======
>>>>>>> origin/JasperV2


        public ObservableCollection<EquipmentItemViewModel> items { get; set; }
        public ObservableCollection<InventoryItemViewModel> inventory { get; set; }
<<<<<<< HEAD
        public ObservableCollection<LoadoutItemViewModel> loadouts { get; set; }

        private EquipmentItemViewModel _selectedItem;
        private InventoryItemViewModel _selectedInventoryItem;
        private LoadoutItemViewModel _selectedLoadoutItem;
=======

        private EquipmentItemViewModel _selectedItem;
        private InventoryItemViewModel _selectedInventoryItem;
>>>>>>> origin/JasperV2

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

        public InventoryItemViewModel SelectedInventoryItem
        {
            get
            {
                return _selectedInventoryItem;
            }
            set
            {
                _selectedInventoryItem = value;
                RaisePropertyChanged();
            }
        }

<<<<<<< HEAD
        public LoadoutItemViewModel SelectedLoadoutItem
        {
            get
            {
                return _selectedLoadoutItem;
            }
            set
            {
                _selectedLoadoutItem = value;
                RaisePropertyChanged();
            }
        }

=======
>>>>>>> origin/JasperV2
        public ICommand AddEquipmentItemCommand { get; set; }

        public ICommand ComboValueChangedCommand { get; set; }

        public ICommand ClearItemCommand { get; set; }

        public ICommand RemoveEquipmentItemCommand { get; set; }

        public ICommand BuyItemCommand { get; set; }

<<<<<<< HEAD
        public ICommand SaveLoadoutCommand { get; set; }

        public ICommand AddToLoadoutCommand { get; set; }



=======
>>>>>>> origin/JasperV2
        public EquipmentItemListViewModel()
        {
            itemRepository = new DummyEquipmentItemRepository();
            inventoryRepository = new DummyInventoryRepository();
<<<<<<< HEAD
            loadoutRepository = new DummyLoadoutRepository();

            var itemList = itemRepository.ToList().Select(s => new EquipmentItemViewModel(s));
            var equipmentItemList = inventoryRepository.ToList().Select(s => new InventoryItemViewModel(s));
            var loadoutItemList = loadoutRepository.ToList().Select(s => new LoadoutItemViewModel(s));
=======

            var itemList = itemRepository.ToList().Select(s => new EquipmentItemViewModel(s));
            var equipmentItemList = inventoryRepository.ToList().Select(s => new InventoryItemViewModel(s));
>>>>>>> origin/JasperV2

            AddEquipmentItemCommand = new RelayCommand(AddEquipmentItem); // , CanAddNewItem
            ClearItemCommand = new RelayCommand(ClearItem);
            BuyItemCommand = new RelayCommand(BuyItem);
<<<<<<< HEAD
            SaveLoadoutCommand = new RelayCommand(SaveLoadout);
            AddToLoadoutCommand = new RelayCommand(AddToLoadout);
=======
>>>>>>> origin/JasperV2

            RemoveEquipmentItemCommand = new RelayCommand(DeleteEquipmentItem, CanDeleteItem);

            items = new ObservableCollection<EquipmentItemViewModel>(itemList);
            SelectedItem = items.First();

            inventory = new ObservableCollection<InventoryItemViewModel>(equipmentItemList);
            SelectedInventoryItem = inventory.First();
<<<<<<< HEAD

            loadouts = new ObservableCollection<LoadoutItemViewModel>(loadoutItemList);
            SelectedLoadoutItem = loadouts.First();
=======
>>>>>>> origin/JasperV2
        }

        private bool CanDeleteItem()
        {
            return SelectedItem != null;
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

        private void DeleteEquipmentItem()
        {
            items.Remove(SelectedItem);
            SelectedItem = new EquipmentItemViewModel();
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

        private void BuyItem()
        {
            if(SelectedItem != null)
            {
                if(true /* ENOUGH MONEY */)
                {
                    var iivm = new InventoryItemViewModel();

                    iivm.id = SelectedItem.id;
                    iivm.type = SelectedItem.type;
                    iivm.intelligence = SelectedItem.intelligence;
                    iivm.strength = SelectedItem.strength;
                    iivm.agility = SelectedItem.agility;
                    iivm.price = SelectedItem.price;
                    iivm.name = SelectedItem.name;

                    inventory.Add(iivm);
                }
            }
        }
<<<<<<< HEAD

        private void SaveLoadout()
        {
            if(SelectedLoadoutItem != null)
            {
                loadouts.Add(SelectedLoadoutItem);
            }
        }

        private void AddToLoadout()
        {
            if(this.SelectedInventoryItem != null)
            {
                if(this.SelectedInventoryItem.type == EquipmentItem.HEAD)
                {
                    var item = new EquipmentItem();

                    item.id = SelectedInventoryItem.id;
                    item.type = SelectedInventoryItem.type;
                    item.intelligence = SelectedInventoryItem.intelligence;
                    item.strength = SelectedInventoryItem.strength;
                    item.agility = SelectedInventoryItem.agility;
                    item.price = SelectedInventoryItem.price;
                    item.name = SelectedInventoryItem.name;

                    SelectedLoadoutItem.head = item;
                }
                else if (this.SelectedInventoryItem.type == EquipmentItem.SHOULDERS)
                {
                    var item = new EquipmentItem();

                    item.id = SelectedInventoryItem.id;
                    item.type = SelectedInventoryItem.type;
                    item.intelligence = SelectedInventoryItem.intelligence;
                    item.strength = SelectedInventoryItem.strength;
                    item.agility = SelectedInventoryItem.agility;
                    item.price = SelectedInventoryItem.price;
                    item.name = SelectedInventoryItem.name;

                    SelectedLoadoutItem.shoulders = item;
                }
                else if (this.SelectedInventoryItem.type == EquipmentItem.CHEST)
                {
                    var item = new EquipmentItem();

                    item.id = SelectedInventoryItem.id;
                    item.type = SelectedInventoryItem.type;
                    item.intelligence = SelectedInventoryItem.intelligence;
                    item.strength = SelectedInventoryItem.strength;
                    item.agility = SelectedInventoryItem.agility;
                    item.price = SelectedInventoryItem.price;
                    item.name = SelectedInventoryItem.name;

                    SelectedLoadoutItem.chest = item;
                }
                else if (this.SelectedInventoryItem.type == EquipmentItem.BELT)
                {
                    var item = new EquipmentItem();

                    item.id = SelectedInventoryItem.id;
                    item.type = SelectedInventoryItem.type;
                    item.intelligence = SelectedInventoryItem.intelligence;
                    item.strength = SelectedInventoryItem.strength;
                    item.agility = SelectedInventoryItem.agility;
                    item.price = SelectedInventoryItem.price;
                    item.name = SelectedInventoryItem.name;

                    SelectedLoadoutItem.belt = item;
                }
                else if (this.SelectedInventoryItem.type == EquipmentItem.LEGS)
                {
                    var item = new EquipmentItem();

                    item.id = SelectedInventoryItem.id;
                    item.type = SelectedInventoryItem.type;
                    item.intelligence = SelectedInventoryItem.intelligence;
                    item.strength = SelectedInventoryItem.strength;
                    item.agility = SelectedInventoryItem.agility;
                    item.price = SelectedInventoryItem.price;
                    item.name = SelectedInventoryItem.name;

                    SelectedLoadoutItem.legs = item;
                }
                else if (this.SelectedInventoryItem.type == EquipmentItem.BOOTS)
                {
                    var item = new EquipmentItem();

                    item.id = SelectedInventoryItem.id;
                    item.type = SelectedInventoryItem.type;
                    item.intelligence = SelectedInventoryItem.intelligence;
                    item.strength = SelectedInventoryItem.strength;
                    item.agility = SelectedInventoryItem.agility;
                    item.price = SelectedInventoryItem.price;
                    item.name = SelectedInventoryItem.name;

                    SelectedLoadoutItem.boots = item;
                }
            }
        }
=======
>>>>>>> origin/JasperV2
    }
}
