using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

using System.Globalization;


using System.Windows.Forms;



namespace PagoElectronico.Utils
{
    class ConfigInicial
    {       
        public DateTime GetFecha()
        {
            return Convert.ToDateTime(GetValue("FechaSistema"), CultureInfo.CurrentCulture);
        }
        public string GetDatosConexion()
        {
            string datosConexionDB = @"Server=" + GetValue("DBServer") +
                                     ";Database=" + GetValue("DBName") +
                                     ";User Id=" + GetValue("DBUser") +
                                     ";Password=" + GetValue("DBPassword") + ";";

            return datosConexionDB;
        }
        public string GetValue(string key)
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;
            return appSettings.Get(key);
        }
    }
}
