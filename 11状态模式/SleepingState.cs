using System;

namespace _11状态模式
{
    internal class SleepingState : IState
    {
        public void WriteProgram(Work work)
        {
            Console.WriteLine("睡觉咯...");
        }
    }
}