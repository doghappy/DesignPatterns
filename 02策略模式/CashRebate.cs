using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    /// <summary>
    /// 打折收费
    /// </summary>
    class CashRebate : Cash
    {
        private double moneyRebate;
        /// <summary>
        /// 折扣率
        /// </summary>
        public double MoneyRebate
        {
            get { return moneyRebate; }
            private set
            {
                if(moneyRebate < 0 || moneyRebate > 1)
                {
                    throw new Exception("折扣率错误，如果是8折就是0.8");
                }
                moneyRebate = value;
            }
        }

        public CashRebate()
        {
            //实际从数据库读取折扣和条件
            MoneyRebate = .8;
        }

        public override double AcceptCash(double money)
        {
            return money * MoneyRebate;
        }
    }
}
