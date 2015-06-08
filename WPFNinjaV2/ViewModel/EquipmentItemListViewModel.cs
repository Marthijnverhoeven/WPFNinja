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
        ILoadout loadoutRepository;
        INinja ninjaRepository;


        public ObservableCollection<EquipmentItemViewModel> items { get; set; }
        public ObservableCollection<InventoryItemViewModel> inventory { get; set; }
        public ObservableCollection<LoadoutItemViewModel> loadouts { get; set; }
        public ObservableCollection<NinjaViewModel> ninja { get; set; }

        private EquipmentItemViewModel _selectedItem;
        private InventoryItemViewModel _selectedInventoryItem;
        private LoadoutItemViewModel _selectedLoadoutItem;
        private NinjaViewModel _selectedNinja;

        //public ObservableObject _selectedItem { get; set; }

        public NinjaViewModel SelectedNinja
        {
            get
            {
                return _selectedNinja;
            }
            set
            {
                _selectedNinja = value;
                RaisePropertyChanged();
            }
        }

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

        public ICommand AddEquipmentItemCommand { get; set; }

        public ICommand ComboValueChangedCommand { get; set; }

        public ICommand ClearItemCommand { get; set; }

        public ICommand RemoveEquipmentItemCommand { get; set; }

        public ICommand RemoveInventoryItemCommand { get; set; }

        public ICommand BuyItemCommand { get; set; }

        public ICommand SaveLoadoutCommand { get; set; }

        public ICommand AddToLoadoutCommand { get; set; }

        public ICommand ClearLoadoutCommand { get; set; }

        public ICommand DeleteLoadoutCommand { get; set; }

        public ICommand DeleteLoadoutHeadCommand { get; set; }

        public ICommand DeleteLoadoutBeltCommand { get; set; }

        public ICommand DeleteLoadoutChestCommand { get; set; }

        public ICommand DeleteLoadoutShouldersCommand { get; set; }

        public ICommand DeleteLoadoutLegsCommand { get; set; }

        public ICommand DeleteLoadoutBootsCommand { get; set; }



        public EquipmentItemListViewModel()
        {
            itemRepository = new DummyEquipmentItemRepository();
            inventoryRepository = new DummyInventoryRepository();
            loadoutRepository = new DummyLoadoutRepository();
            ninjaRepository = new DummyNinjaRepository();

            var itemList = itemRepository.ToList().Select(s => new EquipmentItemViewModel(s));
            var equipmentItemList = inventoryRepository.ToList().Select(s => new InventoryItemViewModel(s));
            var loadoutItemList = loadoutRepository.ToList().Select(s => new LoadoutItemViewModel(s));
            var ninjaList = ninjaRepository.ToList().Select(s => new NinjaViewModel(s));

            AddEquipmentItemCommand = new RelayCommand(AddEquipmentItem); // , CanAddNewItem
            ClearItemCommand = new RelayCommand(ClearItem);
            BuyItemCommand = new RelayCommand(BuyItem);
            SaveLoadoutCommand = new RelayCommand(SaveLoadout);
            AddToLoadoutCommand = new RelayCommand(AddToLoadout);
            RemoveInventoryItemCommand = new RelayCommand(RemoveFromInventory);
            ClearLoadoutCommand = new RelayCommand(ClearLoadout);
            DeleteLoadoutCommand = new RelayCommand(DeleteLoadout);

            DeleteLoadoutBeltCommand = new RelayCommand(DeleteLoadoutBelt);
            DeleteLoadoutChestCommand = new RelayCommand(DeleteLoadoutChest);
            DeleteLoadoutHeadCommand = new RelayCommand(DeleteLoadoutHead);
            DeleteLoadoutShouldersCommand = new RelayCommand(DeleteLoadoutShoulders);
            DeleteLoadoutLegsCommand = new RelayCommand(DeleteLoadoutLegs);
            DeleteLoadoutBootsCommand = new RelayCommand(DeleteLoadoutBoots);

            RemoveEquipmentItemCommand = new RelayCommand(DeleteEquipmentItem, CanDeleteItem);

            items = new ObservableCollection<EquipmentItemViewModel>(itemList);
            SelectedItem = items.First();

            inventory = new ObservableCollection<InventoryItemViewModel>(equipmentItemList);
            SelectedInventoryItem = inventory.First();

            loadouts = new ObservableCollection<LoadoutItemViewModel>(loadoutItemList);
            SelectedLoadoutItem = loadouts.First();

            ninja = new ObservableCollection<NinjaViewModel>(ninjaList);
            SelectedNinja = ninja.First();
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
            if(!items.Contains(SelectedItem))
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
                if(SelectedNinja.money >= SelectedItem.price)
                {
                    SelectedNinja.money = SelectedNinja.money - SelectedItem.price;

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

        private void RemoveFromInventory()
        {
            inventory.Remove(SelectedInventoryItem);
            SelectedInventoryItem = new InventoryItemViewModel();
        }

        private void SaveLoadout()
        {
            if(SelectedLoadoutItem != null)
            {
                if(!loadouts.Contains(SelectedLoadoutItem))
                {
                    loadouts.Add(SelectedLoadoutItem);
                }
            }
        }

        private void ClearLoadout()
        {
            SelectedLoadoutItem = new LoadoutItemViewModel(new LoadoutItem());
        }

        private void DeleteLoadout()
        {
            loadouts.Remove(SelectedLoadoutItem);
            SelectedLoadoutItem = new LoadoutItemViewModel(new LoadoutItem());
        }

        private void DeleteLoadoutHead()
        {
            SelectedLoadoutItem.head = null;
        }

        private void DeleteLoadoutBelt()
        {
            SelectedLoadoutItem.belt = null;
        }

        private void DeleteLoadoutChest()
        {
            SelectedLoadoutItem.chest = null;
        }

        private void DeleteLoadoutShoulders()
        {
            SelectedLoadoutItem.shoulders = null;
        }

        private void DeleteLoadoutLegs()
        {
            SelectedLoadoutItem.legs = null;
        }

        private void DeleteLoadoutBoots()
        {
            SelectedLoadoutItem.boots = null;
        }

        private void AddToLoadout()
        {
            if(this.SelectedInventoryItem != null)
            {
                if(this.SelectedInventoryItem.type == EquipmentItem.HEAD)
                {
                    var item = new EquipmentItem();

                    item.id = SelectedInventoryItem.id;
                    item.type = EquipmentItem.HEAD;
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
                    item.type = EquipmentItem.SHOULDERS;
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
                    item.type = EquipmentItem.CHEST;
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
                    item.type = EquipmentItem.BELT;
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
                    item.type = EquipmentItem.LEGS;
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
                    item.type = EquipmentItem.BOOTS;
                    item.intelligence = SelectedInventoryItem.intelligence;
                    item.strength = SelectedInventoryItem.strength;
                    item.agility = SelectedInventoryItem.agility;
                    item.price = SelectedInventoryItem.price;
                    item.name = SelectedInventoryItem.name;

                    SelectedLoadoutItem.boots = item;
                }
            }
        }
    }
}
