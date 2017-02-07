using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19中介者模式
{
    /// <summary>
    /// 联合国安理会，ConcreteMediator具体中介者
    /// </summary>
    class UNSecurityCouncil : UnitedNations
    {
        public Country USA { get; set; }
        public Country Iraq { get; set; }

        public override void Declare(string message, Country country)
        {
            if(country == USA)
            {
                //如果发表声明的国家是USA，伊拉克应该收到消息。
                Iraq.GetMessage(message);
            }
            else
            {
                USA.GetMessage(message);
            }
        }
    }
}
