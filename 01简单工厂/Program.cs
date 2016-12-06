using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operAdd = OperationFactory.CreateOperate(Operate.Add);
            operAdd.NumberA = 1;
            operAdd.NumberB = 2;
            Console.WriteLine("加法结果是："+operAdd.Result);

            Operation operSub = OperationFactory.CreateOperate(Operate.Sub);
            operSub.NumberA = 1;
            operSub.NumberB = 2;
            Console.WriteLine("减法结果是："+operSub.Result);

            Operation operMul = OperationFactory.CreateOperate(Operate.Mul);
            operMul.NumberA = 1;
            operMul.NumberB = 2;
            Console.WriteLine("乘法结果是："+operMul.Result);

            Operation operDiv = OperationFactory.CreateOperate(Operate.Div);
            operDiv.NumberA = 1;
            operDiv.NumberB = 2;
            Console.WriteLine("除法结果是："+operDiv.Result);

            Console.ReadKey();
        }
    }
}
