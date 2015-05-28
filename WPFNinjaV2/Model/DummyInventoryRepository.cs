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

            return inventory;
        }
    }
}
