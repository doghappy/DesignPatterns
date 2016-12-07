using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12适配器模式
{
    /// <summary>
    /// 后卫
    /// </summary>
    class Guards:Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attack() =>
            Console.WriteLine($"后卫 {Name} 进攻");

        public override void Defense() =>
            Console.WriteLine($"后卫 {Name} 防守");
    }
}
