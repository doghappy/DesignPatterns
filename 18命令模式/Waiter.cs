using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18命令模式
{
    class Waiter
    {
        /*
         * 第一，真实的情况并不是用户点一个菜，服务员就去通知一个菜。
         * 第二，如果此时鸡翅没了，应该是服务员或者烤肉者来决定这个请求。
         * 第三，客户点了哪些吃的，需要记录日志，以备收费。
         * 第四，客户可能取消一些还没有制作的肉串。
         */

        // 增加存放具体命令的容器
        List<Command> orders = new List<Command>();
        
        public Command Command
        {
            set
            {
                if(value.ToString() == "_18命令模式.BakeChickenWingCommand")
                {
                    Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤。");
                }
                else
                {
                    orders.Add(value);
                    Console.WriteLine($"增加订单：{value.ToString()}  时间：{DateTime.Now.ToString()}");
                }
            }
        }

        public void Notify() => orders.ForEach(o => o.ExecuteCommand());

        public void CancelOrder(Command cmd)
        {
            orders.Remove(cmd);
            Console.WriteLine($"取消订单：{cmd.ToString()}  时间：{DateTime.Now.ToString()}");
        }
    }
}
