namespace _10观察者模式
{
    interface INotifier
    {
        void Notify();
        void Attach(ISubscribe subs);
        void Detach(ISubscribe subs);
    }
}
