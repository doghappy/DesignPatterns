using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18命令模式
{
    abstract class Command
    {
        /// <summary>
        /// 烧烤者
        /// </summary>
        public Barbecuer Receiver { get; protected set; }

        protected Command(Barbecuer receiver)
        {
            Receiver = receiver;
        }


        public abstract void ExecuteCommand();
    }
}
