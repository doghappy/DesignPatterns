using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16单例模式
{
    //sealed，防止派生类，而派生可能会增加实例
    sealed class Singleton
    {
        static Singleton _instance;
        //多线程时，单例需要上锁
        static readonly object _locker = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                //双重锁定，对于instace存在的情况，就直接返回，这当然没有问题。
                //当instance为null，并且同时有两个线程调用Instace的get方法时，
                //它们将都可以通过第一重instance==null判断。然后由于lock机制，
                //这两个线程则只有一个进入，另一个排队等候，必须要其中一个进入
                //并出来后，另一个才能进入。而此时如果没有了第二重判断，则第一个
                //线程创建了实例，第二个还能再创建，就不是“单例”了
                if(_instance == null)
                    lock(_locker)
                        if(_instance == null)
                            _instance = new Singleton();
                return _instance;
            }
        }

        public override string ToString() => "单例对象";
    }
}
