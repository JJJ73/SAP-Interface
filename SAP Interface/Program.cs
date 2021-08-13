using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Interface
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

            Global.DB = new DB_Connect(Global.dbSQL, false);
            Global.conSAP = new SAP_Connection(Global.DB, Global.configSAP);

            Application.Run(new frmMain());
            //Application.Run(new formPriceQuery());
        }
    }
}
