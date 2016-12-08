using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19职责链模式
{
    /// <summary>
    /// 经理
    /// </summary>
    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void Request(Request request)
        {
            if(request.Type == RequestType.Leave && request.Number <= 2)
            {
                //经理所能有的权限就是可准许下属2天内的请假
                Console.WriteLine($"{Name}：{request.Content}  数量：{request.Number}  被批准。");
            }
            else
            {
                //其余的申请都需要转到上级
                Superior?.Request(request);
            }
        }
    }
}
