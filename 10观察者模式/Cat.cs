using System;
using System.Collections.Generic;

namespace _10观察者模式
{
    class Cat : INotifier
    {
        public Cat()
        {
            _subscribes = new List<ISubscribe>();
        }

        private List<ISubscribe> _subscribes;

        public void Attach(ISubscribe subs) => _subscribes.Add(subs);

        public void Detach(ISubscribe subs) => _subscribes.Remove(subs);

        public void Notify()
        {
            foreach (var item in _subscribes)
            {
                item.Response();
            }
        }

        public void Miao()
        {
            Console.WriteLine("🐱：喵喵喵");
            Notify();
        }
    }
}
