using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("郭靖");
            a.SetPersonalInfo('男', 38);
            a.SetWorkExperience("1230-1273", "襄阳城");

            Resume b = a.Clone() as Resume;
            b.SetWorkExperience("1243-1273", "武林盟主");

            Resume c = a.Clone() as Resume;
            c.Name = "黄蓉";
            c.SetPersonalInfo('女', 24);

            a.Display();
            b.Display();
            c.Display();

            Console.ReadKey();
        }

        /*
         * 原型模式(Prototype)，用原型实例指定创建对象的种类，并且通过拷贝这些原型
         * 创建新的对象
         * 
         * 原型模式其实就是从一个对象再创建另外一个可定制的对象，而且不需知道任何创
         * 建细节。
         * 
         * 如果构造函数的执行时间很长，那么多次new效率太低了，一般是在初始化的信息不
         * 发生变化的情况下，克隆时最好的办法，这既隐藏了对象创建细节，又对性能是大大
         * 的提高。
         */
    }
}
