using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21解释器模式
{
    abstract class Expression
    {
        public void Interpret(PlayContext context)
        {
            if(context.Text.Length!=0)
            {
                //此方法用于将当前地演奏文本第一条命令获得命令字母和其参数值
                //例如“O3 E0.5 G0.5 A3”
                //则playKey为O，而playValue为3
                string playKey = context.Text.Substring(0, 1);
                context.Text = context.Text.Substring(2);
                double playValue = Convert.ToDouble(context.Text.Substring(0, context.Text.IndexOf(' ')));
                context.Text = context.Text.Substring(context.Text.IndexOf(' ') + 1);
                Execute(playKey, playValue);
            }
        }

        public abstract void Execute(string key, double value);
    }
}
