using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFNinja.Model;

namespace WPFNinja.DataAccess
{
    public class EquipmentRepository
    {
        readonly List<EquipmentItem> equipment;

        public EquipmentRepository()
        {
            if(equipment == null)
            {
                equipment = new List<EquipmentItem>();
            }

            equipment.Add(new EquipmentItem(EquipmentItem.HEAD, 10, 15, -2, 1000));
            equipment.Add(new EquipmentItem(EquipmentItem.HEAD, 20, 30, -1, 2000));
            equipment.Add(new EquipmentItem(EquipmentItem.HEAD, 30, 50, 30, 3000));

            equipment.Add(new EquipmentItem(EquipmentItem.SHOULDERS, 10, -10, 10, 500));
            equipment.Add(new EquipmentItem(EquipmentItem.SHOULDERS, 20, 15, -10, 1000));
            equipment.Add(new EquipmentItem(EquipmentItem.SHOULDERS, 30, 17, -12, 1000));

            equipment.Add(new EquipmentItem(EquipmentItem.CHEST, 10, 15, -2, 1000));
            equipment.Add(new EquipmentItem(EquipmentItem.CHEST, 10, 13, 12, 1200));
            equipment.Add(new EquipmentItem(EquipmentItem.CHEST, -5, 15, -8, 1500));

            equipment.Add(new EquipmentItem(EquipmentItem.BELT, 15, 31, -2, 1000));
            equipment.Add(new EquipmentItem(EquipmentItem.BELT, -3, 82, 30, 1500));
            equipment.Add(new EquipmentItem(EquipmentItem.BELT, 20, 23, 15, 800));

            equipment.Add(new EquipmentItem(EquipmentItem.LEGS, 10, 15, -2, 1000));
            equipment.Add(new EquipmentItem(EquipmentItem.LEGS, 20, 15, 5, 1200));
            equipment.Add(new EquipmentItem(EquipmentItem.LEGS, 5, 2, 20, 300));

            equipment.Add(new EquipmentItem(EquipmentItem.BOOTS, 10, 15, -2, 1000));
            equipment.Add(new EquipmentItem(EquipmentItem.BOOTS, 15, 130, 23, 2000));
            equipment.Add(new EquipmentItem(EquipmentItem.BOOTS, 10, 30, -2, 1200));
        }
    }
}
