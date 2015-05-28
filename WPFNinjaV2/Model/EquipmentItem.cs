using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    public class EquipmentItem
    {
        public static int HEAD = 0;
        public static int SHOULDERS = 1;
        public static int CHEST = 2;
        public static int BELT = 3;
        public static int LEGS = 4;
        public static int BOOTS = 5;

        public int id { get; set; }
        public int type { get; set; }
        public int intelligence { get; set; }
        public int strength { get; set; }
        public int agility { get; set; }
        public int price { get; set; }
        public string name { get; set; }
    }
}
