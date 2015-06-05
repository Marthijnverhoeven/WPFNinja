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
            item.head = new EquipmentItem { id = 1, type = EquipmentItem.HEAD, intelligence = 100, strength = 100, agility = 100, price = 100, name = "h1" };
            item.shoulders = new EquipmentItem { id = 5, type = EquipmentItem.SHOULDERS, intelligence = 100, strength = 100, agility = 100, price = 100, name = "s1" };
            item.chest = new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 100, strength = 100, agility = 100, price = 100, name = "c1" };
            item.belt = new EquipmentItem { id = 13, type = EquipmentItem.BELT, intelligence = 100, strength = 100, agility = 100, price = 100, name = "b1" };
            item.legs = new EquipmentItem { id = 17, type = EquipmentItem.LEGS, intelligence = 100, strength = 100, agility = 100, price = 100, name = "l1" };
            item.boots = new EquipmentItem { id = 21, type = EquipmentItem.BOOTS, intelligence = 100, strength = 100, agility = 100, price = 100, name = "bo1" };

            items.Add(item);

            LoadoutItem item2 = new LoadoutItem();
            item2.name = "mage neger";
            item2.head = new EquipmentItem { id = 1, type = EquipmentItem.HEAD, intelligence = 102055160, strength = 100, agility = 100, price = 100, name = "h1" };
            item2.shoulders = new EquipmentItem { id = 5, type = EquipmentItem.SHOULDERS, intelligence = 1075370, strength = 100, agility = 100, price = 100, name = "s1" };
            item2.chest = new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 13500, strength = 100, agility = 100, price = 100, name = "c1" };
            item2.belt = new EquipmentItem { id = 13, type = EquipmentItem.BELT, intelligence = 17530, strength = 100, agility = 100, price = 100, name = "b1" };
            item2.legs = new EquipmentItem { id = 17, type = EquipmentItem.LEGS, intelligence = 17537500, strength = 100, agility = 100, price = 100, name = "l1" };
            item2.boots = new EquipmentItem { id = 21, type = EquipmentItem.BOOTS, intelligence = 1375300, strength = 100, agility = 100, price = 100, name = "bo1" };

            items.Add(item2);

            return items;
        }
    }
}
