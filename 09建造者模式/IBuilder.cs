using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09建造者模式
{
    /// <summary>
    /// 建造者接口
    /// </summary>
    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product Product { get; }
    }
}
