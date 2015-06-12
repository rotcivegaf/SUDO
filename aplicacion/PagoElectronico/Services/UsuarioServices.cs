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
    static class UsuarioServices
    {
        public static int SaveUser(Usuario u) {
            SqlConnection conn = ConexionDB.conectarDB();
            SqlCommand command = getComandoSave(u, conn);
            try{
                command.ExecuteScalar();

                int iRdo = int.Parse(command.Parameters["@VALOR"].Value.ToString());

                if (iRdo == 0){
                    MessageBox.Show("El Usuario se ha creado correctamente");
                }
                if (iRdo == 1)
                {
                    MessageBox.Show("Existe un Usuario con ese Username, por favor ingrese otro");
                    return 1;
                }
            }
            catch (Exception ex){
                throw new Exception(ex.Message);

            }
            finally{
                conn.Dispose();
                command.Dispose();
            }
            return 0;
        }

        private static SqlCommand getComandoSave(Usuario u, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SUDO.SP_ALTA_USUARIO";
            comando.Connection = conn;
            adapter.SelectCommand = comando;

            SqlParameter user = new SqlParameter("@USER", SqlDbType.VarChar, 255);
            user.Value = u.userName;
            comando.Parameters.Add(user);

            SqlParameter password = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 255);
            password.Value = u.userPassword;
            comando.Parameters.Add(password);

            SqlParameter fechaCreacion = new SqlParameter("@FECHACREA", SqlDbType.DateTime);
            fechaCreacion.Value = u.fechaCreacion;
            comando.Parameters.Add(fechaCreacion);

            SqlParameter fechaModificacion = new SqlParameter("@FECHAMODIF", SqlDbType.DateTime);
            fechaModificacion.Value = u.fechaUltimaModificacion;
            comando.Parameters.Add(fechaModificacion);
            return comando;

        }


    }
}
