using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

using System.Windows.Forms;

namespace PagoElectronico
{
    class Encriptador
    {
        public static string Encriptar(string cadena)
        {
            SHA256Managed contraseña = new SHA256Managed();
            byte[] sinCifrar = System.Text.Encoding.ASCII.GetBytes(cadena);
            byte[] cifrado = contraseña.ComputeHash(sinCifrar);
            string password = Convert.ToBase64String(cifrado);

            return password;
        }

    }
}
