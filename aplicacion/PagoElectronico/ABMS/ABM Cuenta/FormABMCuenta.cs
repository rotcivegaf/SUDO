using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using PagoElectronico.Login;

namespace PagoElectronico.ABM_Cuenta
{
    public partial class FormABMCuenta : Form
    {
        GestorLogin gestorLogin = new GestorLogin();

        public FormABMCuenta(int idUser)
        {
            InitializeComponent();
            SqlDataReader reader = gestorLogin.ConsultarConIdUsuario(idUser, "SUDO.GetCuentas");

            for (; reader.Read(); comboBox1.Items.Add(reader["nroCuenta"].ToString())) ;


            SqlDataReader reader2 = gestorLogin.Consultar("SUDO.GetTiposCuenta");

            for (; reader2.Read(); comboBox2.Items.Add(reader2["nombre"].ToString())) ;
        }

        private void FormABMCuenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
