using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20享元模式
{
    class User
    {
        public string Name { get; private set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
