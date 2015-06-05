using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PagoElectronico.Dominio
{
    class Usuario
    {
        public int idUser { get; set; }
        public String userName { get; set; }
        public String userPassword { get; set; }
        public String preguntaSecreta { get; set; }
        public String respuestaSecreta { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaUltimaModificacion { get; set; }
        public int cantIntentosFallidos { get; set; }
        public bool estado { get; set; }

        public Usuario(SqlDataReader reader) {
            while (reader.Read())
            {
                idUser = Convert.ToInt32(reader["idUsuario"].ToString());
                userName = reader["userName"].ToString();
                userPassword = reader["userPassword"].ToString();
                preguntaSecreta = reader["preguntaSecreta"].ToString();
                respuestaSecreta = reader["respuestaSecreta"].ToString();
                fechaCreacion = DateTime.Parse(reader["fechaCreacion"].ToString());
                fechaUltimaModificacion = DateTime.Parse(reader["fechaDeUltimaModificacion"].ToString());
                cantIntentosFallidos = Convert.ToInt32(reader["cantIntentosFallidos"].ToString());
                estado = Boolean.Parse(reader["estado"].ToString());
            }
        }

        public Usuario(String idUsuario, String usrName, String usrPassword, String pregSecreta, String rtaSecreta, String fCreacion, String fUltimaModificacion, String cantIntFallidos, String est)
        {
                idUser = Convert.ToInt32(idUsuario);
                userName = usrName;
                userPassword = usrPassword;
                preguntaSecreta = pregSecreta;
                respuestaSecreta = rtaSecreta;
                fechaCreacion = DateTime.Parse(fCreacion);
                fechaUltimaModificacion = DateTime.Parse(fUltimaModificacion);
                cantIntentosFallidos = Convert.ToInt32(cantIntFallidos);
                estado = Boolean.Parse(est);
        }
    }
}

