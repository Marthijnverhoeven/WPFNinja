using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    public class DummyCurrentLoadoutRepository : ICurrentLoadout
    {
        public List<EquipmentItem> ToList()
        {
            var items = new List<EquipmentItem>();
            items.Add(new EquipmentItem { id = 1, type = EquipmentItem.HEAD, intelligence = 100, strength = 100, agility = 100, price = 100 });

            return items;
        }
    }
}
