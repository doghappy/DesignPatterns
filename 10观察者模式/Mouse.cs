using System;

namespace _10观察者模式
{
    class Mouse : ISubscribe
    {
        public Mouse(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Response()
        {
            Console.WriteLine($"🐭({Name})：老大来了，溜了溜了。");
        }
    }
}
