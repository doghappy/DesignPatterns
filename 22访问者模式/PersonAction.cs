using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22访问者模式
{
    enum PersonAction
    {
        [Description("成功")]
        /// <summary>
        /// 成功
        /// </summary>
        Success,
        [Description("失败")]
        /// <summary>
        /// 失败
        /// </summary>
        Fail,
        [Description("恋爱")]
        /// <summary>
        /// 恋爱
        /// </summary>
        Love
    }
}
