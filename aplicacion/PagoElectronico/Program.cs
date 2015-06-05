using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PagoElectronico.Login;

using PagoElectronico.DAO;

namespace PagoElectronico
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
            ConexionDB.conectarDB();
            Application.Run(new FormLogin());
            ConexionDB.DesconectarDB();
        }
    }
}
