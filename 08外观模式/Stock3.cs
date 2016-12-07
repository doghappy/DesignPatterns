using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08外观模式
{
    /// <summary>
    /// 股票3
    /// </summary>
    class Stock3 : IFinancing
    {
        public void Sell() => Console.WriteLine("股票3卖出");

        public void Buy() => Console.WriteLine("股票3买入");
    }
}
