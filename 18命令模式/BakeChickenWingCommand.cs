using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18命令模式
{
    /// <summary>
    /// 烤鸡翅命令
    /// </summary>
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExecuteCommand() => base.Receiver.BakeChickenWing();
    }
}
