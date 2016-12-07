using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate ca = new ConcreteAggregate();
            ca[0] = "a";
            ca[1] = "b";
            ca[2] = "c";
            ca[3] = "d";
            ca[4] = "e";
            ca[5] = "f";

            Iterator i = new ConcreteIterator(ca);
            object item = i.First;
            while(!i.IsDone)
            {
                Console.WriteLine(i.Current.ToString() + "请买车票");
                i.Next();
            }

            Console.ReadKey();
        }

        /*
         * 迭代器模式(Iterator)，提供一种方法顺序访问一个聚合对象中各个元素，而又
         * 不暴露该对象地内部表示。
         * 
         * 一个聚集对象，而且不管这些对象是什么都需要遍历的时候，你就应该考虑用迭
         * 代器模式。也就是说，你需要对聚焦有多种方式遍历时，可以考虑用迭代器模式
         */
    }
}
