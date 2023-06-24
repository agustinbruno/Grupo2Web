using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_de_Ropa.Controladores;
using Tienda_de_Ropa.Vistas;

namespace Tienda_de_Ropa
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
            DB_Controller.initialize();

            if (DB_Controller.validateConnection())
            {
                Trace.WriteLine("Conexion a la base de datos establecida con exito");
            }

            Application.Run(new LoginForm());

            
        }

        


    }
}
