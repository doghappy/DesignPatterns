using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07模板方法
{
    class TestPagerA : TestPaper
    {
        public override char Answer1 { get { return 'b'; } }
        public override char Answer2 { get { return 'c'; } }
        public override char Answer3 { get { return 'a'; } }
    }
}
