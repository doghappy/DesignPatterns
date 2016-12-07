using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07模板方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("学生A的试卷：");
            TestPaper ta = new TestPagerA();
            ta.Question1();
            ta.Question2();
            ta.Question3();

            Console.WriteLine();

            Console.WriteLine("学生B的试卷：");
            TestPaper tb = new TestPagerB();
            tb.Question1();
            tb.Question2();
            tb.Question3();

            Console.ReadKey();
        }

        /*
         * 模板方法模式，定义一个操作中的算法骨架，而将一些步骤延迟到子类中。模板方法
         * 使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
         * 
         * 模板方法模式是通过把不变形为搬移到基类，去除子类中的重复代码来体现它的优势
         * 模板方法模式就是提供了一个很好的代码服用平台。因为有时候，我们会遇到由一系
         * 列步骤构成的过程需要执行。这个过程从高层次上看是相同的，但有些步骤的实现可
         * 能不同。这时候，我们通常就应该要考虑用模板方法模式了
         * 
         * 当不变何可变的行为在方法的子类实现中混合在一起的时候，不变的行为就会在子类
         * 中重复出现。我们通过模板方法模式把这些行为搬移到单一的地方，这样就帮助子类
         * 摆脱重复的不变行为的纠缠
         */
    }
}
