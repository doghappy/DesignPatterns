using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    class CashReturn : Cash
    {
        /// <summary>
        /// 返现条件，大于等于该值，才能返现
        /// </summary>
        public double MoneyCondition { get; private set; }

        /// <summary>
        /// 返现
        /// </summary>
        public double MoneyReturn { get; private set; }

        public CashReturn()
        {
            //实际从数据库读取折扣和条件
            MoneyCondition = 300;
            MoneyReturn = 50;
        }

        public override double AcceptCash(double money)
        {
            //大于等于该值，才能返现
            if(money >= MoneyCondition)
            {
                return money - Math.Floor(money / MoneyCondition) * MoneyReturn;
            }
            return money;
        }
    }
}
