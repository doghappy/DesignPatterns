using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08外观模式
{
    /// <summary>
    /// 股票2
    /// </summary>
    class Stock2:IFinancing
    {
        public void Sell() => Console.WriteLine("股票2卖出");

        public void Buy() => Console.WriteLine("股票2买入");
    }
}
