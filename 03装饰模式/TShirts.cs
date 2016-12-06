using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03装饰模式
{
    /// <summary>
    /// T恤 具体服饰类
    /// </summary>
    class TShirts:Finery
    {
        public override void Show()
        {
            Console.Write("大T恤 ");
            base.Show();
        }
    }
}
