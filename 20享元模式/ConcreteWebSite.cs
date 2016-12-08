using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20享元模式
{
    class ConcreteWebSite : WebSite
    {
        string _name;

        public ConcreteWebSite(string name)
        {
            _name = name;
        }

        public override void Use(User user) =>
            Console.WriteLine($"网站分类：{_name}  用户：{user.Name}");
    }
}
