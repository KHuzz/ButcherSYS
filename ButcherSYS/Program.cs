using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButcherSYS
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
            Application.Run(new frmMainMenuNew());
           // Application.Run(new frmAmendStock());
          //  Application.Run(new frmSales());
          //  Application.Run(new frmStock());
          //  Application.Run(new frmAddStock());
        }
    }
}
