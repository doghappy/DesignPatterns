using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14组合模式
{
    abstract class Company
    {
        public string Name { get; private set; }

        public Company(string name)
        {
            Name = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        /// <summary>
        /// 履行职责
        /// </summary>
        public abstract void LineOfDuty();
    }
}
