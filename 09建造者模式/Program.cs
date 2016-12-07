using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //客户不需知道具体的建造过程
            Director dir = new Director();
            IBuilder b1 = new Builder1();
            IBuilder b2 = new Builder2();

            //指挥b1建造者去建造
            dir.Construct(b1);
            Product p1 = b1.Product;
            p1.Show();

            //指挥b2建造者去建造
            dir.Construct(b2);
            Product p2 = b2.Product;
            p2.Show();

            Console.ReadKey();
        }

        /*
         * 建造者模式(Builder)，将一个复杂对象的构建与它的表示分离，使得同样的构建
         * 过程可以创建不同的表示。
         * 
         * 如果你需要将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建
         * 不同的表示
         * 
         * 如果我们用了建造者模式，那么用户就只需要指定需要建造的类型就可以得到它们
         * 而具体建造的过程和细节就不需知道了
         * 
         * 建造者模式是在当创建复杂对象的算法应该独立于该对象的组成部分以及它们的装
         * 配方式时适用的模式。
         */
    }
}
