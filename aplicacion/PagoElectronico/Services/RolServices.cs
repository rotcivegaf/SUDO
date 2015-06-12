using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using System.Data.SqlClient;
using System.Data;
using PagoElectronico.Dominio;
using System.Windows.Forms;

namespace PagoElectronico.Services
{
    static class RolServices
    {
        public static DataTable getRoles()
        {
            SqlConnection conn = ConexionDB.conectarDB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            try{
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SUDO.SP_LISTAR_ROLES";
                command.Connection = conn;
                adapter.SelectCommand = command;

                DataTable tb = new DataTable();
                adapter.Fill(tb);
                return (tb);
            }
            catch (Exception ex){
                throw new Exception(ex.Message);

            }
            finally{
                conn.Dispose();
                command.Dispose();
            }
        }
    }
}
