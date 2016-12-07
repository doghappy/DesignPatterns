using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10观察者模式
{
    /// <summary>
    /// 看股票的同事
    /// </summary>
    class HuangRongObserver : Observer
    {
        public HuangRongObserver(string name, ISubject sub) : base(name, sub)
        {
        }

        public override void Update() =>
            Console.WriteLine($"{base._sub.SubjectState} {base.Name} 跟随郭靖，前去应付！");
    }
}
