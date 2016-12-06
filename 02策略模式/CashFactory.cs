using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    static class CashFactory
    {
        public static Cash CreateCash(CashType type)
        {
            Cash cash = null;
            switch(type)
            {
                case CashType.Normal:
                    cash = new CashNormal();
                    break;
                case CashType.CashReturn:
                    cash = new CashReturn();
                    break;
                case CashType.Rebate:
                    cash = new CashRebate();
                    break;
            }
            return cash;
        }
    }
}
