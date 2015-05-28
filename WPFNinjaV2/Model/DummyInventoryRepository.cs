using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    public class DummyInventoryRepository : IInventory
    {
        public List<Gear> ToList()
        {
            var loadout = new List<Gear>();

            return loadout;
        }
    }
}
