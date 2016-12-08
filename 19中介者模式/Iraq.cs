using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19中介者模式
{
    class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }

        public override void Declare(string message) =>
            base.Mediator.Declare(message, this);

        public override void GetMessage(string message) =>
            Console.WriteLine("伊拉克获得对方信息：" + message);
    }
}
