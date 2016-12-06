using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03装饰模式
{
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤 ");
            base.Show();
        }
    }
}
