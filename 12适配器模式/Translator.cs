using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12适配器模式
{
    /// <summary>
    /// 翻译
    /// </summary>
    class Translator : Player
    {
        ChinaCenter fc = new ChinaCenter();

        public Translator(string name) : base(name)
        {
            fc.Name = base.Name;
        }

        public override void Attack() => fc.进攻();

        public override void Defense() => fc.防守();
    }
}
