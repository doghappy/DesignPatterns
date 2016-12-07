using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15迭代器模式
{
    /// <summary>
    /// 聚集
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator Iterator { get; }
    }
}
