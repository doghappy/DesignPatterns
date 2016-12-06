using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    class CashNormal : Cash
    {
        public override double AcceptCash(double money) => money;
    }
}
