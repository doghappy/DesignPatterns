using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    class OperationAdd:Operation
    {
        public override double Result
        {
            get { return NumberA + NumberB; }
        }
    }
}
