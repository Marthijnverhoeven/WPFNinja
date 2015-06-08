using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinjaV2.Model
{
    public class Ninja
    {
        public Ninja(int _money)
        {
            money = _money;
        }

        public int money
        {
            get;
            set;
        }
    }
}
