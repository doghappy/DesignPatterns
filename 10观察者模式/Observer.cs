using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10观察者模式
{
    /// <summary>
    /// 观察者
    /// </summary>
    abstract class Observer
    {
        protected string Name { get; set; }
        protected ISubject _sub;

        public Observer(string name,ISubject sub)
        {
            Name = name;
            _sub = sub;
        }

        public abstract void Update();
    }
}
