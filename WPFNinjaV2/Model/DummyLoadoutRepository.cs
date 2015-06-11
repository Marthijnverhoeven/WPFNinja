using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    class DummyLoadoutRepository : ILoadout
    {
        public List<LoadoutItem> ToList()
        {
            var items = new List<LoadoutItem>();

            /*
            LoadoutItem item = new LoadoutItem();
            item.name = "Loadout one";
            item.head = new EquipmentItem { id = 3, type = EquipmentItem.HEAD, intelligence = -100, strength = 50, agility = 500, price = 200, name = "Helmet of the Monkey" };
            item.shoulders = new EquipmentItem { id = 8, type = EquipmentItem.SHOULDERS, intelligence = 800, strength = -200, agility = 0, price = 300, name = "Shoulders of ultimate intelligence" };
            item.chest = new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 100, strength = 100, agility = 100, price = 100, name = "Chestplate of minor all" };
            item.belt = new EquipmentItem { id = 15, type = EquipmentItem.BELT, intelligence = -100, strength = 500, agility = 50, price = 200, name = "Belt of major Strength" };
            item.legs = new EquipmentItem { id = 20, type = EquipmentItem.LEGS, intelligence = 800, strength = -200, agility = 0, price = 300, name = "Legs of major intelligence" };
            item.boots = new EquipmentItem { id = 24, type = EquipmentItem.BOOTS, intelligence = 0, strength = 2000, agility = -2000, price = 300, name = "Clumsy boots" };

            items.Add(item);
            */

            LoadoutItem item = new LoadoutItem();
            item.name = "Standard loadout";
            item.chest = new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 0, strength = 0, agility = 0, price = 0, name = "Vest" };
            items.Add(item);

            return items;
        }
    }
}
