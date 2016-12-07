using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IFinancing gu1 = new Stock1();
            IFinancing gu2 = new Stock2();
            IFinancing gu3 = new Stock3();
            IFinancing gz1 = new NationalDebt1();
            IFinancing fdc1 = new Realty1();

            Console.WriteLine("投资股票");
            gu1.Buy();
            gu2.Buy();
            gu3.Buy();

            Console.WriteLine("挣到钱了，卖掉");
            gu1.Sell();
            gu2.Sell();
            gu3.Sell();
            Console.WriteLine("去买国债房地产");
            gz1.Buy();
            fdc1.Buy();
            Console.WriteLine("抵达人生巅峰了");
            Console.ReadKey();
        }

        /*
         * 外观模式(Facade)，为子系统中得一组接口提供一个一致的界面，此模式定义了
         * 一个高层接口，这个接口使得这一子系统更加容易使用
         * 
         * 外观模式在什么时候使用最好呢？
         *     首先，在设计初期阶段，应该要有意识地将不同的两个层分离，比如经典的
         *     三层架构，就需要考虑在DAL层和BLL层、BLL层和UI层的层与层之间建立外
         *     观，这样可以为复杂的子系统提供一个简单的接口，使得耦合大大降低。
         *     
         *     其次，在开发阶段，子系统往往因为不断的重构演化而变得越来越复杂，大
         *     多数的模式使用时也都会产生很多很小的类，这本是好事，但也给外部调用
         *     它们的用户程序带来了使用上的困难，增加外观可以提供一个简单的接口，
         *     减少它们之间的依赖。
         *     
         *     第三，在维护一个遗留的大型系统时，可能这个系统已经非常难以维护和扩
         *     展了，但因为它包含了非常重要的功能，新的需求开发必须要依赖于它。此
         *     时用外观模式也是非常合适的，你可以为新系统开发一个外观类，来提供设
         *     计粗糙或高度复杂的遗留代码的比较清晰简单的接口，让新系统于外观对象
         *     交互，外观于遗留代码交互所有复杂的工作。
         */
    }
}
