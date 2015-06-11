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

            items.Add(new EquipmentItem { id = 1, type = EquipmentItem.HEAD, intelligence = 100, strength = 100, agility = 100, price = 100, name="Helmet of minor all" });
            items.Add(new EquipmentItem { id = 2, type = EquipmentItem.HEAD, intelligence = 200, strength = 200, agility = 200, price = 200, name="Helmet of major all"});
            items.Add(new EquipmentItem { id = 3, type = EquipmentItem.HEAD, intelligence = -100, strength = 50, agility = 500, price = 200, name="Helmet of the Monkey"});
            items.Add(new EquipmentItem { id = 4, type = EquipmentItem.HEAD, intelligence = 800, strength = -200, agility = 0, price = 300, name="Helmet of the owl"});

            items.Add(new EquipmentItem { id = 5, type = EquipmentItem.SHOULDERS, intelligence = 100, strength = 100, agility = 100, price = 100, name = "Shoulders of minor all" });
            items.Add(new EquipmentItem { id = 6, type = EquipmentItem.SHOULDERS, intelligence = 200, strength = 200, agility = 200, price = 200, name = "Shoulders of major all" });
            items.Add(new EquipmentItem { id = 7, type = EquipmentItem.SHOULDERS, intelligence = -100, strength = 500, agility = 50, price = 200, name = "Shoulders of the Boar" });
            items.Add(new EquipmentItem { id = 8, type = EquipmentItem.SHOULDERS, intelligence = 800, strength = -200, agility = 0, price = 300, name = "Shoulders of ultimate intelligence" });

            items.Add(new EquipmentItem { id = 9, type = EquipmentItem.CHEST, intelligence = 100, strength = 100, agility = 100, price = 100, name = "Chestplate of minor all" });
            items.Add(new EquipmentItem { id = 10, type = EquipmentItem.CHEST, intelligence = 200, strength = 200, agility = 200, price = 200, name = "Chestplate of major all" });
            items.Add(new EquipmentItem { id = 11, type = EquipmentItem.CHEST, intelligence = -100, strength = 800, agility = 50, price = 200, name = "Chestplate of ultimate strength" });
            items.Add(new EquipmentItem { id = 12, type = EquipmentItem.CHEST, intelligence = -200, strength = 100, agility = 800, price = 300, name= "Chestplate of moving fast" });

            items.Add(new EquipmentItem { id = 13, type = EquipmentItem.BELT, intelligence = 100, strength = 100, agility = 100, price = 100, name = "Belt of minor all" });
            items.Add(new EquipmentItem { id = 14, type = EquipmentItem.BELT, intelligence = 200, strength = 200, agility = 200, price = 200, name = "Belt of minor all" });
            items.Add(new EquipmentItem { id = 15, type = EquipmentItem.BELT, intelligence = -100, strength = 500, agility = 50, price = 200, name = "Belt of major Strength" });
            items.Add(new EquipmentItem { id = 16, type = EquipmentItem.BELT, intelligence = 800, strength = -200, agility = 0, price = 300, name = "Belt of major intelligence" });

            items.Add(new EquipmentItem { id = 17, type = EquipmentItem.LEGS, intelligence = 100, strength = 100, agility = 100, price = 100, name = "Legs of minor all" });
            items.Add(new EquipmentItem { id = 18, type = EquipmentItem.LEGS, intelligence = 200, strength = 200, agility = 200, price = 200, name = "Legs of major all" });
            items.Add(new EquipmentItem { id = 19, type = EquipmentItem.LEGS, intelligence = -100, strength = 500, agility = 50, price = 200, name = "Legs of major agility" });
            items.Add(new EquipmentItem { id = 20, type = EquipmentItem.LEGS, intelligence = 800, strength = -200, agility = 0, price = 300, name = "Legs of major intelligence" });

            items.Add(new EquipmentItem { id = 21, type = EquipmentItem.BOOTS, intelligence = 100, strength = 100, agility = 100, price = 100, name = "Boots of minor all" });
            items.Add(new EquipmentItem { id = 22, type = EquipmentItem.BOOTS, intelligence = 200, strength = 200, agility = 200, price = 200, name = "Boots of major all" });
            items.Add(new EquipmentItem { id = 23, type = EquipmentItem.BOOTS, intelligence = -100, strength = 500, agility = 50, price = 200, name = "Boots of strength" });
            items.Add(new EquipmentItem { id = 24, type = EquipmentItem.BOOTS, intelligence = 0, strength = 2000, agility = -2000, price = 300, name = "Clumsy boots" });


            return items;
        }
    }
}
