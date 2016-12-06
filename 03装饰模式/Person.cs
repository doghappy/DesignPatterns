using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03装饰模式
{
    class Person
    {
        public Person() { }

        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public virtual void Show()
        {
            Console.WriteLine("装扮的人是：" + Name);
        }
    }
}
