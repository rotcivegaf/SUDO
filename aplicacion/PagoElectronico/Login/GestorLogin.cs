using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.DAO;
using PagoElectronico.Dominio;
//using PagoElectronico;

namespace PagoElectronico.Login
{
    class GestorLogin
    {
        public bool VerificarUsuario(Usuario usuario, string userName, string password)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@userNameIng", userName));
            parametros.Add(new SqlParameter("@userPasswordIng", password));
            parametros.Add(new SqlParameter("@fechaHora", DateTime.Now));

            if (usuario.userName == null)
            {
                parametros.Add(new SqlParameter("@descripcion", "UserName inexistente"));
                DAO.ConexionDB.ejecNonQueryProc("SUDO.RegistrarLoginUsuarioInexistente", parametros);
                MessageBox.Show("UserName inexistente");
            }
            else
            {
                parametros.Add(new SqlParameter("@idUsuario", usuario.idUser));
                if (usuario.userPassword != Encriptador.Encriptar(password)) 
                {
                    if (usuario.cantIntentosFallidos < 3)
                    {
                        ++usuario.cantIntentosFallidos;
                    }
                    else
                    {
                        List<SqlParameter> parametrosBlock = new List<SqlParameter>();
                        parametrosBlock.Add(new SqlParameter("@idUsuario", usuario.idUser));
                        DAO.ConexionDB.ejecNonQueryProc("SUDO.BlockearUsuario", parametrosBlock);
                    }
                    parametros.Add(new SqlParameter("@numeroIntentoFallido", usuario.cantIntentosFallidos));
                    parametros.Add(new SqlParameter("@estado", false));
                    parametros.Add(new SqlParameter("@descripcion", "Password incorecta"));
                    DAO.ConexionDB.ejecNonQueryProc("SUDO.RegistrarLogin", parametros);
                    MessageBox.Show("Password incorecta");
                }
                else
                {
                    if (usuario.estado == false)
                    {
                        parametros.Add(new SqlParameter("@numeroIntentoFallido", usuario.cantIntentosFallidos));
                        parametros.Add(new SqlParameter("@estado", false));
                        parametros.Add(new SqlParameter("@descripcion", "Usuario BLockeado"));
                        DAO.ConexionDB.ejecNonQueryProc("SUDO.RegistrarLogin", parametros);
                        MessageBox.Show("Usuario BLockeado");
                    }
                    else
                    {
                        usuario.cantIntentosFallidos = 0;
                        parametros.Add(new SqlParameter("@numeroIntentoFallido", usuario.cantIntentosFallidos));
                        parametros.Add(new SqlParameter("@estado", true));
                        parametros.Add(new SqlParameter("@descripcion", "Usuario Logueado"));
                        DAO.ConexionDB.ejecNonQueryProc("SUDO.RegistrarLogin", parametros);
                        return true;
                    }
                }
            }
            return false;
        }
        public Roles GetRolesXFuncionalidades(int idUsuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idUsuario", idUsuario));
            Roles roles = new Roles(DAO.ConexionDB.ejecReaderProc("SUDO.GetRolesXFuncionalidades", parametros));
  
            return roles;
        }
    }
}
