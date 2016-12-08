using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19职责链模式
{
    /// <summary>
    /// 总经理
    /// </summary>
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void Request(Request request)
        {
            if(request.Type == RequestType.Leave)
            {
                Console.WriteLine($"{Name}：{request.Content}  数量：{request.Number}  被批准。");
            }
            else if(request.Type == RequestType.Raises && request.Number <= 500)
            {
                Console.WriteLine($"{Name}：{request.Content}  数量：{request.Number}  被批准。");
            }
            else if(request.Type == RequestType.Raises && request.Number > 500)
            {
                Console.WriteLine($"{Name}：{request.Content}  数量：{request.Number}  再说吧。");
            }
        }
    }
}
