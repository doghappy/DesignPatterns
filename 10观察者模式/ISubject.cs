using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10观察者模式
{
    /// <summary>
    /// 通知者
    /// </summary>
    interface ISubject
    {
        void Attach(Observer ob);
        void Detach(Observer ob);
        void Notify();

        /// <summary>
        /// 通知状态
        /// </summary>
        string SubjectState { get; set; }
    }
}
