using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            // 开店前的准备，找好烤肉厨师、服务员、烤肉菜单
            Barbecuer boy = new Barbecuer();
            Command cmd1 = new BakeMuttonCommand(boy);
            Command cmd2 = new BakeMuttonCommand(boy);
            Command cmd3 = new BakeChickenWingCommand(boy);
            Waiter girl = new Waiter();

            // 开门营业  服务员根据用户要求，通知厨房开始制作
            girl.Command = cmd1;
            girl.Command = cmd2;
            girl.Command = cmd3;

            //点菜完毕，通知厨房。
            girl.Notify();

            Console.ReadKey();
        }

        /*
         * 命令模式(Command)，将一个请求封装为一个对象，从而使你可用不同的请求对客户
         * 进行参数化；请求队列或记录请求日志，以及支持可撤销的操作。
         * 
         * 命令模式的优点：
         *     第一：它能较容易地设计一个命令队列。
         *     第二：在需要的情况下，可以较容易地将命令记入日志。
         *     第三：允许接收请求地一方决定是否要否决请求。
         *     第四：可以容易地实现对请求地撤销和重做。
         *     第五：由于加进新的具体命令类不影响其它类，因此增加新的具体命令类很容易。
         *     最关键优点：命令模式把请求一个操作地对象与知道怎么执行一个操作地对象分割开了。
         *     
         * 敏捷开发原则告诉我们，不要为代码添加基于猜测地、实际不需要地功能。如果不清楚
         * 一个系统是否需要命令模式，一般就不要急着去实现它，事实上，在需要的时候通过重
         * 构实现这个模式并不困难，只有在真正需要如撤销/恢复操作等功能时，把原来地代码重
         * 构为命令模式才有意义。
         */
    }
}
