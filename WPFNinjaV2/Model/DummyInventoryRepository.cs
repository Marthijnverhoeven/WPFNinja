using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    class DummyInventoryRepository : IInventory
    {
        public List<EquipmentItem> ToList()
        {
            var inventory = new List<EquipmentItem>();

            /*
            inventory.Add(new EquipmentItem { id = 3, type = EquipmentItem.HEAD, intelligence = -100, strength = 50, agility = 500, price = 200, name = "Helmet of the Monkey" });
            inventory.Add(new EquipmentItem { id = 8, type = EquipmentItem.SHOULDERS, intelligence = 800, strength = -200, agility = 0, price = 300, name = "Shoulders of ultimate intelligence" });
            inventory.Add(new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 100, strength = 100, agility = 100, price = 100, name = "Chestplate of minor all" });
            inventory.Add(new EquipmentItem { id = 15, type = EquipmentItem.BELT, intelligence = -100, strength = 500, agility = 50, price = 200, name = "Belt of major Strength" });
            inventory.Add(new EquipmentItem { id = 20, type = EquipmentItem.LEGS, intelligence = 800, strength = -200, agility = 0, price = 300, name = "Legs of major intelligence" });
            inventory.Add(new EquipmentItem { id = 24, type = EquipmentItem.BOOTS, intelligence = 0, strength = 2000, agility = -2000, price = 300, name = "Clumsy boots" });
            */

            inventory.Add(new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 0, strength = 0, agility = 0, price = 0, name = "Vest" });

            return inventory;
        }
    }
}
