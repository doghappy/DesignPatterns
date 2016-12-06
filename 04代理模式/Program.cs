using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Girl girl = new Girl("蓉儿");
            Proxy proxy = new Proxy(girl);
            proxy.GiveDolls();
            proxy.GiveFlowers();
            proxy.GiveChocolate();

            Console.ReadKey();
        }

        /*
         * 代理模式(Proxy)，为其它对象提供一种代理以控制对这个对象地访问
         * 
         * 代理模式一般用在什么场合？
         *     第一：远程代理，也就是为一个对象在不同的地址空间提供据局部代表。这样
         *     可以隐藏一个对象存在于不同地址空间地事实。比如WebService需要生成代理
         *     类，通过代理类来访问远程服务器。
         *     
         *     第二：虚拟代理，是根据需要创建开销很大的对象。通过它来存放实例需要很
         *     长时间地真是对象
         *     
         *     第三：安全代理，用来控制真是对象访问时地权限
         *     
         *     第四：只能指引，是指当调用真实地对象时，代理处理另外一些事
         */
    }
}
