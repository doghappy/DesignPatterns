using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07模板方法
{
    /// <summary>
    /// 金庸小说考题试卷
    /// </summary>
    abstract class TestPaper
    {
        public void Question1()
        {
            Console.WriteLine("杨过得到，后来给了郭靖，炼成倚天剑、屠龙刀的玄铁可能是[ ]");
            Console.WriteLine("a.球磨铸铁  b.马口铁  c.高速合金钢  d.碳素纤维");
            Console.WriteLine("答案：" + Answer1);
        }

        public void Question2()
        {
            Console.WriteLine("杨过、程英、陆无双铲除了情花，造成[ ]");
            Console.WriteLine("a.使这种植物不再害人  b.使一种珍稀物种灭绝  c.破坏了当地生物圈的生态平衡  d.造成该地区沙漠化");
            Console.WriteLine("答案：" + Answer2);
        }

        public void Question3()
        {
            Console.WriteLine("蓝凤凰致使华山师徒、桃谷六仙呕吐不止，如果你是大夫，会给他们开什么药？");
            Console.WriteLine("a.阿司匹林  b.牛黄解毒片  c.氟哌酸  d.让他们喝大量的生牛奶  e.以上全不对");
            Console.WriteLine("答案：" + Answer3);
        }

        public abstract char Answer1 { get; }
        public abstract char Answer2 { get; }
        public abstract char Answer3 { get; }
    }
}
