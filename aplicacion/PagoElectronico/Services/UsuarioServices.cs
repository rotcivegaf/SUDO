using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagoElectronico.DAO;
using System.Data.SqlClient;
using System.Data;
using PagoElectronico.Dominio;
using System.Windows.Forms;
using System.Globalization;

namespace PagoElectronico.Services
{
    static class UsuarioServices
    {
        public static int SaveUser(Usuario u, int rol)
        {
            SqlConnection conn = ConexionDB.conectarDB();
            SqlCommand command = GetComandoSave(u, conn, rol);

            try
            {
                command.ExecuteScalar();

                int iRdo = int.Parse(command.Parameters["@VALOR"].Value.ToString());

                if (iRdo == 0)
                {
                    MessageBox.Show("El Usuario se ha creado correctamente");
                }
                if (iRdo == 1)
                {
                    MessageBox.Show("Existe un Usuario con ese Username, por favor ingrese otro");
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                conn.Dispose();
                command.Dispose();
            }
            return 0;
        }

        private static SqlCommand GetComandoSave(Usuario u, SqlConnection conn, int rol)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SUDO.SP_ALTA_USUARIO";
            comando.Connection = conn;
            adapter.SelectCommand = comando;

            SqlParameter user = new SqlParameter("@USUARIO", SqlDbType.VarChar, 255);
            user.Value = u.userName;
            comando.Parameters.Add(user);

            SqlParameter rolDB = new SqlParameter("@ROL", SqlDbType.Int);
            rolDB.Value = rol;
            comando.Parameters.Add(rolDB);

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

        public static DataTable GetUserByFiltros(String user, int rolAsignado, DateTime? fechaAlta, DateTime? fechaModif)
        {
            SqlConnection conn = ConexionDB.conectarDB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SUDO.SP_LISTADO_USUARIOS";
            comando.Connection = conn;
            adapter.SelectCommand = comando;

            SqlParameter userDB = new SqlParameter("@USUARIO", SqlDbType.VarChar, 255);
            if (user == "")
            {
                userDB.Value = DBNull.Value;
            }
            else
            {
                userDB.Value = user;
            }
            comando.Parameters.Add(userDB);

            SqlParameter rolAsignadoDB = new SqlParameter("@ROL", SqlDbType.Int);
            if (rolAsignado == 0)
            {
                rolAsignadoDB.Value = DBNull.Value;
            }
            else
            {
                rolAsignadoDB.Value = rolAsignado;
            }
            comando.Parameters.Add(rolAsignadoDB);

            SqlParameter fechaAltaDB = new SqlParameter("@FECHAALTA", SqlDbType.DateTime);
            if (fechaAlta == null)
            {
                fechaAltaDB.Value = DBNull.Value;
            }
            else
            {
                //DateTime fa = DateTime.ParseExact(fechaAlta.ToString(), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None);
                String fa = String.Format("{0:u}", fechaAlta.ToString());
                fechaAltaDB.Value = fechaAlta;
            }
            comando.Parameters.Add(fechaAltaDB);

            SqlParameter fechaModifDB = new SqlParameter("@FECHAMODIF", SqlDbType.DateTime);
            if (fechaModif == null)
            {
                fechaModifDB.Value = DBNull.Value;
            }
            else
            {
                fechaModifDB.Value = fechaModif;
            }
            comando.Parameters.Add(fechaModifDB);

            string debugSQL = comando.CommandText;

            foreach (SqlParameter param in comando.Parameters)
            {
                param.SqlValue.ToString();
                param.ToString();

            }
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