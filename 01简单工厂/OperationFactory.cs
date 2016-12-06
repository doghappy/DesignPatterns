using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    static class OperationFactory
    {
        public static Operation CreateOperate(Operate op)
        {
            Operation operation = null;
            switch(op)
            {
                case Operate.Add:
                    operation = new OperationAdd();
                    break;
                case Operate.Sub:
                    operation = new OperationSub();
                    break;
                case Operate.Mul:
                    operation = new OperationMul();
                    break;
                case Operate.Div:
                    operation = new OperationDiv();
                    break;
            }
            return operation;
        }
    }
}
