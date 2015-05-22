using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinja.Model
{
   class EquipmentItem
    {
        public static int HEAD = 0;
        public static int SHOULDERS = 1;
        public static int CHEST = 2;
        public static int BELT = 3;
        public static int LEGS = 4;
        public static int BOOTS = 5;

        public int type { get; set; }
        public int agility { get; set; }
        public int intelligence { get; set; }
        public int strength { get; set; }
        public int price { get; set; }

        public EquipmentItem(int _type, int _agility, int _intelligence, int _strength, int _price)
        {
            if(_type >= 0 && _type <= 5)
            {
                this.type = _type;
            }

            this.agility = _agility;
            this.intelligence = _intelligence;
            this.strength = _strength;
            
            if(_price > 0)
            {
                this.price = _price;
            }
            else
            {
                price = 0;
            }
        }

    }
}
