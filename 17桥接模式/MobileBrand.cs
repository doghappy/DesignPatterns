using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17桥接模式
{
    abstract class MobileBrand
    {
        public IMobileSoft MobileSoft { get; set; }

        public abstract void Run();
    }
}
