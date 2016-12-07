using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10观察者模式
{
    class GuoJingObserver : Observer
    {
        public GuoJingObserver(string name, ISubject sub) : base(name, sub)
        {
        }

        public override void Update() =>
            Console.WriteLine($"{base._sub.SubjectState} {base.Name} 带上蓉儿，前去应付！");
    }
}
