using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Punto de entrada principal para la aplicación.
            /// </summary>
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
