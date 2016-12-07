using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08外观模式
{
    /// <summary>
    /// 股票1
    /// </summary>
    class Stock1 : IFinancing
    {
        public void Sell() => Console.WriteLine("股票1卖出");

        public void Buy() => Console.WriteLine("股票1买入");
    }
}
