using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory factory = new WebSiteFactory();
            WebSite a = factory["产品展示"];
            a.Use(new User("郭靖"));
            WebSite b = factory["产品展示"];
            b.Use(new User("黄蓉"));
            WebSite c = factory["产品展示"];
            c.Use(new User("杨过"));
            WebSite d = factory["博客"];
            d.Use(new User("小龙女"));
            WebSite e = factory["博客"];
            e.Use(new User("郭芙"));
            WebSite f = factory["博客"];
            f.Use(new User("郭襄"));

            Console.WriteLine("网站分类总数为：" + factory.Count);

            Console.ReadKey();
        }

        /*
         * 享元模式(Flyweight)，运用共享技术有效地支持大量细粒度的对象。
         * 
         * 享元模式可以避免大量非常像类的开销。再程序设计中，有时需要生成大量
         * 细粒度地类实例来表示数据。如果能发现这些实例除了几个参数外基本上都
         * 是相同的，有时就能接受大幅度地减少需要实例化的类的数量。如果能把那
         * 些参数移到类实例的外面，再方法调用时将他们传递进来，就可以通过共享
         * 大幅度地减少单个实例地数目。
         * 
         * 如果一个应用程序使用了大量的对象，而大量的这些对象造成了很大的存储
         * 开销时就应该考虑使用；还有就是对象的大多数状态可以外部状态，如果删
         * 除对象的外部状态，那么可以用相对较少的共享对象取来很多组对象，此时
         * 可以考虑使用享元模式。
         */
    }
}
