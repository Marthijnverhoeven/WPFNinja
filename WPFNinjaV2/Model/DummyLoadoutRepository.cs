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

            LoadoutItem item = new LoadoutItem();
            item.name = "Tank";
            item.head = new EquipmentItem { id = 1, type = EquipmentItem.HEAD, intelligence = 100, strength = 100, agility = 100, price = 100 };
            item.shoulders = new EquipmentItem { id = 5, type = EquipmentItem.SHOULDERS, intelligence = 100, strength = 100, agility = 100, price = 100 };
            item.chest = new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 100, strength = 100, agility = 100, price = 100 };
            item.belt = new EquipmentItem { id = 13, type = EquipmentItem.BELT, intelligence = 100, strength = 100, agility = 100, price = 100 };
            item.legs = new EquipmentItem { id = 17, type = EquipmentItem.LEGS, intelligence = 100, strength = 100, agility = 100, price = 100 };
            item.boots = new EquipmentItem { id = 21, type = EquipmentItem.BOOTS, intelligence = 100, strength = 100, agility = 100, price = 100 };

            items.Add(item);

            return items;
        }
    }
}
