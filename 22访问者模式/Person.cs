using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22访问者模式
{
    abstract class Person
    {
        public PersonAction Action { get; set; }

        /// <summary>
        /// 得到结论或反应
        /// </summary>
        public abstract void GetConclusion();
    }
}
