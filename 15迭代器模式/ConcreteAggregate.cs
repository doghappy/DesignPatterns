using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15迭代器模式
{
    class ConcreteAggregate : Aggregate
    {
        List<object> items = new List<object>();

        public override Iterator Iterator
        {
            get { return new ConcreteIterator(this); }
        }

        public int Count { get { return items.Count; } }

        //索引器
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
