using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));

            ConcreteCompany comp = new ConcreteCompany("上海华东分公司");
            comp.Add(new HRDepartment("华东分公司人力资源部"));
            comp.Add(new FinanceDepartment("华东分公司财务部"));
            root.Add(comp);

            ConcreteCompany comp2 = new ConcreteCompany("南京办事处");
            comp2.Add(new HRDepartment("南京办事处人力资源部"));
            comp2.Add(new FinanceDepartment("南京办事处财务部"));
            comp.Add(comp2);

            ConcreteCompany comp3 = new ConcreteCompany("杭州办事处");
            comp3.Add(new HRDepartment("杭州办事处人力资源部"));
            comp3.Add(new FinanceDepartment("杭州办事处财务部"));
            comp.Add(comp3);

            Console.WriteLine("\n结构图：");
            root.Display(1);

            Console.WriteLine("\n职责");
            root.LineOfDuty();

            Console.ReadKey();
        }

        /*
         * 组合模式(Composite)，将对象组合成树形结构以表示“部分-整体”的层次结构。
         * 组合模式使得用户对单个对象和组合对象的使用具有一致性
         * 
         * 当发现需求中是体现部分于整体层次的结构时，以及希望用户可以忽略组合对象
         * 与单个对象的不同，统一地使用组合结构中的所有对象时，就应该考虑用组合模
         * 式了。
         * 
         * 组合模式定义了包含基本对象和层次结构。基本对象可以被组合成更复杂的组合
         * 对象，而这个组合对象又可以被组合，这样不断地递归下去，客户代码中，任何
         * 用到基本对象地地方都可以使用组合对象
         * 
         * 用户是不关系到底是处理一个叶节点还是处理一个组合组件，也就用不着为定义
         * 组合而写一些选择判断语句了。组合模式让客户可以一致地使用组合结构和单个
         * 对象。
         */
    }
}
