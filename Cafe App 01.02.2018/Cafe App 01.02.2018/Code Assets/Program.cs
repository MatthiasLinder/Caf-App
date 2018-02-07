using Cafe_App_01._02._2018.Code_Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_App_01._02._2018
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FirstScreen());
            
            Application.Run(new PurchaseScreen());

            Application.Run(new ExitAndPayScreen());
        }
    }
}
