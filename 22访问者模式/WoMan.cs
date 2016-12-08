using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22访问者模式
{
    class WoMan : Person
    {
        public override void GetConclusion()
        {
            string name = GetType().Name;
            string desc = Action.GetDescription();
            switch(Action)
            {
                case PersonAction.Success:
                    Console.WriteLine($"{name} {desc}时，背后多半有一个失败的男人。");
                    break;
                case PersonAction.Fail:
                    Console.WriteLine($"{name} {desc}时，眼泪汪汪，谁也劝不了。");
                    break;
                case PersonAction.Love:
                    Console.WriteLine($"{name} {desc}时，凡事不懂也要装不懂。");
                    break;
            }
        }
    }
}
