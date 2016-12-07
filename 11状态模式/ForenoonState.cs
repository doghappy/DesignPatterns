using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11状态模式
{
    class ForenoonState : IState
    {
        public void WriteProgram(Work work)
        {
            if(work.Hour < 12)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 上午工作，精神百倍！");
            }
            else
            {
                work.State = new NoonState();
                work.WriteProgram();
            }
        }
    }
}
