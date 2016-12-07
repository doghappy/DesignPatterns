using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15迭代器模式
{
    /// <summary>
    /// 迭代器
    /// </summary>
    abstract class Iterator
    {
        public abstract object First { get; }
        public abstract object Next();
        public abstract bool IsDone { get; }
        public abstract object Current { get; }
    }
}
