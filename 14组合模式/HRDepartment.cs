using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14组合模式
{
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
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
            Console.WriteLine(base.Name + " 员工招聘培训管理");
        }

        public override void Remove(Company c)
        {
        }
    }
}
