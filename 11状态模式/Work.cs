using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11状态模式
{
    class Work
    {
        public int Hour { get; set; }
        public bool TaskFinished { get; set; }

        public IState State { get; set; }

        public Work()
        {
            //工作初始化为上午工作状态
            State = new ForenoonState();
        }

        public void WriteProgram() => State.WriteProgram(this);
    }
}
