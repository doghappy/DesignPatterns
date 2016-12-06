using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    abstract class Operation
    {
        protected Operation(double a,double b)
        {
            NumberA = a;
            NumberB = b;
        }

        public double NumberA { get; private set; }
        public double NumberB { get; private set; }

        public abstract double Result { get; }
    }
}
