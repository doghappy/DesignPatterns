using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            UNSecurityCouncil unsc = new UNSecurityCouncil();
            Country usa = new USA(unsc);
            Country iraq = new Iraq(unsc);
            unsc.USA = usa;
            unsc.Iraq = iraq;

            usa.Declare("不准研制核武器，否则要发动战争！");
            iraq.Declare("我们没有核武器，也不怕侵略。");

            Console.ReadKey();
        }

        /*
         * 中介者模式(Mediator)，用一个中介对象来封装一系列的对象交互。中介者使各个
         * 对象不需要显示地相互引用，从而使其耦合松散，而且可以独立地改变它们之间的
         * 交互。
         * 
         * 中介者模式很容易在系统中应用，也很容易在系统中误用。当系统出现“多对多”交互
         * 复杂的对象群时，不要急于使用中介者模式，而要先反思你的系统在设计上是否合理
         * 
         * 中介者模式的优点：
         *     首先，Mediator的出现减少了各个对象的耦合，使得可以独立地改变和复用各个
         *     Contry和Mediator
         *     
         *     其次，由于把对象如何协作进行了抽象，将中介作为一个独立的概念并将其封装
         *     再一个对象中，这样关注地对象就从对象各自本身地行为转移到它们之间的交互
         *     上来，也就是站在一个更宏观的角度去看待系统。
         *     
         *     由于具体的中介者控制了集中化，于是就把交互复杂行变为了中介者的复杂性，
         *     这就使得中介者会变得比任何一个Country都复杂。
         */
    }
}
