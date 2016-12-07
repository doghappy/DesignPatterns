using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08外观模式
{
    /// <summary>
    /// 房地产1
    /// </summary>
    class Realty1 : IFinancing
    {
        public void Sell() => Console.WriteLine("房地产1卖出");

        public void Buy() => Console.WriteLine("房地产1买入");
    }
}
