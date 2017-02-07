using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05工厂方法
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            LeiFeng stuent = factory.CreateLeiFeng();

            stuent.BuyRice();
            stuent.Sweep();
            stuent.Wash();

            IFactory factoryVolu = new VolunteerFactory();
            LeiFeng volu = factoryVolu.CreateLeiFeng();
            volu.BuyRice();
            volu.Sweep();
            volu.Wash();
        }

        /*
         * 工厂方法(Factory Method)，定义一个用于创建对象的接口，让子类决定实例化
         * 哪一个类。工厂方法使用一个类的实例化延迟到其子类
         * 
         * 工厂方法模式克服了简单工厂违背“开放封闭原则”的缺点，又保持了封装对象创
         * 建过程的优点，他们都是集中封装了对象的创建，使得要更换对象时，不需要做
         * 大的改动就可以实现，降低了客户程序与产品对象耦合。
         * 
         * 工厂方法模式是简单工厂模式的进一步抽象和推广。由于使用了多态性，工厂方
         * 法模式保持了简单工厂模式的优点，而且克服了它的缺点，但工厂方法模式缺点
         * 是由于每加一个产品，就需要加一个产品工厂的类，增加了额外的开发量。
         */
    }
}
