using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06原型模式
{
    /// <summary>
    /// 简历
    /// </summary>
    class Resume : ICloneable
    {
        public string Name { get; set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }
        public string TimeArea { get; private set; }
        public string Company { get; private set; }

        public Resume(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(char gender, int age)
        {
            Gender = gender;
            Age = age;
        }

        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="timeArea"></param>
        /// <param name="company"></param>
        public void SetWorkExperience(string timeArea, string company)
        {
            TimeArea = timeArea;
            Company = company;
        }


        public void Display()
        {
            Console.WriteLine($"{Name} {Gender} {Age}");
            Console.WriteLine($"工作经历：{TimeArea} {Company}");
        }

        /*
         * MemberwiseClone()方法，如果字段是值类型的，则对该字段执行逐位赋值，
         * 如果是引用类型，则赋值引用的对象；因此，原始对象及其副本引用同一对象
         * 这叫做“浅复制”
         * 
         * 如果想要“深复制”，字段、属性对应的类型也需要实现ICloneable接口
         */
        public object Clone() => MemberwiseClone();
    }
}
