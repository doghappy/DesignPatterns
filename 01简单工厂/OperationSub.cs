using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    class OperationSub : Operation
    {
        public OperationSub(double a, double b) : base(a, b)
        {
        }

        public override double Result
        {
            get { return NumberA - NumberB; }
        }
    }
}
