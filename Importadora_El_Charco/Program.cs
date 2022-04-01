using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using BD;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importadora_El_Charcho
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());

        }
    }
}
