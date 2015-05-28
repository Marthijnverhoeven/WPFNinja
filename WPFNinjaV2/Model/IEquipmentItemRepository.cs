using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    interface IEquipmentItemRepository
    {
        List<EquipmentItem> ToList();
    }
}
