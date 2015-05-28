using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    public class DummyLoadoutRepository : ILoadout
    {
        public List<EquipmentItem> ToList()
        {
            var loadout = new List<EquipmentItem>();

            return loadout;
        }

    }
}
