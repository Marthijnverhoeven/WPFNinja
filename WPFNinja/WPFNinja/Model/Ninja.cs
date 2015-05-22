using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinja.Model
{
    class Ninja
    {
        private List<EquipmentItem> inventory;

        public EquipmentItem head;
        public EquipmentItem shoulders;
        public EquipmentItem chest;
        public EquipmentItem belt;
        public EquipmentItem legs;
        public EquipmentItem boots;

        public Ninja()
        {
            if(inventory == null)
            {
                this.inventory = new List<EquipmentItem>();
            }
        }

        public void addToInventory(EquipmentItem item)
        {
            this.inventory.Add(item);
        }

        public void setHead(EquipmentItem item)
        {
            if(item.type == EquipmentItem.HEAD)
            {
                this.head = item;
            }
        }

        public EquipmentItem getHead()
        {
            return this.head;
        }

        public void setShoulders(EquipmentItem item)
        {
            if (item.type == EquipmentItem.SHOULDERS)
            {
                this.shoulders = item;
            }
        }

        public EquipmentItem getShoulders()
        {
            return this.shoulders;
        }

        public void setChest(EquipmentItem item)
        {
            if (item.type == EquipmentItem.CHEST)
            {
                this.chest = item;
            }
        }

        public EquipmentItem getChest()
        {
            return this.chest;
        }

        public void setBelt(EquipmentItem item)
        {
            if (item.type == EquipmentItem.BELT)
            {
                this.belt = item;
            }
        }

        public EquipmentItem getBelt()
        {
            return this.belt;
        }

        public void setLegs(EquipmentItem item)
        {
            if (item.type == EquipmentItem.LEGS)
            {
                this.legs = item;
            }
        }

        public EquipmentItem getlegs()
        {
            return this.legs;
        }

        public void setBoots(EquipmentItem item)
        {
            if (item.type == EquipmentItem.BOOTS)
            {
                this.boots = item;
            }
        }

        public EquipmentItem getBoots()
        {
            return this.boots;
        }

    }
}
