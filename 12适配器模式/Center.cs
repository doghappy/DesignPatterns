using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12适配器模式
{
    /// <summary>
    /// 中锋
    /// </summary>
    class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack() =>
            Console.WriteLine($"中锋 {Name} 进攻");

        public override void Defense() =>
            Console.WriteLine($"中锋 {Name} 防守");
    }
}
