using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Person man1 = new Man();
            man1.Action = PersonAction.Success;
            persons.Add(man1);
            Person woman1 = new WoMan();
            woman1.Action = PersonAction.Success;
            persons.Add(woman1);

            Person man2 = new Man();
            man2.Action = PersonAction.Fail;
            persons.Add(man2);
            Person woman2 = new WoMan();
            woman2.Action = PersonAction.Fail;
            persons.Add(woman2);

            Person man3 = new Man();
            man3.Action = PersonAction.Love;
            persons.Add(man3);
            Person woman3 = new WoMan();
            woman3.Action = PersonAction.Love;
            persons.Add(woman3);

            persons.ForEach(p => p.GetConclusion());

            Console.ReadKey();
        }

        /*
         * 访问者模式(Visitor)，表示一个作用于某对象结构中的各个元素操作。它使你
         * 可以在不改变各个元素的类的前提下定义作用与这些元素的新操作。
         * 
         * 访问者模式适用于数据结构相对稳定的系统，它把数据结构和用于用结构上的操
         * 作之间的耦合解脱开了，使得操作集合可以相对自由地演化。
         * 
         * 访问者模式地目的是要把处理从数据结构分离出来，有比较稳定地数据结构，又
         * 易于变化的算法的话，使用访问者模式就是比较合适的，因为访问者模式使得算
         * 法操作的增加变得更容易。
         * 
         * 访问者模式的优点就是增加新的操作很容易，因为增加新的操作就意味着增加一
         * 个新的访问者。访问者模式将有关的行为集中到一个访问者对象中。
         * 
         * 访问者的缺点就是是增加新的数据结构变得困难了。
         */
    }
}
