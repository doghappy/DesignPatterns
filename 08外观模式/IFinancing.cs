using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08外观模式
{
    /// <summary>
    /// 理财接口
    /// </summary>
    interface IFinancing
    {
        void Sell();
        void Buy();
    }
}
