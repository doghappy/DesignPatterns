using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19职责链模式
{
    abstract class Manager
    {
        public string Name { get; private set; }

        protected Manager(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 管理者的上级
        /// </summary>
        public Manager Superior { get; set; }

        public abstract void Request(Request request);
    }
}
