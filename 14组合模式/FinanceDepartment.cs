using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14组合模式
{
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + base.Name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine(base.Name+" 公司财务收支管理");
        }

        public override void Remove(Company c)
        {
        }
    }
}
