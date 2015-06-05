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

            inventory.Add(new EquipmentItem { id = 1, type = EquipmentItem.HEAD, intelligence = 100, strength = 100, agility = 100, price = 100 });
            inventory.Add(new EquipmentItem { id = 2, type = EquipmentItem.HEAD, intelligence = 200, strength = 200, agility = 200, price = 150 });
            inventory.Add(new EquipmentItem { id = 3, type = EquipmentItem.HEAD, intelligence = -100, strength = 500, agility = 50, price = 200 });
            inventory.Add(new EquipmentItem { id = 4, type = EquipmentItem.HEAD, intelligence = 800, strength = -200, agility = 0, price = 300 });

            return inventory;
        }
    }
}
