using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.DAO;
using PagoElectronico.Dominio;

namespace PagoElectronico.Login
{
    public partial class FormLogin : Form
    {
        private const int LECTURA = 2;
        private const int CONSULTASINRESPUESTA = 3;
  
        public SqlConnection coneccion;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e){   
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            SqlParameter username = new SqlParameter("@userName", textBoxUser.Text);
            parametros.Add(username);
            SqlDataReader resultadoStoreProcedure = DAO.ConexionDB.ejecReaderProc("SUDO.GetUser", parametros);
            Usuario usuario = new Usuario(resultadoStoreProcedure);
            GestorLogin gestorLogin = new GestorLogin();
            if (gestorLogin.VerificarUsuario(usuario, textBoxUser.Text, textBoxPassword.Text))
            {
                FormRolesFuncionalidades formRoles = new FormRolesFuncionalidades(usuario.idUser);
                formRoles.Show(this); 
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
