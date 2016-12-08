using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayContext context = new PlayContext();
            Console.WriteLine("上海滩：");
            context.Text = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
            Expression exp = null;
            while(context.Text.Length>0)
            {
                string str = context.Text.Substring(0, 1);
                switch(str)
                {
                    case "O": exp = new Scale();break;
                    case "C":
                    case "D":
                    case "E":
                    case "F":
                    case "G":
                    case "A":
                    case "B":
                    case "P": exp = new Note();break;
                }
                exp.Interpret(context);
            }
            Console.ReadKey();
        }

        /*
         * 解释器模式(Interpreter)，给定一个语言，定义它地文法的一种表示，
         * 并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
         * 
         * 解释器模式主要解决的是，如果一种特定类型的问题发生的频率足够高，
         * 那么可能就值得将该问题的各个实例表述为一个简单语言中的句子。这样
         * 就可以构建一个解释器，该解释其通过解释这些句子来解决该问题。
         * 
         * 当有一个语言需要解释执行，并且你可将改语言中的句子表示为一个抽象
         * 语法树时，可使用解释器模式。
         * 
         * 用了解释器模式，就意味着可以很容易地改变和扩展文法，因为该模式使
         * 用类来表示文法规则，你可以使用继承来改变或扩展该文法。也比较容易
         * 实现文法，因为定义抽象语法树中各个节点的类地实现大体类似，这些类
         * 都易于直接编写。
         * 
         * 解释器模式也有不足，解释器模式为文法中的每一条规则至少定义了一个
         * 类，因此包含书多规则的文法可能难以管理和维护。建议当文法非常复杂
         * 时，使用其他的技术如语法分析程序或编译器生成器来处理。
         */
    }
}
