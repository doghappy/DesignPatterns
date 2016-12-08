using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileBrand nokia = new NokiaMobile();
            nokia.MobileSoft = new MobileGame();
            nokia.Run();

            nokia.MobileSoft = new AddressBook();
            nokia.Run();

            MobileBrand apple = new AppleMobile();
            apple.MobileSoft = new MobileMP3();
            apple.Run();

            Console.ReadKey();
        }

        /*
         * 桥接模式(Bridge)，将抽象部分与它的实现部分分离，使它们都可以独立地变化。
         * 
         * 抽象与它的实现分离，这并不是说，让抽象类与其派生类分离，因为这没有任何意
         * 义。实现指的是抽象类和它的派生类用来实现自己的对象。
         * 
         * 我觉得桥接模式所说的“将抽象部分与它的实现部分分离”，还是不好理解，我的理
         * 解时：实现系统可能有多角度分类，每一种分类都有可能变化，那么就把这种多角
         * 度分离出来，让它们独立变化，减少它们之间的耦合。
         * 
         * 只要真正深入理解了设计原则，很多设计模式其实就是原则地应用而已，或在不知
         * 不觉中就在使用设计模式了。
         */
    }
}
