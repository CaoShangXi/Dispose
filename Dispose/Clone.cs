using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispose
{
    public class Clone : IDisposable
    {
        public int Id { get; private set; }

        public Clone(int Id)
        {
            this.Id = Id;
        }

        /// <summary>
        ///Dispose方法会在using语句后的代码块的最后被调用 
        /// </summary>
        public void Dispose()
        {
            MessageBox.Show("已执行到using语句代码块最后！","Clone #"+Id+" says……");
        }

        /// <summary>
        /// 对象被回收时会运行它的最终化方法
        /// </summary>
        ~Clone()
        {
            MessageBox.Show("我被回收啦！", "Clone #" + Id + " says……");
        }
    }
}
