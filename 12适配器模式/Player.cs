using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12适配器模式
{
    /// <summary>
    /// 球员
    /// </summary>
    abstract class Player
    {
        protected string Name { get;private set; }

        public Player(string name)
        {
            Name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }
}
