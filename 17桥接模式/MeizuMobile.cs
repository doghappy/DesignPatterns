using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17桥接模式
{
    // 增加Meizu品牌，只需要增加一个品牌子类就行
    class MeizuMobile : MobileBrand
    {
        public override void Run() => base.MobileSoft.Run();
    }
}
