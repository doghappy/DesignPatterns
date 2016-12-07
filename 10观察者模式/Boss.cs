using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10观察者模式
{
    class Boss : ISubject
    {
        /// <summary>
        /// 同事列表
        /// </summary>
        List<Observer> observers = new List<Observer>();

        string _action;

        /// <summary>
        /// 老板状态
        /// </summary>
        public string SubjectState
        {
            get { return _action; }

            set { _action = value; }
        }

        public void Attach(Observer ob) => observers.Add(ob);

        public void Detach(Observer ob) => observers.Remove(ob);

        public void Notify() => observers.ForEach(o => o.Update());
    }
}
