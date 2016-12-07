using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            work.Hour = 9;
            work.WriteProgram();
            work.Hour = 10;
            work.WriteProgram();
            work.Hour = 12;
            work.WriteProgram();
            work.Hour = 13;
            work.WriteProgram();
            work.Hour = 14;
            work.WriteProgram();
            work.Hour = 17;

            work.TaskFinished = false;
            work.WriteProgram();
            work.Hour = 19;
            work.WriteProgram();
            work.Hour = 22;
            work.WriteProgram();

            Console.ReadKey();
        }


        /*
         * 面向对象设计其实就是希望做到代码地责任分解
         * 
         * 状态模式(State)，当一个对象地内在状态改变时允许改变其行为，这个对象看起来像是
         * 改变了其类。
         * 
         * 状态模式主要解决的是当控制一个对象状态转换的条件表达式过于复杂时的情况。
         * 逻辑转移到表示不同状态的一系列类中，可以把复杂的判断逻辑简化。
         * 
         * 状态模式的好处是将与特定状态相关的行为局部化，并且将不同状态的行为分割开来
         * 将特定的状态相关的行为都放入一个对象中，由于所有于状态相关的代码都存在于某个
         * ConcreteState中，所以通过定义新的子类可以很容易地增加新的状态和转换。说白了
         * 这样做的目的就是为了消除庞大的条件分支语句，大的分支判断会使得它们难以修改和
         * 扩展。
         * 
         * 状态模式通过把各种状态转移逻辑分不到State地子类之间，来减少相互地依赖。
         * 
         * 当一个对象地行为取决于它的状态，并且它必须在运行时刻根据状态改变它地行为时，
         * 就可以考虑使用状态模式了。
         */
    }
}
