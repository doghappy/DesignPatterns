using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    abstract class Cash
    {
        public abstract double AcceptCash(double money);
    }
}
