using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13备忘录模式
{
    class Role
    {
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; set; }

        public Role()
        {
            InitState();
        }

        /// <summary>
        /// 状态显示
        /// </summary>
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("体力：" + Vitality);
            Console.WriteLine("攻击力：" + Attack);
            Console.WriteLine("防御力：" + Defense);
            Console.WriteLine();
        }

        /// <summary>
        /// 初始化状态
        /// </summary>
        public void InitState() =>
            //数据通常来自本机磁盘，或远程数据库
            Vitality = Attack = Defense = 100;

        /// <summary>
        /// 大战boss后耗损到0
        /// </summary>
        public void Fight() =>
            Vitality = Attack = Defense = 0;

        /// <summary>
        /// 根据当前状态获取状态的备忘录
        /// </summary>
        public RoleStateMemento StateMemento
        {
            get { return new RoleStateMemento(this); }
        }

        /// <summary>
        /// 恢复状态
        /// </summary>
        /// <param name="memnote">状态备忘录</param>
        public void RecoveryState(RoleStateMemento memnote)
        {
            Vitality = memnote.Vitality;
            Attack = memnote.Attack;
            Defense = memnote.Defense;
        }
    }
}
