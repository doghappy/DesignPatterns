using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12适配器模式
{
    /// <summary>
    /// 中国籍的中锋
    /// </summary>
    class ChinaCenter
    {
        public string Name { get; set; }

        public void 进攻()=>
            Console.WriteLine($"外籍中锋 {Name} 进攻");

        public void 防守()=>
            Console.WriteLine($"外籍中锋 {Name} 防守");
    }
}
