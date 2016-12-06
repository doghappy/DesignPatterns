using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    abstract class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public abstract double Result { get; }
    }
}
