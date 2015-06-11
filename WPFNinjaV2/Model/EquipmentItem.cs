using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    public class EquipmentItem
    {
        public static String HEAD = "Head";
        public static String SHOULDERS = "Shoulders";
        public static String CHEST = "Chest";
        public static String BELT = "Belt";
        public static String LEGS = "Legs";
        public static String BOOTS = "Boots";

        public int id { get; set; }
        public String type { get; set; }
        public int intelligence { get; set; }
        public int strength { get; set; }
        public int agility { get; set; }
        public int price { get; set; }
        public String name { get; set; }
    }
}
