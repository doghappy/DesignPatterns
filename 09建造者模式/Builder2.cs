using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09建造者模式
{
    class Builder2 : IBuilder
    {
        Product _product = new Product();

        public Product Product
        {
            get { return _product; }
        }

        public void BuildPartA() => _product.Add("部件X");

        public void BuildPartB() => _product.Add("部件Y");
    }
}
