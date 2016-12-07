using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09建造者模式
{
    /// <summary>
    /// 产品，由多个部件组成
    /// </summary>
    class Product
    {
        List<string> _parts = new List<string>();
        
        public void Add(string part) => _parts.Add(part);

        public void Show()
        {
            Console.WriteLine("\n产品 创建 ----");
            _parts.ForEach(i => Console.WriteLine(i));
        }
    }
}
