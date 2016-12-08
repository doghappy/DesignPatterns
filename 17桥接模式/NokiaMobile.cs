using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17桥接模式
{
    class NokiaMobile : MobileBrand
    {
        public override void Run()
        {
            base.MobileSoft.Run();
        }
    }
}
