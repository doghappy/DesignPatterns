using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20享元模式
{
    abstract class WebSite
    {
        //Use()需要传递“用户对象”
        public abstract void Use(User user);
    }
}
