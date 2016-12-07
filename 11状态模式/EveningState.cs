using System;

namespace _11状态模式
{
    internal class EveningState : IState
    {
        public void WriteProgram(Work work)
        {
            if(work.TaskFinished)
            {
                //如果任务完成，转入下班状态。
                work.State = new RestState();
                work.WriteProgram();
            }
            else
            {
                if(work.Hour < 21)
                {
                    Console.WriteLine($"当前时间：{work.Hour}点 加班哟，累呀！");
                }
                else
                {
                    work.State = new SleepingState();
                    work.WriteProgram();
                }
            }
        }
    }
}