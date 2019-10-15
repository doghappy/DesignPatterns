using System;

namespace _10观察者模式
{
    class Human : ISubscribe
    {
        public void Response()
        {
            Console.WriteLine("👩：太吵了，醒来看看情况吧。");
        }
    }
}
