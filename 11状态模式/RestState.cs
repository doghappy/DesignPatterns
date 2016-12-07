using System;

namespace _11状态模式
{
    internal class RestState : IState
    {
        public void WriteProgram(Work work)
        {
            Console.WriteLine("下班咯...");
        }
    }
}