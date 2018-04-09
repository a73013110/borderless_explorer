using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using Gma.System.MouseKeyHook;

namespace borderless_explorer
{
    static class Program
    {
        public static Form1 main_form;
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main_form = new Form1();
            Application.Run(main_form);

            // 記得要用這個, 不然內存可能會爆
            Cef.Shutdown();
            main_form.unsubscribe();
            Console.WriteLine("清除內存");
        }
    }
}
