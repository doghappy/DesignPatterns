using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19职责链模式
{
    /// <summary>
    /// 总监
    /// </summary>
    class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {
        }

        public override void Request(Request request)
        {
            if(request.Type == RequestType.Leave && request.Number <= 5)
            {
                //总监所能有的权限就是可准许下属一周内的请假
                Console.WriteLine($"{Name}：{request.Content}  数量：{request.Number}  被批准。");
            }
            else
            {
                Superior.Request(request);
            }
        }
    }
}
