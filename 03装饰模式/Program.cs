using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");
            TShirts ts = new TShirts();
            BigTrouser kk = new BigTrouser();
            ts.Decorate(xc);
            kk.Decorate(ts);
            kk.Show();

            /*
             * 装饰模式是为已有功能动态地添加更多功能的一种方式，当系统需要新功能的时候
             * 是向旧的类中添加新的代码。这些新加的代码通常装饰了原有类的核心职责或主要
             * 行为，在主类中加入了新的字段，新的方法何新的逻辑，从而增加了主类的复杂度
             * 而这些新加入的东西仅仅是为了满足一些只在某种特定情况下才会执行的特殊行为
             * 的需要。而装饰模式却提供了一个非常好的解决方案，它把每个要装饰的功能放在
             * 单独的类中，并让这个类包装它所要装饰的对象，因此，当需要执行特殊行为时，
             * 客户代码就可以在运行时根据需要有选择地、按顺序地使用装饰功能包装对象了。
             * 
             * 装饰模式地优点：
             *     把类中地装饰功能从类搬移去除，这样可以简化原有的类，更大的好处就是有
             *     效地把类的核心职责何装饰功能区分开了。而且可以去除相关类中重复的装饰
             *     逻辑
             */
        }
    }
}
