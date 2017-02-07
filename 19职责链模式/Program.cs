using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager jingli = new CommonManager("经理");
            Manager zongjian = new Majordomo("总监");
            Manager zongjingli = new GeneralManager("总经理");
            //设置上级，完全可以根据用户需求来设置
            jingli.Superior = zongjian;
            zongjian.Superior = zongjingli;

            //客户端申请都是由“经理”发起的，但实际谁来决策由具体管理类处理，客户端不知道
            Request request = new Request();
            request.Type = RequestType.Leave;
            request.Content = "小菜请假";
            request.Number = 1;
            jingli.Request(request);

            Request request2 = new Request();
            request2.Type = RequestType.Leave;
            request2.Content = "小菜请假";
            request2.Number = 4;
            jingli.Request(request2);

            Request request3 = new Request
            {
                Type = RequestType.Raises,
                Content = "小菜请求加薪",
                Number = 500
            };
            jingli.Request(request3);

            jingli.Request(new Request
            {
                Type = RequestType.Raises,
                Content = "小菜请求加薪",
                Number = 1000
            });

            Console.ReadKey();
        }

        /*
         * 职责链模式(Chain of Responsibility)：使多个对象都有机会处理请求，
         * 从而避免请求的发送者和接收者之间的耦合关系。将这个对象连成一条链，
         * 并沿着这条链传递该请求，直到有一个对象处理它为止。
         * 
         * 接收者和发送者都没有对方的明确信息，且链中的对象自己也并不知道链的
         * 结构。结果时职责链可简化对象的相互连接，它们仅保持一个指向其后继者
         * 的引用，而不需要保持它所有的候选者的引用。这也就大大降低了耦合度了
         * 
         * 随时的增加或修改处理一个请求的结构。增强了给对象支配职责的灵活性。
         * 
         * 一个请求极有可能到了链的末端都得不到处理，或者因为没有正确配置而得
         * 到处理。
         */
    }
}
