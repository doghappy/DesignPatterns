using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15迭代器模式
{
    /// <summary>
    /// 具体的迭代器
    /// </summary>
    class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int index = 0;

        public ConcreteIterator(ConcreteAggregate aggr)
        {
            aggregate = aggr;
        }

        public override object Current
        {
            get { return aggregate[index]; }
        }

        public override object First
        {
            get { return aggregate[0]; }
        }

        public override bool IsDone
        {
            get { return index >= aggregate.Count - 1; }
        }

        public override object Next()
        {
            object obj = null;
            index++;
            if(!IsDone) obj = aggregate[index];
            return obj;
        }
    }
}
