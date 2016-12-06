using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04代理模式
{
    class Pursuit : IGiveGift
    {
        Girl _girl;

        public Pursuit(Girl girl)
        {
            _girl = girl;
        }

        public void GiveChocolate() => Console.WriteLine($"送给{_girl.Name}洋娃娃");

        public void GiveDolls() => Console.WriteLine($"送给{_girl.Name}鲜花");

        public void GiveFlowers() => Console.WriteLine($"送给{_girl.Name}巧克力");
    }
}
