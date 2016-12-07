using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton instance = new Singleton();构造函数私有，不能创建对象。
            Console.WriteLine(Singleton.Instance.ToString());

            Console.ReadKey();
        }
        // 单例模式(Singleton)，保证一个类仅有一个实例，并提供一个访问它的全局访问点。
    }
}
