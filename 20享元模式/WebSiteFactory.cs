using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20享元模式
{
    class WebSiteFactory
    {
        Dictionary<string, WebSite> _dic = new Dictionary<string, WebSite>();

        public WebSite this[string key]
        {
            get
            {
                if(!_dic.ContainsKey(key))
                    _dic[key] = new ConcreteWebSite(key);
                return _dic[key];
            }
        }

        public int Count { get { return _dic.Count; } }
    }
}
