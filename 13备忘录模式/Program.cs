using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("大战 boss前");
            Role role = new Role();
            role.StateDisplay();

            Console.WriteLine("保存进度");
            RoleStateCaretaker admin = new RoleStateCaretaker();
            admin.StateMemento = role.StateMemento;

            Console.WriteLine("大战boss时，损耗严重");
            role.Fight();
            role.StateDisplay();

            Console.WriteLine("恢复之前的状态");
            role.RecoveryState(admin.StateMemento);
            role.StateDisplay();

            Console.ReadKey();
        }

        /*
         * 备忘录(Memento)：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象
         * 之外保存这个状态。这样以后就可以将该对象恢复到原先保存的状态。
         */
    }
}
