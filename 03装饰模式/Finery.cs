using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03装饰模式
{
    /// <summary>
    /// 服饰
    /// </summary>
    class Finery : Person
    {
        protected Person _component;

        public void Decorate(Person component) => _component = component;

        public override void Show() => _component?.Show();
    }
}
