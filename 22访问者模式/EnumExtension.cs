using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace _22访问者模式
{
    /// <summary>
    /// 枚举扩展
    /// </summary>
    static class EnumExtension
    {
        /// <summary>
        /// 获取枚举的Description
        /// </summary>
        /// <param name="value">枚举值</param>
        /// <returns>枚举的Description</returns>
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if(!string.IsNullOrEmpty(name))
            {
                FieldInfo field = type.GetField(name);
                var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
                if(attr == null)
                {
                    return name;
                }
                return attr?.Description;
            }
            return string.Empty;
        }
    }
}
