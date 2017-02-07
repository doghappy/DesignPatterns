using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 720;

            Cash cashNormal = new CashNormal();
            CashContext context = new CashContext(cashNormal);
            Console.WriteLine("正常收费：" + context.GetResult(total));

            CashRebate cashRebate = new CashRebate();
            context.Cash = cashRebate;
            Console.WriteLine($"打{(int)(cashRebate.MoneyRebate * 10)}折收费：" + context.GetResult(total));

            CashReturn cashReturn = new CashReturn();
            context.Cash = cashReturn;
            Console.WriteLine($"满{cashReturn.MoneyCondition}返{cashReturn.MoneyReturn}收费：" + context.GetResult(total));

            Console.ReadKey();

            /*
             * 策略模式(Strategy)：它定义了算法家族，分别封装起来，让他们之间可以互相替换
             * 此模式让算法的变化，不会影响到使用算法的客户
             * 
             * 策略模式解析：
             *     策略模式是一种定义一系列算法的方法，从概念上来看，所有这些算法完成的都
             *     是相同的工作，只是实现不通，它可以以相同的方式调用所有的算法，减少了各
             *     种算法类与算法类之间的耦合
             *     
             *     当不同的行为堆砌在一个类中时，就很难避免使用条件语句来选择合适的行为。
             *     将这些行为封装在一个个独立的Strategy类中，可以在使用这些行为的类中消
             *     除条件语句
             *     
             *     策略模式就是用来封装算法的，但在实践中，我们发现可以用它来封装几乎任
             *     何类型的规则，只要在分析过程中听到需要在不同时间应用不同的业务规则就
             *     可以考虑使用策略模式处理这种变化的可能性
             *     
             *     在基本的策略模式中，选择所用具体实现的这则有客户端对象承担，并转给策
             *     略模式的Context对象
             */
        }
    }
}
