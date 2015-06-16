using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

using PagoElectronico.Utils;

namespace PagoElectronico.DAO
{
    class ConexionDB
    {
        public static SqlConnection conexionDB;

        public static SqlConnection conectarDB()
        {
            ConfigInicial configInicial = new ConfigInicial();

            conexionDB = new SqlConnection(configInicial.GetDatosConexion());
            if (conexionDB.State != System.Data.ConnectionState.Open)
            {
                conexionDB.Open();
            }
            else
            {
                Console.WriteLine("PagoElectronico.DAO.DBConection: ERROR AL INTENTAR CONECTARSE CON LA BASE DE DATOS!!");
            }
            return conexionDB;
        }

        public static int ejecNonQueryProc(string nombreProc, List<SqlParameter> parametros)
        {
            SqlCommand comandoSQL = new SqlCommand();
            comandoSQL.CommandText = nombreProc;
            comandoSQL.Connection = conectarDB();
            comandoSQL.CommandType = CommandType.StoredProcedure;

            if (parametros != null && parametros.Exists(x => x != null))
            {
                foreach (SqlParameter parametro in parametros)
                {
                    comandoSQL.Parameters.Add(parametro);
                }
            }
            int numeroFilasAfectadas = comandoSQL.ExecuteNonQuery();
            comandoSQL.Dispose();
            return numeroFilasAfectadas;            
        }

        public static object ejecScalarProc(string nombreProc, List<SqlParameter> parametros)
        {
            SqlCommand comandoSQL = new SqlCommand();
            comandoSQL.CommandText = nombreProc;
            comandoSQL.Connection = conectarDB();
            comandoSQL.CommandType = CommandType.StoredProcedure;

            if (parametros != null && parametros.Exists(x => x != null))
            {
                foreach (SqlParameter parametro in parametros)
                {
                    comandoSQL.Parameters.Add(parametro);
                }
            }

            object scalarResultado = comandoSQL.ExecuteScalar();
            comandoSQL.Dispose();

            return scalarResultado;
        }

        public static SqlDataReader ejecReaderProc(string nombreProc, List<SqlParameter> parametros)
        {
            SqlCommand comandoSQL = new SqlCommand();
            comandoSQL.CommandText = nombreProc;
            comandoSQL.Connection = conectarDB();
            comandoSQL.CommandType = CommandType.StoredProcedure;

            if (parametros != null && parametros.Exists(x => x != null))
            {
                foreach (SqlParameter parametro in parametros)
                {
                    comandoSQL.Parameters.Add(parametro);
                }
            }
            SqlDataReader tablaResultado = comandoSQL.ExecuteReader();
            comandoSQL.Dispose();

            return tablaResultado;
        }

        public static void DesconectarDB()
        {
            if (conexionDB.State != System.Data.ConnectionState.Closed)
            {
                conexionDB.Close();
            }
            else
            {
                Console.WriteLine("PagoElectronico.DAO.DBConection: ERROR AL INTENTAR DESCONECTARSE CON LA BASE DE DATOS!!");
            }
        }
    }
}
