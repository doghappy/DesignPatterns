using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14组合模式
{
    class ConcreteCompany : Company
    {
        List<Company> children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c) => children.Add(c);

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + base.Name);
            children.ForEach(i => i.Display(depth + 2));
        }

        public override void LineOfDuty() => children.ForEach(i => i.LineOfDuty());

        public override void Remove(Company c) => children.Remove(c);
    }
}
