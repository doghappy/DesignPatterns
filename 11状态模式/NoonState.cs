using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11状态模式
{
    class NoonState : IState
    {
        public void WriteProgram(Work work)
        {
            if(work.Hour<13)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 饿了，午饭，犯困，午休");
            }
            else
            {
                work.State = new AfternoonState();
            }
        }
    }
}
