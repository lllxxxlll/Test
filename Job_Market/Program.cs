using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Job_Market
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f_City());
          //  Application.Run(new f_City());


        }
    }
}
