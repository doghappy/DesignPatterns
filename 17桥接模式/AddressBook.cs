using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17桥接模式
{
    class AddressBook : IMobileSoft
    {
        public void Run() => Console.WriteLine("运行手机通讯录");
    }
}
