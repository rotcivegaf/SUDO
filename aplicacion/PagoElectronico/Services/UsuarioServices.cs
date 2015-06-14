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
            SqlCommand command = GetComandoSave(u, conn);
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

        private static SqlCommand GetComandoSave(Usuario u, SqlConnection conn)
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

            SqlParameter preguntaSecreta = new SqlParameter("@PREGUNTASECRETA", SqlDbType.VarChar, 255);
            preguntaSecreta.Value = u.preguntaSecreta;
            comando.Parameters.Add(preguntaSecreta);

            SqlParameter rtaSecreta = new SqlParameter("@RTASECRETA", SqlDbType.VarChar, 255);
            rtaSecreta.Value = u.respuestaSecreta;
            comando.Parameters.Add(rtaSecreta);

            SqlParameter cantidadDeIntentosFallidos = new SqlParameter("@CANTINTENTOSFALL", SqlDbType.TinyInt);
            cantidadDeIntentosFallidos.Value = u.cantIntentosFallidos;
            comando.Parameters.Add(cantidadDeIntentosFallidos);

            SqlParameter estado = new SqlParameter("@ESTADO", SqlDbType.Bit);
            estado.Value = u.estado;
            comando.Parameters.Add(estado);

            SqlParameter valor = new SqlParameter("@VALOR", SqlDbType.Int, 1);
            comando.Parameters.Add(valor);
            valor.Direction = ParameterDirection.Output;

            return comando;

        }

        public static DataTable GetUserByFiltros(String user, int rolAsignado, DateTime fechaAlta, DateTime fechaModif) {
            SqlConnection conn = ConexionDB.conectarDB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "GR46.SUDO_LISTADO_USERS";
            comando.Connection = conn;
            adapter.SelectCommand = comando;

            SqlParameter userDB = new SqlParameter("@USER", SqlDbType.VarChar, 255);
            if (user == "")
            {
                userDB.Value = DBNull.Value;
            }else
            {
                userDB.Value = user;
            }
            comando.Parameters.Add(userDB);

            SqlParameter rolAsignadoDB = new SqlParameter("@ROL", SqlDbType.Int);
            rolAsignadoDB.Value = rolAsignado;
            comando.Parameters.Add(rolAsignadoDB);

            SqlParameter fechaAltaDB = new SqlParameter("@FECHAALTA", SqlDbType.DateTime);
            fechaAltaDB.Value = fechaAlta;
            comando.Parameters.Add(fechaAltaDB);

            SqlParameter fechaModifDB = new SqlParameter("@FECHAMODIF", SqlDbType.DateTime);
            fechaModifDB.Value = fechaModif;
            comando.Parameters.Add(fechaModifDB);

            try
            {
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                return (tb);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Dispose();
                comando.Dispose();

            }
        }
    }
}
