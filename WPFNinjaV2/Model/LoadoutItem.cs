using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    public class LoadoutItem
    {
        public String name { get; set; }
        public EquipmentItem head { get; set; }
        public EquipmentItem shoulders { get; set; }
        public EquipmentItem chest { get; set; }
        public EquipmentItem belt { get; set; }
        public EquipmentItem legs { get; set; }
        public EquipmentItem boots { get; set; }
    }
}
