using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17桥接模式
{
    // 如果增加一个功能，比如MP3音乐播放功能，那么只要增加这个类就行了。
    class MobileMP3 : IMobileSoft
    {
        public void Run() => Console.WriteLine("运行手机MP3播放");
    }
}
