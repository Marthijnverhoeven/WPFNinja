using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    class DummyEquipmentItemRepository : IEquipmentItemRepository
    {
        public List<EquipmentItem> ToList()
        {
            var items = new List<EquipmentItem>();

            items.Add(new EquipmentItem { id = 1, type = EquipmentItem.HEAD, intelligence = 100, strength = 100, agility = 100, price = 100 });
            items.Add(new EquipmentItem { id = 2, type = EquipmentItem.HEAD, intelligence = 200, strength = 200, agility = 200, price = 150 });
            items.Add(new EquipmentItem { id = 3, type = EquipmentItem.HEAD, intelligence = -100, strength = 500, agility = 50, price = 200 });
            items.Add(new EquipmentItem { id = 4, type = EquipmentItem.HEAD, intelligence = 800, strength = -200, agility = 0, price = 300 });

            items.Add(new EquipmentItem { id = 5, type = EquipmentItem.SHOULDERS, intelligence = 100, strength = 100, agility = 100, price = 100 });
            items.Add(new EquipmentItem { id = 6, type = EquipmentItem.SHOULDERS, intelligence = 200, strength = 200, agility = 200, price = 150 });
            items.Add(new EquipmentItem { id = 7, type = EquipmentItem.SHOULDERS, intelligence = -100, strength = 500, agility = 50, price = 200 });
            items.Add(new EquipmentItem { id = 8, type = EquipmentItem.SHOULDERS, intelligence = 800, strength = -200, agility = 0, price = 300 });

            items.Add(new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 100, strength = 100, agility = 100, price = 100 });
            items.Add(new EquipmentItem { id = 10, type = EquipmentItem.CHEST, intelligence = 200, strength = 200, agility = 200, price = 150 });
            items.Add(new EquipmentItem { id = 11, type = EquipmentItem.CHEST, intelligence = -100, strength = 500, agility = 50, price = 200 });
            items.Add(new EquipmentItem { id = 12, type = EquipmentItem.CHEST, intelligence = 800, strength = -200, agility = 0, price = 300 });

            items.Add(new EquipmentItem { id = 13, type = EquipmentItem.BELT, intelligence = 100, strength = 100, agility = 100, price = 100 });
            items.Add(new EquipmentItem { id = 14, type = EquipmentItem.BELT, intelligence = 200, strength = 200, agility = 200, price = 150 });
            items.Add(new EquipmentItem { id = 15, type = EquipmentItem.BELT, intelligence = -100, strength = 500, agility = 50, price = 200 });
            items.Add(new EquipmentItem { id = 16, type = EquipmentItem.BELT, intelligence = 800, strength = -200, agility = 0, price = 300 });

            items.Add(new EquipmentItem { id = 17, type = EquipmentItem.LEGS, intelligence = 100, strength = 100, agility = 100, price = 100 });
            items.Add(new EquipmentItem { id = 18, type = EquipmentItem.LEGS, intelligence = 200, strength = 200, agility = 200, price = 150 });
            items.Add(new EquipmentItem { id = 19, type = EquipmentItem.LEGS, intelligence = -100, strength = 500, agility = 50, price = 200 });
            items.Add(new EquipmentItem { id = 20, type = EquipmentItem.LEGS, intelligence = 800, strength = -200, agility = 0, price = 300 });

            items.Add(new EquipmentItem { id = 21, type = EquipmentItem.BOOTS, intelligence = 100, strength = 100, agility = 100, price = 100 });
            items.Add(new EquipmentItem { id = 22, type = EquipmentItem.BOOTS, intelligence = 200, strength = 200, agility = 200, price = 150 });
            items.Add(new EquipmentItem { id = 23, type = EquipmentItem.BOOTS, intelligence = -100, strength = 500, agility = 50, price = 200 });
            items.Add(new EquipmentItem { id = 24, type = EquipmentItem.BOOTS, intelligence = 800, strength = -200, agility = 0, price = 300 });


            return items;
        }
    }
}
