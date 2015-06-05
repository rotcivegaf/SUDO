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
    public partial class FormRoles : Form
    {
        List<string> listaRoles = new List<string>();

        public FormRoles(int idUser)
        {
            InitializeComponent();
            GestorLogin gestorLogin = new GestorLogin();
            SqlDataReader rolesReader = gestorLogin.GetRoles(idUser);
            int cantRoles = 0;

            for (; rolesReader.Read(); cantRoles++)
            {
                listaRoles.Add(rolesReader["nombreRol"].ToString());
                comboBox1.Items.Add(rolesReader["nombreRol"].ToString()); 
            }
            if (cantRoles == 1)
            {

            }
        }
        private void FormRoles_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
