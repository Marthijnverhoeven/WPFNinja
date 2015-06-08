using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    class DummyNinjaRepository : INinja
    {
        public List<Ninja> ToList()
        {
            var ninjas = new List<Ninja>();

            ninjas.Add(new Ninja(100000));

            return ninjas;
        }
    }
}
