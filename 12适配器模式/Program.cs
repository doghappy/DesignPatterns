using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("巴蒂尔");
            b.Attack();

            Player m = new Guards("麦克格雷迪");
            m.Attack();

            //Player ym = new Center("姚明");
            //ym.Attack();
            //ym.Defense();
            //姚明问："Attack"和"Defense"是什么意思？

            Player ym = new Translator("姚明");
            //Translator内部调用的是 ChinaCenter的 进攻() 防御()
            //ChinaCenter 没有从Player类派生，Translator从Player派生
            //相当于做了一次中转
            ym.Attack();
            ym.Defense();

            Console.ReadKey();
        }

        /*
         * 适配器模式(Adapter)，将一个类地接口转换成客户希望的另外一个接口。
         * Adapter模式使得原本由于接口不兼容而不能一起工作的那个类可以一起工作。
         * 
         * 系统的数据和行为都正确，但接口不符时，我们应该考虑时适配器，目的是使控制
         * 范围之外的一个原有对象与某个接口匹配。适配器模式主要应用于希望复用一些现
         * 存的类，但是接口又与复用环境要求不一致的情况。
         * 
         * DataAdapter用作DataSet和数据源之间的适配器以便检索和保存数据，DataAdapter
         * 通过Fill(这更改了DataSet中的数据以便于数据源中的数据相匹配)和Update(这更改
         * 了数据源中的数据以便于DataSet中的数据相匹配)来提供这一适配器
         */
    }
}
