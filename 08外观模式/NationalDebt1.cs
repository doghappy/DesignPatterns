using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08外观模式
{
    /// <summary>
    /// 国债1
    /// </summary>
    class NationalDebt1 : IFinancing
    {
        public void Sell() => Console.WriteLine("国债1卖出");

        public void Buy() => Console.WriteLine("国债1买入");
    }
}
