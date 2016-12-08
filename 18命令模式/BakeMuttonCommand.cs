using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18命令模式
{
    /// <summary>
    /// 烤肉串命令
    /// </summary>
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand() => base.Receiver.BakeMutton();
    }
}
