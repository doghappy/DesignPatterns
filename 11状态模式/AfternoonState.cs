using System;

namespace _11状态模式
{
    internal class AfternoonState : IState
    {
        public void WriteProgram(Work work)
        {
            if(work.Hour < 17)
            {
                Console.WriteLine($"当前时间：{work.Hour}点 下午状态还不错，继续努力！");
            }
            else
            {
                work.State = new EveningState();
                work.WriteProgram();
            }
        }
    }
}