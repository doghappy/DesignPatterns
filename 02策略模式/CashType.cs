using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    enum CashType
    {
        /// <summary>
        /// 正常收费
        /// </summary>
        Normal,
        /// <summary>
        /// 返现
        /// </summary>
        CashReturn,
        /// <summary>
        /// 折扣
        /// </summary>
        Rebate
    }
}
