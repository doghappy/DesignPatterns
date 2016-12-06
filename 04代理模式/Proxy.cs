using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04代理模式
{
    class Proxy : IGiveGift
    {
        Pursuit gg;

        public Proxy(Girl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveChocolate() => gg.GiveChocolate();

        public void GiveDolls() => gg.GiveDolls();

        public void GiveFlowers() => gg.GiveFlowers();
    }
}
