using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12适配器模式
{
    /// <summary>
    /// 前锋
    /// </summary>
    class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attack() =>
            Console.WriteLine($"前锋 {Name} 进攻");

        public override void Defense() =>
            Console.WriteLine($"前锋 {Name} 防守");
    }
}
