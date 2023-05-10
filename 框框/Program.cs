using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_Forms;
using Lab_Forms第二題;
using Lab_Forms第三題;
using Lab_Forms第四題;
using 作業OOXX;
using 作業計算機;
using 作業螢幕保護裝置;

namespace 框框
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
