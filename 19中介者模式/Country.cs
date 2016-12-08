namespace _19中介者模式
{
    abstract class Country
    {
        protected UnitedNations Mediator { get;private set; }

        protected Country(UnitedNations mediator)
        {
            Mediator = mediator;
        }

        public abstract void Declare(string message);

        public abstract void GetMessage(string message);
    }
}