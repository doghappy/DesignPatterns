using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19中介者模式
{
    /// <summary>
    /// 联合国：抽象的中介者
    /// </summary>
    abstract class UnitedNations
    {
        public abstract void Declare(string message, Country country);
    }
}
