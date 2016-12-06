using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 720;

            Cash cashNormal = CashFactory.CreateCash(CashType.Normal);
            Console.WriteLine("正常收费：" + cashNormal.AcceptCash(total));

            CashRebate cashRebate = (CashRebate)CashFactory.CreateCash(CashType.Rebate);
            Console.WriteLine($"打{(int)(cashRebate.MoneyRebate * 10)}折收费：" + cashRebate.AcceptCash(total));

            CashReturn cashReturn = (CashReturn)CashFactory.CreateCash(CashType.CashReturn);
            Console.WriteLine($"满{cashReturn.MoneyCondition}返{cashReturn.MoneyReturn}收费：" + cashReturn.AcceptCash(total));

            Console.ReadKey();
        }
    }
}
