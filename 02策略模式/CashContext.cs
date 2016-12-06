using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    class CashContext
    {
        public Cash Cash { get; set; }

        public CashContext(Cash cash)
        {
            Cash = cash;
        }

        public double GetResult(double money) => Cash.AcceptCash(money);
    }
}
