using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13备忘录模式
{
    /// <summary>
    /// 角色状态管理者
    /// </summary>
    class RoleStateCaretaker
    {
        /// <summary>
        /// 状态备忘录
        /// </summary>
        public RoleStateMemento StateMemento { get; set; }
    }
}
